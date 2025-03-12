namespace Task5_2
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
                t[i] = rnd.Next(-20, 21); // Диапазон случайных чисел: от -20 до 20
                Console.Write("{0} ", t[i]);
            }

            int a = 0;
            int b = 0;
            int c = 0;
            foreach (int x in t) // Находим положительные, отрицательные и числа равных нулю в массиве
            {
                if (x > 0)
                    a++;
                else if (x < 0)
                    b++;
                else
                    c++;
            }
            Console.WriteLine();

            Console.WriteLine("Количество положительных чисел: {0} ", a);
            Console.WriteLine("Количество отрицательных чисел: {0} ", b);
            Console.WriteLine("Количество чисел равных нулю: {0} ", c);

            Console.ReadKey();
        }
    }
}
