using System;

namespace SOLIDEjemplo2
{
    /// <summary>
    /// SOLID SingleResponsability
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Factura f = new Factura(21332, new Cliente { Apellido = "Lopez", Nombre = "Diego" });


            Item it1 = new Item(new Producto("Arroz", 10 ),5 );
            Item it2 = new Item(new Producto("Queso", 90), 1);
            Item it3 = new Item(new Producto("Queso", 70), 2);

            f.Items.Add(it1);
            f.Items.Add(it2);
            f.Items.Add(it3);

            Console.WriteLine(f.Total());
            Console.ReadKey();
        }
    }
}
