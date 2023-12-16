//try
//{
//    int numero1 = Convert.ToInt32("10");
//    int numero2 = Convert.ToInt32("12p");

//    int some = numero1 + numero2;   

//    Console.WriteLine("Numero: "+ numero1);
//    Console.WriteLine("Numero: " + numero2);
//}
//catch(Exception e)
//{
//    Console.WriteLine("Aconteceu um erro na conversãodo numero");
//}

//Console.WriteLine("Programa encerrou corretamente");

Console.Write("\n\nDigite o nome: ");
string nome = Console.ReadLine();
int idade = 0;

try
{
    Console.Write("Digite sua idade: ");
    idade = Convert.ToInt32(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine("Idade não e um numero inteiro valido");
}

double peso = 0;

try
{
    Console.Write("Digite o seu peso: ");
    peso = Convert.ToDouble(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine("Peso não e um valor real valido");
}
//teste
Console.WriteLine("Nome: " + nome + "\nIdade: " + idade + "\npeso: " + peso);
