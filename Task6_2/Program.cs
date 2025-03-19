namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            while (input.Contains(" ")) // Удаление пробелов 
            {
                input = input.Replace(" ", "").ToLower(); // Приведение к нижнему регистру
            }

            bool Palindrome = true; // Проверка на палиндром
            int length = input.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (input[i] != input[length - 1 - i])
                {
                    Palindrome = false;
                    break;
                }
            }
            if (Palindrome == true)
            {
                Console.WriteLine("Предложение является палиндромом.");
            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом.");
            }
            Console.ReadKey();
        }
    }
}
