using System;
using System.Collections.Generic;

namespace EjercicioCine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejecución principal 

            Logger log = new Logger();

            Butaca[] butacasSala = {
                new Butaca(0,0), new Butaca(0, 1), new Butaca(0, 2),
                new Butaca(1, 0), new Butaca(1, 1), new Butaca(1, 2),
                new Butaca(2, 0), new Butaca(2, 1), new Butaca(2, 2),
            };
            Sala[] salas = { new Sala(new Pelicula(10, "SAW3", "RandomDirector", 18), "Sala2", butacasSala) };
            Cine cinesTest = new Cine(salas, "Cines Testeo");

            List<Espectador> listaDeEspectadores = new List<Espectador>();

            for (int i = 0; i < 10; i++)
            {
                Random rnd = new Random();
                Espectador espectador = new Espectador($"Espectador-{i}", rnd.Next(1, 30), rnd.Next(0, 20));
                listaDeEspectadores.Add(espectador);

                log.CreadoEspectador(espectador);
            }

            for (int i = 0; i < salas.Length; i++)
            {
                SentarGente(listaDeEspectadores, salas[i], log);
            }

            log.CrearResumen(cinesTest);

            Console.ReadKey();

        } // Salida del Main

        static void SentarGente(List<Espectador> listaDeEspectadores, Sala sala, Logger log)
        {

            foreach (var espectador in listaDeEspectadores)
            {
                if (ComprobarEdad(espectador.edad, sala.peliculaProyectada.pegi))
                {

                    if (ComprobarDinero(espectador.dinero, sala.peliculaProyectada.precio))
                    {

                        espectador.pagar(sala.peliculaProyectada.precio);

                        // Tenemos edad y dinero
                        if (BuscarAsiento(sala, espectador))
                        {
                            log.EncontradoAsiento(sala, espectador);
                        }
                        else
                        {
                            log.SalaLLena(sala);
                        }
                    }
                    else
                    {
                        log.NoSuficienteDinero(espectador);
                    }
                }
                else
                {
                    log.NoSuficienteEdad(espectador);
                }
            }

        }

        private static bool BuscarAsiento(Sala sala, Espectador espectador)
        {
            bool swEncontradoAsiento = false;

            for (int i = 0; i < sala.butacas.Length; i++)
            {
                if (sala.butacas[i].espectador == null)
                {
                    // Asiento vacío
                    sala.butacas[i].espectador = espectador;
                    swEncontradoAsiento = true;
                    break;
                }
            }

            if (swEncontradoAsiento)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ComprobarDinero(int dinero, int precio)
        {
            if (dinero >= precio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ComprobarEdad(int edad, int pegi)
        {
           if (edad >= pegi)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    } // Salida de la clase 
}
