using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        int c = int.Parse(Console.ReadLine());

        int mdc = MDC(MDC(a, b), c);
        int mmc = MMC(MMC(a, b), c);

        Console.WriteLine($"\nMDC entre {a}, {b} e {c} é: {mdc}");
        Console.WriteLine($"MMC entre {a}, {b} e {c} é: {mmc}");
    }

    // Função para calcular o MDC entre dois números
    static int MDC(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }

    // Função para calcular o MMC entre dois números
    static int MMC(int x, int y)
    {
        return (x * y) / MDC(x, y);
    }
}