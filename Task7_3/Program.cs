using System;

namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Обычный массив:");
            PrintNumbers(numbers);

            Console.WriteLine("Обратный массив:");
            PrintNumbers(numbers, true);
            Console.ReadKey();  
        }

        static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (!reverse)
            {
                // Вывод в прямом порядке
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            else
            {
                // Вывод в обратном порядке
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine();
        }
    }
}
