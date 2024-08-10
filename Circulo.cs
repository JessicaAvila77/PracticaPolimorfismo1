using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo1
{
    public class Circulo: Figura
    {
        public double radio;

        //Metodo constructor
        public Circulo  (double radio)
        {
            this.radio = radio;
        } 


        //Polimorfismo con sobrecarga de metodos.

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El area de un circulo con radio = {radio} es: {CalcularArea()}");
        }

    }
    
}
