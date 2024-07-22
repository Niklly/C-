using System.ComponentModel;

Console.Write("Digite o ano que você nasceu: ");

int data;
int.TryParse(Console.ReadLine(), out data); // em c# tudo é string e caso precisamos trabalhar com  números precisamos transformar!!
int ano = DateTime.Now.Year;
int tempo = ano - data;


//mostrando resultados
Console.WriteLine("*********************************");
Console.WriteLine($"Estamos no ano de {ano}.");
Console.WriteLine($"Se você nasceu {data}, vai ter {tempo} anos.");
Console.ReadKey();