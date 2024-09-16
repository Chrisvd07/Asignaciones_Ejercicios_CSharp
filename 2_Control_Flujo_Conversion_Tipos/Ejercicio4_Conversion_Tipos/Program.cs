Console.WriteLine("Conversion de entero");
Console.WriteLine("======================================");
Console.WriteLine("Ingrese el numero entero");
int num = Convert.ToInt32(Console.ReadLine());
decimal concvertir = Convert.ToDecimal(num);
Console.WriteLine($"{concvertir:F1}");
int dobleconversion = Convert.ToInt32(concvertir);
Console.WriteLine(dobleconversion);