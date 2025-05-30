namespace Lab12_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Code - string, PublicationYear - int
            Book<string, int>[] library1 = new Book<string, int>[]
            {
            new Book<string, int>("F-1234", "Война и мир", "Лев Толстой", 1869),
            new Book<string, int>("S-567", "Преступление и наказание", "Фёдор Достоевский", 1866),
            new Book<string, int>("A-901", "Анна Каренина", "Лев Толстой", 1877)
            };

            // Code - int, PublicationYear - string
            Book<int, string>[] library2 = new Book<int, string>[]
            {
            new Book<int, string>(23, "1984", "Джордж Оруэлл", "XX век"),
            new Book<int, string>(42, "Великий Гэтсби", "Фрэнсис Скотт Фицджеральд", "XX век"),
            new Book<int, string>(99, "Гарри Поттер", "Джоан Роулинг", "XXI век")
            };

            // Поиск и вывод книг
            var book1 = FindBook(library1, "F-1234");
            Console.WriteLine(book1?.ToString() ?? "Книга не найдена");

            var book2 = FindBook(library2, 42);
            Console.WriteLine(book2?.ToString() ?? "Книга не найдена");
        }
        
        public static Book<T, U> FindBook<T, U>(Book<T, U>[] books, T code)
        {
            foreach (var book in books)
            {
                if (book.Code.Equals(code))
                    return book;
            }
            return null;
        }

        public class Book<T, U>
        {
            public T Code { get; set; }
            public string Title { get; set; }
            public U PublicationYear { get; set; }
            public string Author { get; set; }

            public Book(T code, string title, string author, U publicationYear)
            {
                Code = code;
                Title = title;
                Author = author;
                PublicationYear = publicationYear;
            }

            public override string ToString()
            {
                return $"Код: {Code} ({typeof(T).Name}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U).Name})";
            }
        }
    }
}
