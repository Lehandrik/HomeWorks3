namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int a = 10;
            const int b = 5;
            int[,] t = new int[a, b];
            Random random = new Random();

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    t[i, j] = random.Next(0, 11); // Диапазон случайных чисел: от 0 до 10
                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < a; i++) // Находим максимальное значение в каждой строке
            {
                int max = t[i, 0];

                for (int j = 0; j < b; j++)
                {
                    if (t[i, j] > max)
                    {
                        max = t[i, j];
                    }
                }
                Console.WriteLine("Максимальный элемент в строчке {0}: {1}", i, max);
            }
            Console.ReadKey();
        }
    }
}
