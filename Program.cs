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
            unaLibreria.ArrayLibros[0] = miLibro;
        }
    }
}
