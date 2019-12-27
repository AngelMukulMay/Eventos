using Logica;
using System;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Lector objLector = new Lector();

            string[] texto = objLector.GetTextFromFile(@"TextFile.txt");

            CalcularFechaArchivo objAñadirEventoLista = new CalcularFechaArchivo();

            objAñadirEventoLista.AñadirEventosLista(texto);

            Console.ReadKey();
        }
    }
}
