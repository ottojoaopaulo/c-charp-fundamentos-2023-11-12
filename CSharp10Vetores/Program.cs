//int idade1 = 21;
//int idade2 = 14;
//int idade3 = 30;
//int idade4 = 5;
//int idade5 = 18;

//int[] idades = new int[5];

//idades[0] = 21;
//idades[1] = 14;
//idades[2] = 30;
//idades[3] = 5;
//idades[4] = 18;

//int soma = idades[0] + idades[1] + idades[2] + idades[3] + idades[4];

//Console.WriteLine("1 posição: " + idades[0]);
//Console.WriteLine("2 posição: " + idades[1]);
//Console.WriteLine("3 posição: " + idades[2]);
//Console.WriteLine("4 posição: " + idades[3]);
//Console.WriteLine("5 posição: " + idades[4]);

//Console.WriteLine("soma: " + soma);

//string[] nomes = new string[3];
//int[] quantidades = new int[3];
//double[] precoUnitarios= new double[3];


//Console.Write("Nome: ");
//nomes[0] = Console.ReadLine().Trim();
//Console.Write("Quantidade: ");
//quantidades[0] = Convert.ToInt32(Console.ReadLine());
//Console.Write("Preco Unitario: ");
//precoUnitarios[0] = Convert.ToDouble(Console.ReadLine());

//Console.Write("Nome: ");
//nomes[1] = Console.ReadLine().Trim();
//Console.Write("Quantidade: ");
//quantidades[1] = Convert.ToInt32(Console.ReadLine());
//Console.Write("Preco Unitario: ");
//precoUnitarios[1] = Convert.ToDouble(Console.ReadLine());

//Console.Write("Nome: ");
//nomes[2] = Console.ReadLine().Trim();
//Console.Write("Quantidade: ");
//quantidades[2] = Convert.ToInt32(Console.ReadLine());
//Console.Write("Preco Unitario: ");
//precoUnitarios[2] = Convert.ToDouble(Console.ReadLine());

//double[] precoProdutos= new double[3];

//precoProdutos[0] = quantidades[0] * precoUnitarios[0];
//precoProdutos[1] = quantidades[1] * precoUnitarios[1];
//precoProdutos[2] = quantidades[2] * precoUnitarios[2];

//double total = precoUnitarios[0] + precoProdutos[1] + precoProdutos[2];

//Console.WriteLine("\n\nProduto 1: " + precoProdutos[0]);
//Console.WriteLine("Produto 2: " + precoProdutos[1]);
//Console.WriteLine("Produto 3: " + precoProdutos[2]);
//Console.WriteLine("total: " + total);

string[] nome = new string[2];
int[] quantidadeHoras = new int[2]; 
double[] valorHora = new double[2];
double[] uniodonto = new double[2];
double[] descontoUnimed = new double[2];

Console.Write("Informe seu nome: ");
nome[0] = Console.ReadLine().Trim();
Console.Write("Informe o quantidade de horas trabalhadas: ");
quantidadeHoras[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor da hora: ");
valorHora[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe o valor da uniodonto: ");
uniodonto[0] = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe o desconto da Unimed:  ");
descontoUnimed[0] = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe seu nome: ");
nome[1] = Console.ReadLine().Trim();
Console.Write("Informe o quantidade de horas trabalhadas: ");
quantidadeHoras[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor da hora: ");
valorHora[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe o valor da uniodonto: ");
uniodonto[1] = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe o desconto da Unimed: ");
descontoUnimed[1] = Convert.ToDouble(Console.ReadLine());

double[] salarioBruto = new double[2];
double[] salarioLiquido = new double[2];
double[] totalDescontos = new double[2];

salarioBruto[0] = quantidadeHoras[0] * valorHora[0];
totalDescontos[0] = salarioBruto[0] - uniodonto[0] - descontoUnimed[0];

salarioBruto[1] = quantidadeHoras[1] * valorHora[1];
totalDescontos[1] = salarioBruto[1] - uniodonto[1] - descontoUnimed[1];




Console.WriteLine("\nsalario bruto: " + salarioBruto[0]);
Console.WriteLine("\nTotal com desconto: " + totalDescontos[0]);

Console.WriteLine("\nsalario bruto: " + salarioBruto[1]);
Console.WriteLine("\nTotal com desconto: " + totalDescontos[1]);


