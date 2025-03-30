namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите ваш возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
                Console.WriteLine($"Введённый возраст {age} корректен");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите целое число");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        static void ValidateAge(int age)
        {
            if (age < 0)
            {
                throw new ArgumentException("Возраст не может быть отрицательным");
            }

            if (age > 150)
            {
                throw new ArgumentOutOfRangeException("Слишком большой возраст");
            }
        }
    }
}
