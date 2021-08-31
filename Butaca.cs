using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCine
{
    class Butaca
    {
        public int fila { get; set; }
        public int columna { get; set; }
        public Espectador espectador { get; set; }

        // Constructor 
        public Butaca(int fila, int columna) {
            this.fila = fila;
            this.columna = columna;
            this.espectador = null;
        }

        // Métodos
    }
}
