/*for (int x = 10; x < 15; x++) //init(contador) ; condição ; incremento(atualiza o contador)
{
    Console.WriteLine($"Valor de x: {x}"); //código 
    Console.ReadKey();
}
*/

for (int i = 0; i < 10; i++)
{
    if (i == 5) continue; //continue é parecido com o break - mas, ele ignora a iteração atual do loop e continua com a próxima iteração
    Console.WriteLine(i);
}
Console.ReadKey();

/// nesse codigo acima não será impresso o número 5 