namespace Task9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book warAndPeace = new Book("Война и мир", "Л. Толстой", 1869, 1225);

            Console.WriteLine(warAndPeace.GetInfo());

            warAndPeace.Year = 1870;
            warAndPeace.Pages = 1300;

            Console.WriteLine(warAndPeace.GetInfo());
            Console.ReadKey();
        }
    }
    class Book
    {
        // Приватные поля
        private string _title;
        private string _author;

        // Автосвойства
        public int Year { get; set; }
        public int Pages { get; set; }

        // Конструктор
        public Book(string title, string author, int year, int pages)
        {
            _title = title;
            _author = author;
            Year = year;
            Pages = pages;
        }

        // Метод для получения информации о книге
        public string GetInfo()
        {
            return $"{_title}, {_author}, {Year}, {Pages} стр.";
        }
    }
}
