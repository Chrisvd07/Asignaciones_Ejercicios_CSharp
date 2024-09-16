using System;

class Caja<T>
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
        Caja<int> cajaDeEntero = new Caja<int>();
        cajaDeEntero.Añadir(42);
        int valorEntero = cajaDeEntero.Obtener();
        Console.WriteLine($"Valor en la caja de enteros: {valorEntero}");

        Caja<string> cajaDeCadena = new Caja<string>();
        cajaDeCadena.Añadir("Hola, mundo!");
        string valorCadena = cajaDeCadena.Obtener();
        Console.WriteLine($"Valor en la caja de cadenas: {valorCadena}");

        Caja<Persona> cajaDePersona = new Caja<Persona>();
        Persona persona = new Persona { Nombre = "Juan", Edad = 30 };
        cajaDePersona.Añadir(persona);
        Persona valorPersona = cajaDePersona.Obtener();
        Console.WriteLine($"Nombre de la persona en la caja: {valorPersona.Nombre}, Edad: {valorPersona.Edad}");
    }
}

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
