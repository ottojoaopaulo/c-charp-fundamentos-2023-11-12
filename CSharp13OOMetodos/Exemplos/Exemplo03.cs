using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exemplo03
    {
        public void Executar()
        {
            Paciente paciente1 = new Paciente();
      
            Console.Write("Nome: ");
            paciente1.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            paciente1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura: ");
            paciente1.Altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Peso: ");
            paciente1.Peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("CPF: ");
            paciente1.Cpf = Console.ReadLine();

            double imcPaciente1 = paciente1.CalcularImc();
            Console.WriteLine("O IMC do paciente e: " + imcPaciente1);

            string classificacaoPaciente1 = paciente1.ObterClassificacaoImc();
            Console.WriteLine("Classificacao do paciente e: " + classificacaoPaciente1);

            string geracaiPaciente1 = paciente1.ObterClassificacaoGeracao();
            Console.WriteLine("Geracao do paciente 1: " + geracaiPaciente1);
        }
    }
}
