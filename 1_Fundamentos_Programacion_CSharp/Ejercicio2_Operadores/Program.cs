using System.ComponentModel.Design;

Console.WriteLine("Calculadora");
Console.WriteLine("=====================================");
Console.WriteLine("Inicio");
Console.WriteLine("1-Suma");
Console.WriteLine("2-Resta");
Console.WriteLine("3-Multiplicacion");
Console.WriteLine("4-Division");
Console.WriteLine("----------------------------------------------");


Console.WriteLine("Seleccione una");


int opcion = Convert.ToInt32(Console.ReadLine());

if (opcion == 1)
{
    double num = Convert.ToDouble(Console.ReadLine());
    double num2 = Convert.ToDouble(Console.ReadLine());
    double resultado = num + num2;
    Console.WriteLine("la suma de " + num + " + " + num2 + " es = " + resultado);
}
else if (opcion == 2)
{
    Console.WriteLine("Seleccione el primer numero");
    double num = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Seleccione el segundo numero");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double resultado = num - num2;
    Console.WriteLine("la resta de " + num + " - " + num2 + " es= " + resultado);
}
else if (opcion == 3)
{
    Console.WriteLine("Seleccione el primer numero");
    double num = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Seleccione el segundo numero");
    double num2 = Convert.ToDouble(Console.ReadLine());
    double resultado = num * num2;
    Console.WriteLine("la multiplicacion  de " + num + " * " + num2 + " es= " + resultado);

}
else if (opcion == 4)
{

    Console.WriteLine("Seleccione el primer numero");
    double num = Convert.ToDouble(Console.ReadLine());
   
    Console.WriteLine("Seleccione el segundo numero");
    double num2 = Convert.ToDouble(Console.ReadLine());
    if (num2 == 0)
    {
        Console.WriteLine("No se puede dividir entre  0");
       
       
    }
    else
    {
        double resultado = num / num2;
        Console.WriteLine("la division de " + num + "/" + num2 + " es= " + resultado);
    }
}
