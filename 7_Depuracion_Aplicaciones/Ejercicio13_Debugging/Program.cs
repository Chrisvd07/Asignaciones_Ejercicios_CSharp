using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int cantidadNumeros = 10;

        Console.WriteLine("Números aleatorios generados:");

        for (int i = 0; i < cantidadNumeros; i++)
        {
            // Error intencional: El rango debería ser (1, 101) en lugar de (1, 100)
            int numeroAleatorio = random.Next(1, 100); // Error: no incluye el 100
            Console.WriteLine(numeroAleatorio);
        }
    }
}
