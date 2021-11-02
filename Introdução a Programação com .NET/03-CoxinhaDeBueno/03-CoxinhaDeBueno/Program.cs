using System;

namespace _03_CoxinhaDeBueno
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(" ");
            double a = double.Parse(line[0]);
            double b = double.Parse(line[1]);

            double result = a / b;

            Console.WriteLine(result.ToString("0.00"));

        }
    }
}
