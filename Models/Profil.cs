using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagbog.Models
{
    internal class Profil
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Key { get; set; }
        public Roles Role { get; set; }
        public Profil(Guid x_Id,string x_Name,string x_Password,string x_Key, Roles x_role)
        {
            Id = x_Id;
            Name = x_Name;
            Password = x_Password;
            Key = x_Key;
            Role = x_role;
        }
    }
}
