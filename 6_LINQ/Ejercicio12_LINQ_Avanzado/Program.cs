using System;
using System.Collections.Generic;
using System.Linq;

class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Categoria { get; set; }

    public Producto(string nombre, decimal precio, string categoria)
    {
        Nombre = nombre;
        Precio = precio;
        Categoria = categoria;
    }
}

class Program
{
    static void Main()
    {
        List<Producto> productos = new List<Producto>
        {
            new Producto("Laptop", 1000m, "Electrónica"),
            new Producto("Celular", 600m, "Electrónica"),
            new Producto("Cámara", 300m, "Fotografía"),
            new Producto("Lente", 150m, "Fotografía"),
            new Producto("Refrigerador", 800m, "Electrodomésticos"),
            new Producto("Microondas", 200m, "Electrodomésticos"),
            new Producto("Televisor", 900m, "Electrónica")
        };

        var productosPorCategoria = productos
            .GroupBy(p => p.Categoria)
            .Select(grupo => new
            {
                Categoria = grupo.Key,
                PrecioPromedio = grupo.Average(p => p.Precio)
            });

        foreach (var grupo in productosPorCategoria)
        {
            // Mostrar el precio promedio como número decimal sin formato de moneda
            Console.WriteLine($"Categoría: {grupo.Categoria}, Precio Promedio: {grupo.PrecioPromedio:F2}");
        }
    }
}
