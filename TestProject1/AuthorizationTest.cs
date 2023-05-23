using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class AuthorizationTest
    {
        [TestMethod]
        public void DeleteTest()
        {
            int id = Authorization.LastId();
            Authorization.Registration("doctor1", "passworddoctor1", "doctor");

            bool isSuccesseful = Authorization.Delete(++id);

            Assert.IsTrue(isSuccesseful);
        }

        [TestMethod]
        public void LastIdTest()
        {
            int id1 = 0;
            int id2 = Authorization.LastId();

            Assert.AreEqual(id1, id2);
        }

        [TestMethod]
        public void CheckLoginTest_False()
        {
            Authorization.Registration("doctor50", "passwordddoctor50", "doctor");

            bool isFalse = Authorization.CheckLogin("doctor5");

            Assert.IsFalse(isFalse);
        }

        [TestMethod]
        public void CheckLoginTest_True()
        {
            Authorization.Registration("doctor50", "passwordddoctor5", "doctor");

            bool isTrue = Authorization.CheckLogin("doctor50");

            Assert.IsTrue(isTrue);
        }

        [TestMethod]
        public void CheckLoginAndPasswordTest_patient()
        {
            Authorization.Registration("patient2", "passwordPatient");
            Patient patient = Patient.ReadFromFileJSON(Authorization.LastId());

            Patient patient1 = (Patient)Authorization.CheckLoginAndPassword("patient2", "passwordPatient");

            Assert.AreEqual(patient.Id, patient1.Id);
        }

        [TestMethod]
        public void CheckLoginAndPasswordTest_doctor()
        {
            Authorization.Registration("doctor1", "passwordDoctor", "doctor");
            Doctor doctor = Doctor.ReadFromFileJSON(Authorization.LastId());

            Doctor doctor1 = (Doctor)Authorization.CheckLoginAndPassword("doctor1", "passwordDoctor");

            Assert.AreEqual(doctor.Id, doctor1.Id);
        }

        [TestMethod]
        public void CheckLoginAndPasswordTest_admin()
        {
            Authorization.Registration("admin1", "passwordAdmin", "admin");
            Admin admin = Admin.ReadFromFileJSON(Authorization.LastId());

            Admin admin1 = (Admin)Authorization.CheckLoginAndPassword("admin1", "passwordAdmin");

            Assert.AreEqual(admin.Id, admin1.Id);
        }

        [TestMethod]
        public void CheckLoginAndPasswordTest_null()
        {
            Authorization.Registration("patient7", "passwordPatient");

            Patient patient1 = (Patient)Authorization.CheckLoginAndPassword("patient5", "passwordPatient");

            Assert.AreEqual(null, patient1);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            File.WriteAllText($"{Authorization.path}/passwords.json", "");
            Directory.Delete($"{Authorization.path}/users/patients", true);
            Directory.CreateDirectory($"{Authorization.path}/users/patients");
            Directory.Delete($"{Authorization.path}/users/doctors", true);
            Directory.CreateDirectory($"{Authorization.path}/users/doctors");
            Directory.Delete($"{Authorization.path}/users/admins", true);
            Directory.CreateDirectory($"{Authorization.path}/users/admins");
        }
    }
}
