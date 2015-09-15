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

        public bool agregarLibro(Libro libroRecibido)
        {
            //si hay un indice libre, mete el libro en ese indice libre.
            if (this.indiceLibre() != -1)
            {
                this.ArrayLibros[this.indiceLibre()] = libroRecibido;
                return true;
            }
            return false;

            /*
            int i;
            for (i = 0; i < this.ArrayLibros.Length; i++)
            {
                if (this.ArrayLibros[i] == null)
                { 
                    this.ArrayLibros[i] =  libroR;
                    return true;
                }
            }
            return false;*/
        }
        
        /// <summary>
        /// Retornará el primer índice libre, sino retornará -1.
        /// </summary>
        /// <returns></returns>
        public int indiceLibre()
        {
            int i;

            for (i = 0; i < this.ArrayLibros.Length; i++)
            {
                if (this.ArrayLibros[i] == null)
                {
                    return i;//o i+1?
                }
            }
            return -1;
        }
    }
}
