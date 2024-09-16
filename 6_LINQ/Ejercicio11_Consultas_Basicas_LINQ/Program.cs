using System;
using System.Collections.Generic;
using System.Linq; 

class Program
{
    static void Main()
    {
       
        List<int> numeros = new List<int> { 1, 4, 5, 8, 11, 14, 17, 20, 25, 30 };

      
        var numerosImparesOrdenados = numeros.Where(numero => numero % 2 != 0).OrderByDescending(numero => numero).ToList();

        
        Console.WriteLine("Números impares ordenados en orden descendente:");
        foreach (int numero in numerosImparesOrdenados)
        {
            Console.WriteLine(numero);
        }
    }
}
