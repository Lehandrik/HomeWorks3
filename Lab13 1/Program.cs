namespace Lab13_1
{
    internal class Program
    {
        // Делегат для условия фильтрации
        public delegate int Transformer(int number);

        public static int[] Transform(int[] numbers, Transformer transformer)
        {
            // Создаем массив
            int[] result = new int[numbers.Length];

            // Преобразуем каждый элемент
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = transformer(numbers[i]);
            }

            return result;
        }
        static void Main(string[] args)
        {
            var numbers = new int[] { -3, -2, -1, 0, 1, 2, 3 };

            // 1. Удвоение всех чисел
            var doubleNumbers = Transform(numbers, n => n * 2);
            Console.WriteLine("Удвоенные числа: " + string.Join(", ", doubleNumbers));


            // 2. Возведение в квадрат
            var squareNumbers = Transform(numbers, n => n * n);
            Console.WriteLine("Квадраты чисел: " + string.Join(", ", squareNumbers));
            // Вывод: Квадраты чисел: 9, 4, 1, 0, 1, 4, 9

            // 3. Замена чисел на их модули
            var absoluteNumbers = Transform(numbers, n => Math.Abs(n));
            Console.WriteLine("Модули чисел: " + string.Join(", ", absoluteNumbers));
            // Вывод: Модули чисел: 3, 2, 1, 0, 1, 2, 3

            Console.ReadKey();
        }
    }
}
