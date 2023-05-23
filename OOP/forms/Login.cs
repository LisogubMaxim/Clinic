using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.LinkLabel;

namespace OOP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void enter_Click(object sender, EventArgs e)
        {
            IUserLogIn user = Authorization.CheckLoginAndPassword(textBox1.Text, textBox2.Text);
            if (user != null)
            {
                this.Hide();
                if (user.GetType() == typeof(Patient))
                {
                    PatientForm form3 = new PatientForm(user);
                    form3.Show();
                }
                else if (user.GetType() == typeof(Doctor))
                {
                    DoctorForm form2 = new DoctorForm(user);
                    form2.Show();
                }
                else
                {
                    AdminForm form4 = new AdminForm();
                    form4.Show();
                }
            }
            else
            {
                label3.Text = "Перевірте дані для входу";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm form5 = new RegistrationForm();
            form5.Owner = this;
            form5.Show();
        }

        private void guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestForm form4 = new GuestForm();
            form4.Show();
        }
    }
}
