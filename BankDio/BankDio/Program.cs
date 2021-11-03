using BankDIO.Classes;
using BankDIO.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BankDIO
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = MenuUsuario.ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        InserirConta();
                        break;
                    case "2":
                        ListarContas();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = MenuUsuario.ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços!!");
            Console.ReadLine();
        }

        private static void Depositar()
        {
            Console.Write("Digite o número da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser Depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Sacar()
        {
            Console.Write("Digite o número da Conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do Saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             
            listContas[indiceConta].Sacar(valorSaque);
        }

        private static void Transferir()
        {
            Console.Write("Digite o número da conta de Origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o número da conta de Destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser Transferido: ");
            double valorTranferencia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            listContas[indiceContaOrigem].Transferir(valorTranferencia, listContas[indiceContaDestino]);
        }

        private static void InserirConta()
        {
            Console.WriteLine("**INSERIR NOVA CONTA**");
            Console.WriteLine();
            Console.Write("Digite 1 para Conta Física ou 2 para Jurídica: ");
            int tipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do Cliente: ");
            string valorNome = Console.ReadLine();

            Console.Write("Digite o Saldo Inicial: ");
            double valorSaldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Digite o crédito: ");
            double valorCredito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Conta novaConta = new Conta(tipoConta: (TipoConta)tipoConta,
                                        saldo: valorSaldo,
                                        credito: valorCredito,
                                        nome: valorNome);
            listContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("***LISTAR CONTAS***");

            if (listContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                Console.WriteLine("#{0} - ", i);
                Console.WriteLine(conta);
            }
        }

      
    }
}
