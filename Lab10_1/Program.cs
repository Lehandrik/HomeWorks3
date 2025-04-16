namespace Lab10_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Базовый класс.
            Building house = new Building("ул. Гаккелевская, 23", 100.5, 2010);
            house.DisplayInfo();
            Console.WriteLine($"Налог: {house.CalculateTax()}");
            Console.WriteLine($"Возраст здания: {house.BuildingAge} лет");
            Console.WriteLine();

            // Производный класс.
            MultiBuilding skyscraper = new MultiBuilding("ул. Морозова, 20", 500, 2015, 25, true);
            skyscraper.DisplayInfo();
            Console.WriteLine($"Налог: {skyscraper.CalculateTax()}");
            Console.WriteLine($"Средняя площадь на этаж: {skyscraper.AreaPerFloor:F2} м2");
            Console.WriteLine();

            // Upcasting (приведение к базовому классу).
            Building building = skyscraper;
            building.DisplayInfo();
            Console.WriteLine($"Налог через базовый класс: {building.CalculateTax()}");
            Console.WriteLine();

            // Downcasting с проверкой типа.
            if (building is MultiBuilding)
            {
                MultiBuilding multiBuilding = (MultiBuilding)building;
                multiBuilding.DisplayInfo();
                Console.WriteLine($"Уникальное свойство: {multiBuilding.AreaPerFloor:F2} м2 на этаж");
            }

            Console.ReadKey();
        }
    }

    class Building // Базовый класс.
    {
        protected string address;
        protected double area;
        protected int yearBuilt;

        public Building(string address, double area, int yearBuilt)
        {
            this.address = address;
            this.area = area;
            this.yearBuilt = yearBuilt;
        }

        public int BuildingAge
        {
            get { return DateTime.Now.Year - yearBuilt; }
        }
        public virtual double CalculateTax()
        {
            return area * 1000;
        }

        // Вывод информации
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Адрес: {address}");
            Console.WriteLine($"Площадь: {area:F2} м2");
            Console.WriteLine($"Год постройки: {yearBuilt}");
        }
    }
    sealed class MultiBuilding : Building // Наследование
    {
        private int _floors;
        private bool _hasElevator;

        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
        }

        public double AreaPerFloor
        {
            get { return area / _floors; }
        }

        public override double CalculateTax()
        {
            double baseTax = base.CalculateTax(); // Базовый налог
            double floorsCoefficient = 1 + (_floors - 1) * 0.05; // Коэффициент за этажи
            double elevatorFee = _hasElevator ? 5000 : 0; // Доплата за лифт

            return baseTax * floorsCoefficient + elevatorFee;
        }

        // Вывод
        public override void DisplayInfo()
        {
            base.DisplayInfo(); // Вызов базовой версии
            Console.WriteLine($"Этажность: {_floors} этажей");
            Console.WriteLine($"Наличие лифта: {(_hasElevator ? "Да" : "Нет")}");
        }
    }
}
