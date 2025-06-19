namespace Lab15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
        {
            new Computer() { Code = 1, Brand = "HP", Processor = "Intel i5", Frequency = 3.2, RAM = 8, HDD = 512, VideoMemory = 4, Price = 800, Quantity = 15 },
            new Computer() { Code = 2, Brand = "Dell", Processor = "AMD Ryzen 5", Frequency = 3.6, RAM = 16, HDD = 1024, VideoMemory = 6, Price = 950, Quantity = 8 },
            new Computer() { Code = 3, Brand = "Lenovo", Processor = "Intel i7", Frequency = 4.0, RAM = 32, HDD = 2048, VideoMemory = 8, Price = 1500, Quantity = 5 },
            new Computer() { Code = 4, Brand = "Asus", Processor = "AMD Ryzen 7", Frequency = 3.8, RAM = 16, HDD = 512, VideoMemory = 6, Price = 1100, Quantity = 12 },
            new Computer() { Code = 5, Brand = "Acer", Processor = "Intel i5", Frequency = 3.0, RAM = 8, HDD = 256, VideoMemory = 2, Price = 600, Quantity = 30 },
            new Computer() { Code = 6, Brand = "MacBook", Processor = "M2", Frequency = 5.0, RAM = 64, HDD = 2048, VideoMemory = 32, Price = 3500, Quantity = 3 }
        };

            // 1. Все компьютеры с указанным процессором
            Console.Write("Введите название процессора для поиска: ");
            string processor = Console.ReadLine();
            var byProcessor = computers
                .Where(computer => computer.Processor.Equals(processor))
                .ToList();
            Console.WriteLine("\nКомпьютеры с процессором " + processor + ":");
            PrintComputers(byProcessor);

            // 2. Все компьютеры с объемом ОЗУ не ниже указанного
            Console.Write("\nВведите минимальный объем ОЗУ: ");
            if (int.TryParse(Console.ReadLine(), out int minRAM))
            {
                var byRAM = computers
                    .Where(computer => computer.RAM >= minRAM)
                    .ToList();
                Console.WriteLine($"\nКомпьютеры с ОЗУ не менее {minRAM} ГБ:");
                PrintComputers(byRAM);
            }

            // 3. Cписок, отсортированный по стоимости
            var sortedByPrice = computers.OrderBy(item => item.Price).ToList();
            Console.WriteLine("\nСписок компьютеров, отсортированный по цене:");
            PrintComputers(sortedByPrice);

            // 4. Cписок, сгруппированный по типу процессора
            var groupedByProcessor = computers.GroupBy(c => c.Processor);
            Console.WriteLine("\nСписок компьютеров, сгруппированный по процессору:");
            foreach (var group in groupedByProcessor)
            {
                Console.WriteLine($"\nПроцессор: {group.Key}");
                PrintComputers(group.ToList());
            }

            // 5. Самый дорогой и самый бюджетный компьютер
            var mostExpensive = computers.OrderByDescending(c => c.Price).First();
            var cheapest = computers.OrderBy(c => c.Price).First();
            Console.WriteLine("\nСамый дорогой компьютер:");
            PrintComputer(mostExpensive);
            Console.WriteLine("\nСамый бюджетный компьютер:");
            PrintComputer(cheapest);

            // 6. Проверка наличия компьютеров в количестве ≥ 30
            bool has30Plus = computers.Any(c => c.Quantity >= 30);
            Console.WriteLine($"\nЕсть ли хотя бы один компьютер в количестве ≥ 30: {(has30Plus ? "Да" : "Нет")}");

            Console.ReadKey();
        }
        class Computer
        {
            public int Code { get; set; }
            public string Brand { get; set; }
            public string Processor { get; set; }
            public double Frequency { get; set; }
            public int RAM { get; set; }
            public int HDD { get; set; }
            public int VideoMemory { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
        static void PrintComputers(List<Computer> computers)
        {
            foreach (var comp in computers)
            {
                PrintComputer(comp);
            }
        }

        static void PrintComputer(Computer comp)
        {
            Console.WriteLine($"Код: {comp.Code}, Марка: {comp.Brand}, Процессор: {comp.Processor}, " +
                $"Частота: {comp.Frequency} ГГц, ОЗУ: {comp.RAM} ГБ, HDD: {comp.HDD} ГБ, " +
                $"Видеокарта: {comp.VideoMemory} ГБ, Цена: {comp.Price} у.е., Количество: {comp.Quantity}");
        }
    }
}
