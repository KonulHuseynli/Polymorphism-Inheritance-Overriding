using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp61
{
    class Students : User
    {
        public int Grade;
        public Students(string name, string surname, string username, string password, int grade)
        {
            Name = name;
            Surname = surname;
            this.Username = username;
            this.Password = password;
            Grade = grade;

        }
        public override void getgrade()
        {
            Console.WriteLine(Grade);
        }
    }
    }
