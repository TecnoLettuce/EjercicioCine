using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCine
{
    class Cine
    {
        public Sala[] salas { get; set; }
        public string nombre { get; set; }

        // Constructor
        public Cine(Sala[] salas, string nombre) {
            this.salas = salas;
            this.nombre = nombre;
        }

        //Métodos
    }
}
