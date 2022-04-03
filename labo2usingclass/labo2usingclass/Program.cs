using System;

namespace Calculadora_Salario
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Declarando unEmpleado de tipo Empleado
            Empleado empleado1, empleado2;
            
            // Instancia 
            empleado1 = new Empleado("Daniel", 500.50, 1, true, 1960 );
            empleado2 = new Empleado("Vanesa", 300, 2, false, 1960 );
            // genero = true - MASCULINO y genero = False - FEMENINO
            // modalidad = 1 - PLANILLA y modalidad = 2 SERV. PROFESIONAL
            
            // Imprimir Datos del Empleado 1
            Console.WriteLine("nombre del empleado: " + empleado1.getNombre());
            Console.WriteLine("Salario sin deducciones: $" + empleado1.getSalario());
            Console.WriteLine("Genero: " + empleado1.getGenero());
            Console.WriteLine("Anio de Nacimiento: " + empleado1.getNacimiento());
            Console.WriteLine("Retiro: " + empleado1.calcularRetiro());
            Console.WriteLine("Total de deducciones: $" + empleado1.calcularDeducciones());
            Console.WriteLine("Salario final: $");
            Console.WriteLine();
            
            // Imprimir Datos del Empleado 2
            Console.WriteLine("nombre del empleado: " + empleado2.getNombre());
            Console.WriteLine("Salario sin deducciones: $" + empleado2.getSalario());
            Console.WriteLine("Genero: " + empleado2.getGenero());
            Console.WriteLine("Anio de Nacimiento: " + empleado2.getNacimiento());
            Console.WriteLine("Retiro: " + empleado2.calcularRetiro());
            Console.WriteLine("Total de deducciones: $" + empleado2.calcularDeducciones());
            Console.WriteLine("Salario final: $");
        }
    }
}