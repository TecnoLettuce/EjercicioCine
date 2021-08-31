using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCine
{
    class Sala
    {
        public Pelicula peliculaProyectada { get; set; }
        public Butaca[] butacas { get; set; }
        public string nombre { get; set; }

        public Sala(Pelicula pelicula, string nombre, Butaca[] butacas) {
            this.peliculaProyectada = pelicula;
            this.butacas = butacas;
            this.nombre = nombre;
        }

        //Métodos
    }
}
