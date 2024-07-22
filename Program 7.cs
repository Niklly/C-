int x = 4;
int y = x++;

int a = 4;
int b = ++a;

Console.WriteLine($"O postfix de X->{x} valendo 4 = {y}->Y");
Console.WriteLine($"O prefix de A->{a} valendo 2 = {b}->B");
Console.ReadKey();