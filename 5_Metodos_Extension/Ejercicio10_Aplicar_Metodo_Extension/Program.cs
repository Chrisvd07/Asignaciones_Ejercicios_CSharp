﻿using System;

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
        Console.WriteLine("Introduce una oración:");
        string textoUsuario = Console.ReadLine();

        int cantidadVocales = textoUsuario.ContarVocales();

        Console.WriteLine($"La oración contiene {cantidadVocales} vocales.");
    }
}
