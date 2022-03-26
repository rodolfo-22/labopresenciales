using System;
using System.Reflection;

public class Libro
{
    // Atributos de instancia
    public int ISBN { get; private set; }
    public string nombre { get; private set; }
    public int paginas { get; private set; }

    // Constructor
    public Libro()
    {
        paginas = 0;
        ISBN = GeneradorISBN.nuevoID();
    }

    public void tostring(double monto)
    {
        Console.WriteLine("Nuevo libro");
    }
}