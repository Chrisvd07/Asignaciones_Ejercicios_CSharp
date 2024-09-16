using System;
using System.Collections.Generic;

class Animal
{
    public virtual void Hablar()
    {
        Console.WriteLine("El animal hace un sonido.");
    }
}

class Perro : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("El perro dice: ¡Guau!");
    }
}

class Gato : Animal
{
    public override void Hablar()
    {
        Console.WriteLine("El gato dice: ¡Miau!");
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animales = new List<Animal>
        {
            new Perro(),
            new Gato(),
            new Perro(),
            new Gato()
        };

        foreach (Animal animal in animales)
        {
            animal.Hablar();
        }
    }
}
