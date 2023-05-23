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
    public class Message
    {
        private int idDoctor;
        private int idPatient;
        private int lastMesFrom;
        private string textMes = "";

        public Message(Patient patient, Doctor doctor)
        {
            patient.Messages.Add(doctor.Id);
            patient.SaveToFileJSON();

            doctor.Messages.Add(patient.Id);
            doctor.SaveToFileJSON();

            IdDoctor = doctor.Id;
            IdPatient = patient.Id;
        }

        public Message()
        {

        }

        public int IdDoctor
        {
            get => idDoctor; set => idDoctor = value;
        }

        public int IdPatient
        {
            get => idPatient; set => idPatient = value;
        }

        public int LastMesFrom
        {
            get => lastMesFrom; set => lastMesFrom = value;
        }

        public string TextMes
        {
            get => textMes; set => textMes += value;
        }

        public override string ToString()
        {
            return $"IdDoctor: {IdDoctor}, IdPatient: {IdPatient}, Last message from: {LastMesFrom}, Text: {TextMes}";
        }

        public void SendMessage(int id, string name, string text)
        {
            if (LastMesFrom != id)
            {
                TextMes = Environment.NewLine + $"{name}:" + Environment.NewLine;
            }

            TextMes = text + Environment.NewLine;
            LastMesFrom = id;
        }

        public bool Delete()
        {
            try
            {
                Doctor doctor = Doctor.ReadFromFileJSON(IdDoctor);
                Patient patient = Patient.ReadFromFileJSON(IdPatient);
                patient.Messages.Remove(doctor.Id);
                patient.SaveToFileJSON();

                doctor.Messages.Remove(patient.Id);
                doctor.SaveToFileJSON();

                //File.Delete($"../../../Data/message/{doctor.Id}_{patient.Id}.json");
                File.Delete($"{Authorization.path}/message/{doctor.Id}_{patient.Id}.json");

                return true;
            }catch(Exception ex) { return false; }
        }

        public static Message ReadFromFileJSON(int idDoctor, int idPatient)
        {
            try
            {
                //string mes = File.ReadLines($"../../../Data/message/{idDoctor}_{idPatient}.json").First();
                string mes = File.ReadLines($"{Authorization.path}/message/{idDoctor}_{idPatient}.json").First();

                Message message = JsonSerializer.Deserialize<Message>(mes);
                return message;
            }
            catch (IOException ex) { }
            return null;
        }

        public bool SaveToFileJSON()
        {
            try
            {
                string jsonstring = "";

                jsonstring += JsonSerializer.Serialize<Message>(this);

                //File.WriteAllText($"../../../Data/message/{IdDoctor}_{IdPatient}.json", jsonstring, Encoding.UTF8);
                File.WriteAllText($"{Authorization.path}/message/{IdDoctor}_{IdPatient}.json", jsonstring, Encoding.UTF8);
                return true;
            }
            catch (Exception ex) { }
            return false;
        }
    }
}
