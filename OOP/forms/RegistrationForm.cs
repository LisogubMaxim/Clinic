using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP
{
    public partial class RegistrationForm : Form
    {
        private bool isButtonBack = false;
        public RegistrationForm()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            textBoxRepeatPassword.PasswordChar = '*';
        }

        private ErrorProvider error = new ErrorProvider();

        private void button2_Click(object sender, EventArgs e)
        {
            error.Clear();

            bool flag = true;
            Regex regex = new Regex("^[a-zA-Z0-9]*$");

            if (textBoxLogin.Text == "patient" || textBoxLogin.Text == "doctor" || textBoxLogin.Text == "admin")
            {
                error.SetError(textBoxLogin, "Це слово є зарезервоване");
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
            if(flag)
            {
                Authorization.Registration(textBoxLogin.Text, textBoxPassword.Text);

                PatientForm form3 = new PatientForm(Authorization.CheckLoginAndPassword(textBoxLogin.Text, textBoxPassword.Text));
                form3.Show();

                this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            isButtonBack = true;
            Form parentForm = this.Owner;
            parentForm.Show();
            Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isButtonBack)
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
