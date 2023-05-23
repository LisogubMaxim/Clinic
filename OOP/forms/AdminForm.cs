using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP
{
    public partial class AdminForm : Form
    {
        //private List<string> filesDoctor = Directory.GetFiles("../../../Data/users/doctors").ToList();
        private List<string> filesDoctor = Directory.GetFiles($"{Authorization.path}/users/doctors").ToList();
        //private List<string> filesPatient = Directory.GetFiles("../../../Data/users/patients").ToList();
        private List<string> filesPatient = Directory.GetFiles($"{Authorization.path}/users/patients").ToList();
        private Doctor doctor;
        private Patient patient;
        private bool permission = true;
        private ErrorProvider error = new ErrorProvider();

        public AdminForm()
        {
            InitializeComponent();

            InputWithName(listDoctor, filesDoctor);

            textBoxPassword.PasswordChar = '*';
            textBoxRepeatPassword.PasswordChar = '*';
        }
        ///////////////////////////////////tabContal///////////////////////////////////

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Лікарі")
            {
                listDoctor.Items.Clear();

                doctorId.Text = "";
                doctorName.Text = "";
                doctorLastName.Text = "";
                doctorMiddleName.Text = "";
                doctorSpeciality.Text = "";

                InputWithName(listDoctor, filesDoctor);
            }

            if (tabControl1.SelectedTab.Text == "Пацієнти")
            {
                listPatient.Items.Clear();

                patientId.Text = "";
                patientName.Text = "";
                patientLastName.Text = "";
                patientMiddleName.Text = "";
                patientAbout.Text = "";

                InputPatient();
            }
        }

        ///////////////////////////////////Лікарі///////////////////////////////////

        private void listDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDoctor.SelectedItem == null) return;

            doctor = Doctor.ReadFromFileJSON(filesDoctor[listDoctor.SelectedIndex]);

            doctorId.Text = doctor.Id.ToString();
            doctorName.Text = doctor.Firstname;
            doctorLastName.Text = doctor.Lastname;
            doctorMiddleName.Text = doctor.Middlename;
            doctorSpeciality.Text = doctor.Speciality;
        }

        private void editDoctor_Click(object sender, EventArgs e)
        {
            if (listDoctor.SelectedItem == null) return;

            if (!doctorName.Enabled)
            {
                doctorName.Enabled = true;
                doctorLastName.Enabled = true;
                doctorMiddleName.Enabled = true;
                doctorSpeciality.Enabled = true;

                listDoctor.Enabled = false;
                deleteDoctor.Enabled = false;

                permission = false;
            }
            else
            {
                doctor.Firstname = doctorName.Text;
                doctor.Lastname = doctorLastName.Text;
                doctor.Middlename= doctorMiddleName.Text;
                doctor.Speciality = doctorSpeciality.Text;
                doctor.SaveToFileJSON();

                doctorName.Enabled = false;
                doctorLastName.Enabled = false;
                doctorMiddleName.Enabled = false;
                doctorSpeciality.Enabled = false;

                listDoctor.Enabled = true;
                deleteDoctor.Enabled = true;

                permission = true;
            }
        }

        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (!permission) e.Cancel = true;
        }

        private void deleteDoctor_Click(object sender, EventArgs e)
        {
            if (listDoctor.SelectedItem == null) return;

            DialogResult result = MessageBox.Show("Видалити?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) { return; }

            Doctor doctor = Doctor.ReadFromFileJSON(filesDoctor[listDoctor.SelectedIndex]);
            doctor.Delete();

            //filesDoctor = Directory.GetFiles("../../../Data/users/doctors").ToList();
            filesDoctor = Directory.GetFiles($"{Authorization.path}/users/doctors").ToList();

            listDoctor.Items.Clear();

            InputWithName(listDoctor, filesDoctor);

            doctorId.Text = "";
            doctorName.Text = "";
            doctorLastName.Text = "";
            doctorMiddleName.Text = "";
            doctorSpeciality.Text = "";
        }

        ///////////////////////////////////Пацієнти///////////////////////////////////

        private void listPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPatient.SelectedItem == null) return;

            patient = Patient.ReadFromFileJSON(filesPatient[listPatient.SelectedIndex]);

            patientId.Text = patient.Id.ToString();
            patientName.Text = patient.Firstname == null ? "null" : patient.Lastname;
            patientLastName.Text = patient.Lastname == null ? "null" : patient.Firstname;
            patientMiddleName.Text = patient.Middlename == null ? "null" : patient.Middlename;
            patientAbout.Text = patient.Description;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listPatient.SelectedItem == null) return;

            DialogResult result = MessageBox.Show("Видалити?", "Повідомлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) { return; }

            Patient patient = Patient.ReadFromFileJSON(filesPatient[listPatient.SelectedIndex]);
            patient.Delete();

            //filesPatient = Directory.GetFiles("../../../Data/users/patients").ToList();
            filesPatient = Directory.GetFiles($"{Authorization.path}/users/patients").ToList();

            patientId.Text = "";
            patientName.Text = "";
            patientLastName.Text = "";
            patientMiddleName.Text = "";
            patientAbout.Text = "";

            listPatient.Items.Clear();
            InputPatient();
        }

        ///////////////////////////////////Додати///////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            error.Clear();

            bool flag = true;
            Regex regex = new Regex("^[a-zA-Z0-9]*$");
            if(textBox7.Text.Length < 2)
            {
                error.SetError(textBox7, "Ім’я має містити не менше 2 символів");
                flag = false;
            }
            if (textBox6.Text.Length < 2)
            {
                error.SetError(textBox6, "Прізвище має містити не менше 2 символів");
                flag = false;
            }
            if (textBox3.Text.Length < 2)
            {
                error.SetError(textBox3, "По-батькові має бути не меньше 2 символів");
                flag = false;
            }
            if (comboBox1.Text == null)
            {
                error.SetError(comboBox1, "Оберіть спеціалізацію");
                flag = false;
            }
            if (!regex.IsMatch(textBoxLogin.Text))
            {
                error.SetError(textBoxLogin, "Логін може містити тільки латинські літери та цифри");
                flag = false;
            }
            if (!regex.IsMatch(textBoxPassword.Text))
            {
                error.SetError(textBoxPassword, "Пароль може містити тільки латинські літери та цифри");
                flag = false;
            }
            if (textBoxLogin.Text.Length < 5)
            {
                error.SetError(textBoxLogin, "Логін повинен мати не менше 5 символів");
                flag = false;
            }
            if (textBoxPassword.Text.Length < 6)
            {
                error.SetError(textBoxPassword, "Пароль повинен мати не менше 6 символів");
                flag = false;
            }
            if (textBoxPassword.Text != textBoxRepeatPassword.Text)
            {
                error.SetError(textBoxPassword, "Не співпадають");
                error.SetError(textBoxRepeatPassword, "Не співпадають");
                flag = false;
            }
            if (Authorization.CheckLogin(textBoxLogin.Text))
            {
                error.SetError(textBoxLogin, "Даний логін вже зайнятий");
                flag = false;
            }
            if (flag)
            {
                Authorization.Registration(textBoxLogin.Text, textBoxPassword.Text, "doctor");
                Doctor doctor = new Doctor(Authorization.LastId(), textBox7.Text, textBox6.Text, textBox3.Text, comboBox1.Text);
                doctor.SaveToFileJSON();

                //filesDoctor = Directory.GetFiles("../../../Data/users/doctors").ToList();
                filesDoctor = Directory.GetFiles($"{Authorization.path}/users/doctors").ToList();

                textBox7.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
                comboBox1.SelectedIndex = -1;
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxRepeatPassword.Text = "";

                MessageBox.Show("Аккаунт створено", "", MessageBoxButtons.OK);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxRepeatPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                textBoxRepeatPassword.PasswordChar = '*';
            }
        }

        ////////////////////////////////////////////////////////////

        private void InputWithName(ListBox listBox, List<string> list)
        {
            int i = 1;
            foreach (string p in list)
            {
                Doctor user = Doctor.ReadFromFileJSON(p);
                listBox.Items.Add($"{i++}. {user.Lastname} {user.Firstname[0]}. {user.Middlename[0]}.");
            }
        }

        private void InputPatient()
        {
            int i = 1;
            foreach (string p in filesPatient)
            {
                Patient user = Patient.ReadFromFileJSON(p);

                string lastname = user.Lastname == null ? "null" : user.Lastname;
                string firstname = user.Firstname == null ? "null" : user.Firstname[0].ToString();
                string middlename = user.Middlename == null ? "null" : user.Middlename[0].ToString();

                listPatient.Items.Add($"{i++}. {lastname} {firstname}. {middlename}.");
            }
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
