namespace Lab14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем HashSet
            HashSet<string> subscribers = new HashSet<string>();

            // Добавляем подписчиков
            subscribers.Add("alice@example.com");
            subscribers.Add("bob@example.com");
            subscribers.Add("charlie@example.com");

            // Попытка добавления дубликата
            bool aliceAdded = subscribers.Add("alice@example.com");
            Console.WriteLine($"Дубликат alice@example.com добавлен? {aliceAdded}");

            // Проверка наличия подписчиков
            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {subscribers.Contains("bob@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {subscribers.Contains("dave@example.com")}");

            // Создаем второе множество новых подписчиков
            HashSet<string> newSubscribers = new HashSet<string>
        {
            "bob@example.com",
            "dave@example.com",
            "eve@example.com"
        };

            // Объединение множеств
            subscribers.UnionWith(newSubscribers);

            // Вывод подписчиков после объединения
            Console.WriteLine("Подписчики после объединения:");
            foreach (var email in subscribers)
            {
                Console.WriteLine($"- {email}");
            }

            // Поиск пересечения (общих подписчиков)
            HashSet<string> intersection = new HashSet<string>(subscribers);
            intersection.IntersectWith(new HashSet<string> { "bob@example.com", "charlie@example.com" });

            Console.WriteLine("Общие подписчики:");
            foreach (var email in intersection)
            {
                Console.WriteLine($"- {email}");
            }

            // Удаление подписчика
            bool charlieRemoved = subscribers.Remove("charlie@example.com");
            Console.WriteLine($"Удалили charlie@example.com? {charlieRemoved}");

            // Проверка количества подписчиков
            Console.WriteLine($"Всего подписчиков: {subscribers.Count}");

            // Проверка на подмножество
            HashSet<string> testGroup = new HashSet<string>
        {
            "bob@example.com",
            "alice@example.com"
        };

            bool isSubset = testGroup.IsSubsetOf(subscribers);
            Console.WriteLine($"testGroup является подмножеством? {isSubset}");

            // Очистка всей коллекции
            subscribers.Clear();
            Console.WriteLine($"Подписчиков после очистки: {subscribers.Count}");

            Console.ReadKey();
        }
    }
}
