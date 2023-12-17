using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp15ForcomVetor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string[] nomes = new string[2];
            double[] notas1 = new double[nomes.Length];
            double[] notas2 = new double[nomes.Length];
            double[] notas3 = new double[nomes.Length];

            for (int i = 0; i < nomes.Length; i = i + 1)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("nota 1: ");
                notas1[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("nota 2: ");
                notas2[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("nota 3: ");
                notas3[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < nomes.Length; i++)
            {
                double media = (notas1[i] + notas2[i] + notas3[i]) / 3;
                Console.WriteLine(nomes[i] + " media: " + media);
            }

        }
    }
}
