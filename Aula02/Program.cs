using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool s = true; // Apenas criando uma variável do tipo booleano
            Console.WriteLine(s);

            /*------------------------------------------------------------------*/

            int[] vetor = new int[3];  // Criei um vetor com 3 casas, 3 index

            Console.WriteLine("Digite o 1º valor: ");
            vetor[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 2º valor: ");
            vetor[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o 3º valor: ");
            vetor[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Os valores digitados para o vetor foram: ");
            Console.WriteLine("{0}", vetor[0]);
            Console.WriteLine("{0}", vetor[1]);
            Console.WriteLine("{0}\n", vetor[2]);

            // Tem como criar o vetor já iniciando-o

            Console.WriteLine("Vetor já iniciado: ");

            int[] vetor1 = { 10, 14, 35 };
            Console.WriteLine("{0}", vetor1[0]);
            Console.WriteLine("{0}", vetor1[1]);
            Console.WriteLine("{0}", vetor1[2]);
        }
    }
}
