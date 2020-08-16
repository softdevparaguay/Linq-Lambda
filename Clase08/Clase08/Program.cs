using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*LINQ*/

            Cliente Cliente1 = new Cliente();
            Cliente1.Id = 1;
            Cliente1.Nombre = "Leonardo";
            Cliente1.LimiteDeCredito = 100_000;
            Cliente1.Nacimiento = new DateTime(1983, 08, 20);

            Cliente Cliente2 = new Cliente();
            Cliente2.Id = 2;
            Cliente2.Nombre = "Raul";
            Cliente2.LimiteDeCredito = 500_000;
            Cliente2.Nacimiento = new DateTime(1984, 02, 21);

            Cliente Cliente3 = new Cliente();
            Cliente3.Id = 3;
            Cliente3.Nombre = "Guillermo";
            Cliente3.LimiteDeCredito = 1_000_000;
            Cliente3.Nacimiento = new DateTime(1984, 08, 25);


            List<Cliente> Clientes = new List<Cliente>();
            Clientes.AddRange(new[] { Cliente1, Cliente2, Cliente3 });

            var ClientesAgosto = from c in Clientes where c.Nacimiento.Month == 8 && c.Nombre.Contains("L") select c;

            foreach (var Item in ClientesAgosto)
            {
                Console.WriteLine(Item.Nombre);
            }

            var ClientesNuevo = from c in Clientes where c.Nacimiento.Month == 8 && c.Nombre.Contains("L") select new { Nombre = c.Nombre + c.Nacimiento.Year.ToString(), Id = c.Id };

            foreach (var Item in ClientesNuevo)
            {
                Console.WriteLine(Item.Nombre);
            }


        }

        public struct Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public double LimiteDeCredito { get; set; }
            public DateTime Nacimiento { get; set; }
        }
    }
}







































