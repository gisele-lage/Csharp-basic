using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Saída de dados
            Console.WriteLine("Olá, Mundo!");

            string nome = "Gisele";
            int idade;

            //Entrada de dados
            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            Double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Você se chama {0}, tem {1} anos e {2} de altura", nome, idade, altura);
        }
    }
}
