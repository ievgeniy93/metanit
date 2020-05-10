using System;
namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ввод чисел
            int[] nums = new int[7];
            Console.WriteLine("Введи семь чисел");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}-е число: ", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());
            }

            // сортировка
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            // вывод
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.ReadLine();


                    }
    }
}