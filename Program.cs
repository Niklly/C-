int n = 0;
Console.Write("Escreva uma idade: ");
int.TryParse(Console.ReadLine(), out n);
Console.ReadKey();

if (n > 14)
{
    if (n > 18)
    {
        Console.WriteLine("Adulto");
    }

    else
    {
        Console.WriteLine("Adolescente");
    }
}

else
{
    if (n > 0)
    {
        Console.WriteLine("Criança");
    }
    else
    {
        Console.WriteLine("Algo está errado");
    }
}
Console.ReadKey();