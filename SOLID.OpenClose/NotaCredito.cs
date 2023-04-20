using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero) : base(numero)
        {
            
        }
        public override string Descripcion()
        {
            return $"NC-{Numero}";
        }
    }
}
