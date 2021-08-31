using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCine
{
    class Logger
    {

        public Logger() { }

        public void CreadoEspectador(Espectador espectador) { 
            Console.WriteLine($"Creado espectador --> {espectador.nombre} | {espectador.edad} | {espectador.dinero}");
        }

        public void SalaLLena(Sala sala)
        {
            Console.WriteLine($"La sala {sala.nombre} está llena");
        }

        public void EncontradoAsiento(Sala sala, Espectador espectador)
        {
            int indexAsiento = -1;
            for (int i = 0; i < sala.butacas.Length; i++)
            {
                if (sala.butacas[i].espectador.nombre.Equals(espectador.nombre))
                {
                    indexAsiento = i;
                    break;
                }
            }
            if (indexAsiento < 0)
            {
                Console.WriteLine("La asignación de sitios está más rota que la relación con tu ex");
            }
            Console.WriteLine($"Encontrado asiento para el espectador {espectador.nombre} en el asiento ({sala.butacas[indexAsiento].fila} , {sala.butacas[indexAsiento].columna}) de la sala {sala.nombre}.");
        }

        public void NoSuficienteEdad(Espectador espectador)
        {
            Console.WriteLine($"El espectador {espectador.nombre} no tiene la edad suficiente");
        }

        public void NoSuficienteDinero(Espectador espectador)
        {
            Console.WriteLine($"El espectador {espectador.nombre} no tiene suficiente dinero");
        }

        public void CrearResumen(Cine cine) {
            Console.WriteLine($"\nCine {cine.nombre} > \n");
            for (int i = 0; i < cine.salas.Length; i++)
            {
                Console.WriteLine($"\nSala {cine.salas[i].nombre}\n");
                for (int j = 0; j < cine.salas[i].butacas.Length; j++)
                {
                    try
                    {
                        Console.WriteLine($"\t({cine.salas[i].butacas[j].fila} , {cine.salas[i].butacas[j].columna}) --> {cine.salas[i].butacas[j].espectador.nombre}");
                    }
                    catch (System.NullReferenceException)
                    {
                        Console.WriteLine("Cine Vacío");
                        break;
                    }
                }
            }
        }
    }
}
