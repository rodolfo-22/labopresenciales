using System;
class HelloWorld {
    static void Main() {
        Libro cuenta1 = new Libro();
        Console.WriteLine("No. de libro: " + cuenta1.ISBN);
        
        Libro cuenta2 = new Libro();
        Console.WriteLine("No. de libro: " + cuenta2.ISBN);
        
        Libro cuenta3 = new Libro();
        Console.WriteLine("No. de libro: " + cuenta3.ISBN);

        Libro caperusa5 = new Libro();
        Console.WriteLine("No. de libro: " + caperusa5.ISBN);
    }
}