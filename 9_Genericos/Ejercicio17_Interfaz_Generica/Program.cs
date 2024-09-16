using System;

public interface IContenedor<T>
{
    void Añadir(T objeto);
    T Obtener();
}

public class Caja<T> : IContenedor<T>
{
    private T contenido;

    public void Añadir(T objeto)
    {
        contenido = objeto;
    }

    public T Obtener()
    {
        return contenido;
    }
}

class Program
{
    static void Main()
    {
        IContenedor<int> cajaDeEntero = new Caja<int>();
        cajaDeEntero.Añadir(42);
        int valorEntero = cajaDeEntero.Obtener();
        Console.WriteLine($"Valor en la caja de enteros: {valorEntero}");

        IContenedor<string> cajaDeCadena = new Caja<string>();
        cajaDeCadena.Añadir("Hola, mundo!");
        string valorCadena = cajaDeCadena.Obtener();
        Console.WriteLine($"Valor en la caja de cadenas: {valorCadena}");

        IContenedor<Persona> cajaDePersona = new Caja<Persona>();
        Persona persona = new Persona { Nombre = "Juan", Edad = 30 };
        cajaDePersona.Añadir(persona);
        Persona valorPersona = cajaDePersona.Obtener();
        Console.WriteLine($"Nombre de la persona en la caja: {valorPersona.Nombre}, Edad: {valorPersona.Edad}");
    }
}

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
