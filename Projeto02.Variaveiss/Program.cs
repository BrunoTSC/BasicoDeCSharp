using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Variaveiss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Este é um comentário.     
            //Tipos para armazenar números inteiros. Passo o tipo primeiro, dps nome da variável e por último o que ela vai receber.
            sbyte medida = 177; // O que cada tipo suporta? este vai de -128 até 127;
            byte tamanho = 255; // De 0 a 255;
            short quantidade = 100; //-32.768 a 32.768;
            int idade = 34; //-2.147.483.648 a 2.147.483.648.

            //String e Char. String sequencia de caracteres e o Char apenas um caractere:

            string nome = "Bruno";
            char iniciaNome = 'B';

            //Tipo Booleado, sempra salva True ou False.

            bool estaLogado = true;
            bool possuiPermissao = false;

            //Tipos Flutuantes
            float altura = 1.75f; //float além do número, precisamos colocar um "f" no final. Floar é menos preciso e ocupa menos espaco;
            double peso = 65.5; //Double é mais preciso e ocupa mais espaco. Por padrão o C# ja inicia em double.

            //sempre vamos utilizar , string, int e double.


        }
    }
}
