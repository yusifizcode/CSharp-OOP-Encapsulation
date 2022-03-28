using System;

namespace CSharp_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Istifadeci adinizi daxil edin: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Parolu daxil edin: ");
            string pass = Console.ReadLine();

            User user = new User(userName);
            user.Password = pass;
            Console.WriteLine($"Istifadeci adi: {user.UserName} - password: {user.Password}");
        }
    }
}
