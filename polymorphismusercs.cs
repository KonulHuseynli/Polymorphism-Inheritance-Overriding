using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class User
    {

        public string Name;
        public string Surname;
        public string Username;
        public string Password;  
        public virtual void getgrade()
        {
            Console.WriteLine("grade");
        }
    }
}
