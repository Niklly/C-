int num = 1;
Console.WriteLine("Digite o número para decompor: ");
int.TryParse(Console.ReadLine(), out num);

while (num != 0)
{
    Console.WriteLine(num);
    num = num - 1;
}
Console.ReadKey();