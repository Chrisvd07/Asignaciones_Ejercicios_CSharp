using System;

public class Recurso : IDisposable
{
    private bool _disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                
            }

            
            Console.WriteLine("El recurso ha sido liberado.");

            _disposed = true;
        }
    }

    ~Recurso()
    {
        Dispose(false);
    }
}

class Program
{
    static void Main()
    {
        using (Recurso recurso = new Recurso())
        {
            Console.WriteLine("Usando el recurso...");
        } 

        
    }
}
