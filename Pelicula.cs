using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCine
{
    class Pelicula
    {
        public int precio { get; set; }
        public string titulo { get; set; }
        public string director { get; set; }
        public int pegi { get; set; }

        // Constructor 
        public Pelicula(int precio, string titulo, string director, int pegi) {
            this.precio = precio;
            this.titulo = titulo;
            this.director = director;
            this.pegi = pegi;
        }

    }
}
