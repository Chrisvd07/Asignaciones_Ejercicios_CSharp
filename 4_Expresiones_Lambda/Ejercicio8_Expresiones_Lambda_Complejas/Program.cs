using System;
using System.Collections.Generic;
using System.Linq; 

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

class Program
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante("Ana", 17),
            new Estudiante("Carlos", 19),
            new Estudiante("Lucía", 20),
            new Estudiante("Pedro", 16),
            new Estudiante("Sofía", 25),
            new Estudiante("Miguel", 18)
        };

        List<Estudiante> mayoresDeEdad = mayores(estudiantes);

        foreach (Estudiante estudiante in mayoresDeEdad)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}");
        }
    }

    static List<Estudiante> mayores(List<Estudiante> estudiantes)
    {
        var resultado = estudiantes.Where(estudiante => estudiante.Edad > 18).ToList();
        return resultado;
    }
}
