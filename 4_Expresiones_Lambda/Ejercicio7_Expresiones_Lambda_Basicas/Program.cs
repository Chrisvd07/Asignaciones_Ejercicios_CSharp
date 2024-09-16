using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();

        for (int i = 1; i <= 100; i++)
        {
            numeros.Add(i);
        }
        var resultado = numeros.Where(numero => numero % 2 == 0);
        foreach (int numero in resultado)
        {

            Console.WriteLine(numero.ToString());
        }
    }
}