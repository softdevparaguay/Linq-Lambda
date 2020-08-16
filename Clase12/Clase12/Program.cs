using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> Clientes = new List<Cliente>()
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
                new Cliente("Tod", "Vachev", 13, 180, 26, Genero.Masculino,Ciudad.CiudadDelEste)
            };

            List<Venta> Ventas = new List<Venta>()
            {
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

            //var ListadoJoin = from C in Clientes
            //                  orderby C.Nombre
            //                  join V in Ventas on C.Id equals V.Id_Cliente
            //                  select new 
            //                  {
            //                      C.Nombre,
            //                      V.Fecha,
            //                      V.MontoTotal
            //                  };

            //foreach (var ClienteYVenta in ListadoJoin)
            //{
            //    Console.WriteLine($"Cliente: {ClienteYVenta.Nombre} - Fecha {ClienteYVenta.Fecha} - Monto {ClienteYVenta.MontoTotal}");
            //}

            //var ListadoJoinMultiple = from C in Clientes
            //                          join V in Ventas on new { Id_Cliente = C.Id, Ciudad = C.Ciudad } equals new { Id_Cliente = V.Id_Cliente, Ciudad = V.CiudadDeVenta }
            //                          select new
            //                          {
            //                              C.Nombre,
            //                              Venta = V
            //                          };

            //foreach (var ClienteYVenta in ListadoJoinMultiple)
            //{
            //    Console.WriteLine($"Cliente: {ClienteYVenta.Nombre} - Fecha {ClienteYVenta.Venta.Fecha} - Monto {ClienteYVenta.Venta.MontoTotal} - Id_Venta {ClienteYVenta.Venta.Id}");
            //}


            //var ListadoJoinAgrupado = from C in Clientes
            //                          join V in Ventas on C.Id equals V.Id_Cliente into GrupoDeVentas
            //                          select new
            //                          {
            //                              C.Nombre,
            //                              Ventas = GrupoDeVentas
            //                          };

            //foreach (var Cliente in ListadoJoinAgrupado)
            //{
            //    Console.WriteLine($"Cliente: {Cliente.Nombre}");

            //    foreach (var VentaDelCliente in Cliente.Ventas)
            //    {
            //        Console.WriteLine($"     Fecha {VentaDelCliente.Fecha} - Monto {VentaDelCliente.MontoTotal} - Id_Venta {VentaDelCliente.Id} ");
            //    }
            //}

            //var ListadoJoinAgrupadoInner = from C in Clientes
            //                               join V in Ventas on C.Id equals V.Id_Cliente into GrupoDeVentas
            //                               select new
            //                               {
            //                                   C.Nombre,
            //                                   C.Apellido,
            //                                   Ventas = from VC in GrupoDeVentas
            //                                            orderby VC.MontoTotal descending
            //                                            select VC
            //                               };

            //foreach (var Cliente in ListadoJoinAgrupadoInner)
            //{
            //    Console.WriteLine($"Cliente: {Cliente.Nombre}");

            //    foreach (var VentaDelCliente in Cliente.Ventas)
            //    {
            //        Console.WriteLine($"     Fecha {VentaDelCliente.Fecha} - Monto {VentaDelCliente.MontoTotal} - Id_Venta {VentaDelCliente.Id} ");
            //    }
            //}

            //var ListadoOuterJoin = from C in Clientes
            //                       join V in Ventas on C.Id equals V.Id_Cliente into GrupoDeVentas
            //                       select new
            //                       {
            //                           C.Nombre,
            //                           C.Apellido,
            //                           Ventas = GrupoDeVentas.DefaultIfEmpty(
            //                                       new Venta() 
            //                                       { 
            //                                           Id = 0, 
            //                                           MontoTotal = 0, 
            //                                           Observacion="SIN VENTAS"
            //                                       }
            //                                    )
            //                       };

            //foreach (var Cliente in ListadoOuterJoin)
            //{
            //    Console.WriteLine($"Cliente: {Cliente.Nombre}");

            //    foreach (var VentaDelCliente in Cliente.Ventas)
            //    {
            //        Console.WriteLine($"     Observacion {VentaDelCliente.Observacion} Fecha {VentaDelCliente.Fecha} - Monto {VentaDelCliente.MontoTotal} - Id_Venta {VentaDelCliente.Id} ");
            //    }
            //}


            //var ListadoOuterJoin = from C in Clientes
            //                       join V in Ventas on C.Id equals V.Id_Cliente into GrupoDeVentas
            //                       from VC in GrupoDeVentas.DefaultIfEmpty()
            //                       select new
            //                       {
            //                           C.Nombre,
            //                           IdDeVenta = VC?.Id ?? 0,
            //                           Observacion = VC?.Observacion ?? "SIN VENTAS"
            //                       };

            //foreach (var Datos in ListadoOuterJoin)
            //{
            //    Console.WriteLine($"Cliente: {Datos.Nombre}");
            //    Console.WriteLine($"     Observacion {Datos.Observacion}  - Id_Venta {Datos.IdDeVenta} ");
            //}











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

        public struct Cliente
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
