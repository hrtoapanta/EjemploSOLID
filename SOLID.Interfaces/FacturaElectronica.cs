using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    public class FacturaElectronica : Documento, IEmaileable
    {
        public string CAE { get; set; }
        public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha)
        {

        }
      
        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo la factura electrónica {Numero} del dia {Fecha.ToShortDateString()} con cae {CAE}");
        }

        public void EnviarPorEmail()
        {
            Console.WriteLine($"Enviando por email la factura electrónica {Numero} del dia {Fecha.ToShortDateString()} con cae {CAE}");
        }
    }
}
