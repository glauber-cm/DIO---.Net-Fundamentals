using System;

namespace _03_QuantaMandioca
{
    class Program
    {
        static void Main(string[] args)
        {
            double chico = 300 * Int32.Parse(Console.ReadLine());
            double bento = 1500 * Int32.Parse(Console.ReadLine());
            double bernardo = 600 * Int32.Parse(Console.ReadLine());
            double marina = 1000 * Int32.Parse(Console.ReadLine());
            double iara = 150 * Int32.Parse(Console.ReadLine());
            double marlene = 225;
            double total = 0; // Digite aqui o calculo total
            total = chico + bento + bernardo + marina + iara + marlene;
            Console.WriteLine(total);
        }
    }
}
