using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;
            do
            {
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();
            }
            while (password != "root");
        }
    }






}
    
