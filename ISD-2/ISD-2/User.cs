using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_2
{
    class User
    {
        #region
        public string Login { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public readonly DateTime Date;
        #endregion
        public User(string login, string name, string lastname, int age)
        {
            Login = login;
            Name = name;
            Lastname = lastname;
            Age = age;
            Date = DateTime.Now;
        }
    }
}
