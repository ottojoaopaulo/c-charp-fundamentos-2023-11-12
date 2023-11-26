
string caminho = "C:\\Users\\74639\\Desktop\\arquivo.csv";

if (File.Exists(caminho) == false)
{
    string cabecalho = "Nome;Idade\n";
    File.WriteAllText(caminho, cabecalho);
}
//else
//{
//    string registrosTexto = File.ReadAllText(caminho);
//    string[] registros = registrosTexto.Split("\n");
//}


Console.Write("Deseja cadastrar algum registro: [S/N]");
string desejaContinuar = Console.ReadLine().Trim().ToLower();

while(desejaContinuar == "S")
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine().Trim();

    Console.Write("Idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    string registro = nome + ";" + idade + "\n";
    File.AppendAllText(caminho, registro);

    Console.Write("deseja cadastrar mais algum registro S/N");
    desejaContinuar = Console.ReadLine().Trim().ToLower();

}


