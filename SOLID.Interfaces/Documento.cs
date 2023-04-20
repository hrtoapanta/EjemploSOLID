using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    public abstract class Documento :IImprimible
    {
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public Documento(int numero, DateTime fecha)
        {
            Numero = numero;
            Fecha = fecha;
        }
        public abstract void Imprimir();


    }
}
