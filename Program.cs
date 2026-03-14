        Console.Write("Digite um valor em real para o programa efetuar as converções");
                double real = double.Parse(Console.ReadLine());
double dólar = real / 5.17;
double euro = real / 6.14;
        double p                     eso_argentino = real * 0.05;
Console.WriteLine($"Valor em dólar: {dólar:F2}");
Console.WriteLine($"Valor em euro: {euro:F2}");

Console.WriteLine($"Valor em peso argentino: {peso_argentino:F2}");