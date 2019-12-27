using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class ChainWithStatePattern
    {
        class Handler
        {
            Handler next;

            public int Limit { get; set; }

            public Handler( Handler handler)
            {
                Limit = 3600;
                next = handler;
            }

            public string HandleRequest(int Data)
            {
                if (Data < Limit)
                    return ("" + Data);
                else if (next != null)
                    return next.HandleRequest(Data);
                else return ("Default" + Data);
            }

        }
    }
}
