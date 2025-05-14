using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05.OperadorRelacional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Relação" estamos falando de comparação. Podemos comparar qualquer tipo de dados, números , strings, bytes, etc.
            //"Operadores Relacionais" são usados para comparar dois valores e retornar um valor booleano (true ou false).
            //Os operadores relacionais são: ==, !=, >, <, >=, <=.
            int a = 5;
            int b = 5;

            bool resultado = (a == b);//O operador == verifica se os valores são iguais. É verdade que "a" é igual a "b"?

            Console.WriteLine("A é igual a B? " + resultado);
            Console.ReadKey();
            
            resultado = (a != b);//Operador diferente de !=. O operador != verifica se os valores são diferentes. É verdade que "a" é diferente de "b"?
            Console.WriteLine("A é diferente de B? " + resultado);
            Console.ReadKey();

            a = 7;
            b = 4;

            resultado = (a > b);//Operador maior que >. O operador > verifica se o valor da esquerda é maior que o valor da direita. É verdade que "a" é maior que "b"?
            Console.WriteLine("A é maior que B? " + resultado);
            Console.ReadKey();

            a = 6;
            b = 6;

            resultado = (a <= b);//Operador menor ou igual <=. O operador <= verifica se o valor da esquerda é menor ou igual o valor da direita. É verdade que "a" é menor ou igual a "b"?
            Console.WriteLine("A é menor ou igual a B? " + resultado);
            Console.ReadKey();

        }
    }
}
