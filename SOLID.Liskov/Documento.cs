﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov
{
    public abstract class DocumentoContable
    {
        protected string _sigla;
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public DocumentoContable(int numero, DateTime fecha)
        {
            Numero = numero;    
            Fecha = fecha;
        }
        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }
        public virtual string Descripcion()
        {
            return $"{_sigla} nro {Numero} de fecha {Fecha.ToShortDateString()}";
        }
    }
}
