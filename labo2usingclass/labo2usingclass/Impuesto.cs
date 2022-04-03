namespace Calculadora_Salario
{
    public class Impuesto
    {
        
        // Declaracion de variables
        private string nombre;
        private double porcentaje;
        
        // Constructor
        public Impuesto(string nombre, double porcentaje)
        {
            this.nombre = nombre;
            this.porcentaje = porcentaje;
        }

        // Para tener acceso controlado a los atributos privados de la clase
        public double getPorcentaje()
        {
            return porcentaje;
        }
    }
}