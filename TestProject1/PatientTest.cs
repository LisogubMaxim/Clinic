using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class PatientTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            string str = $"Id: {2}, firstname: {"Микита"}, lastname: {"Гирич"}, middlename: {"В'ячеславович"}";
            Patient patient = new Patient(2, "Микита", "Гирич", "В'ячеславович");

            Assert.AreEqual(str, patient.ToString());
        }

        [TestMethod]
        public void DeleteTest()
        {
            Authorization.Registration("patient", "passwordPatient", "patient");
            Patient patient = new Patient(Authorization.LastId(), "Микита", "Гирич", "В'ячеславович");
            patient.SaveToFileJSON();

            bool isDelete = patient.Delete();

            Assert.IsTrue(isDelete);
        }

        [TestMethod]
        public void IsNullTest()
        {
            Patient patient = new Patient(Authorization.LastId(), null, null, null);

            Assert.IsTrue(patient.isNull());
        }

        [TestMethod]
        public void SaveToFileJSONTest()
        {
            Authorization.Registration("patient", "passwordPatient", "patient");
            Patient patient = new Patient(Authorization.LastId(), "Микита", "Гирич", "В'ячеславович");
            bool isSuccessful = patient.SaveToFileJSON();

            Assert.IsTrue(isSuccessful);
        }

        [TestMethod]
        public void ReadFromFileJSONTest_int()
        {
            Authorization.Registration("patient", "passwordPatient", "patient");
            Patient patient = new Patient(Authorization.LastId(), "Микита", "Гирич", "В'ячеславович");
            patient.SaveToFileJSON();

            Patient patient1 = Patient.ReadFromFileJSON(Authorization.LastId());

            Assert.AreEqual(patient.ToString(), patient1.ToString());
        }

        [TestMethod]
        public void ReadFromFileJSONTest_path()
        {
            Authorization.Registration("patient", "passwordPatient", "patient");
            Patient patient = new Patient(Authorization.LastId(), "Микита", "Гирич", "В'ячеславович");
            patient.SaveToFileJSON();

            Patient patient1 = Patient.ReadFromFileJSON($"{Authorization.path}/users/patients/{Authorization.LastId()}.json");

            Assert.AreEqual(patient.ToString(), patient1.ToString());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Directory.Delete($"{Authorization.path}/users/patients", true);
            Directory.CreateDirectory($"{Authorization.path}/users/patients");
            File.WriteAllText($"{Authorization.path}/passwords.json", "");
        }
    }
}
