namespace Lab11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFlyable[] flyingObjects = new IFlyable[]
        {
            new Bird(1000),
            new Airplane(10000, 150),
            new Bird(500),
            new Airplane(8000, 80)
        };

            foreach (var flyable in flyingObjects)
            {
                flyable.Fly();
            }
            Console.ReadKey();
        }

        public interface IFlyable
        {
            void Fly();
            int MaxAltitude { get; }
        }

        public class Bird : IFlyable
        {
            public int MaxAltitude { get; }

            public Bird(int maxAltitude)
            {
                MaxAltitude = maxAltitude;
            }

            public void Fly()
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
            }
        }

        public class Airplane : IFlyable
        {
            public int MaxAltitude { get; }
            public int CountPassengers { get; }

            public Airplane(int maxAltitude, int countPassengers)
            {
                MaxAltitude = maxAltitude;
                CountPassengers = countPassengers;
            }

            public void Fly()
            {
                Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
            }
        }
    }
}
