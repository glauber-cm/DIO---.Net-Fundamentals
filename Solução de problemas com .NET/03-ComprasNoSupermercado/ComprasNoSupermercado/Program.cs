using System;
using System.Collections.Generic;
using System.Linq;

namespace ComprasNoSupermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
            List<string> listaCompra;
            List<string> listaSemDuplicidade;


            for (int i = 0; i < totalDeCasosDeTeste; i++)
            {
                listaCompra = new List<String>(Console.ReadLine().Split(' '));
                listaSemDuplicidade = listaCompra.Distinct().ToList();

                listaSemDuplicidade.Sort();

                foreach (string lista in listaSemDuplicidade)
                {
                    Console.Write($"{lista} ");
                }

                Console.WriteLine(" ");
            }
        }
    }
}
