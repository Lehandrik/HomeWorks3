namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random(); // Заданы 10 случайных чисел в массиве

            Console.Write("Массив случайных чисел: ");
            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 101); // Диапазон случайных чисел: от 0 до 100
                Console.Write("{0} ", t[i]);
            }

            int a = 0; // Переменная для четных чисел
            int b = 0;
            for (int i = 0; i < n; i++) // Находим четные и нечетные числа в массиве
            {
                if (t[i] % 2 == 0)
                    a++;
                else
                    b++;
            }
            Console.WriteLine();

            if (a > b) // Вывод каких чисел больше в массиве
                Console.WriteLine("Четных чисел больше");
            else
                Console.WriteLine("Нечетных чисел больше");

            Console.ReadKey();
        }
    }
}
