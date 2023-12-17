using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp16ListasTiposPrimitivos
{
    internal class Exemplo00
    {
        public void Executar()
        {
            //tipos primitivos
            //string
            //int
            //double
            //char
            //boll

            //criar um vetor de 4 posicoes
            //int[] numeros = new numeros[4];
            //numeros[0]
            //numeros[1]
            //numeros[2]
            //numeros[3]
            //numeros[4]

            //criar uma lista de  numeros inteiros
            List<int> numeros = new List<int>();
            numeros.Add(5); //adicionando o numero 5 na primeira(0) posicao da lista
            numeros.Add(7); //adicionando o numero 7 na segunda(1) posicao da lista
            numeros.Add(9); //adicionando o numero 9 na terceira(2) posicao da lista
            numeros.Add(3); //adicionando o numero 3 na quarta(3) posicao da lista
            numeros.Add(10); //adicionando o numero 10 na quinta(4) posicao da lista

            //remover um numero da lista
            numeros.Remove(9); // Removido o numero 9 da posicao 2 => [5.7.3.10]

            //verificar se o numero 10 exist na lista
            bool numero10existeNaLista = numeros.Contains(10);
            Console.WriteLine("Numero contem numero 10: " + numero10existeNaLista);


            //alterar o numero 5 para numero 6
            numeros[0] = 6;

            Console.WriteLine("Numeros: ");
            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);
            Console.WriteLine(numeros[3]);

            int soma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
            Console.WriteLine("Some: " + soma);
        }
    }
}
