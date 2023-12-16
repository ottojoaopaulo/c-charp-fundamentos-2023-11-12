////Exemplo de utilizacao de while, pois nao sabe-se quantos pacientes serao atendidos
//string temPaciente = "s";
//while (temPaciente == "s")
//{
//    Console.Write("Nome: ");
//    string nome = Console.ReadLine();

//    Console.Write("Tem paciente pra atendendimento?");
//    temPaciente = Console.ReadLine().ToLower();
//}

//Deve apresentar a mensagem 5 vezes, podendo utilizar while ou for
//int indice = 0;
//while (indice < 5)
//{
//    Console.WriteLine("Hello Word");
//    indice = indice + 1;
//}
//Console.WriteLine("Fim while\n\n\n");


////For e utilizado para percorer de um determinado indice ate outro
////for (declaracao variavel; condicao repeticao; incrementar/decrementar)
//for (int indice2 = 0; indice2 < 5; indice2 = indice2 + 1)
//{
//    Console.WriteLine("Hello Word");
//}

////solicitar o nome e sobrenome de quatro pessoas
//for (int i = 0; i <= 3; i = i + 1)
//{
//    Console.Write("Nome: ");
//    string nome = Console.ReadLine();

//    Console.Write("Sobrenome: ");
//    string sobrenome = Console.ReadLine();

//    string nomeCompleto = nome +" " + sobrenome;
//    Console.WriteLine("Nome completo: " + nomeCompleto);
//}


//// Contagem de 0 a 10
//for (int i = 0; i <= 100; i = i + 1)
//{
//    Console.WriteLine(i);
//}

//// Contagem regressiva 10 9 8 7 6 5 4 3 2 1 0
//for (int i = 10; i >=0; i = i - 1)
//{
//    Console.WriteLine(i);
//}

//Apresentar um relogio
//nm:lk:ji
//00:00:00
//for (int n = 0; n <=2; n=n + 1)
//{
//    for( int m = 0; m <= 3; m = m + 1)
//    {
//        for(int l = 0; l <=5; l = l + 1)
//        {
//            for (int k = 0; k <= 9; k = k + 1)
//            {
//                for (int j = 0; j <=5; j = j + 1)
//                {
//                    for (int i = 0; i <= 9; i = i + 1)
//                    {
//                        Console.WriteLine(n + "" + m + ":" + l + "" + k + ":" + j + "" +i);
//                        Thread.Sleep(1000);
//                    } 
//                }
//            }
//        }
//    }
//}
//for (int hora = 0; hora <= 23; hora = hora + 1)
//{
//    for (int minuto = 0; minuto <= 59; minuto = minuto + 1)
//    {
//        for (int segundo = 0; segundo <= 59; segundo = segundo + 1)
//        {
//            Console.WriteLine(hora + ":" + minuto + ":" + segundo);
//            Thread.Sleep(1000);
//        }
//    }
//}

//obter o caminho da pasta do desktop do usuario logado
string caminhoDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string caminho = Path.Combine(caminhoDesktop, "Arquivos");

//verifica se a pasta nao existe
if(Directory.Exists(caminho) == false)
{
    //criar pasta arquivos no Desktop do usuario
    Directory.CreateDirectory(caminho);
}

for (int i = 0; i < 10; i ++)
{
    string NomeArquivo = "Arquivo " + i + ".txt";
    string caminhoArquivo = Path.Combine(caminho, NomeArquivo);
    File.WriteAllText(caminhoArquivo, "Ola mundo");
}
Console.WriteLine("Arquivos criados");




