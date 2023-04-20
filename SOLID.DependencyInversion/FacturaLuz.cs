using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class FacturaLuz : Impuesto
    {
        public string CodigoPago { get; set; }
        public FacturaLuz(double importe, string codigoPago) : base(importe)
        {
            CodigoPago = codigoPago;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura de luz con codigo {CodigoPago} por un importe de {Importe}");
        }
    }
}
