using System;

namespace corto1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a calculadora");
            Boolean continuar = true;
            //declaracion del do while
             do
             {
                 double n1=0,n2=0,suma=0,resta=0,mult=0,div=0;
                 //declaracion del switch
                 switch (menu())
                 {
                     case 1:
                         Console.Write("Digite el primer numero: ");
                         n1 = Convert.ToDouble(Console.ReadLine());
                         Console.Write("Digite el segundo numero: ");
                         n2 = Convert.ToDouble(Console.ReadLine());
                         suma = n1 + n2;
                         Console.WriteLine("El resultado es: " + suma);
                         break;
                     case 2:
                         Console.Write("Digite el minuendo: ");
                         n1 = Convert.ToDouble(Console.ReadLine());
                         Console.Write("Digite el sustraendo: ");
                         n2 = Convert.ToDouble(Console.ReadLine());
                         resta = n1 - n2;
                         Console.WriteLine("El resultado es: " + resta);
                         break;
                     case 3:
                         Console.Write("Digite el primer numero: ");
                         n1 = Convert.ToDouble(Console.ReadLine());
                         Console.Write("Digite el segundo numero: ");
                         n2 = Convert.ToDouble(Console.ReadLine());
                         mult = n1 * n2;
                         Console.WriteLine("El resultado es: " + mult);
                         break;
                     case 4:
                         Console.Write("Digite el dividendo: ");
                         n1 = Convert.ToDouble(Console.ReadLine());
                         Console.Write("Digite el divisor: ");
                         n2 = Convert.ToDouble(Console.ReadLine());
                         div = n1 / n2;
                         Console.WriteLine("El resultado es: " + div);
                         break;
                     case 5:
                         Console.WriteLine("Finalizando programa");
                         continuar = false;
                         break;
                 }

             } while (continuar);
             
             //declaracion de la funcion menu
            int menu()
             {
                 Console.WriteLine("1. Sumar dos numeros ");
                 Console.WriteLine("2. Restar dos numeros ");
                 Console.WriteLine("3. Multiplicar dos numeros ");
                 Console.WriteLine("4. Dividir dos numeros ");
                 Console.WriteLine("5. Salir ");
                 Console.Write("Opcion: ");
                 int opcion = Convert.ToInt32(Console.ReadLine());

                 return opcion;
             }
        }
    }
}