int idade = 0;
bool idadeValida = false;

while (idadeValida == false)
{
    try
    {
        Console.Write("Digite a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());
        if (idade < 0)
        {
            Console.Write("idade náo pode ser negativa");
            continue;
        }
        if (idade > 120)
        { 
            Console.WriteLine("idade maxima de 120");
            continue;
        }


        idadeValida = true;
    }
    catch (Exception e)
    {
        Console.WriteLine("Idade nao e um numero valido");
    }
}

double peso = 0;
bool pesoValido = false;

while (pesoValido == false)
{
    try
    {
        Console.WriteLine("Digite o peso");
        peso = Convert.ToInt32(Console.ReadLine().ToUpper().Replace("KG", "");
        if (peso <= 0.99)
        {
            Console.Write("peso minimo e de 1kG");
            continue;
        }
        if (peso > 400)
        {
            Console.WriteLine("peso maximo de 400");
            continue;
        }

        pesoValido = true;
    }
    catch (Exception e)
    {
        Console.WriteLine("peso maximo e de 400kG");
    }
}

