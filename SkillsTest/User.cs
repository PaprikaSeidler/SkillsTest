using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class User
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public User(string name, string phone, string email) 
        { 
            Name = name;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"User information:\n" +
                $"Name: {Name}\n" +
                $"Phone number: {Phone}\n" +
                $"Email: {Email}\n";
        }
    }
}
