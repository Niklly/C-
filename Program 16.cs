Console.Write("Escreva um nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Muito prazer em te conhecer, " + nome + "!!");
Console.ReadLine();

Console.Write("Qual a sua idade, " + nome + "?");
int idade = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Uauu! Então você possui " + idade + " anos");
Console.ReadKey();