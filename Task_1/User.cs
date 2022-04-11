using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class User
    {
        public string login;
        public string name;
        public string soname;
        public int age = 31;
        public readonly DateTime Data_of_registr;


        public User()
        {            
            Data_of_registr = DateTime.Today;
        }
    }
}
