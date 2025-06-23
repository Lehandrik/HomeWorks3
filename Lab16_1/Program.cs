namespace Lab16_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача продолжения");
            TaskContinuation();

            Console.WriteLine("\nИспользование async/await");
            AsyncAwait().Wait();

            Console.ReadKey();
        }
        // Задача продолжения
        static void TaskContinuation()
        {
            Console.WriteLine("Запуск генерации массива...");
            var generateTask = Task.Run(() => GenerateArray(10));

            var calculateTask = generateTask.ContinueWith(t =>
            {
                return Calculate1(t.Result);
            });
            Console.WriteLine($"Среднее арифметическое: {calculateTask.Result}");
        }
        // Async/await
        static async Task AsyncAwait()
        {
            Console.WriteLine("Запуск генерации массива...");
            int[] array = await Task.Run(() => GenerateArray(10));
            double average = await Task.Run(() => Calculate1(array));

            Console.WriteLine($"Среднее арифметическое: {average}");
        }
        // Генерация массива
        static int[] GenerateArray(int size)
        {
            var random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 100);
                Thread.Sleep(200);
                Console.Write($"{array[i]} ");
            }
            return array;
        }

        // Расчет среднего арифметического
        static double Calculate1(int[] array)
        {
            double sum = 0;

            foreach (int num in array)
            {
                sum += num;
                Thread.Sleep(100);
                Console.Write(".");
            }

            Console.WriteLine("\nРасчет завершен!");
            return sum / array.Length;
        }

    }
}
