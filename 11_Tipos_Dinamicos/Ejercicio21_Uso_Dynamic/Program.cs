using System;
using System.Dynamic;

public class CustomObject
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        dynamic dynamicObject = new ExpandoObject();

        dynamicObject.IntegerProperty = 10;
        dynamicObject.StringProperty = "Hello, World!";
        dynamicObject.CustomObjectProperty = new CustomObject { Name = "John Doe", Age = 30 };

        Console.WriteLine(dynamicObject.IntegerProperty);
        Console.WriteLine(dynamicObject.StringProperty);
        dynamicObject.CustomObjectProperty.PrintInfo();
    }
}