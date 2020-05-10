using System;

namespace Ссылки_и_значения
{
    class Program
    {
        // передача по ЗНАЧЕНИЮ

        //static void Main(string[] args)
        //{
        //    int a = 9;
        //    Console.WriteLine($"Начальное значение a = {a}");
        //    IncrementVal(a);
        //    Console.WriteLine($"Переменная a после передачи по значению = {a}");
        //    Console.ReadKey();
        //}
        //static void IncrementVal(int x)
        //{
        //    x++;
        //    Console.WriteLine($"IncrementVal: {x}");
        //}



        //Передача переменных по ССЫЛКЕ

        static void Main(string[] args)
        {
            int a = 25;
            Console.WriteLine($"Начальное значение a  = {a}");
            IncrementRef(ref a);
            Console.WriteLine($"Переменная a после передачи ссылке = {a}");
            Console.ReadKey();
        }
        
        static void IncrementRef(ref int x)
        {
            x++;
            Console.WriteLine($"IncrementRef: {x}");
        }



    }
}
