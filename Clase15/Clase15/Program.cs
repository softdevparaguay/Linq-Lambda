using System;
using System.Linq;

namespace Clase15
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Repetir = Enumerable.Repeat('A', 5);

            //var Repetir = Enumerable.Repeat(3, 8);


            //foreach (var item in Repetir)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //var Rango = Enumerable.Range(1, 10);

            //var Rango = Enumerable.Range(1, 10).Where(n => n % 2 == 0);
            //var Rango = from n in Enumerable.Range(1, 10)
            //            where n % 2 == 0
            //            select n;

            //foreach (var item in Rango)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //var Cuadrado = Enumerable.Range(1, 10).Select(n => n * n);
            //var Cuadrado = from n in Enumerable.Range(1, 10)
            //               select n * n;

            //foreach (var item in Cuadrado)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //Random rng = new Random();
            //var NumerosAleatorios = Enumerable.Range(1, 10).Select(n => rng.Next(1, 100));
            //var NumerosAleatorios = from n in Enumerable.Range(1, 10)
            //                        select rng.Next(1, 100);

            //foreach (var item in NumerosAleatorios)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //var Letras = Enumerable.Range(0, 26).Select(c => ((char)(c + 'a')).ToString());
            //foreach (var item in Letras)
            //{
            //    Console.WriteLine($"{item}");
            //}

            string[] Nombres1 = { "Leo", "Raul", "Guillermo", "Chito", "Alexis", "Antonio", "Pablo", "Germano" };
            string[] Nombres2 = { "Leo", "Raul", "Guillermo", "Chito", "Alexis", "Antonio", "Pablo", "Germano" };
            int[] Numeros = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(Nombres1 == Nombres2);
            //Console.WriteLine(Equals(Nombres1, Nombres2));
            //Console.WriteLine(Nombres1.Equals(Nombres2));
            Console.WriteLine(Nombres1.SequenceEqual(Nombres2));
            //Console.WriteLine(Nombres1.SequenceEqual(Numeros));





        }
    }
}















