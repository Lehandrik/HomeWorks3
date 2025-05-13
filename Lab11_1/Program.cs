namespace Lab11_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[]
            {
            new Dog(),
            new Cat(),
            };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ShowInfo());
            }
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract string Name { get; }
        public abstract string Say();

        public string ShowInfo()
        {
            return $"{Name} говорит: {Say()}";
        }
    }

    class Dog : Animal
    {
        public override string Name => "Собака";

        public override string Say()
        {
            return "Гав!";
        }
    }

    class Cat : Animal
    {
        public override string Name => "Кошка";

        public override string Say()
        {
            return "Мяу!";
        }
    }
}
