using System.Linq;
using System.Text;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' '); // Разделение строки на слова

            string longer = "";  
            foreach (string word in words) // Поиск длинного слова
            {
                if (word.Length > longer.Length)
                {
                    longer = word;
                }
            }

            if (!string.IsNullOrEmpty(longer)) 
            {
                longer = char.ToUpper(longer[0]) + longer.Substring(1); // Первая буква большая у длинного слова
            }

            Console.WriteLine("Самое длинное слово: {0}", longer);
            Console.ReadKey();

        }
    }
}
