using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace OOP
{
    public class Meet
    {
        private DateTime date;
        private int idPatient;
        private int idDoctor;
        private string description;

        public Meet(DateTime date, Patient patient, Doctor doctor, string description)
        {
            patient.Meetings.Add(date);
            patient.SaveToFileJSON();

            doctor.Meetings.Add(date);
            doctor.PatientsWithMeet.Add(patient.Id);
            doctor.SaveToFileJSON();

            Date = date;
            IdPatient = patient.Id;
            IdDoctor = doctor.Id;
            Description = description;
        }

        public Meet()
        {

        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public int IdPatient
        {
            get => idPatient;
            set => idPatient = value;
        }

        public int IdDoctor
        {
            get => idDoctor;
            set => idDoctor = value;
        }

        public string Description
        {
            get => description; 
            set => description = value;
        }

        public override string ToString()
        {
            return $"Date: {Date}, IdPatient: {IdPatient}, IdDoctor: {IdDoctor}, Description: {Description}";
        }

        public bool Cancel()
        {
            try
            {
                Doctor doctor = Doctor.ReadFromFileJSON(IdDoctor);
                Patient patient = Patient.ReadFromFileJSON(IdPatient);

                doctor.Meetings.Remove(Date);
                doctor.PatientsWithMeet.Remove(patient.Id);
                doctor.SaveToFileJSON();

                patient.Meetings.Remove(Date);
                patient.SaveToFileJSON();

                //File.Delete($"../../../Data/meetings/{Date.Day}.{Date.Month}/{Date.Hour}.{Date.Minute}.json");
                File.Delete($"{Authorization.path}/meetings/{Date.Day}.{Date.Month}/{Date.Hour}.{Date.Minute}.json");

                //if (Directory.GetFiles($"../../../Data/meetings/{Date.Day}.{Date.Month}").Length == 0)
                if (Directory.GetFiles($"{Authorization.path}/meetings/{Date.Day}.{Date.Month}").Length == 0)
                {
                    //Directory.Delete($"../../../Data/meetings/{Date.Day}.{Date.Month}");
                    Directory.Delete($"{Authorization.path}/meetings/{Date.Day}.{Date.Month}");
                }
                return true;
            }catch(Exception ex) { }
            return false;
        }

        public bool DeleteYesterday()
        {
            try
            {
                if (Date < DateTime.Now)
                {
                    this.Cancel();
                    return true;
                }
            }catch(Exception ex) { }
            return false;
        }

        public static Meet ReadFromFileJSON(string path)
        {
            try
            {
                string m = File.ReadLines(path).First();

                Meet meet = JsonSerializer.Deserialize<Meet>(m);
                return meet;
            }
            catch (IOException ex) { }
            return null;
        }

        public bool SaveToFileJSON()
        {
            try
            {
                //string path = $"../../../Data/meetings/{Date.Day}.{Date.Month}/";
                string path = $"{Authorization.path}/meetings/{Date.Day}.{Date.Month}/";

                string jsonstring = "";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                jsonstring += JsonSerializer.Serialize<Meet>(this) + "\n";

                File.WriteAllText(path + $"{Date.Hour}.{Date.Minute}.json", jsonstring, Encoding.UTF8);
                return true;
            }
            catch (Exception ex) { }
            return false;
        }
    }
}
