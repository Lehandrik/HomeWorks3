namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину ребра куба: ");
            double edgeLength = Convert.ToDouble(Console.ReadLine());
            CalcCube(edgeLength, out double volume, out double surfaceArea);

            // Вывод результатов
            Console.WriteLine($"Объем куба: {volume}");
            Console.WriteLine($"Площадь поверхности: {surfaceArea}");
            Console.ReadKey();  
        }

        static void CalcCube(double edge, out double volume, out double surfaceArea)
        {
            volume = edge * edge * edge; // V = a³
            surfaceArea = 6 * edge * edge; // S = 6a²
        }
    }
}
