using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_09_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Libro[] libros;
            libros = new Libro[10];
            libros[0] = new Libro();*/

            Libro miLibro = new Libro(1234, "Brunoooooooooo");
            Libreria unaLibreria = new Libreria();
            int indice;


            Libro miOtroLibro = new Libro(1234,"Brunoooooooooo");

            if (unaLibreria.agregarLibro(miLibro))
            {
                Console.WriteLine("El libro se ingresó");
            }

            if (miLibro == miOtroLibro)
            {
                Console.WriteLine("Son iguales");
            }
            else
                Console.WriteLine("No son iguales");

            //unaLibreria.agregarLibro(miLibro);//agrega otro libro. prueba indice. ah re loco!

            indice = unaLibreria.indiceLibre();
            Console.WriteLine(indice);
            
        }
    }
}
