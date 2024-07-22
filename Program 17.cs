int n = 0;
Console.Write("Digite um número: ");
int.TryParse(Console.ReadLine(), out n);
int d = n * 2;
Console.WriteLine("O dobro de " + n + " é " + d);
Console.ReadKey();