using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using File = System.IO.File;

namespace OOP
{
    public partial class PatientForm : Form
    {
        //private List<string> files = Directory.GetFiles("../../../Data/users/doctors").ToList();
        private List<string> files = Directory.GetFiles($"{Authorization.path}/users/doctors").ToList();
        private Patient patient;
        private Doctor doctor;
        private Message message;
        private Meet meetShow;
        private bool permission = true;

        public PatientForm(IUserLogIn patien)
        {
            InitializeComponent();

            patient = (Patient)patien;

            InputMeetings();
        }

        ///////////////////////////////////tabContal///////////////////////////////////

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Зустрічі")
            {
                textBox6.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                richTextBox2.Text = "";

                listMeet.Items.Clear();

                InputMeetings();
            }

            if (tabControl1.SelectedTab.Text == "Лікарі")
            {
                doctorId.Text = "";
                doctorName.Text = "";
                doctorLastName.Text = "";
                doctorMiddleName.Text = "";
                doctorSpeciality.Text = "";
                listDoctor.Items.Clear();


                int i = 1;
                foreach (string file in files)
                {
                    Doctor user = Doctor.ReadFromFileJSON(file);
                    listDoctor.Items.Add($"{i++}. {user.Lastname} {user.Firstname[0]}. {user.Middlename[0]}.");
                }
            }

            if (tabControl1.SelectedTab.Text == "Повідомлення")
            {
                textBox10.Text = "";
                label15.Text = "";

                listMessage.Items.Clear();

                InputWithName(listMessage, patient.Messages);
            }

