using System;
using System.Text.RegularExpressions;

namespace ValidadorSenhaComRequisitos
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;

            while (!string.IsNullOrEmpty(senha = Console.ReadLine()))
            {
                var contLetraMaiuscula = Regex.Matches(senha, "[A-Z]").Count;
                var contLetraMinuscula = Regex.Matches(senha, "[a-z]").Count;
                var contNumero = Regex.Matches(senha, "[0-9]").Count;

                if (senha.Length >= 6
                  && senha.Length <= 32
                  && contLetraMaiuscula > 0
                  && contLetraMinuscula > 0
                  && contNumero > 0
                  && (contLetraMaiuscula + contLetraMinuscula + contNumero == senha.Length))
                {
                    Console.WriteLine("Senha valida.");
                }
                else
                {
                    Console.WriteLine("Senha invalida.");
                }
            }

        }
    }
}
