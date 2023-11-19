string texto = " ola mundo bem vindo ao C#" ;
Console.WriteLine("texto original: " + texto);

int quantidadeCaracteres = texto.Length;
Console.WriteLine("quantidades de caracteres: " + quantidadeCaracteres);


texto = texto.TrimStart();
texto = texto.TrimEnd();

string textoRemovidoEspacos = texto.Replace(" ", "");
Console.WriteLine("textoRemovidoEspacos: " + quantidadeCaracteres);


string textoCaixaAlta = texto.ToUpper();

string textoCaixaBaixa = texto.ToLower();

Console.WriteLine("texto em maiusculo :" + textoCaixaAlta + "\nTexto em minusculo: " + textoCaixaBaixa);

if (texto.StartsWith("ola mundo"))
{
    Console.WriteLine("comeca com ola mundo");
}
else
{
    Console.WriteLine("nao comeca com ola mundo");
}

if (texto.EndsWith("."))
{
    Console.WriteLine("Texto termina com ponto final");
}
else
{
    Console.WriteLine("Texto nao termina com ponto final");
}

if (texto.Contains("mundo"))
{
    Console.WriteLine("Contem a palavra mundo");
}
else
{
    Console.WriteLine("Nao contem a palavra mundo");
}

texto = texto.Replace("C#", "Csharp");
Console.WriteLine("texto substituido C# por Csharp: " + texto);


string nomeCompleto = "Gustavo da Silva";

int indiceEspaco = nomeCompleto.IndexOf(" ");

string nome = nomeCompleto.Substring(0, indiceEspaco);
Console.WriteLine("\n\nNome: " + nome);

int indiceEspacoFim = nomeCompleto.LastIndexOf(" ");
Console.WriteLine("indice do ultimo espaco: " + indiceEspacoFim);

int quantidadeCaracteresUltimoNome = nomeCompleto.Length - indiceEspacoFim;
string ultimoNome = nomeCompleto.Substring(indiceEspacoFim, quantidadeCaracteresUltimoNome);
Console.WriteLine("ultimo nome: " + ultimoNome);