Random ger = new(); 

Console.WriteLine("SORTEADOR NÚMERO");
Console.WriteLine("_____________________");

int inicio, final;

Console.Write("Inicio: ");
int.TryParse(Console.ReadLine(), out inicio);
Console.Write("\nFinal: ");
int.TryParse(Console.ReadLine(), out final);

int num = ger.Next(inicio, final+1);

Console.Write("Sorteando.....");
Thread.Sleep(2000);
Console.WriteLine("\n_____________________");
Console.Write($"\nEntre {inicio} e {final}. O número sorteado foi {num}.");
Console.ReadKey();