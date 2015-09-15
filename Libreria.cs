using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_09_15
{
    class Libreria
    {
        public string direccion;
        public string nomApe;
        public Libro[] ArrayLibros;
        
        public Libreria()
        {
            ArrayLibros = new Libro[10];
        }

        public bool agregarLibro(Libro libroR)
        {
            for (int i = 0; i < this.ArrayLibros.Length; i++)
            {
                if (this.ArrayLibros[i] == null)
                { 
                    this.ArrayLibros[i] =  libroR;
                    return true;
                }
            }
            return false;
        }

    }
}
