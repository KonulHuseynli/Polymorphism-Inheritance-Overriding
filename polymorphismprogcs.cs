using System;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            User Konul = new Students ("konul","huseynli","konul03","K0313z",80);
            User Aysun = new Students("aysun", "huseynli", "aysunvh", "michael58",90);
            User Gunay = new Students("gunay", "quseynov", "guney002", "1302#g",70);
            User[] users = { Konul, Aysun, Gunay };
            Console.WriteLine($"Zehmet olmazsa istifadeci adinizi ve parolunuzu daxil ediniz");
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            foreach (var item in users)
            {
                if(item.Username==username && item.Password==password)
                {
                    item.getgrade();
                }
            }
        }
    }
}
