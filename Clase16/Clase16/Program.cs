using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase16
{
    class Program
    {
        static void Main(string[] args)
        {
            string ElPerro = "Yo Soy Un Perro";
            string ElGato = "Yo Soy Un Gato";
            string Nada = "";

            List<int> Numeros1 = new List<int>() { 1, 2, 2, 2, 3, 3, 4, 5, 5, 6, 3, 5, 6, 7, 8, 8, 4, 3 };
            List<int> Numeros2 = new List<int>() { 3, 2, 3, 5, 8, 43, 5, 67, 1, 2, 3, 7, 7, 7, 6, 5, 2, 1 };
            List<int> Numeros3 = new List<int>() { 2, 4, 7, 8, 10, 5 };

            //Contains()
            //Console.WriteLine(ElGato.Contains('P'));
            //Console.WriteLine(Numeros1.Contains(99));

            //Any
            //Console.WriteLine(ElPerro.Any());
            //Console.WriteLine(Nada.Any());

            //Any()
            //var AlgunoCumple = ElGato.Any(c => c.Equals('a'));
            //Console.WriteLine(AlgunoCumple);

            //var AlgunoCumple = Numeros3.Any(n => n % 3 == 0);
            //Console.WriteLine(AlgunoCumple);

            //All()
            //var TodosCumplen = ElPerro.All(c => c.Equals('a'));
            //Console.WriteLine(TodosCumplen);

            //var TodosCumplen = Numeros1.All(n => n > 0);
            //Console.WriteLine(TodosCumplen);

            //var TodosCumplen = Numeros3.All(n => n % 2 == 0);
            //Console.WriteLine(TodosCumplen);


            //Distinct()
            //var DistintosString = ElPerro.Distinct();
            //Console.WriteLine(string.Join(',', DistintosString));

            //var DistintosString2 = ElGato.Distinct();
            //Console.WriteLine(string.Join(',', DistintosString2));

            //var DistintosInt1 = Numeros1.Distinct();
            //Console.WriteLine(string.Join(',', DistintosInt1));

            //var DistintosInt2 = Numeros2.Distinct();
            //Console.WriteLine(string.Join(',', DistintosInt2));

            //Intersect()
            //var Interseccion1 = ElPerro.Intersect(ElGato);
            //Console.WriteLine(string.Join(',', Interseccion1));

            //var Interseccion2 = Numeros1.Intersect(Numeros2);
            //Console.WriteLine(string.Join(',', Interseccion2));

            //Union()
            //var Union1 = ElPerro.Union(ElGato);
            //Console.WriteLine(string.Join(',', Union1));

            //var Union2 = Numeros1.Union(Numeros2);
            //Console.WriteLine(string.Join(',', Union2));

            //var Union3 = ElGato.Union(ElPerro);
            //Console.WriteLine(string.Join(',', Union3));

            //Except()
            //var Except = ElPerro.Except(ElGato);
            //Console.WriteLine(string.Join(',', Except));

            //var Except2 = ElGato.Except(ElPerro);
            //Console.WriteLine(string.Join(',', Except2));

            //var Except3= Numeros1.Except(Numeros2);
            //Console.WriteLine(string.Join(',', Except3));

            //var Except4= Numeros2.Except(Numeros1);
            //Console.WriteLine(string.Join(',', Except4));




        }
    }
}
