using System;

namespace SOLID.OpenClose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentoContable unaFactura = new Factura(10);
            Console.WriteLine(unaFactura.Descripcion());
            DocumentoContable unaNotaDeCredito = new NotaCredito(120);
            Console.WriteLine(unaNotaDeCredito.Descripcion());
            DocumentoContable unaNotaDeDebito = new NotaDebito(300);
            Console.WriteLine(unaNotaDeDebito.Descripcion());
            Console.ReadKey();
        }
    }
}
