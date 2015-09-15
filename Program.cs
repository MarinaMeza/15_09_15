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

            Libro miLibro=new Libro();
            Libreria unaLibreria = new Libreria();
            int indice;

            if (unaLibreria.agregarLibro(miLibro))
            {
                Console.WriteLine("El libro se ingresó");
            }
            
            //unaLibreria.agregarLibro(miLibro);//agrega otro libro. prueba indice. ah re loco!

            indice = unaLibreria.indiceLibre();
            Console.WriteLine(indice);
            
        }
    }
}
