using System;

namespace Конструкции
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 67;
            if(num1>num2)
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }
            else if(num1 < num2)
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }
            else
            {
                Console.WriteLine($"Число {num1} равно {num2}");
            }
            Console.ReadKey();

            // Конструкция switch

            Console.WriteLine("Нажмите клавишу Y или N ");
            string selection = Console.ReadLine();

            switch(selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали клавишу Y");
                    break;
                case "N":
                    Console.WriteLine("Вы нажали клавишу N");
                        break;
                default:
                    Console.WriteLine("Вы нажали неизвестную клавишу");
                    break;                            
            }
            Console.ReadKey();

            //Тернарная операция

            int x = 2;
            int y = 3;
            Console.WriteLine("Нажмите + или - ");
            string test = Console.ReadLine();

            int z = test == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
