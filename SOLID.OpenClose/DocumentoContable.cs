﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose
{
    public abstract class DocumentoContable
    {
        public DocumentoContable(int numero)
        {
             Numero = numero;    
        }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }
        public TipoDocumentoContable Tipo { get; set; }

        public abstract string Descripcion();

    }
}
