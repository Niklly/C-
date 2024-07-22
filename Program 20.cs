float sal = 0;
Console.Write("Qual é o seu salário: ");
float.TryParse(Console.ReadLine(), out sal);
Console.WriteLine($"O seu salario é {sal:C}"); 'monetario' 
Console.WriteLine($"O seu salario é {sal:N}");  'numero real sem o R$'
Console.WriteLine($"O seu salario é {sal:E}");  'cientifico'
Console.WriteLine($"O seu salario é {sal:X}");      'hexadecimal'
Console.WriteLine($"O seu salário é {sal:D}");   'Decimal'
Console.ReadKey();