            if (tabControl1.SelectedTab.Text == "Профіль")
            {
                ProfileId.Text = patient.Id.ToString();
                ProfileName.Text = patient.Firstname;
                ProfileLastName.Text = patient.Lastname;
                ProfileMiddleName.Text = patient.Middlename;
                if (patient.GenderIsMale == true) radioButtonMen.Checked = true;
                else radioButtonWomen.Checked = false;
                About.Text = patient.Description;
            }
        }

        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (!permission) e.Cancel = true;
        }

        ///////////////////////////////////Зустрічі///////////////////////////////////

        private void listMeet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMeet.SelectedItem == null) return;

            int id = listMeet.SelectedIndex;

            DateTime meetDate = patient.Meetings[id];

            //meetShow = Meet.ReadFromFileJSON($"../../../Data/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");
            meetShow = Meet.ReadFromFileJSON($"{Authorization.path}/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");

            doctor = Doctor.ReadFromFileJSON(meetShow.IdDoctor);

            textBox6.Text = doctor.Id.ToString();
            textBox3.Text = $"{doctor.Lastname} {doctor.Firstname[0]}. {doctor.Middlename[0]}.";
            textBox5.Text = meetShow.Date.ToString("dd:MM:yyyy HH:mm");
            richTextBox2.Text = meetShow.Description;
        }

        private void editMeet_Click(object sender, EventArgs e)
        {
            if (listMeet.SelectedItem == null) return;

            if (permission)
            {
                permission = false;
                richTextBox2.ReadOnly = false;
                listMeet.Enabled = false;
                deleteMeet.Enabled = false;
            }
            else
            {
                permission = true;
                richTextBox2.ReadOnly = true;
                listMeet.Enabled = true;
                deleteMeet.Enabled = true;

                meetShow.Description = richTextBox2.Text;
                meetShow.SaveToFileJSON();
            }
        }

        private void deleteMeet_Click(object sender, EventArgs e)
        {
            if (listMeet.SelectedItem == null) return;

            DialogResult result = MessageBox.Show("Видалити?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) { return; }

            int num = listMeet.SelectedIndex;

            //Meet meet = Meet.ReadFromFileJSON($"../../../Data/meetings/{patient.Meetings[num].Day}.{patient.Meetings[num].Month}/{patient.Meetings[num].Hour}.{patient.Meetings[num].Minute}.json");
            Meet meet = Meet.ReadFromFileJSON($"{Authorization.path}/meetings/{patient.Meetings[num].Day}.{patient.Meetings[num].Month}/{patient.Meetings[num].Hour}.{patient.Meetings[num].Minute}.json");

            meet.Cancel();
            patient = Patient.ReadFromFileJSON(patient.Id);

            listMeet.Items.Clear();

            textBox6.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            richTextBox2.Text = "";

            InputMeetings();
        }

        ///////////////////////////////////Лікарі///////////////////////////////////

        private void listDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDoctor.SelectedItem == null) return;

            int id = listDoctor.SelectedIndex;

            doctor = Doctor.ReadFromFileJSON(files[id]);

            doctorId.Text = doctor.Id.ToString();
            doctorName.Text = doctor.Firstname;
            doctorLastName.Text = doctor.Lastname;
            doctorMiddleName.Text = doctor.Middlename;
            doctorSpeciality.Text = doctor.Speciality;
        }

        private void writeMessage_Click(object sender, EventArgs e)
        {
            if (listDoctor.SelectedItem == null) return;
            tabControl1.SelectedTab = tabPage3;

            //if (!File.Exists($"../../../Data/message/{doctor.Id}_{patient.Id}.json"))
            if (!File.Exists($"{Authorization.path}/message/{doctor.Id}_{patient.Id}.json"))
                {
                Message m = new Message(patient, doctor);
                m.SaveToFileJSON();
            }

            listMessage.Items.Clear();

            InputWithName(listMessage, patient.Messages);
            listMessage.SelectedIndex = patient.Messages.IndexOf(doctor.Id);
        }

        private void newMeet_Click(object sender, EventArgs e)
        {

            foreach (DateTime meetDate in patient.Meetings)
            {
                //Meet meet = Meet.ReadFromFileJSON($"../../../Data/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");
                Meet meet = Meet.ReadFromFileJSON($"{Authorization.path}/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");

                if(meet.IdDoctor == doctor.Id)
                {
                    MessageBox.Show("Ви вже маєте зустріч з цим лікарем.");
                    return;
                }
            }

            if (listDoctor.SelectedItem == null) return;

            permission = false;
            writeMessage.Enabled = false;
            newMeet.Enabled = false;
            listDoctor.Enabled = false;

            dateTimeNewMeet.MaxDate = DateTime.Now.AddMonths(1).AddDays(1);
            dateTimeNewMeet.MinDate = DateTime.Now.AddDays(1);

            panel4.Show();
        }

        private void closeNewMeet_Click(object sender, EventArgs e)
        {
            permission = true;
            writeMessage.Enabled = true;
            newMeet.Enabled = true;
            listDoctor.Enabled = true;

            label18.Text = "";
            timeNewMeet.SelectedValue = null;

            panel4.Hide();
        }

        private void createNewMeet_Click(object sender, EventArgs e)
        {
            if (timeNewMeet.SelectedItem == null)
            {
                label18.Text = "Оберіть час зустрічі";
                return;
            }

            DateTime date = DateTime.Parse(dateTimeNewMeet.Text + " " + timeNewMeet.Text);
            Meet m = new Meet(date, patient, doctor, "");
            m.SaveToFileJSON();

            timeNewMeet.SelectedValue = null;
            closeNewMeet.PerformClick();

            tabControl1.SelectedTab = tabPage1;

            listMeet.Items.Clear();
            InputMeetings();

            listMeet.SelectedIndex = patient.Meetings.IndexOf(date);
        }

        private void dateTimeNewMeet_ValueChanged(object sender, EventArgs e)
        {
            timeNewMeet.Items.Clear();
            string[] arr = { "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30" };
            timeNewMeet.Items.AddRange(arr);

            DateTime date = dateTimeNewMeet.Value;

            //string path = $"../../../Data/meetings/{date.Day}.{date.Month}/";
            string path = $"{Authorization.path}/meetings/{date.Day}.{date.Month}/";

            if (!Directory.Exists(path)) return;

            List<string> files = Directory.GetFiles(path).ToList();

            foreach (string m in files)
            {
                Meet meet = Meet.ReadFromFileJSON(m);

                string s = meet.Date.ToString("HH:mm");

                if (timeNewMeet.Items.Contains(meet.Date.ToString("HH:mm")))
                {
                    timeNewMeet.Items.Remove(meet.Date.ToString("HH:mm"));
                }
            }
        }

        private void timeNewMeet_SelectedIndexChanged(object sender, EventArgs e)
        {
            label18.Text = "";
        }
        ///////////////////////////////////Повідомлення///////////////////////////////////

        private void listMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMessage.SelectedItem == null) return;

            int id = listMessage.SelectedIndex;

            doctor = Doctor.ReadFromFileJSON(patient.Messages[id]);
            message = Message.ReadFromFileJSON(patient.Messages[id], patient.Id);

            label15.Text = doctor.Firstname;
            textBox10.Text = message.TextMes;

            //Прокручуємо RichTextBox до кінця
            textBox10.SelectionStart = textBox10.Text.Length;
            textBox10.ScrollToCaret();
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (listMessage.SelectedItem == null)
            {
                return;
            }

            int id = listMessage.SelectedIndex;

            message.SendMessage(patient.Id, patient.Firstname, textBox1.Text);

            textBox10.Text = message.TextMes;

            textBox10.SelectionStart = textBox10.Text.Length;
            textBox10.ScrollToCaret();

            textBox1.Text = "";

            message.SaveToFileJSON();
        }

        private void deleteMessage_Click(object sender, EventArgs e)
        {
            if (listMessage.SelectedItem == null) return;

            DialogResult result = MessageBox.Show("Видалити?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) { return; }

            textBox10.Text = "";
            label15.Text = "";

            int num = listMessage.SelectedIndex;

            message.Delete();

            listMessage.Items.RemoveAt(num);
            patient = Patient.ReadFromFileJSON(patient.Id);
        }

        private ErrorProvider error = new ErrorProvider();

        private void editProfile_Click(object sender, EventArgs e)
        {
            if (permission)
            {
                ProfileName.Enabled = true;
                ProfileLastName.Enabled = true;
                ProfileMiddleName.Enabled = true;
                radioButtonMen.Enabled = true;
                radioButtonWomen.Enabled = true;
                About.Enabled = true;
                permission = !permission;
            }
            else
            {
                error.Clear();

                bool flag = true;
                Regex regex = new Regex("^[a-zA-Zа-яА-ЯґҐєЄіІїЇҐґ']+$");

                if (!regex.IsMatch(ProfileName.Text))
                {
                    error.SetError(ProfileName, "Ім'я може містити тільки літери");
                    flag = false;
                }
                if (!regex.IsMatch(ProfileLastName.Text))
                {
                    error.SetError(ProfileLastName, "Прізвище може містити тільки літери");
                    flag = false;
                }
                if (!regex.IsMatch(ProfileMiddleName.Text))
                {
                    error.SetError(ProfileMiddleName, "По-батькові може містити тільки літери");
                    flag = false;
                }

                if (!flag) return;

                patient.Firstname = ProfileName.Text;
                patient.Lastname = ProfileLastName.Text;
                patient.Middlename = ProfileMiddleName.Text;
                patient.GenderIsMale = radioButtonMen.Checked;
                patient.Description = About.Text;

                patient.SaveToFileJSON();

                ProfileName.Enabled = false;
                ProfileLastName.Enabled = false;
                ProfileMiddleName.Enabled = false;
                radioButtonMen.Enabled = false;
                radioButtonWomen.Enabled = false;
                About.Enabled = false;
                permission = !permission;
            }
        }

        ///////////////////////////////////
        
        private void InputMeetings()
        {
            int i = 1;
            foreach (DateTime meetDate in patient.Meetings)
            {
                //Meet meet = Meet.ReadFromFileJSON($"../../../Data/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");
                Meet meet = Meet.ReadFromFileJSON($"{Authorization.path}/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");
                if (!meet.DeleteYesterday())
                {
                    listMeet.Items.Add($"{i++}. {meet.Date.ToString("dd.MM HH:mm")}");
                } 
            }
            patient = Patient.ReadFromFileJSON(patient.Id);
        }

        private void InputWithName(ListBox listBox, List<int> list)
        {
            int i = 1;
            foreach (int p in list)
            {
                Doctor user = Doctor.ReadFromFileJSON(p);
                listBox.Items.Add($"{i++}. {user.Lastname} {user.Firstname[0]}. {user.Middlename[0]}.");
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
