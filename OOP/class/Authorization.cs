using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OOP
{
    public class Authorization
    {
        private int id;
        private string login;
        private string password;
        private string role;

        public static string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Data";
       
        public Authorization(int id, string login, string password, string role)
        {
            Id = id;
            Login = login;
            Password = password;
            Role = role;
        }

        public int Id
        {
            get => id; set => id = value;
        }

        public string Login
        {
            get => login;
            set => login = value;
        }

        public string Password
        {
            get => password; set => password = value;
        }

        public string Role
        {
            get => role; set => role = value;
        }

        public static bool Delete(int i)
        {
            try
            {
                //string[] lines = File.ReadAllLines("../../../Data/passwords.json");
                string[] lines = File.ReadAllLines($"{path}/passwords.json");

                string[] newLines = lines.Where((val, idx) => val.IndexOf($"\"Id\":{i}") == -1).ToArray();
                //File.WriteAllLines("../../../Data/passwords.json", newLines);
                File.WriteAllLines($"{path}/passwords.json", newLines);

                return true;
            }catch(Exception ex) { return false; }
        }

        public static int LastId()
        {
            int id = 0;

            //if (File.ReadAllLines("../../../Data/passwords.json").Length != 0)
            if (File.ReadAllLines($"{path}/passwords.json").Length != 0)
            {
                //id = JsonSerializer.Deserialize<Authorization>(File.ReadAllLines("../../../Data/passwords.json").Last()).Id;
                id = JsonSerializer.Deserialize<Authorization>(File.ReadAllLines($"{path}/passwords.json").Last()).Id;
            }

            return id;
        }

        public static bool CheckLogin(string textBoxLogin)
        {
            List<string> users = new List<string>();
            //users = File.ReadAllLines("../../../Data/passwords.json").ToList();
            users = File.ReadAllLines($"{path}/passwords.json").ToList();

            foreach (string user in users)
            {
                if (user.Contains("\"" + textBoxLogin + "\"") && !(string.IsNullOrEmpty(textBoxLogin)))
                {
                    return true;
                }
            }

            return false;
        }

        public static IUserLogIn CheckLoginAndPassword(string textBoxLogin, string textBoxPassword)
        {
            if (textBoxLogin == "patient" || textBoxLogin == "doctor" || textBoxLogin == "admin") return null;
            List<string> users = new List<string>();
            //users = File.ReadAllLines("../../../Data/passwords.json").ToList();
            users = File.ReadAllLines($"{path}/passwords.json").ToList();


            foreach (string user in users)
            {
                if (user.Contains("\"" + textBoxLogin + "\"") && !(string.IsNullOrEmpty(textBoxLogin)))
                {
                     Authorization auth = JsonSerializer.Deserialize<Authorization>(user);
                    if (auth.Password == textBoxPassword)
                    {
                        if (auth.Role == "doctor")
                        {
                            return Doctor.ReadFromFileJSON("doctor", auth.Id);
                        }
                        if (auth.Role == "admin")
                        {
                            return Admin.ReadFromFileJSON("admin", auth.Id);
                        }
                        if (auth.Role == "patient")
                        {
                            return Patient.ReadFromFileJSON("patient", auth.Id);
                        }
                    }
                }
            }

            return null;
        }


        public static bool Registration(string login, string password, string role = "patient")
        {
            try
            {
                string jsonstring = "";
                int id = LastId();

                Authorization auth = new Authorization(++id, login, password, role);

                jsonstring += JsonSerializer.Serialize<Authorization>(auth);
                jsonstring += "\n";

                //File.AppendAllText($"../../../Data/passwords.json", jsonstring, Encoding.UTF8);
                File.AppendAllText($"{path}/passwords.json", jsonstring, Encoding.UTF8);


                if (role == "patient")
                {
                    Patient patient = new Patient(auth.Id, null, null, null);
                    patient.SaveToFileJSON();
                }
                if (role == "doctor")
                {
                    Doctor doctor = new Doctor(auth.Id, null, null, null, null);
                    doctor.SaveToFileJSON();
                }
                if (role == "admin")
                {
                    Admin admin = new Admin(auth.Id, null, null, null);
                    admin.SaveToFileJSON();
                }
                return true;
            }
            catch(Exception ex) { }

            return false;
        }
    }
}
