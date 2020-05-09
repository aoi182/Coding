using System;

namespace DesignPatterns.SOLID.ISP
{
    public class OldFashionedPrinter : IMachine
    {
        public void Fax(Document d)
        {
            // this is OK, we can do something here
        }

        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        [Obsolete("Not supported", true)]
        public void Scan(Document d)
        {
            // deliberately left blank
        }
    }
}