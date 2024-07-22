static void Sqr(int x)
{
    x = x + x;
}

static void Main()
{
    int a = 3;
    Sqr(a);
    Console.WriteLine($"O valor de a é {a}");
    Console.ReadKey();
}