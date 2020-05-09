namespace DesignPatterns.SOLID.ISP
{
    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IScanner scanner;
        private IPrinter printer;

        public MultiFunctionMachine(IScanner scanner, IPrinter printer)
        {
            this.scanner = scanner;
            this.printer = printer;
        }

        public void Print(Document d)
        {
            this.printer.Print(d);
        }

        public void Scan(Document d)
        {
            this.scanner.Scan(d);
        }
    }
}