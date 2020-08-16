using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase13
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
                new Cliente("Tod", "Vachev", 13, 180, 26, Genero.Masculino,Ciudad.CiudadDelEste),
                new Cliente("Tod2", "Vachev2", 14, 180, 26, Genero.Masculino,Ciudad.CiudadDelEste)
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


            //int[] Numeros = { 5, 6, 3, 2, 1, 5, 7, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            //var AgrupacionPorGenero = Clientes.GroupBy(c => c.Genero);
            ////from c in Clientes
            ////group c by c.Genero;

            //foreach (var ClienteAgrupado in AgrupacionPorGenero)
            //{
            //    Console.WriteLine($"Genero: {ClienteAgrupado.Key}");

            //    foreach (var Cliente in ClienteAgrupado)
            //    {
            //        Console.WriteLine($"    Cliente: {Cliente.Nombre}");
            //    }
            //}


            //var Agrupacion = Clientes
            //                   .Where(c => c.Edad > 20)
            //                   .GroupBy(a => a.Edad);


            //foreach (var ClienteAgrupado in Agrupacion)
            //{
            //    Console.WriteLine($"Edad: {ClienteAgrupado.Key}");

            //    foreach (var Cliente in ClienteAgrupado)
            //    {
            //        Console.WriteLine($"    Cliente: {Cliente.Nombre} , Genero: {Cliente.Genero} , Edad: {Cliente.Edad}");
            //    }
            //}

            //var Agrupacion = Clientes
            //                   .OrderBy(c => c.Nombre)
            //                   .GroupBy(c => c.Nombre[0]);

            //foreach (var ClienteAgrupado in Agrupacion)
            //{
            //    Console.WriteLine($"{ClienteAgrupado.Key}");

            //    foreach (var Cliente in ClienteAgrupado)
            //    {
            //        Console.WriteLine($"    Cliente: {Cliente.Nombre} , Genero: {Cliente.Genero} , Edad: {Cliente.Edad}");
            //    }
            //}

            //var Agrupacion = Clientes.GroupBy(c => new { c.Ciudad, c.Genero, c.Edad });

            //foreach (var ClienteAgrupado in Agrupacion)
            //{
            //    Console.WriteLine($"Genero: {ClienteAgrupado.Key.Genero}, Edad: {ClienteAgrupado.Key.Edad}, Ciudad: {ClienteAgrupado.Key.Ciudad}");

            //    foreach (var Cliente in ClienteAgrupado)
            //    {
            //        Console.WriteLine($"    Cliente: {Cliente.Nombre} , Genero: {Cliente.Genero} , Edad: {Cliente.Edad}");
            //    }
            //}


            //var Agrupacion = Clientes.
            //                   GroupBy(c => new { c.Ciudad, c.Genero, c.Edad }).
            //                   OrderBy(key => key.Count());

            //foreach (var ClienteAgrupado in Agrupacion)
            //{
            //    Console.WriteLine($"{ClienteAgrupado.Key}");

            //    foreach (var Cliente in ClienteAgrupado)
            //    {
            //        Console.WriteLine($"    Cliente: {Cliente.Nombre} , Genero: {Cliente.Genero} , Edad: {Cliente.Edad}");
            //    }
            //}


            //var Agrupacion = Numeros.
            //                    OrderBy(n => n).
            //                    GroupBy(n => (n % 2 == 0) ? "Par" : "Impar").
            //                    OrderBy(key => key.Count());

            //foreach (var NumerosAgrupados in Agrupacion)
            //{
            //    Console.WriteLine($"{NumerosAgrupados.Key}");

            //    foreach (var Numero in NumerosAgrupados)
            //    {
            //        Console.WriteLine($"    {Numero}");
            //    }
            //}


            //var Agrupaciones = Clientes.OrderBy(c=>c.Edad).GroupBy(c => c.Edad < 10 
            //                                                            ? "Niños" 
            //                                                            : c.Edad >= 10 && c.Edad <= 20 
            //                                                                ? "Adolecente" 
            //                                                                : "Señor");

            //foreach (var ClienteAgrupado in Agrupaciones)
            //{
            //    Console.WriteLine($"{ClienteAgrupado.Key}");

            //    foreach (var Cliente in ClienteAgrupado)
            //    {
            //        Console.WriteLine($"    Cliente: {Cliente.Nombre} , Genero: {Cliente.Genero} , Edad: {Cliente.Edad}");
            //    }
            //}

            //var Agrupacion = Clientes.
            //                 GroupBy(c => c.Genero).
            //                 OrderBy(c => c.Count()).
            //                 Select(c => new { Genero = c.Key, Cantidad = c.Count() });


            //foreach (var CantidadAgrupada in Agrupacion)
            //{
            //    Console.WriteLine($"{CantidadAgrupada.Genero}");
            //    Console.WriteLine($"{CantidadAgrupada.Cantidad}");
            //}

            //var InnerJoin = Ventas.Join(Clientes, 
            //                            v => v.Id_Cliente, c => c.Id,
            //                            (v, c) => new
            //                            {
            //                                CodigoDeVenta = v.Id,
            //                                NombreCliente = c.Nombre
            //                            });


            //foreach (var Item in InnerJoin)
            //{
            //    Console.WriteLine($"Codigo de la venta: {Item.CodigoDeVenta} pertenece a: {Item.NombreCliente}");
            //}


            //var InnerJoinMultiplesLLaves = Ventas.Join(Clientes,
            //                                 v => new { Id_Cliente = v.Id_Cliente, Ciudad = v.CiudadDeVenta },
            //                                 c => new { Id_Cliente = c.Id, Ciudad = c.Ciudad },
            //                                 (v, c) => new
            //                                 {
            //                                     CodigoDeVenta = v.Id,
            //                                     NombreCliente = c.Nombre
            //                                 });

            //foreach (var Item in InnerJoinMultiplesLLaves)
            //{
            //    Console.WriteLine($"Codigo de la venta: {Item.CodigoDeVenta} pertenece a: {Item.NombreCliente}");
            //}

            var GroupJoin = Clientes.GroupJoin(Ventas,
                                               c => c.Id,
                                               v => v.Id_Cliente,
                                               (c, GrupoDeVentas) => new
                                               {
                                                   NombreCliente = c.Nombre,
                                                   CiudadDelCliente = c.Ciudad,
                                                   ListadoDeVentas = GrupoDeVentas.OrderByDescending(v => v.MontoTotal)
                                               });

            //foreach (var Cliente in GroupJoin)
            //{
            //    Console.WriteLine($"Cliente: {Cliente.NombreCliente}, Ciudad: {Cliente.CiudadDelCliente} \nVentas:");

            //    foreach (var Venta in Cliente.ListadoDeVentas)
            //    {
            //        Console.WriteLine($"    Id_Venta: {Venta.Id} Monto: {Venta.MontoTotal}");
            //    }
            //}


            //var GroupLeftOuterJoin = Clientes.GroupJoin(Ventas,
            //                                               c => c.Id,
            //                                               v => v.Id_Cliente,
            //                                               (c, GrupoDeVentas) => new
            //                                               {
            //                                                   NombreCliente = c.Nombre,
            //                                                   CiudadDelCliente = c.Ciudad,
            //                                                   ListadoDeVentas = GrupoDeVentas.DefaultIfEmpty(new Venta(0, new DateTime(1, 1, 1), 0, c.Id, Ciudad.CiudadDelEste, "SIN VENTAS"))
            //                                               });


            //foreach (var Cliente in GroupLeftOuterJoin)
            //{
            //    Console.WriteLine($"Cliente: {Cliente.NombreCliente}, Ciudad: {Cliente.CiudadDelCliente} \nVentas:");

            //    foreach (var Venta in Cliente.ListadoDeVentas)
            //    {
            //        Console.WriteLine($"    Id_Venta: {Venta.Id} Monto: {Venta.MontoTotal} Observacion: {Venta.Observacion}");
            //    }
            //}


            //var GroupLeftOuterJoin = Clientes.GroupJoin(Ventas,
            //                                               c => c.Id,
            //                                               v => v.Id_Cliente,
            //                                               (c, GrupoDeVentas) => new
            //                                               {
            //                                                   NombreCliente = c.Nombre,
            //                                                   CiudadDelCliente = c.Ciudad,
            //                                                   ListadoDeVentas = GrupoDeVentas
            //                                               }).SelectMany(c => c.ListadoDeVentas.DefaultIfEmpty(),
            //                                               (c, v) => new
            //                                               {
            //                                                   c.NombreCliente,
            //                                                   c.CiudadDelCliente,
            //                                                   Id_Venta = v?.Id ?? 0,
            //                                                   Observacion = v?.Observacion ?? "SIN VENTAS"
            //                                               });


            //foreach (var ClienteYVenta in GroupLeftOuterJoin)
            //{
            //    Console.WriteLine($"Cliente: {ClienteYVenta.NombreCliente}, Ciudad: {ClienteYVenta.CiudadDelCliente}");
            //    Console.WriteLine($"     Id_Venta: {ClienteYVenta.Id_Venta}, Observacion: {ClienteYVenta.Observacion}");
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