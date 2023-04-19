using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double n1;
            Double e;
            Double soma;
            Console.WriteLine("coloque o valor da aresta do quadrado:");
            n1 = Double.Parse(Console.ReadLine());
            e = n1;
            soma = n1 * e;
            Console.Write("o Valor da Área é: {0}", soma);
            Console.WriteLine();

        }
    }
}
