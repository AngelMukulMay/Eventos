using System;
using System.Collections.Generic;

namespace Logica
{
    public class CalcularFechaArchivo
    {
        public List<EventosDTO> AñadirEventosLista(string[] text)
        {
            string[] separadas;

            List<EventosDTO> lstEventos = new List<EventosDTO>();

            foreach (string line in text)
            {
                separadas = line.Split(",");
                lstEventos.Add(new EventosDTO { cNombre = separadas[0], dtFecha = Convert.ToDateTime(separadas[1]) });
            }

            return lstEventos;

        }
    }
}
