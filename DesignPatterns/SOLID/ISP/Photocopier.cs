using System;

namespace DesignPatterns.SOLID.ISP
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            // something here
        }

        public void Scan(Document d)
        {
            // something here
        }
    }
}