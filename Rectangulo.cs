using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo1
{
    public class Rectangulo : Figura
    {
        public double Largo {  get; set; }  
        public double Ancho { get; set; }

        //Metodo constructor que recibe parametros
        public Rectangulo() { } 

        public Rectangulo(double largo, double ancho)
        {
            this.Largo = largo;
            this.Ancho = ancho;
        }

        //Polimorfismo con sobrecarga de metodos.
        public override double CalcularArea()
        {
            return Largo * Ancho;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Rectángulo con largo = {Largo} y ancho = {Ancho}, Área = {CalcularArea()}");
        }

    }

}
