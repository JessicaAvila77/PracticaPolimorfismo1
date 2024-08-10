using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            //creando la lista de tipo figura
            List<Figura> figuraLista = new List<Figura>();

            int Opcion = Menu();

            do
            {
               
                switch (Opcion)
                {
                    case 1:

                        Console.WriteLine("");
                        Console.Write("Ingrese el largo del rectángulo: ");
                        double largo = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el ancho del rectángulo: ");
                        double ancho = double.Parse(Console.ReadLine());

                        figuraLista.Add(new Rectangulo(largo, ancho));
                        break;


                    case 2:

                        Console.WriteLine("");
                        Console.Write("Ingrese el radio del circulo: ");
                        double radio = double.Parse(Console.ReadLine());

                        figuraLista.Add(new Circulo(radio));
                        break;

                    case 3:
                        Console.Write("Ingrese la base del triangulo: ");
                        double baseTriangulo = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del triangulo: ");
                        double altura = double.Parse(Console.ReadLine());

                        figuraLista.Add(new Triangulo(baseTriangulo, altura));
                        break;

                    default:
                        Console.WriteLine("Ingrese una opcion válida");
                        break;


                }

             Opcion = Menu();


            }while (Opcion != 4);

            Console.WriteLine("");
            Console.WriteLine("======Area de de las figuras ingresadas=====");

            //llama al método imprimir por cada figura en la lista de tipo Figura
            foreach (Figura figura in figuraLista)
            {
                figura.Imprimir();
            }


        }

        //Método del menu
        public static int Menu()
        {
            int opcion = 0;

            Console.WriteLine("");
            Console.WriteLine("Ingrese la figura en la que desea calcular el area o 4 para salir: ");
            Console.WriteLine("1. Rectanculo");
            Console.WriteLine("2. Circulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese la opción:");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;

        }

    }
  
}
