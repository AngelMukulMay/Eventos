using Logica;
using System;
using System.Collections.Generic;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Lector objLector = new Lector();

            AñadirFechaArchivo objAñadirEventoLista = new AñadirFechaArchivo();

            FechaTiempoVerbal objCompararFecha = new FechaTiempoVerbal();

            string[] texto = objLector.GetTextFromFile(@"TextFile.txt");

            List<EventosDTO> lstEventos = objAñadirEventoLista.AñadirEventosLista(texto);

            Console.WriteLine("El contenido del archivo de texto");

            foreach (var item in lstEventos)
            {
                Console.WriteLine("Título del evento: " + item.cNombre + " " + "Fecha: " + item.dtFecha);
            }

            objCompararFecha.CompararTiempo(DateTime.Now,lstEventos);

            Console.ReadKey();
        }
    }
}
