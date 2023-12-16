using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Aluno Aluno1 = new Aluno();

            Console.Write("Digite a Nota 1 de logica: ");
            Aluno1.LogicaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota 2 de logica:: ");
            Aluno1.LogicaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota 3 de logica: ");
            Aluno1.LogicaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota 1 de Banco: ");
            Aluno1.BancoDadosNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota 2 de Banco: ");
            Aluno1.BancoDadosNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota 3 de Banco: ");
            Aluno1.BancoDadosNota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A media do aluno em Logica e de : " + Aluno1.CalcularMediaLogica());
            Console.WriteLine("A media do aluno em Banco de dados e de: " + Aluno1.CalcularMediaBancoDados());
            Console.WriteLine("O status do aluno em logica e de : " + Aluno1.ObterStatusLogica());
            Console.WriteLine("O status do aluno em Banco de dados e de: " + Aluno1.ObterStatusBancoDados());
            Console.WriteLine("O aluno foi: " + Aluno1.ObterStatus());
        }

    }
}
