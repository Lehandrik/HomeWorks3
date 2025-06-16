namespace Lab14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем словарь для хранения инвентаря
            Dictionary<string, int> inventory = new Dictionary<string, int>();

            // Добавляем товары на склад
            inventory.Add("A001", 10);  // Ноутбуки
            inventory.Add("B205", 25);  // Смартфоны
            inventory.Add("C307", 15);  // Наушники

            // Проверяем наличие товара с артикулом "B205"
            bool hasB205 = inventory.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205? {hasB205}");

            // Обновляем количество ноутбуков (продали 2 шт.)
            inventory["A001"] = 8;

            // Получаем количество наушников безопасным способом
            if (inventory.TryGetValue("C307", out int headphonesCount))
            {
                Console.WriteLine($"Количество наушников: {headphonesCount}");
            }

            // Увеличиваем количество смартфонов на 5 (новый завоз)
            inventory["B205"] += 5;

            // Удаляем наушники из инвентаря
            inventory.Remove("C307");

            // Выводим текущий инвентарь
            Console.WriteLine("Текущий инвентарь:");
            foreach (KeyValuePair<string, int> item in inventory)
            {
                Console.WriteLine($"Артикул: {item.Key}, Количество: {item.Value}");
            }

            // Проверяем, пуст ли словарь
            bool isEmpty = inventory.Count == 0;
            Console.WriteLine($"Инвентарь пуст? {isEmpty}");

            // Очищаем инвентарь
            inventory.Clear();

            // Выводим количество товаров после очистки
            Console.WriteLine($"Количество товаров после очистки: {inventory.Count}");

            Console.ReadKey();
        }
    }
}
