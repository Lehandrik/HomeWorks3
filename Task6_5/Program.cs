using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] test =
                {
            "+7(123)456-78-90",  // Корректный
            "+7(123)456-7890",   // Некорректный (отсутствует дефис)
            "8(123)456-78-90",   // Некорректный (начинается не с +7)
            "+7(123)4567890",    // Некорректный (отсутствуют дефисы)
            "+7(123)456-78-9",   // Некорректный (не хватает одной цифры)
            "+7(123)456-78-901"  // Некорректный (лишняя цифра)
                };
            Regex regex = new Regex(@"^\+[7]\(+[0-9]{3}\)+[0-9]{3}-+[0-9]{2}-+[0-9]{2}$"); // Правило

            foreach (string x in test) // Проверка
            {
                if (regex.IsMatch(x))
                     Console.WriteLine("\"{0}\"-ok", x);
                else Console.WriteLine("\"{0}\"- не ok", x);
            }
            Console.ReadKey();
        }
    }
}
