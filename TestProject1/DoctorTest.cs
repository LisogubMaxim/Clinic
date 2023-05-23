using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class DoctorTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            string str = $"Id: {1}, firstname: {"Андрій"}, lastname: {"Науменко"}, middlename: {"Микитович"}, speciality: {"Хірург"}";
            Doctor doctor = new Doctor(1, "Андрій", "Науменко", "Микитович", "Хірург");

            Assert.AreEqual(str, doctor.ToString());
        }

        [TestMethod]
        public void DeleteTest()
        {
            Authorization.Registration("doctor", "passwordDoctor", "doctor");
            Doctor doctor = new Doctor(Authorization.LastId(), "Андрій", "Науменко", "Микитович", "Хірург");
            doctor.SaveToFileJSON();

            bool isDelete = doctor.Delete();

            Assert.IsTrue(isDelete);
        }

        [TestMethod]
        public void SaveToFileJSONTest()
        {
            Authorization.Registration("doctor", "passwordDoctor", "doctor");
            Doctor doctor = new Doctor(Authorization.LastId(), "Андрій", "Науменко", "Микитович", "Хірург");
            bool isSuccessful = doctor.SaveToFileJSON();

            Assert.IsTrue(isSuccessful);
        }

        [TestMethod]
        public void ReadFromFileJSONTest_int()
        {
            Authorization.Registration("doctor", "passwordDoctor", "doctor");
            Doctor doctor = new Doctor(Authorization.LastId(), "Андрій", "Науменко", "Микитович", "Хірург");
            doctor.SaveToFileJSON();

            Doctor doctor1 = Doctor.ReadFromFileJSON(Authorization.LastId());

            Assert.AreEqual(doctor.ToString(), doctor1.ToString());
        }

        [TestMethod]
        public void ReadFromFileJSONTest_path()
        {
            Authorization.Registration("doctor", "passwordDoctor", "doctor");
            Doctor doctor = new Doctor(Authorization.LastId(), "Андрій", "Науменко", "Микитович", "Хірург");
            doctor.SaveToFileJSON();

            Doctor doctor1 = Doctor.ReadFromFileJSON($"../../../Data/users/doctors/{Authorization.LastId()}.json");

            Assert.AreEqual(doctor.ToString(), doctor1.ToString());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Directory.Delete("../../../Data/users/doctors", true);
            Directory.CreateDirectory("../../../Data/users/doctors");
            File.WriteAllText("../../../Data/passwords.json", "");
        }
    }
}
