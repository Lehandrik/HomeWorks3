namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double result1 = Square(a1, b1, c1);

            Console.WriteLine("Введите длины сторон второго треугольника: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double result2 = Square(a2, b2, c2);

            if (result1 > result2)
                Console.WriteLine("Площадь первого треугольника больше");
            else if (result1 < result2)
                Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("Площади треугольников равны");
            Console.ReadKey();  
        }
        static double Square(double a, double b, double c)
        {
            double p = (a + b + c) / 2; // Полупериметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
