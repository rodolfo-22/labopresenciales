using System.Xml.Serialization;

namespace Calculadora_Salario
{
    public class Empleado
    {
        // Variables a utilizar
        private string nombre;
        private double salario;
        private int modalidad;
        private Impuesto ISSS;
        private Impuesto AFP;
        private Impuesto renta;
        private bool genero;
        private int anioNac;
        
        // Constructor
        public Empleado(string nombre, double salario, int modalidad, bool genero, int anioNac)
        {
            this.nombre = nombre;
            this.salario = salario;
            this.modalidad = modalidad;
            this.genero = genero;
            this.anioNac = anioNac;
        }
        

        // Metodo para calcular deducciones de empleado
        
        public double calcularDeducciones()
        {
            
            // Para modalidad planilla
            if (modalidad == 1)
            {
                
                // Instancia de objetos
                ISSS = new Impuesto("ISSS", 0.03);
                AFP = new Impuesto("AFP", 0.07);
                renta = new Impuesto("renta", 0.10);
                
                // Calculo de deduccion 
                return ((salario * ISSS.getPorcentaje()) + (salario * AFP.getPorcentaje()) +
                        (salario * renta.getPorcentaje()));
            }
            else
            {
                // Instancia de objeto
                renta = new Impuesto("renta", 0.10);
                
                // Calculo de deduccion
                return salario * renta.getPorcentaje();  
            }
            
        }

        
        // Metodo para calcular retiro
        public bool calcularRetiro()
        {
            // Declaramos variable para calcular la edad
            int edad;

            edad = 2022 - anioNac;
            // Condicionales necesarios para calculo de retiro
            if (genero == false && edad >= 55) // FEMENINO
            {
                return true;
            }
            else
            {
                if (genero == true && edad >= 60) // MASCULINO
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        
        // Para tener acceso controlado a los atributos privados de la clase
        public string getNombre()
        {
            return nombre;
        }
        
        public double getSalario()
        {
            return salario;
        }
        
        public string getGenero()
        {
            if (genero)
            {
                return "MASCULINO";
            }
            else
            {
                return "FEMENINO";
            }
        }

        public int getNacimiento()
        {
            return anioNac;
        }
        
        
    }
}