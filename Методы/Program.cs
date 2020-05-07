using System;

namespace Методы
{
    class Program
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            string s = Hello();
            int c = Sum();
            string t = Hello2();
            Console.WriteLine(t);
            Console.WriteLine(c);
            Console.WriteLine(s);
            
            Console.ReadKey();

        }
        
        static int Sum()
        {
        int x = 2;
        int y = 3;
        int z = x + y;
            return z;
           
        }

        static string Hello()
        {
            return "Zdorov!";
            
        }
        static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        static void Method2()
        {
            Console.WriteLine("Methid 2");
        }

        static string Hello2() => "tetststststst";
        static void SayHello() => Console.WriteLine("Hello");
        static string GetHello() => "hello";


    }
}
