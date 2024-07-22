int num = 0;
Console.Write("Digite um numero: ");
int.TryParse(Console.ReadLine(), out num);


switch (num)
{
    case 1:
        Console.WriteLine("one");
        break;
    
    case 2:
        Console.WriteLine("two");
        break;
    case 3:
        Console.WriteLine("three");
        break;
    default:
        Console.WriteLine("Caso padrão.");
        break;

}

Console.ReadKey();