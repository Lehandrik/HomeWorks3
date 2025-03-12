namespace Task5_3
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
                t[i] = rnd.Next(0, 51); // Диапазон случайных чисел: от 0 до 50
                Console.Write("{0} ", t[i]);
            }

            int max = 0; // Переменная для максимального значение
            int min = t[0]; // Переменная для минимального значения
            int maxindex = 0; // Переменная для индекса у максимального
            int minindex = 0; // Переменная для индекса у минимального
            for (int i = 0; i < n; i++) // Находим значения и их индексы
            {
                if (t[i] > max)
                {
                    max = t[i];
                    maxindex = i;
                }
                if (t[i] < min)
                {
                    min = t[i];
                    minindex = i;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Максимальное значение: {0}, его индекс: {1}", max, maxindex);
            Console.WriteLine("Минимальное значение: {0}, его индекс: {1}", min, minindex);
            Console.ReadKey();
        }
    }
}
