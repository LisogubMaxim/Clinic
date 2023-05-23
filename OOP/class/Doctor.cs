using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OOP
{
    public class Doctor : User, IUserLogIn
    {
        private string speciality;

        private SortList<DateTime> meetings = new SortList<DateTime>();
        private List<int> patientsWithMeet = new List<int>();
        private List<int> messages = new List<int>();
        private List<int> patients = new List<int>();

        public Doctor(int id, string firstname, string lastname, string middlename, string speciality) : base(id, firstname, lastname, middlename)
        {
            Speciality = speciality;
        }

        public string Speciality
        {
            get => speciality; 
            set => speciality = value;
        }

        public SortList<DateTime> Meetings
        {
            get => meetings;
            set => meetings = value;
        }

        public List<int> PatientsWithMeet
        {
            get => patientsWithMeet;
            set => patientsWithMeet = value;
        }

        public List<int> Messages
        {
            get => messages;
            set => messages = value;
        }

        public List<int> Patients
        {
            get => patients;
            set => patients = value;
        }

        public override string ToString()
        {
            return $"Id: {Id}, firstname: {Firstname}, lastname: {Lastname}, middlename: {Middlename}, speciality: {Speciality}";
        }

        public bool Delete()
        {
            try
            {
                foreach (DateTime m in Meetings)
                {
                    //Meet meet = Meet.ReadFromFileJSON($"../../../Data/meetings/{m.Day}.{m.Month}/{m.Hour}.{m.Minute}.json");
                    Meet meet = Meet.ReadFromFileJSON($"{Authorization.path}/meetings/{m.Day}.{m.Month}/{m.Hour}.{m.Minute}.json");

                    meet.Cancel();
                }

                Authorization.Delete(Id);
                //File.Delete($"../../../Data/users/doctors/{Id}.json");
                File.Delete($"{Authorization.path}/users/doctors/{Id}.json");

                return true;
            }catch(Exception ex) { return false; }
        }

        public static Doctor ReadFromFileJSON(int id)
        {
            try
            {
                //string user = File.ReadLines($"../../../Data/users/doctors/{id}.json").First();
                string user = File.ReadLines($"{Authorization.path}/users/doctors/{id}.json").First();

                Doctor doctor = JsonSerializer.Deserialize<Doctor>(user);
                return doctor;
            }
            catch (IOException ex) { }
            return null;
        }

        public static Doctor ReadFromFileJSON(string path)
        {
            try
            {
                string user = File.ReadLines(path).First();

                Doctor doctor = JsonSerializer.Deserialize<Doctor>(user);
                return doctor;
            }
            catch (IOException ex) { }
            return null;
        }

        public bool SaveToFileJSON()
        {
            try
            {
                string jsonstring = "";

                jsonstring += JsonSerializer.Serialize<Doctor>(this);
                jsonstring += "\n";

                //File.WriteAllText($"../../../Data/users/doctors/{this.Id}.json", jsonstring, Encoding.UTF8);
                File.WriteAllText($"{Authorization.path}/users/doctors/{this.Id}.json", jsonstring, Encoding.UTF8);

                return true;
            }
            catch (Exception ex) { return false; }
        }

    }
}
