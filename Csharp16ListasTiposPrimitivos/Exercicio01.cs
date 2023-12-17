using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp16ListasTiposPrimitivos
{
    internal class Exercicio01
    {
        public void Executar()
        {
            List<string> nome = new List<string>();
            List<double> nota1 = new List<double>();
            List<double> nota2 = new List<double>();
            List<double> nota3 = new List<double>();

            Console.WriteLine("1 - Cadastrar aluno: ");
            Console.WriteLine("2 - Cadastrar nota: ");
            Console.WriteLine("3 - Editar nota: ");
            Console.WriteLine("4 - apagar nota: ");
            Console.WriteLine("5 - Listar notas");
            Console.WriteLine("10 - sair");
            Console.WriteLine("Digite a opçao desejada: ");
            int menu = Convert.ToInt32(Console.ReadLine());

            while (menu != 10)
            {
                Console.Clear();

                if (menu == 1)
                {
                    Console.Write("Digite o nome do Aluno: ");
                    string nome = Console.ReadLine().Trim();
                    nomes.Add(nome);

                    Console.Write("Digite a nota 1 do aluno: ");
                    double nota1 = Convert.ToDouble(Console.ReadLine());
                    notas1.Add(nota1);

                    Console.Write("Digite a nota 1 do aluno: ");
                    double nota2 = Convert.ToDouble(Console.ReadLine());
                    notas2.Add(nota2);

                    Console.Write("Digite a nota 1 do aluno: ");
                    double nota3 = Convert.ToDouble(Console.ReadLine());
                    notas3.Add(nota3);

                }
                else if (menu == 2)
                {
                    Console.Write("Digite o nome do aluno que deseja editar: ");
                    string nomearaEditar = Console.ReadLine().Trim();

                    if(nomes.Contains(nomearaEditar))
                    {
                        Console.Write("Digite o novo nome")
                    }
                }
                
                else if (menu == 3)
                {
                    Console.Write("Digite a nota que deseja editar: ");
                    string nota = Console.ReadLine();

                    int indiceNomeParaAlterar = nota.IndexOf(nota);
                }
                else if (menu == 4)
                {
                    Console.Write("Digite o nome do produto para apagar: ");
                    string nome = Console.ReadLine().Trim();
                    
                    if (nomes.Contais(nome))
                    {
                        int indiceDoAluno = nomes.IndefOff(nome);

                        nomes.RemoveAt(indiceDoAluno);
                        notas1.RemoveAt(indiceDoAluno);
                        notas2.RemoveAt(indiceDoAluno);
                        notas3.RemoveAt(indiceDoAluno);
                    }
                }
                else if (menu == 5)
                {
                    Console.WriteLine("Notas Cadastradas:");
                    for (int i = 0; i < nomes.Count; i++)
                    {
                        Console.WriteLine(nomes [i] + );
                    }
                }
               
                Console.Clear();   
                
                Console.WriteLine("1 - Cadastrar aluno: ");
                Console.WriteLine("2 - Cadastrar nota: ");
                Console.WriteLine("3 - Editar nota: ");
                Console.WriteLine("4 - apagar nota: ");
                Console.WriteLine("10 - sair");
                Console.WriteLine("Digite a opçao desejada: ");
             menu = Convert.ToInt32(Console.ReadLine());


            }


        }
    }
}
