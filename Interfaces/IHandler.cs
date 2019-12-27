using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IHandler
    {
        public int Limit { get; set; }

        string HandleRequest(int Data);
    }
}
