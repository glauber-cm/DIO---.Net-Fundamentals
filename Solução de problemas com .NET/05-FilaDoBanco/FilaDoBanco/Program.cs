using System;
using System.Collections.Generic;

namespace FilaDoBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDeTestes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDeTestes; i++)
            {
                if (i <= 1000)
                {
                    int clientes = int.Parse(Console.ReadLine());

                    List<int> lista = new List<int>();
                    string[] linhaNumeroSMS = Console.ReadLine().Split(" ");

                    foreach (var item in linhaNumeroSMS)
                    {
                        if (lista.Count <= 1000)
                        {
                            lista.Add(int.Parse(item));
                        }
                    }

                    lista.Sort((a, b) => b.CompareTo(a));
                    int qtd = clientes;

                    for (int x = 0; x < lista.Count; x++)
                    {
                        if (int.Parse(linhaNumeroSMS[x]) != lista[x])
                        {
                            qtd--;
                        }
                    }
                    Console.WriteLine(qtd);
                }
            }
        }
    }
}
