//int indice = 0;
//int soma = 0;
//while (indice < 5)
//{
//    Console.Write("Digite um numero: ");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    soma = soma + numero;

//    indice = indice + 1;
//}

//Console.WriteLine("soma: " + soma);

using System.ComponentModel.Design;

int indice = 0;
int quantidadePessoasIdosas = 0;
int quantidadePessoasAdultas = 0;
int somaIdades = 0;
while (indice <= 2)
{
    Console.Write("nome: ");
    String nome = Console.ReadLine().Trim();

    Console.Write("Idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    somaIdades = somaIdades + idade;

    if((idade >= 18) && (idade < 60))
    {
        quantidadePessoasAdultas = quantidadePessoasAdultas + 1;
    }
    else if (idade >= 60)
    {
        quantidadePessoasIdosas = quantidadePessoasIdosas +1;
    }

    indice = indice + 1;
}
double mediaIdades = somaIdades / 3.0;

Console.WriteLine(
    "Media das idades: " + mediaIdades +
    "\nQuantidade de Pessoas Adultas: " + quantidadePessoasAdultas +
    "\nQuantidade de pessoas Idosas: " + quantidadePessoasIdosas);