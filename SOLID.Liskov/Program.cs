using System;

namespace SOLID.Liskov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Impresora Impresora = new Impresora();

            Remito rto = new Remito(3331, DateTime.Now, 10);
            DocumentoContable fc = new Factura(662, DateTime.Now);
            DocumentoContable nc = new NotaCredito(441,DateTime.Now);
            DocumentoContable nb = new NotaDebito(441, DateTime.Now);

            Impresora.ImprimirRemito(rto);
            Impresora.Imprimir(fc);
            Impresora.Imprimir(nc);
            Impresora.Imprimir(nb);

            Console.ReadKey();
        }
    }
}
