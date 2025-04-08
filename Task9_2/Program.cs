namespace Task9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Счета
            BankAccount account1 = new BankAccount();
            BankAccount account2 = new BankAccount();

            Console.WriteLine($"Всего счетов: {BankAccount.TotalAccounts}\n");

            // Манипуляции с первым счетом
            Console.WriteLine($"Счет: {account1.AccountNumber}");
            account1.Deposit(4000);
            account1.Withdraw(950);
            Console.WriteLine();

            // Манипуляции со вторым счетом
            Console.WriteLine($"Счет: {account2.AccountNumber}");
            account2.Deposit(3000);
            account2.Withdraw(3550);
            Console.ReadKey();
        }
        public class BankAccount
        {
            // Поле для баланса
            private decimal _balance;

            // Поле для количество счетов
            public static int TotalAccounts { get; private set; }

            // Свойство номера счета readonly
            public string AccountNumber { get; }

            // Свойство баланса
            public decimal Balance
            {
                get => _balance;
                private set => _balance = value;
            }

            // Конструктор
            public BankAccount()
            {
                TotalAccounts++;
                AccountNumber = GenerateAccountNumber();
                _balance = 0;
            }

            // Метод для генерации номера счета
            private string GenerateAccountNumber()
            {
                Random rnd = new Random();
                return rnd.Next(100, 1000).ToString();
            }

            // Метод пополнения счета
            public void Deposit(decimal amount)
            {
                Balance += amount;
                Console.WriteLine($"Пополнение на {amount} руб");
                Console.WriteLine($"Текущий баланс: {Balance} руб");
            }

            // Метод снятия денег
            public void Withdraw(decimal amount)
            {
                Console.WriteLine($"Снятие на {amount} руб");

                if (amount > Balance)
                {
                    Console.WriteLine($"Недостаточно средств на счете");
                    return;
                }
                Balance -= amount;
                Console.WriteLine($"Текущий Баланс: {Balance} руб");
            }
        }
    }
}
