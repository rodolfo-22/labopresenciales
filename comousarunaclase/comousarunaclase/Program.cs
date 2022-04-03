using System;

namespace OperacionesBasicas_Clase
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            // Instanciamos el objeto
            Operaciones objeto1 = new Operaciones(5.0, 9.0);
            
            
            // imprimir datos en consola haciendo uso de los metodos
            
            Console.WriteLine("El resultado de la  suma es: " + objeto1.suma());
            Console.WriteLine("El resultado de la resta es: " + objeto1.resta());
            Console.WriteLine("El resultado de la multiplicaion es: " + objeto1.multiplicacion());
            Console.WriteLine("El resultado de la division es: " + objeto1.division());
            
        }
    }
}