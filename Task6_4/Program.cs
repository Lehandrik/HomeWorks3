using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            result.Append("Имя: ");
            result.Append(name);
            result.Append(", Возраст: ");
            result.Append(age);
            result.Append(", Город: ");
            result.Append(city);

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
