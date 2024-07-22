
float valor,valor2;

//1° compra
Console.Write("Produto 1: ");
string produto = Console.ReadLine();

Console.Write("Valor: ");
float.TryParse(Console.ReadLine(), out valor);

//2° compra
Console.Write("Produto 2: ");
string produto2 = Console.ReadLine();

Console.Write("Valor: ");
float.TryParse(Console.ReadLine(), out valor2);

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Blue;
Console.Write(" Produto");
Console.Write($"{"Preço ",20}");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine($"\n {produto}{valor,21:C}");
Console.WriteLine($" {produto2}{valor2,21:C}");
Console.ResetColor();

Console.ReadKey();