using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exemplo01
    {
        //Metodo, tem como objetivo executar determinada rotina
        public void Executar()
        {
            Cachorro doguinho = new Cachorro();
            //definir as propriedades do cachorro
            doguinho.Nome = "Tigao";
            doguinho.Idade = 3;
            doguinho.Raca = "Doberman";
            doguinho.Sexo = "Masculino";
            //alterando a idade do doguinho, pq ele fez aniversario
            doguinho.Idade = 4;

            //Instanciar um objeto da classe cachorro, o nome do nosso objeto sera dogao
            Cachorro dogao = new Cachorro();

            dogao.Idade = 10;
            dogao.Raca = "ViraLata";
            dogao.Nome = "dogao";
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
}
