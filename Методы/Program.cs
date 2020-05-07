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
            int z = 90;
            int c = Sum(z,15);
            Console.WriteLine(c);
            Console.WriteLine(s);
            
            Console.ReadKey();

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

        static int Sum(int x, int y)
        {
            return x + y;
        }
        

}
}
