using System;

public static class StringExtensions
{
    public static int ContarVocales(this string texto)
    {
        char[] vocales = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int contador = 0;

        foreach (char letra in texto)
        {
            if (Array.Exists(vocales, v => v == letra))
            {
                contador++;
            }
        }

        return contador;
    }
}

class Program
{
    static void Main()
    {
        string textoEjemplo = "Hola, este es un ejemplo de texto.";

        int cantidadVocales = textoEjemplo.ContarVocales();

        Console.WriteLine($"El texto contiene {cantidadVocales} vocales.");
    }
}
