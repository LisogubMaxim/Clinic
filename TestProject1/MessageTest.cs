using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestProject1
{
    [TestClass]
    public class MessageTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            Patient patient = new Patient(1, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(2, "Андрій", "Науменко", "Микитович", "Хірург");
            Message mes = new Message(patient, doctor);

            string str = $"IdDoctor: 2, IdPatient: 1, Last message from: 0, Text: ";

            Assert.AreEqual(str, mes.ToString());
        }

        [TestMethod]
        public void SendMessageTest_FirstMes()
        {
            Patient patient = new Patient(1, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(2, "Андрій", "Науменко", "Микитович", "Хірург");
            Message mes = new Message(patient, doctor);

            string str = "Hello";
            string expectStr = Environment.NewLine + $"{patient.Firstname}:" + Environment.NewLine + str + Environment.NewLine;
            mes.SendMessage(patient.Id, patient.Firstname, str);

            Assert.AreEqual(expectStr, mes.TextMes);
        }

        [TestMethod]
        public void SendMessageTest_SecondMes()
        {
            Patient patient = new Patient(1, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(2, "Андрій", "Науменко", "Микитович", "Хірург");
            Message mes = new Message(patient, doctor);

            string str = "Hello";
            string str2 = "bro";
            string expectStr = Environment.NewLine + $"{patient.Firstname}:" + Environment.NewLine + str + Environment.NewLine + str2 + Environment.NewLine;

            mes.SendMessage(patient.Id, patient.Firstname, str);
            mes.SendMessage(patient.Id, patient.Firstname, str2);

            Assert.AreEqual(expectStr, mes.TextMes);
        }

        [TestMethod]
        public void SendMessageTest_OtherSender()
        {
            Patient patient = new Patient(1, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(2, "Андрій", "Науменко", "Микитович", "Хірург");
            Message mes = new Message(patient, doctor);

            string str = "Hello";
            string expectStr = Environment.NewLine + $"{patient.Firstname}:" + Environment.NewLine + str + Environment.NewLine +
                Environment.NewLine + $"{doctor.Firstname}:" + Environment.NewLine + str + Environment.NewLine;

            mes.SendMessage(patient.Id, patient.Firstname, str);
            mes.SendMessage(doctor.Id, doctor.Firstname, str);

            Assert.AreEqual(expectStr, mes.TextMes);
        }

        [TestMethod]
        public void DeleteTest()
        {
            Patient patient = new Patient(1, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(2, "Андрій", "Науменко", "Микитович", "Хірург");
            Message mes = new Message(patient, doctor);

            bool isSuccessful = mes.Delete();

            Assert.IsTrue(isSuccessful);
        }

        [TestMethod]
        public void ReadFromFileJSONTest()
        {
            Patient patient = new Patient(1, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(2, "Андрій", "Науменко", "Микитович", "Хірург");
            Message mes = new Message(patient, doctor);
            mes.SaveToFileJSON();

            Message mes2 = Message.ReadFromFileJSON(doctor.Id, patient.Id);

            Assert.AreEqual(mes.ToString(), mes.ToString());
        }

        [TestMethod]
        public void SaveToFileJSONTest()
        {
            Patient patient = new Patient(1, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(2, "Андрій", "Науменко", "Микитович", "Хірург");
            Message mes = new Message(patient, doctor);

            bool isSuccessful = mes.SaveToFileJSON();

            Assert.IsTrue(isSuccessful);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Directory.Delete($"{Authorization.path}/message", true);
            Directory.CreateDirectory($"{Authorization.path}/message");
            Directory.Delete($"{Authorization.path}/users/patients", true);
            Directory.CreateDirectory($"{Authorization.path}/users/patients");
            Directory.Delete($"{Authorization.path}/users/doctors", true);
            Directory.CreateDirectory($"{Authorization.path}/users/doctors");
        }
    }
}
