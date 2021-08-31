using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCine
{
    class Espectador
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public int dinero { get; set; }

        // Constructor
        public Espectador(string nombre, int edad, int dinero) {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }

        internal void pagar(int precio)
        {
            this.dinero -= precio;
        }

        // Métodos

    }
}
