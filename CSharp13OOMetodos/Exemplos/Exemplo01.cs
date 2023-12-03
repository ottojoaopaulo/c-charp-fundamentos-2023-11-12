using System;

public class Exemplo01
{
	public Exemplo01()
	{
        Cachorro doguinho = new Cachorro();
        doguinho.Nome = "Tigao";
        doguinho.Idade = 3;
        doguinho.Raca = "Dobermann";
        doguinho.Sexo = "Masculino";
        //alterando a idade do cachorro
        doguinho.Idade = 4;

        Cachorro dogao = new Cachorro();
        dogao.Idade = 10;
        dogao.Raca = "Vira Lata";
        dogao.Nome = "Dogao";
        dogao.Sexo = "Feminino";

        Console.WriteLine("Nome: " + doguinho.Nome);
        Console.WriteLine("Idade: " + doguinho.Idade);
        Console.WriteLine("Raca: " + doguinho.Raca);
        Console.WriteLine("Sexo: " + doguinho.Sexo);

        Console.WriteLine("Nome: " + dogao.Nome);
        Console.WriteLine("Idade: " + dogao.Idade);
        Console.WriteLine("Raca: " + dogao.Raca);
        Console.WriteLine("Sexo: " + dogao.Sexo);

        int soma = doguinho.Idade + dogao.Idade;
        double media = soma / 2.0;
        Console.WriteLine("\n\nA media das idades e: " + media);
    }
}
