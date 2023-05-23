using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class GuestForm : Form
    {
        //private List<string> files = Directory.GetFiles("../../../Data/users/doctors").ToList();
        private List<string> files = Directory.GetFiles($"{Authorization.path}/users/doctors").ToList();

        public GuestForm()
        {
            InitializeComponent();

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
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text == "Реєстрація")
            {
                tabControl1.SelectedTab = tabPage1;

                RegistrationForm form5 = new RegistrationForm();
                form5.Owner = this;
                form5.Show();
                this.Hide();
            }
        }

        private void listDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDoctor.SelectedItem == null) return;

            int id = listDoctor.SelectedIndex;

            Doctor doctor = Doctor.ReadFromFileJSON(files[id]);

            doctorId.Text = doctor.Id.ToString();
            doctorName.Text = doctor.Firstname;
            doctorLastName.Text = doctor.Lastname;
            doctorMiddleName.Text = doctor.Middlename;
            doctorSpeciality.Text = doctor.Speciality;
        }
    }
}
