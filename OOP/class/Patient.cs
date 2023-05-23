using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP
{
    public class Patient : User, IUserLogIn
    {
        private string description;

        private SortList<DateTime> meetings = new SortList<DateTime>();
        private List<int> messages = new List<int>();

        public Patient(int id, string firstname, string lastname, string middlename) : base(id, firstname, lastname, middlename)
        {

        }

        public string Description
        {
            get => description;
            set => description = value;
        }
        
        public SortList<DateTime> Meetings
        {
            get => meetings;
            set => meetings = value;
        }

        public List<int> Messages
        {
            get => messages;
            set => messages = value;
        }

        public override string ToString()
        {
            return $"Id: {Id}, firstname: {Firstname}, lastname: {Lastname}, middlename: {Middlename}";
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
                //File.Delete($"../../../Data/users/patients/{Id}.json");
                File.Delete($"{Authorization.path}/users/patients/{Id}.json");

                return true;
            }catch(Exception ex) { return false; }

        }

        public bool isNull()
        {
            if (this.Firstname == null || this.Lastname == null || this.Middlename == null) return true;
            return false;
        }

        public static Patient ReadFromFileJSON(int id)
        {
            try
            {
                
                //string user = File.ReadLines($"../../../Data/users/patients/{id}.json").First();
                string user = File.ReadLines($"{Authorization.path}/users/patients/{id}.json").First();

                Patient patient = JsonSerializer.Deserialize<Patient>(user);
                return patient;
            }
            catch (IOException ex) { }
            return null;
        }

        public static Patient ReadFromFileJSON(string path)
        
        {
            try
            {
                string user = File.ReadLines(path).First();

                Patient patient = JsonSerializer.Deserialize<Patient>(user);
                return patient;
            }
            catch (IOException ex) { }
            return null;
        }

        public bool SaveToFileJSON()
        {
            try
            {
                string jsonstring = "";

                jsonstring += JsonSerializer.Serialize<Patient>(this);
                jsonstring += "\n";

                //File.WriteAllText($"../../../Data/users/patients/{this.Id}.json", jsonstring, Encoding.UTF8);
                File.WriteAllText($"{Authorization.path}/users/patients/{this.Id}.json", jsonstring, Encoding.UTF8);


                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
