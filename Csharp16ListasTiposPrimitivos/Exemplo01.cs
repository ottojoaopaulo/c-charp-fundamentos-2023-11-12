using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp16ListasTiposPrimitivos
{
    internal class Exemplo01
    {
        public void Executar()
        {
            List<string> produtos = new List<string>();

            //CRUD
            Console.WriteLine("1-Cadastrar");
            Console.WriteLine("2-Alterar");
            Console.WriteLine("3-Listar");
            Console.WriteLine("4-Apagar");
            Console.WriteLine("5-Verificar Produto");
            Console.WriteLine("10-sair");
            Console.WriteLine("Digite o menu desejado: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            while(menu != 10)
            {
                Console.Clear();

                if (menu == 1)
                {
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();
                    produtos.Add(nome);
                }
                else if (menu == 3)
                {
                    Console.WriteLine("Produtos Cadastrados:");
                    for (int i = 0; i < produtos.Count; i++)
                    {
                        Console.WriteLine("Produtos Cadastrados: ");
                        Console.WriteLine(produtos[i]);
                    }
                }

                else if (menu == 4)
                {
                    Console.WriteLine("Digite o produto que deseja apagar: ");
                    string nome = Console.ReadLine();
                    produtos.Remove(nome);
                }

                Console.WriteLine("1-Cadastrar");
                Console.WriteLine("2-Alterar");
                Console.WriteLine("3-Listar");
                Console.WriteLine("4-Apagar");
                Console.WriteLine("5-Verificar Produto");
                Console.WriteLine("10-sair");
                Console.WriteLine("Digite o menu desejado: ");
                menu = Convert.ToInt32(Console.ReadLine());

            }
        }

    }
}
