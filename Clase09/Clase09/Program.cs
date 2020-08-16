using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase09
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes Cliente = new Clientes();

            Cliente.Id = 1;
            Cliente.Nombre = "Leonardo";
            Cliente.Estacion = Estaciones.Invierno;
            Cliente.CodigoError = CodigoDeErrores.SinConexion;

            int[] Numeros = { 1, 2, 3, 4, 5, 6 };

            var NumerosPares = from N in Numeros
                               let NPar = N % 2
                               where NPar == 0
                               where N > 3
                               select N;

            //foreach (var Numero in NumerosPares)
            //{
            //    Console.WriteLine(Numero);
            //}

            List<List<int>> ListadoReal = new List<List<int>>()
            {
               new List<int>(){ 1, 2, 3},
               new List<int>(){ 4, 5, 6},
               new List<int>(){ 7, 8, 9}
            };

            var TodosLosNumeros = from L in ListadoReal
                                  from N in L
                                  let Cuadrado = N * N
                                  where Cuadrado < 50
                                  select Cuadrado;

            foreach (var Numero in TodosLosNumeros)
            {
                Console.WriteLine(Numero);
            }




        }

        enum Estaciones
        {
            Primavera,
            Verano,
            Otoño,
            Invierno
        }

        enum CodigoDeErrores : ushort
        {
            Ninguno = 0,
            Desconocido = 1,
            SinConexion = 100,
            ErrorDeLectura = 200
        }

        struct Clientes
        {
            public int Id { get; set; }
            public string Nombre { get; set; }

            public Estaciones Estacion { get; set; }
            public CodigoDeErrores CodigoError { get; set; }
        }
    }
}
