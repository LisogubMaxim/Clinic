using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP
{
    public partial class DoctorForm : Form
    {
        //private readonly List<string> files = Directory.GetFiles("../../../Data/users/patients").ToList();
        private readonly List<string> files = Directory.GetFiles($"{Authorization.path}/users/patients").ToList();
        private Doctor doctor;
        private Patient patient;
        private List<Patient> fullReg = new List<Patient>();
        private Message message;
        private Meet meetShow;
        private bool permission = true;

        public DoctorForm(IUserLogIn docto)
        {
            InitializeComponent();
            doctor = (Doctor)docto;

            InputMeetings();

        }

        ///////////////////////////////////tabContal///////////////////////////////////
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab.Text == "Зустрічі")
            {
                textBox7.Text = "";
                textBox6.Text = "";
                textBox10.Text = "";
                richTextBox3.Text = "";

                listMeet.Items.Clear();

                InputMeetings();
            }

            if (tabControl1.SelectedTab.Text == "Пацієнти")
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                textBox12.Text = "";

                listPatients.Items.Clear();

                InputWithName(listPatients, doctor.Patients);
            }

            if (tabControl1.SelectedTab.Text == "Повідомлення")
            {
                label10.Text = "";
                textBox11.Text = "";

                listMessage.Items.Clear();

                InputWithName(listMessage, doctor.Messages);
            }
        }
        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (!permission) e.Cancel = true;
        }


        ///////////////////////////////////Зустрічі///////////////////////////////////

        private void listMeetings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMeet.SelectedItem == null) return;

            int id = listMeet.SelectedIndex;

            DateTime meetDate = doctor.Meetings[id];

            //meetShow = Meet.ReadFromFileJSON($"../../../Data/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");
            meetShow = Meet.ReadFromFileJSON($"{Authorization.path}/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");

            patient = Patient.ReadFromFileJSON(meetShow.IdPatient);

            textBox7.Text = patient.Id.ToString();
            textBox6.Text = $"{patient.Lastname} {patient.Firstname[0]}. {patient.Middlename[0]}.";
            textBox10.Text = meetShow.Date.ToString("dd:MM:yyyy HH:mm");
            richTextBox3.Text = meetShow.Description;
        }

        private void editMeet_Click(object sender, EventArgs e)
        {
            if (listMeet.SelectedItem == null) return;

            if (permission)
            {
                permission = false;
                richTextBox3.ReadOnly = false;
                listMeet.Enabled = false;
                deleteMeet.Enabled = false;
            }
            else
            {
                permission = true;
                richTextBox3.ReadOnly = true;
                listMeet.Enabled = true;
                deleteMeet.Enabled = true;

                meetShow.Description = richTextBox3.Text;
                meetShow.SaveToFileJSON();
            }
        }

        private void deleteMeet_Click(object sender, EventArgs e)
        {
            if (listMeet.SelectedItem == null) return;

            DialogResult result = MessageBox.Show("Видалити?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) { return; }

            int num = listMeet.SelectedIndex;

            //Meet meet = Meet.ReadFromFileJSON($"../../../Data/meetings/{doctor.Meetings[num].Day}.{doctor.Meetings[num].Month}/{doctor.Meetings[num].Hour}.{doctor.Meetings[num].Minute}.json");
            Meet meet = Meet.ReadFromFileJSON($"{Authorization.path}/meetings/{doctor.Meetings[num].Day}.{doctor.Meetings[num].Month}/{doctor.Meetings[num].Hour}.{doctor.Meetings[num].Minute}.json");

            meet.Cancel();
            doctor = Doctor.ReadFromFileJSON(doctor.Id);
            listMeet.Items.Clear();

            textBox6.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            richTextBox3.Text = "";

            InputMeetings();
        }

        ///////////////////////////////////Пацієнти///////////////////////////////////

        private void listPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPatients.SelectedItem == null) return;

            int id = listPatients.SelectedIndex;

            patient = Patient.ReadFromFileJSON(doctor.Patients[id]);

            textBox2.Text = patient.Id.ToString();
            textBox3.Text = patient.Firstname;
            textBox5.Text = patient.Lastname;
            textBox4.Text = patient.Middlename;
            textBox12.Text = patient.Description;
        }

        private void newMeet_Click(object sender, EventArgs e)
        {
            if (listPatients.SelectedItem == null) return;
            int id = listPatients.SelectedIndex;
            foreach (DateTime meetDate in doctor.Meetings)
            {
                //Meet meet = Meet.ReadFromFileJSON($"../../../Data/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");
                Meet meet = Meet.ReadFromFileJSON($"{Authorization.path}/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");

                if (meet.IdPatient == patient.Id)
                {
                    MessageBox.Show("Ви вже маєте зустріч з цим пацієнтом.");
                    return;
                }
            }

            permission = false;
            newMeet.Enabled = false;
            writeMessage.Enabled = false;
            editPatient.Enabled = false;
            deletePatient.Enabled = false;
            addPatient.Enabled = false;
            textBox12.Enabled = false;
            listPatients.Enabled = false;

            dateTimeNewMeet.MaxDate = DateTime.Now.AddMonths(1).AddDays(1);
            dateTimeNewMeet.MinDate = DateTime.Now.AddDays(1);

            panel4.Show();
        }

        private void writeMessage_Click(object sender, EventArgs e)
        {
            if (listPatients.SelectedItem == null) return;
            tabControl1.SelectedTab = tabPage3;

            //if (!File.Exists($"../../../Data/message/{doctor.Id}_{patient.Id}.json"))
            if (!File.Exists($"{Authorization.path}/message/{doctor.Id}_{patient.Id}.json"))
                {
                Message m = new Message(patient, doctor);
                m.SaveToFileJSON();
            }

            listMessage.Items.Clear();

            InputWithName(listMessage, doctor.Messages);
            listMessage.SelectedIndex = doctor.Messages.IndexOf(patient.Id);
        }

        private void editPatient_Click(object sender, EventArgs e)
        {
            if (listPatients.SelectedItem == null) return;

            if (textBox12.ReadOnly)
            {
                textBox12.ReadOnly = false;

                listPatients.Enabled = false;
                newMeet.Enabled = false;
                writeMessage.Enabled = false;
                deletePatient.Enabled = false;
                addPatient.Enabled = false;

                permission = false;
            }
            else
            {
                patient.Description = textBox12.Text;
                patient.SaveToFileJSON();

                textBox12.ReadOnly = true;

                listPatients.Enabled = true;
                newMeet.Enabled = true;
                writeMessage.Enabled = true;
                deletePatient.Enabled = true;
                addPatient.Enabled = true;

                permission = true;
            }
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

        private void closeNewMeet_Click(object sender, EventArgs e)
        {
            permission = true;
            newMeet.Enabled = true;
            writeMessage.Enabled = true;
            editPatient.Enabled = true;
            deletePatient.Enabled = true;
            addPatient.Enabled = true;
            textBox12.Enabled = true;
            listPatients.Enabled = true;

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

            //listMeet.Items.Clear();
            //InputMeetings();

            listMeet.SelectedIndex = doctor.Meetings.IndexOf(date);
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            if (permission)
            {
                addPatient.Text = "Вибрати";
                listAllPatient.Show();

                newMeet.Enabled = false;
                writeMessage.Enabled = false;
                editPatient.Enabled = false;
                deletePatient.Enabled = false;
                textBox12.Enabled = false;
                listPatients.Enabled = false;

                permission = false;

                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                textBox12.Text = "";

                listAllPatient.Items.Clear();

                /////////////////////////////////////
                Predicate<Patient> isNull = delegate (Patient patient)
                {
                    if (patient.Firstname == null || patient.Lastname == null || patient.Middlename == null) return true;
                    return false;
                };
                /////////////////////////////////////
                ///
                int i = 1;
                foreach (string p in files)
                {
                    patient = Patient.ReadFromFileJSON(p);
                    
                    if (!isNull(patient) && !doctor.Patients.Contains(patient.Id))
                    {
                        string s = $"{i++}. {patient.Lastname} {patient.Firstname[0]}. {patient.Middlename[0]}.";
                        listAllPatient.Items.Add(s);
                        fullReg.Add(patient);
                    }
                }
            }
            else
            {
                addPatient.Text = "Додати";
                listAllPatient.Hide();

                newMeet.Enabled = true;
                writeMessage.Enabled = true;
                editPatient.Enabled = true;
                deletePatient.Enabled = true;
                textBox12.Enabled = true;
                listPatients.Enabled = true;

                permission = true;

                if (listAllPatient.SelectedItem == null) return;

                doctor.Patients.Add(fullReg[listAllPatient.SelectedIndex].Id);
                doctor.SaveToFileJSON();

                listPatients.Items.Clear();
                InputWithName(listPatients, doctor.Patients);
                
                fullReg.Clear();
            }
        }

        private void listAllPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAllPatient.SelectedItem == null) return;

            char d = listAllPatient.SelectedItem.ToString()[0];
            int id = d - '1';

            patient = fullReg[id];

            textBox2.Text = patient.Id.ToString();
            textBox3.Text = patient.Firstname;
            textBox5.Text = patient.Lastname;
            textBox4.Text = patient.Middlename;
            textBox12.Text = patient.Description;
        }

        private void deletePatient_Click(object sender, EventArgs e)
        {
            if (listPatients.SelectedItem == null) return;
            if (doctor.PatientsWithMeet.Contains(doctor.Patients[listPatients.SelectedIndex]))
            {
                MessageBox.Show("Ви маєте активну зустріч з цим пацієнтом.", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Видалити?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            

            if (result == DialogResult.No) { return; }

            doctor.Patients.RemoveAt(listPatients.SelectedIndex);
            doctor.SaveToFileJSON();

            listPatients.Items.Clear();
            InputWithName(listPatients, doctor.Patients);
        }

        ///////////////////////////////////Повідомлення///////////////////////////////////

        private void listMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listMessage.SelectedItem == null) return;

            int id = listMessage.SelectedIndex;

            patient = Patient.ReadFromFileJSON(doctor.Messages[id]);
            message = Message.ReadFromFileJSON(doctor.Id, patient.Id);

            label10.Text = patient.Firstname;
            textBox11.Text = message.TextMes;

            //Прокручуємо RichTextBox до кінця
            textBox11.SelectionStart = textBox10.Text.Length;
            textBox11.ScrollToCaret();
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (listMessage.SelectedItem == null)
            {
                return;
            }

            int id = listMessage.SelectedIndex;

            message.SendMessage(doctor.Id, doctor.Firstname, textBox1.Text);

            textBox11.Text = message.TextMes;

            textBox11.SelectionStart = textBox10.Text.Length;
            textBox11.ScrollToCaret();

            textBox1.Text = "";

            message.SaveToFileJSON();
        }

        private void deleteMessage_Click(object sender, EventArgs e)
        {
            if (listMessage.SelectedItem == null) return;

            DialogResult result = MessageBox.Show("Видалити?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) { return; }

            textBox11.Text = "";
            label10.Text = "";

            int id = listMessage.SelectedIndex;

            Message mes = Message.ReadFromFileJSON(doctor.Id, doctor.Messages[id]);
            mes.Delete();

            listMessage.Items.RemoveAt(id);

            doctor = Doctor.ReadFromFileJSON(doctor.Id);
        }

        /////////////////////////////
        

        private void InputMeetings()
        {
            int i = 1;
            foreach (DateTime meetDate in doctor.Meetings)
            {
                //Meet meet = Meet.ReadFromFileJSON($"../../../Data/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");
                Meet meet = Meet.ReadFromFileJSON($"{Authorization.path}/meetings/{meetDate.Day}.{meetDate.Month}/{meetDate.Hour}.{meetDate.Minute}.json");
                if (!meet.DeleteYesterday())
                    listMeet.Items.Add($"{i++}. {meet.Date.ToString("dd.MM HH:mm")}");
            }
            doctor = Doctor.ReadFromFileJSON(doctor.Id);
        }

        private void InputWithName(ListBox listBox, List<int> list)
        {
            int i = 1;
            foreach (int p in list)
            {
                Patient user = Patient.ReadFromFileJSON(p);
                listBox.Items.Add($"{i++}. {user.Lastname} {user.Firstname[0]}. {user.Middlename[0]}.");
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
