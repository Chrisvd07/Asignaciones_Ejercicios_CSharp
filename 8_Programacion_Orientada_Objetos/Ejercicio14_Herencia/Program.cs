using System;

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
        Animal miPerro = new Perro();
        Animal miGato = new Gato();

        miPerro.Hablar();
        miGato.Hablar();
    }
}
