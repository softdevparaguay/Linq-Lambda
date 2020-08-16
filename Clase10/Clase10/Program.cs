using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> Clientes = new List<Cliente>()
            {
                new Cliente("Leo","Testa",1,180,26,Genero.Masculino),
                new Cliente("John", "Johnson", 2, 170, 21, Genero.Masculino),
                new Cliente("Anna", "Maria", 3, 150, 22, Genero.Femenino),
                new Cliente("Kyle", "Wilson", 4, 164, 29, Genero.Femenino),
                new Cliente("Anna", "Williams", 5, 164, 28, Genero.Femenino),
                new Cliente("Maria", "Ann", 6, 160, 19, Genero.Femenino),
                new Cliente("John", "Jones", 7, 160, 22, Genero.Masculino),
                new Cliente("Samba", "TheLion", 8, 175, 23, Genero.Masculino),
                new Cliente("Aaron", "Myers", 9, 182, 21, Genero.Masculino),
                new Cliente("Aby", "Wood", 10, 165, 20, Genero.Femenino),
                new Cliente("Maddie","Lewis",  11, 160, 19, Genero.Femenino),
                new Cliente("Lara", "Croft", 12, 162, 23, Genero.Femenino),
                new Cliente("Tod", "Vachev", 13, 180, 26, Genero.Masculino)
            };




            //var AgrupacionPorGenero = from P in Personas
            //                          group P by P.Genero;


            //foreach (var Agrupacion in AgrupacionPorGenero)
            //{
            //    Console.WriteLine($"{Agrupacion.Key}");
            //}

            //foreach (var Agrupacion in AgrupacionPorGenero)
            //{
            //    Console.WriteLine($"{Agrupacion.Key}");

            //    foreach (var Persona in Agrupacion)
            //    {
            //        Console.WriteLine($"     {Persona.Nombre} {Persona.Apellido}");
            //    }
            //}


            //var AgrupacionPorGeneroMayoresDe20Anos = from P in Personas
            //                                         where P.Edad>20
            //                                         group P by P.Genero;

            //foreach (var Agrupacion in AgrupacionPorGeneroMayoresDe20Anos)
            //{
            //    Console.WriteLine($"{Agrupacion.Key}");

            //    foreach (var Persona in Agrupacion)
            //    {
            //        Console.WriteLine($"     {Persona.Nombre} {Persona.Apellido}");
            //    }
            //}

            //var AgrupacionAlfabeto = from P in Personas
            //                         orderby P.Nombre
            //                         group P by P.Nombre[0];


            //foreach (var Agrupacion in AgrupacionAlfabeto)
            //{
            //    Console.WriteLine($"{Agrupacion.Key}");

            //    foreach (var Persona in Agrupacion)
            //    {
            //        Console.WriteLine($"     {Persona.Nombre} {Persona.Apellido}");
            //    }
            //}

            //var MultipleAgrupacion = from P in Personas
            //                         group P by new { P.Genero, P.Edad };

            //foreach (var Agrupacion in MultipleAgrupacion)
            //{
            //    Console.WriteLine($"{Agrupacion.Key}");

            //    foreach (var Persona in Agrupacion)
            //    {
            //        Console.WriteLine($"     {Persona.Nombre} {Persona.Apellido}");
            //    }
            //}

            //var MultipleAgrupacion = from P in Personas
            //                         group P by new { P.Genero, P.Edad };

            //var MultipleAgrupacionOrdenadoPorCantidad = from PKey in MultipleAgrupacion
            //                                            orderby PKey.Count() descending
            //                                            select PKey;

            //foreach (var Agrupacion in MultipleAgrupacionOrdenadoPorCantidad)
            //{
            //    Console.WriteLine($"Genero: {Agrupacion.Key.Genero}, Edad: {Agrupacion.Key.Edad}, Cantidad: {Agrupacion.Count()}" );

            //    foreach (var Persona in Agrupacion)
            //    {
            //        Console.WriteLine($"     {Persona.Nombre} {Persona.Apellido}");
            //    }
            //}

            //var OrdenarPorLLave = from P in Personas
            //                      group P by P.Edad into AgrupacionPorEdad
            //                      orderby AgrupacionPorEdad.Key descending
            //                      select AgrupacionPorEdad;

            //foreach (var Agrupacion in OrdenarPorLLave)
            //{
            //    Console.WriteLine($"{Agrupacion.Key}");
            //    foreach (var Item in Agrupacion)
            //    {
            //        Console.WriteLine($"    {Item.Nombre}");
            //    }
            //}

            //int[] Numeros = { 5, 6, 3, 2, 1, 5, 7, 234, 54, 14, 653, 3, 4, 5, 6, 7 };

            //var NumerosAgrupados = from Num in Numeros
            //                       orderby Num
            //                       let ParOImpar = (Num % 2 == 0) ? "Par" : "Impar"
            //                       group Num by ParOImpar into NumerosParesEImpares
            //                       orderby NumerosParesEImpares.Count() descending
            //                       select NumerosParesEImpares;


            //foreach (var Agrupacion in NumerosAgrupados)
            //{
            //    Console.WriteLine($"{Agrupacion.Key}");
            //    foreach (var Numero in Agrupacion)
            //    {
            //        Console.WriteLine($"    {Numero}");
            //    }
            //}

            //var PersonasConMultiplesAgrupaciones = from P in Personas
            //                                       let SeleccionPorEdad =
            //                                                P.Edad < 20 
            //                                                    ? "Joven" 
            //                                                    : P.Edad >= 20 && P.Edad <= 22 
            //                                                        ? "Adulto" 
            //                                                        : "Anciano"
            //                                       group P by SeleccionPorEdad;

            //foreach (var Agrupacion in PersonasConMultiplesAgrupaciones)
            //{
            //    Console.WriteLine($"{Agrupacion.Key}");
            //    foreach (var Persona in Agrupacion)
            //    {
            //        Console.WriteLine($"    {Persona.Nombre}");
            //    }
            //}

            //var CantidadEnCadaGrupo = from P in Personas
            //                          group P by P.Genero into AgrupacionPorGenero
            //                          orderby AgrupacionPorGenero.Count()
            //                          select new { Genero = AgrupacionPorGenero.Key, Cantidad = AgrupacionPorGenero.Count() };

            //foreach (var Agrupacion in CantidadEnCadaGrupo)
            //{
            //    Console.WriteLine($"Genero: {Agrupacion.Genero} - Cantidad: {Agrupacion.Cantidad}");
            //}























































        }

        public struct Ventas
        {
            public int Id { get; set; }
            public DateTime Fecha { get; set; }
            public double MontoTotal { get; set; }
            public int Id_Cliente { get; set; }

            public Ventas(int Id, DateTime Fecha, double MontoTotal, int Id_Cliente)
            {
                this.Id = Id;
                this.Fecha = Fecha;
                this.MontoTotal = MontoTotal;
                this.Id_Cliente = Id_Cliente;
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

            public Cliente(string Nombre, string Apellido, int Id, int Altura, int Edad, Genero Genero)
            {
                this.Id = Id;
                this.Nombre = Nombre;
                this.Apellido = Apellido;
                this.Altura = Altura;
                this.Edad = Edad;
                this.Genero = Genero;
            }
        }

        public enum Genero
        {
            Masculino,
            Femenino
        }

    }
}
