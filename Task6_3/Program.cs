using System.Globalization;

namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяц: ");
            string month = Console.ReadLine();

            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите общую сумму продаж: ");
            double totalSales = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество проданных товаров: ");
            int totalItems = Convert.ToInt32(Console.ReadLine());

            double average = totalSales / totalItems; // Вычисление средней стоимости товара

            // Форматирование данных
            string result = string.Empty;
            string result2 = string.Empty;
            result = string.Format("{0:N2}", totalSales);
            result2 = string.Format("{0:N2}", totalItems);

            // Вывод отчёта
            Console.WriteLine();
            Console.WriteLine("Отчёт о продажах за {0} {1}", month, year);
            Console.WriteLine("Общая сумма продаж: {0} р.", result);
            Console.WriteLine("Количество проданных товаров: {0:N0} шт.", totalItems);
            Console.WriteLine("Средняя стоимость товара: {0} р.", result2);
            Console.ReadKey();

        }
    }
}
