using System;

public class Aluno
{
	public logicaNota1()
	{ }
		public double nota1 { get; set; }
		public double nota2 { get; set; }
		public double nota3 { get; set; }
		public double nota4 { get; set; }
	}
	
	public double CalculoMedia()
	{
	double media = (nota1 + nota2 + nota3 + nota4) / 4;
	return media;
	}
}
