namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[10];
            Random random = new Random();

            Console.Write("Массив случайных чисел: ");
            for (int i = 0; i < n; i++)
            {
                t[i] = random.Next(-50, 51); // Диапазон случайных чисел: от -50 до 50
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++) // Сортировка первых 5 чисел по возрастанию
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (t[i] > t[j])
                    {
                        int temp = t[i];
                        t[i] = t[j];
                        t[j] = temp;
                    }
                }
            }
            for (int i = 5; i < n; i++) // Сортировка последних 5 чисел по убыванию
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (t[i] < t[j])
                    {
                        int temp = t[i];
                        t[i] = t[j];
                        t[j] = temp;
                    }
                }
            }
            Console.Write("Отсортированный массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", t[i]); // Вывод отсортированного массива
            }
            Console.ReadKey();
        }
    }
}
