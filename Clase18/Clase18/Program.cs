using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase18
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

            int[] Numeros = new int[] { 1, 2, 2, 2, 3, 3 };

            //int p = 0;
            //for (int i = 0; i < Numeros.Length; i++)
            //{
            //    p = p + Numeros[i];
            //}

            //Console.WriteLine($"La sumatoria es: {p}");

            //int Resultado = Numeros.Aggregate((p, n) => p + n);
            //Console.WriteLine($"La sumatoria es: {Resultado}");

            //int p = 1;
            //for (int i = 0; i < Numeros.Length; i++)
            //{
            //    p = p * Numeros[i];
            //}

            //Console.WriteLine($"La multiplicación de cada item es: {p}");

            //int Resultado = Numeros.Aggregate(2, (producto, n) => producto + n);
            //Console.WriteLine($"La multiplicación de cada item es: {Resultado}");

            //int Suma = Numeros.Sum();
            //Console.WriteLine($"La sumatoria es: {Suma}");
            //double Promedio = Numeros.Average();
            //Console.WriteLine($"El promedio es: {Promedio}");
            //int Mayor = Numeros.Max();
            //int Menor = Numeros.Min();
            //Console.WriteLine($"El numero mayor es: {Mayor}, y el numero menor es {Menor}");

            //int SumaDeEdades = Clientes.Sum(c => c.Edad);
            //Console.WriteLine($"La suma de las edades es: {SumaDeEdades}");

            //double PromedioDeEdades = Clientes.Average(c => c.Edad);
            //Console.WriteLine($"El promedio de las edades es: {PromedioDeEdades}");

            int Mayor = Clientes.Max(c=> c.Edad);
            int Menor = Clientes.Min(c => c.Edad);
            Console.WriteLine($"La mayor edad es: {Mayor}, y la menor edad es {Menor}");


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
