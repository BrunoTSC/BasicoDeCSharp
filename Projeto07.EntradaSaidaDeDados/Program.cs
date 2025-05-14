using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto07.EntradaSaidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Entrada e Saída de Dados" é o processo de ler dados do usuário e exibir resultados na tela.
            //A classe Console é usada para interagir com o console.
            
            //saida de dados:
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine(); //Ler a linha digitada pelo usuário.

            Console.WriteLine("-------------");
            Console.WriteLine("O nome digitado foi: " + nome);
            Console.ReadLine();

            //entrada de dados:
            Console.WriteLine("-------------");
            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());//converte o que o usuário escreve de texto para número. PARSE = converter.

            Console.WriteLine("-------------");
            Console.WriteLine("Olá " + nome + " você tem " + idade + " anos de idade.");

            //Interpolação de strings:
            Console.WriteLine($"Olá {nome} você tem {idade} anos de idade.");
            Console.ReadLine();







        }
    }
}
