using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OOP
{
    public class Admin : User, IUserLogIn
    {
        public Admin(int id, string firstname, string lastname, string middlename) : base(id, firstname, lastname, middlename)
        {
        }

        public override string ToString()
        {
            return $"Id: {Id}, firstname: {Firstname}, lastname: {Lastname}, middlename: {Middlename}";
        }

        public static Admin ReadFromFileJSON(int id)
        {
            try
            {
                //string user = File.ReadLines($"../../../Data/users/admins/{id}.json").First();
                string user = File.ReadLines($"{Authorization.path}/users/admins/{id}.json").First();


                Admin admin = JsonSerializer.Deserialize<Admin>(user);
                return admin;
            }
            catch (IOException ex) { }
            return null;
        }
                        
        public bool SaveToFileJSON()
        {
            try
            {
                string jsonstring = "";

                jsonstring += JsonSerializer.Serialize<Admin>(this);
                jsonstring += "\n";

                //File.WriteAllText($"../../../Data/users/admins/{this.Id}.json", jsonstring, Encoding.UTF8);
                File.WriteAllText($"{Authorization.path}/users/admins/{this.Id}.json", jsonstring, Encoding.UTF8);
                return true;
            }
            catch (Exception ex) { return false; }
        }
    }
}
