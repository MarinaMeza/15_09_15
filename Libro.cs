using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15_09_15
{
    class Libro
    {
        public string titulo;
        public int codigo;
        public string autor;

        public Libro()
        {
            autor = "Anonimo";
            titulo = "NN";
            codigo = 1234;
        }

        public Libro(int codigo, string autor)
        {
            this.autor = autor;
            this.codigo = codigo;
        }

        public static bool operator ==(Libro libro1, Libro libro2)
        {
                if (libro1.codigo == libro2.codigo && libro1.autor == libro2.autor)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Libro libro1, Libro libro2)
        {
            return !(libro1 == libro2);
        }
    }
}
