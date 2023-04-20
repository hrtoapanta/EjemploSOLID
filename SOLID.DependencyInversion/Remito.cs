using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class Remito :IImprimible
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int CantBultos { get; set; }
        public Remito( int numero,DateTime fecha, int cantbultos)
        {
            Numero = numero;
            Fecha = fecha;
            CantBultos = cantbultos;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo remito con numero {Numero} fecha {Fecha} por el numero de bultos {CantBultos}");
        }
    }
}
