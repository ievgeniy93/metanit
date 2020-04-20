using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // цикл do

            int i = 6;
            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i > 0);

            Console.ReadKey();

            // цикл while

            int y = 6;
            while (i > 0)
            {
                Console.WriteLine(y);
                y--;
            }
            Console.ReadKey();

            //ввод пароля

            string password;
            do
            {
                Console.WriteLine("Введите пароль: ");
                password = Console.ReadLine();
            }
            while (password != "root");

            Console.ReadKey();

            // continue , break

            for (int t = 0; i < 9; t++)
            {
                if (t == 5)
                    break;
                Console.WriteLine(i);
            }
            Console.ReadKey();



        }
    }
}
