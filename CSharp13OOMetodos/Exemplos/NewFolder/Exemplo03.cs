using System;

public class Exemplo03
{
	public void Executar()
}
	

	{
		Paciente paciente1 = new Paciente();

		Console.Write("Nome: ");
		paciente1.Nome = Console.Readline();

		Console.Write("Idade: ");
		paciente1.Idade = Convert.ToInt32(Console.ReadLine());

		Console.Write("Altura: ");
		paciente1.Altura = Convert.ToDouble(Console.ReadLine());

		Console.Write("Peso: ");
		paciente1.Peso = Convert.ToDouble(Console.ReadLine());

		Console.Write("CPF: ");
		paciente1.Cpf = Console.ReadLine();

		double imcPaciente1 = paciente1.CalcularImc();
		string classificacaoPaciente1 = paciente1.ObterClassificacaoImc();
		string geracaoPaciente1 = paciente1.ObterClassificacaoGeracao();

        Console.writeLine("IMC do Paciente 1:" + imcPaciente1);
        Console.WriteLine("Classificacoa do paciente 1: " + classificacaoPaciente1);
		Console.WriteLine("Geracao do paciente 1: " + geracaoPaciente1);
	}
}
