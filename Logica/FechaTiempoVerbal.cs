using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class FechaTiempoVerbal
    {
        public void CompararTiempo(DateTime FechaComparar, List<EventosDTO> lstEventos)
        {
            bool isFutureDate;
            TimeSpan newDate;

            foreach (var item in lstEventos)
            {
                if (FechaComparar < item.dtFecha)
                {
                    isFutureDate = true;
                }
                else
                {
                    isFutureDate = false;
                }

                Console.WriteLine("Es evento futuro : " + isFutureDate);
            }
            
        }
    }
}
