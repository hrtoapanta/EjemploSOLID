using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    public class Factura : Documento
    {
        public string CAI { get; set; }
        public Factura(int numero, DateTime fecha):base(numero, fecha) 
        {
            
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo por email la factura {Numero} del dia {Fecha.ToShortDateString()} con CAI {CAI}");
        }
    }
}
