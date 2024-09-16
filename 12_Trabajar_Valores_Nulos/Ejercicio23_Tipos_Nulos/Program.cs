using System;

class Program
{
    static void Main()
    {
        int? numero = null;

        int resultado = numero ?? 10;

        Console.WriteLine($"El valor es: {resultado}");
    }
}