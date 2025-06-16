namespace Lab14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем список для хранения фамилий игроков
            List<string> players = new List<string>();

            // Добавляем игроков методом Add
            players.Add("Иванов");
            players.Add("Петров");
            players.Add("Сидоров");

            // Вставляем игрока "Козлов" на позицию с индексом 1
            players.Insert(1, "Козлов");

            // Проверяем наличие игрока "Петров" в команде
            bool hasPetrov = players.Contains("Петров");
            Console.WriteLine($"Есть ли игрок 'Петров' в команде? {hasPetrov}");

            // Находим индекс игрока "Козлов"
            int kozlovIndex = players.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока 'Козлов': {kozlovIndex}");

            // Удаляем игрока "Сидоров"
            players.Remove("Сидоров");

            // Сортируем список по алфавиту
            players.Sort();

            // Выводим текущий состав команды
            Console.WriteLine("Текущий состав команды:");
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"   {i + 1}. {players[i]}");
            }

            // Проверяем, пуст ли список
            bool isEmpty = players.Count == 0;
            Console.WriteLine($"Команда пуста? {isEmpty}");

            // Очищаем список
            players.Clear();

            // Выводим количество игроков после очистки
            Console.WriteLine($"Количество игроков после очистки: {players.Count}");

            Console.ReadKey();
        }
    }
}
