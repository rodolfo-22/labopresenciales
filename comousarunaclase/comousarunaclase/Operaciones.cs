using System;

namespace OperacionesBasicas_Clase
{
    public class Operaciones
    {
        // Atributos
        //son las caracteristicas que tiene nuestra clase
        private double numnA, numB;

        // Constructor
        //inciamos los atributos con this. y ponemos cero si va a contener numero, o el mismo nombre si los recibira
        //de instancia
        public Operaciones(double numnA, double numB)
        {
            this.numnA = numnA;
            this.numB = numB;
        }
    
        // Metodo de suma
        //los metodos son las accciones que hace nuestra clase
        public double suma()
        {
            return numnA + numB; // Retornamos la suma
        }
        
        // Metodo de resta
        public double resta()
        {
            return numnA - numB; // Retornamos la resta
        }
        
        // / Metodo de multipliacion
        public double multiplicacion()
        {
            return numnA * numB; // Retornamos la multiplicacion
        }
        
        // Metodo de division
        public double division()
        {
            return numnA / numB; // Retornamos la division
        }
    }
}