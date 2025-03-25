namespace Task7_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 5;
            int b1 = 6;
            int result1 = Multiply(a1, b1);
            Console.WriteLine(result1);

            double a2 = 5.2;
            double b2 = 4.3;
            double result2 = Multiply(a2, b2);
            Console.WriteLine(result2);

            Console.ReadKey();
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
