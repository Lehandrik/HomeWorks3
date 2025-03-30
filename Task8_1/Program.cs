namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int firstValue, secondValue;
                string action;

                Console.WriteLine("Введите число 1");
                firstValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                secondValue = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Выберите код операций: '1' '2' '3' '4'");
                action = Console.ReadLine();

                if (action == "1")
                {
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (action == "2")
                {
                    Console.WriteLine(firstValue - secondValue);
                }
                else if (action == "3")
                {
                    Console.WriteLine(firstValue * secondValue);
                }
                else if (action == "4")
                {
                    Console.WriteLine(firstValue / secondValue);
                }
                else
                {
                    Console.WriteLine("Неверный код операций");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.ReadKey();
        }
    }
}
