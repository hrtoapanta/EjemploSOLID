using System;

namespace SOLID.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Factura factura = new Factura(1234, DateTime.Now);
            factura.CAI = "12345";

            FacturaElectronica facturaElectronica = new FacturaElectronica(1234, DateTime.Now);
            facturaElectronica.CAE = "877678";

           
           
                facturaElectronica.Imprimir();
                facturaElectronica.EnviarPorEmail();
                factura.Imprimir();
           
            Console.ReadLine();
        }
    }
}
