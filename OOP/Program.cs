using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Data";

            if (!Directory.Exists(desktopPath)) 
            {

                try
                {

                    Directory.CreateDirectory(desktopPath);
                    File.WriteAllText(desktopPath + "/passwords.json", "", Encoding.UTF8);
                    Directory.CreateDirectory(desktopPath + "/meetings");
                    Directory.CreateDirectory(desktopPath + "/message");
                    Directory.CreateDirectory(desktopPath + "/users");
                    Directory.CreateDirectory(desktopPath + "/users/admins");
                    Directory.CreateDirectory(desktopPath + "/users/doctors");
                    Directory.CreateDirectory(desktopPath + "/users/patients");                    
                }
                catch (Exception ex)
                {
                }
                Authorization.Registration("Admin", "password", "admin");
                Admin admin = new Admin(Authorization.LastId(), "Maksim", "Lisohub", "Nikolayovich");
                admin.SaveToFileJSON();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            //Application.Run(new DoctorForm(Authorization.CheckLoginAndPassword("doctor1", "passwordDoctor1")));
            //Application.Run(new PatientForm(Authorization.CheckLoginAndPassword("patient1", "passwordPatient1")));
            //Application.Run(new GuestForm());
            Application.Run(new AdminForm());
        }
    }
}
