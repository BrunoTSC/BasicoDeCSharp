using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.OperadoresAritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Definicoes
            //Soma => +
            //Subtração => -
            //Multiplicaçãp => *
            //Divisão => /

            //Multiplicação primeiro. Caso queira executar em outra ordem, usar parenteses, ex:(5+5)

            //OPERADOR DE SOMA:
            int a = 5;
            int b = 4;

            int resultadoSoma = a + b;

           Console.WriteLine("O resultado da soma é: " + resultadoSoma);
           Console.ReadKey(); //Aguarda uma ação do usuário, exibindo o resultado.

            //OPERADOR DE SUBTRAÇÃO:

             a = 10;
             b = 5;

            int resultadoSubtracao = a - b;
            Console.WriteLine("O resultado da subtração é: " + resultadoSubtracao);
            Console.ReadKey();

            //Com parenteses alteramos a ordem da conta.

            int c = 20;
            int resultadoComParenteses = (a + b) * c;
            Console.WriteLine("O resultado com parênteses é: " + resultadoComParenteses);
            Console.ReadKey();
        }
    }
}
