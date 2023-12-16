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
            Aluno1.Logica = new Materia();
            Aluno1.BancoDados = new Materia();

            Console.Write("Digite a Nota 1 de logica: ");
            Aluno1.Logica.Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota 2 de logica:: ");
            Aluno1.Logica.Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota 3 de logica: ");
            Aluno1.Logica.Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota 1 de Banco: ");
            Aluno1.BancoDados.Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota 2 de Banco: ");
            Aluno1.BancoDados.Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Nota 3 de Banco: ");
            Aluno1.BancoDados.Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("A media do aluno em Logica e de : " + Aluno1.Logica.CalcularMedia());
            Console.WriteLine("A media do aluno em Banco de dados e de: " + Aluno1.BancoDados.CalcularMedia());
            Console.WriteLine("O status do aluno em logica e de : " + Aluno1.Logica.ObterStatus());
            Console.WriteLine("O status do aluno em Banco de dados e de: " + Aluno1.BancoDados.ObterStatus());
            Console.WriteLine("O aluno foi: " + Aluno1.ObterStatus());
        }

    }
}
