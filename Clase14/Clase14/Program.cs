using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase14
{
    class Program
    {
        static void Main(string[] args)
        {

            List<object> Datos = new List<object>()
            {
                new Cliente("Leo","Testa",1,180,26,Genero.Masculino,Ciudad.CiudadDelEste),
                new Cliente("John", "Johnson", 2, 170, 21, Genero.Masculino,Ciudad.Franco),
                new Cliente("Anna", "Maria", 3, 150, 22, Genero.Femenino,Ciudad.Franco),
                new Cliente("Kyle", "Wilson", 4, 164, 29, Genero.Femenino,Ciudad.CiudadDelEste),
                new Cliente("Anna", "Williams", 5, 164, 28, Genero.Femenino,Ciudad.Franco),
                new Cliente("Maria", "Ann", 6, 160, 19, Genero.Femenino,Ciudad.CiudadDelEste),
                new Cliente("John", "Jones", 7, 160, 22, Genero.Masculino,Ciudad.Franco),
                new Cliente("Samba", "TheLion", 8, 175, 23, Genero.Masculino,Ciudad.Hernandarias),
                new Cliente("Aaron", "Myers", 9, 182, 21, Genero.Masculino,Ciudad.CiudadDelEste),
                new Cliente("Aby", "Wood", 10, 165, 20, Genero.Femenino,Ciudad.Hernandarias),
                new Cliente("Maddie","Lewis",  11, 160, 19, Genero.Femenino,Ciudad.CiudadDelEste),
                new Cliente("Lara", "Croft", 12, 162, 23, Genero.Femenino,Ciudad.MingaGuazu),
                new Cliente("Tod", "Vachev", 13, 180, 26, Genero.Masculino,Ciudad.CiudadDelEste),

                new Venta(1, new DateTime(2020,5,4),350_000,11,Ciudad.CiudadDelEste,""),
                new Venta(2, new DateTime(2020,6,9),580_000,10,Ciudad.Franco,""),
                new Venta(3, new DateTime(2000,9,16),270_000,6,Ciudad.Hernandarias,""),
                new Venta(4, new DateTime(2010,10,13),730_000,8,Ciudad.CiudadDelEste,""),
                new Venta(5, new DateTime(2007,1,2),710_000,2,Ciudad.Franco,""),
                new Venta(6, new DateTime(2007,8,16),690_000,3,Ciudad.Hernandarias,""),
                new Venta(7, new DateTime(2014,1,18),580_000,10,Ciudad.CiudadDelEste,""),
                new Venta(8, new DateTime(2019,7,14),220_000,6,Ciudad.Franco,""),
                new Venta(9, new DateTime(2020,5,7),780_000,6,Ciudad.Hernandarias,""),
                new Venta(10, new DateTime(2013,3,9),950_000,1,Ciudad.CiudadDelEste,""),
                new Venta(11, new DateTime(2009,8,11),470_000,3,Ciudad.Franco,""),
                new Venta(12, new DateTime(2000,10,16),220_000,13,Ciudad.MingaGuazu,""),
                new Venta(13, new DateTime(2012,12,24),900_000,13,Ciudad.CiudadDelEste,""),
                new Venta(14, new DateTime(2018,8,12),710_000,1,Ciudad.Franco,""),
                new Venta(15, new DateTime(2012,6,24),210_000,7,Ciudad.MingaGuazu,""),
                new Venta(16, new DateTime(2003,8,4),240_000,6,Ciudad.CiudadDelEste,""),
                new Venta(17, new DateTime(2019,7,8),790_000,4,Ciudad.MingaGuazu,""),
                new Venta(18, new DateTime(2000,7,17),620_000,6,Ciudad.MingaGuazu,""),
                new Venta(19, new DateTime(2009,7,21),360_000,11,Ciudad.CiudadDelEste,""),
                new Venta(20, new DateTime(2015,9,7),470_000,5,Ciudad.MingaGuazu,"")
            };


            //var Ventas = from D in Datos
            //             where D is Venta
            //             select D;


            //var Clientes = from D in Datos
            //               where D is Cliente
            //               select D;


            //foreach (Venta Dato in Ventas)
            //{
            //    Console.WriteLine($"Venta: {Dato.Id}");
            //}

            //foreach (Cliente Dato in Clientes)
            //{
            //    Console.WriteLine($"Cliente: {Dato.Id}");
            //}

            //var Clientes = from D in Datos
            //               let C= D as Cliente
            //               where D is Cliente
            //               where C.Id==4
            //               select C;

            //foreach (Cliente Dato in Clientes)
            //{
            //    Console.WriteLine($"Cliente: {Dato.Nombre}");
            //}

            //var Clientes = Datos.OfType<Cliente>().Where(c => c.Edad > 20);

            //foreach (Cliente Dato in Clientes)
            //{
            //    Console.WriteLine($"Cliente: {Dato.Nombre}");
            //}


            //var Arreglo = (from D in Datos select D).ToArray();

            //var Listado = (from D in Datos select D).ToList();

            //var Listado = Datos.OfType<Cliente>().ToList().ConvertAll(C => new Venta() { Id_Cliente = C.Id, MontoTotal = C.Edad });

            //var Arreglo = (from D in Datos
            //              where D is Cliente
            //              let C = D as Cliente
            //              select new Venta()
            //              {
            //                  Id_Cliente = C.Id,
            //                  MontoTotal = C.Edad
            //              }).ToArray();


            List<int> Numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            List<string> NumerosPeroEnLetras = Numeros.ConvertAll(n => n.ToString());


        }

        public struct Venta
        {
            public int Id { get; set; }
            public DateTime Fecha { get; set; }
            public double MontoTotal { get; set; }
            public int Id_Cliente { get; set; }
            public Ciudad CiudadDeVenta { get; set; }
            public string Observacion { get; set; }

            public Venta(int Id, DateTime Fecha, double MontoTotal, int Id_Cliente, Ciudad CiudadDeVenta, string Observacion)
            {
                this.Id = Id;
                this.Fecha = Fecha;
                this.MontoTotal = MontoTotal;
                this.Id_Cliente = Id_Cliente;
                this.CiudadDeVenta = CiudadDeVenta;
                this.Observacion = Observacion;
            }
        }

        public class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Altura { get; set; }
            public int Edad { get; set; }
            public Genero Genero { get; set; }
            public Ciudad Ciudad { get; set; }

            public Cliente(string Nombre, string Apellido, int Id, int Altura, int Edad, Genero Genero, Ciudad Ciudad)
            {
                this.Id = Id;
                this.Nombre = Nombre;
                this.Apellido = Apellido;
                this.Altura = Altura;
                this.Edad = Edad;
                this.Genero = Genero;
                this.Ciudad = Ciudad;
            }
        }

        public enum Genero
        {
            Masculino,
            Femenino
        }

        public enum Ciudad
        {
            CiudadDelEste,
            Franco,
            Hernandarias,
            MingaGuazu
        }
    }
}
