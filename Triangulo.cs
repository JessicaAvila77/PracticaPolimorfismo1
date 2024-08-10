using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo1
{
    public class Triangulo : Figura
    {
        public double baseTriangulo;
        public double altura;

        //Metodo constructor

        public Triangulo() { }

        public Triangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }


        //Polimorfismo con sobrecarga de metodos.

        public override double CalcularArea()
        {
            return (baseTriangulo * altura) / 2;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El area de un triangulo con base {baseTriangulo} y altura {altura} es: {CalcularArea()}");
        }
    }
}
