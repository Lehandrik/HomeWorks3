namespace Task5_4
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
                t[i] = random.Next(0, 11); // Диапазон случайных чисел: от 0 до 10
                Console.Write("{0} ", t[i]);
            }
            Console.WriteLine();

            int temp;
            for (int i = 0; i < n / 2; i++) // Инверсия массива
            {
                temp = t[i];
                t[i] = t[n - 1 - i];
                t[n - 1 - i] = temp;
            }
            Console.Write("Перевернутый массив:    ");
            foreach (int x in t)
            {
                Console.Write("{0} ", x); // Вывод перевернутого массива 
            }
            Console.ReadKey();
        }
    }
}
