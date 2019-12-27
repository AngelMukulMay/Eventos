using System;
using System.Collections.Generic;

namespace Logica
{
    public class AñadirFechaArchivo
    {
        public List<EventosDTO> AñadirEventosLista(string[] text)
        {
            string[] separadas;

            List<EventosDTO> lstEventos = new List<EventosDTO>();

            try
            {
                foreach (string line in text)
                {
                    separadas = line.Split(",");
                    lstEventos.Add(new EventosDTO { cNombre = separadas[0], dtFecha = Convert.ToDateTime(separadas[1]) });
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("An index error was found.");
            }
            catch (Exception)
            {
                Console.WriteLine("An unknown error happened");
            }

           
            return lstEventos;

        }
    }
}
