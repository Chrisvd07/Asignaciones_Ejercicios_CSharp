using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;

public delegate int Operaciones(int x, int y);
public class Calculadora
{
    public int sumar(int x, int y)
    {
        return x + y;
    }
    public int multiplicacion(int x, int y)
    {
        return x * y;
    }
    
}
class Programa
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();
        Operaciones nose = new Operaciones(calculadora.sumar);

        int resultado = nose(5 , 10);
        Console.WriteLine("el resultado de la suma de x + y es= " + resultado);

        nose = new Operaciones(calculadora.multiplicacion);
        int resultados = nose(10, 6);
        Console.WriteLine("el resultado de la multiplicacion es x*y = " + resultados);

    }
}