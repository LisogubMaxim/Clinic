using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class User
    {
        private int id;
        private string firstname;
        private string lastname;        
        private string middlename;
        private bool genderIsMale = true;

        public User(int id, string firstname, string lastname, string middlename)
        {
            this.id = id;
            Firstname = firstname;
            Lastname = lastname;
            Middlename = middlename;
        }

        public int Id
        {
            get => id;
        }

        public string Firstname
        {
            get => firstname;
            set 
            {
                if(value == null)
                {
                    firstname = value;
                    return;
                }
                if (value.Length > 1) firstname = value;
            }
        }

        public string Lastname
        {
            get => lastname;
            set
            {
                if (value == null)
                {
                    lastname = value;
                    return;
                }
                if (value.Length > 1) lastname = value;
            }
        }

        public string Middlename
        {
            get => middlename;
            set
            {
                if (value == null)
                {
                    middlename = value;
                    return;
                }
                if (value.Length > 1) middlename = value;
            }
        }

        public bool GenderIsMale
        {
            get => genderIsMale;
            set => genderIsMale = value;
        }

        public static IUserLogIn ReadFromFileJSON(string role, int id)
        {
            try
            {
                if (role == "doctor")
                {
                    //string user = File.ReadLines($"../../../Data/users/doctors/{id}.json").First();
                    string user = File.ReadLines($"{Authorization.path}/users/doctors/{id}.json").First();

                    Doctor doctor = JsonSerializer.Deserialize<Doctor>(user);
                    return doctor;
                }
                if (role == "patient")
                {
                    //string user = File.ReadLines($"../../../Data/users/patients/{id}.json").First();
                    string user = File.ReadLines($"{Authorization.path}/users/patients/{id}.json").First();

                    Patient patient = JsonSerializer.Deserialize<Patient>(user);
                    return patient;
                }
                if (role == "admin")
                {
                    //string user = File.ReadLines($"../../../Data/users/admins/{id}.json").First();
                    string user = File.ReadLines($"{Authorization.path}/users/admins/{id}.json").First();

                    Admin admin = JsonSerializer.Deserialize<Admin>(user);
                    return admin;
                }
            }
            catch (IOException ex) { }
            return null;
        }
    }
}
