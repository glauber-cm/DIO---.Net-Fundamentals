using System;
using System.Collections.Generic;
using System.Text;

namespace BankDIO.Classes
{
    public class MenuUsuario
    {
        public static string ObterOpcaoUsuario()
        {

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("INFORME A OPÇÃO DESEJADA: ");

            Console.WriteLine("1 - Inserir Nova Conta");
            Console.WriteLine("2 - Listar Contas");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
