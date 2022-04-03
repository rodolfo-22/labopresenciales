using System;

class HelloWorld {
    static void Main() {
        Vendedor unaPersona = new Vendedor(1, "Juan");
        unaPersona.realizarVenta();
        
        Console.WriteLine("Nombre: " + unaPersona.nombre);
        Console.WriteLine("Ventas: $" + unaPersona.ventas);
        
        unaPersona.ventas += 2;
        Console.WriteLine("Ventas: $" + unaPersona.ventas);
    }
}