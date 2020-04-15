using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя:");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int old = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите рост: ");
            decimal rost = Convert.ToDecimal(Console.ReadLine());
                       
            Console.Write("Введите размер зарплаты в долярах: ");
            decimal ZP = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Имя:{name} Возраст:{old} Рост:{rost}м ЗП:{ZP}$");
            Console.ReadKey();




        }
    }
}
