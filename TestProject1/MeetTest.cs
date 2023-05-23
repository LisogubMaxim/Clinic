using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class MeetTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            DateTime date = DateTime.Now.AddDays(5);
            Patient patient = new Patient(2, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(3, "Андрій", "Науменко", "Микитович", "Хірург");
            Meet meet = new Meet(date, patient, doctor, "");

            string str = $"Date: {date}, IdPatient: {2}, IdDoctor: {3}, Description: ";

            Assert.AreEqual(str, meet.ToString());
        }

        [TestMethod]
        public void CancelTest()
        {
            Patient patient = new Patient(2, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(3, "Андрій", "Науменко", "Микитович", "Хірург");
            Meet meet = new Meet(DateTime.Now.AddDays(5), patient, doctor, "");
            meet.SaveToFileJSON();

            bool isSuccessful = meet.Cancel();

            Assert.IsTrue(isSuccessful);
        }

        [TestMethod]
        public void DeleteYesterdayTest_True()
        {
            Patient patient = new Patient(2, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(3, "Андрій", "Науменко", "Микитович", "Хірург");
            Meet meet = new Meet(DateTime.Now.AddDays(-5), patient, doctor, "");
            meet.SaveToFileJSON();

            bool isSuccessful = meet.DeleteYesterday();

            Assert.IsTrue(isSuccessful);
        }

        [TestMethod]
        public void DeleteYesterdayTest_False()
        {
            Patient patient = new Patient(2, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(3, "Андрій", "Науменко", "Микитович", "Хірург");
            Meet meet = new Meet(DateTime.Now.AddDays(5), patient, doctor, "");
            meet.SaveToFileJSON();

            bool isSuccessful = meet.DeleteYesterday();

            Assert.IsFalse(isSuccessful);
        }

        [TestMethod]
        public void SaveToFileJSONTest()
        {
            Patient patient = new Patient(2, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(3, "Андрій", "Науменко", "Микитович", "Хірург");
            Meet meet = new Meet(DateTime.Now.AddDays(5), patient, doctor, "");
            meet.SaveToFileJSON();

            bool isSuccessful = meet.SaveToFileJSON();

            Assert.IsTrue(isSuccessful);
        }

        [TestMethod]
        public void ReadFromFileJSONTest()
        {
            Patient patient = new Patient(2, "Микита", "Гирич", "В'ячеславович");
            Doctor doctor = new Doctor(3, "Андрій", "Науменко", "Микитович", "Хірург");
            Meet meet = new Meet(DateTime.Now.AddDays(5), patient, doctor, "");
            meet.SaveToFileJSON();

            Meet meet2 = Meet.ReadFromFileJSON($"{Authorization.path}/meetings/{meet.Date.Day}.{meet.Date.Month}/{meet.Date.Hour}.{meet.Date.Minute}.json");

            Assert.AreEqual(meet.ToString(), meet2.ToString());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Directory.Delete($"{Authorization.path}/meetings", true);
            Directory.CreateDirectory($"{Authorization.path}/meetings");
            Directory.Delete($"{Authorization.path}/users/patients", true);
            Directory.CreateDirectory($"{Authorization.path}/users/patients");
            Directory.Delete($"{Authorization.path}/users/doctors", true);
            Directory.CreateDirectory($"{Authorization.path}/users/doctors");
        }
    }
}
