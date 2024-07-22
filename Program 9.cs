using System.Xml;   

static void calculoAoQuadrado(ref int x)
{
    x = x * x;
}

static void Main()
{
    int a = 3;
    calculoAoQuadrado(ref a);
    Console.WriteLine($"O novo valor de a é {a}");
    Console.ReadKey();
}