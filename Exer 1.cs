
Console.Write("Digite um número Real: ");
float num;
float.TryParse(Console.ReadLine(), out num);

int n1 = (int)num;
int n2 = Convert.ToInt16(num);
Console.WriteLine("***************************");

Console.WriteLine($"Você digitou o valor {num:N1}"); // aqui eu escrevo o número digitado
Console.WriteLine($"A parte inteira do número é {n1:D}"); // aqui eu pego apenas a parte inteira do número.
Console.WriteLine($"O número arredonda é {n2}"); // aqui eu arredondo o número para maior ou menor


Console.ReadKey(); 