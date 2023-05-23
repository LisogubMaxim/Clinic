using OOP;
using System.Net;
using System.Text.Json;
using Authorization = OOP.Authorization;

namespace TestProject1
{
    [TestClass]
    public class AdminTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            string str = $"Id: {1}, firstname: {"Андрій"}, lastname: {"Науменко"}, middlename: {"Микитович"}";
            Admin admin = new Admin(1, "Андрій", "Науменко", "Микитович");

            Assert.AreEqual(str, admin.ToString());
        }

        [TestMethod]
        public void SaveToFileJSONTest()
        {
            Authorization.Registration("admin", "passwordAdmin", "admin");

            Admin admin = new Admin(Authorization.LastId(), "Андрій", "Науменко", "Микитович");
            bool isSuccessful = admin.SaveToFileJSON();

            Assert.IsTrue(isSuccessful);
        }

        [TestMethod]
        public void ReadFromFileJSONTest()
        {
            Authorization.Registration("admin", "passwordAdmin", "admin");
            Admin admin = new Admin(Authorization.LastId(), "Андрій", "Науменко", "Микитович");
            admin.SaveToFileJSON();

            Admin admin2 = Admin.ReadFromFileJSON(Authorization.LastId());

            Assert.AreEqual(admin.ToString(), admin2.ToString());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Directory.Delete("../../../Data/users/admins", true);
            Directory.CreateDirectory("../../../Data/users/admins");
            File.WriteAllText("../../../Data/passwords.json", "");
        }

    }
}