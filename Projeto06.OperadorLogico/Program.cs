using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.OperadorLogico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Operadores Lógicos" são usados para combinar expressões booleanas. Eles retornam um valor booleano (true ou false).
            //Os operadores lógicos são: && (E), || (OU), ! (NÃO).
            //Definições:
            //&& (E): Retorna true se ambas as expressões forem verdadeiras.Deve atender todas as condições.
            //|| (OU): Retorna true se pelo menos uma das expressões for verdadeira. Não precisa atender todas as condições.
            //! (NÃO): Inverte o valor lógico da expressão. Se for true, retorna false e vice-versa.Nega a condição.
            //Exemplo:
            bool a = true;
            bool b = false;
            bool resultado;
            //Operador E (&&)
            resultado = a && b; //false
            Console.WriteLine("Resultado do operador E (&&): " + resultado);
            //Operador OU (||)
            resultado = a || b; //true
            Console.WriteLine(
                "Resultado do operador OU (||): " + resultado);
            //Operador NÃO (!)
            resultado = !a; //false

            //Operador E (&&) com mais de uma condição
            int idade = 18;
            string nome = "Bruno";
            //Verifica se a idade é maior ou igual a 18 e se o nome é "Bruno"
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            if (idade >= 18 && nome == "Bruno")
            {
                Console.WriteLine("Você é maior de idade e seu nome é Bruno.");
            }
            else
            {
                Console.WriteLine("Você não atende as condições.");
            }
            //Operador OU (||) com mais de uma condição
            Console.WriteLine(
                "--------------------------------------------------");
            Console.WriteLine(
                "Operador OU (||) com mais de uma condição");
            //Verifica se a idade é maior ou igual a 18 ou se o nome é "Bruno"
            if (idade >= 18 || nome == "Bruno")
            {
                Console.WriteLine("Você é maior de idade ou seu nome é Bruno.");
            }
            else
            {
                Console.WriteLine("Você não atende as condições.");
            }
            //Operador NÃO (!)
            Console.WriteLine(000
                "--------------------------------------------------");
            Console.WriteLine(
                "Operador NÃO (!)");
            //Verifica se a idade não é maior ou igual a 18
            if (!(idade >= 18))
            {
                Console.WriteLine("Você não é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é maior de idade.");
            }
        }
    }
}
