
using ConsoleTables;

string caminho = "C:\\Users\\74639\\Desktop\\arquivo.csv";

if (File.Exists(caminho) == false)
{
    string cabecalho = "Nome;Idade\n";
    File.WriteAllText(caminho, cabecalho);
}
else
{
    string[] registros = File.ReadAllLines(caminho);

    int quantidadeRegistros = registros.Length;

    Console.WriteLine("Registros do arquivo .csv");

    ConsoleTable tabela = new ConsoleTable ("nome" , "idade");


    int indice = 0;

    while (indice < quantidadeRegistros)
    {
        if (indice == 0)
        {
            indice = indice + 1;
            continue;
        }


        string registro = registros[indice];

        string[] colunas = registro.Split(';');

        string nome = colunas[0];

        int idade = Convert.ToInt32(colunas[1]);
        tabela.AddRow(nome, idade);

        indice = indice + 1;
    }

    tabela.Write();
}


Console.Write("\nDeseja cadastrar algum registro: [S/N]");
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


