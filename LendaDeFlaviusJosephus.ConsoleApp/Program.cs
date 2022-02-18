using System;

namespace LendaDeFlaviusJosephus.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de pessoas e o tamanho do salto (separados por espaço, como o exemplo: 5 2: ");
            var pessoasTamanhoDoSalto = (Console.ReadLine());
            char[] listaPessoasTamanhoDoSalto = pessoasTamanhoDoSalto.ToCharArray();

            var quantidadeDePessoas = listaPessoasTamanhoDoSalto[0];
            var tamanhoDoSalto = listaPessoasTamanhoDoSalto[2];

            for (int i = 0; i < listaPessoasTamanhoDoSalto.Length; i++)
            {
                if ()
                {

                }
            }

        }
    }
}
