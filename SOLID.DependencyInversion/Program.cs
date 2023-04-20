using System;

namespace SOLID.DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factura fact = new Factura(123, DateTime.Now, 23);
            NotaCredito nota = new NotaCredito(234, DateTime.Now, 44);
            Remito remi = new Remito(009, DateTime.Now, 23);
            FacturaLuz faluz = new FacturaLuz(234, "23");
            Municipal muni = new Municipal(22, "00012");

            Impresora impresora = new Impresora();
            impresora.Imprimir(fact);
            impresora.Imprimir(nota);
            impresora.Imprimir(remi);
            impresora.Imprimir(faluz);
            impresora.Imprimir(muni);

            Console.ReadKey();
        }
    }
}
