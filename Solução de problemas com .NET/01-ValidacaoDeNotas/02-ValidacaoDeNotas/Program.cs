using System;

namespace _02_ValidacaoDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare suas variáveis corretamente
            int opcao = 1;
            double nota1 = 0;
            double nota2 = 0;
            bool validador = false;
            string entrada;
            double media = 0;

            while (opcao != 2)
            {
                while (validador == false)
                {
                    entrada = Console.ReadLine();
                    if (double.Parse(entrada) >= 0 && double.Parse(entrada) <= 10)
                    {
                        nota1 = double.Parse(entrada);
                        validador = true;
                    }
                    else
                        Console.WriteLine("nota invalida");
                }

                validador = false;

                while (validador == false)
                {
                    entrada = Console.ReadLine();
                    if (double.Parse(entrada) >= 0 && double.Parse(entrada) <= 10)
                    {
                        nota2 = double.Parse(entrada);
                        validador = true;
                    }
                    else
                        Console.WriteLine("nota invalida");

                }

                media = (nota1 + nota2) / 2;
                Console.WriteLine($"media = {media.ToString("N2")}");

                validador = false;

                while (validador == false)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    entrada = Console.ReadLine();
                    opcao = int.Parse(entrada);
                    if (opcao == 1 || opcao == 2)
                    {
                        validador = true;
                    }
                }

                validador = false;
            }
        }
    }
}




