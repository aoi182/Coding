using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.ISP
{
    public interface IMachine
    {
        void Print(Document d);
        void Fax(Document d);
        void Scan(Document d);
    }
}
