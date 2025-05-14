using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.OperadoresAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 5;

            //adicionar 5 ao valor atual do x

            x = x + 5;
   
            Console.WriteLine("O valor do x é: " + x);
            Console.ReadKey(); //Aguarda uma ação do usuário, exibindo o resultado.

            Console.WriteLine("-----------------------"); //Uma separação.

            //Outra forma de fazer a mesma coisa, usando o operador de atribuição +=
            //Para atribuir um valor a variável.

            x += 5;
            Console.WriteLine("O valor atual do x é: " + x);
            Console.ReadKey();

            x -= 7;
            Console.WriteLine("O valor atual do x é: " + x);
            Console.ReadKey();
            Console.WriteLine("------------------------");

            //O mesmo vale para os outros operadores de atribuição, como *=, /=, %=, &=, |=, ^=, <<=, >>=.

            //Podemos utilizar com Strings também:
            string apelido = "Bruno";
            apelido += " Top1 em FPS";
            Console.WriteLine("O apelido é: " + apelido);
            Console.ReadKey();
            Console.WriteLine("------------------------");
        }
    }
}
