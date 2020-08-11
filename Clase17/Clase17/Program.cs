using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numero1 = new[] { 1, 2, 2, 2, 3, 3, 4, 5, 6, 5, 6, 5, 4, 2, 1, 2, 8, 9, 5 };
            int[] Numero2 = new[] { 8, 2, 2, 5, 3, 4 };
            int[] Numero3 = new[] { 5, 6, 5, 6, 5, 4, 2, 1, 2, 8, 9, 5 };

            //SKIP (SALTAR)
            //List<int> Datos = Numero1.Skip(7).ToList();
            //Datos.ForEach(n => Console.Write($"{n}, "));

            //TAKE (OBTENER O TOMAR)
            //List<int> Datos = Numero1.Take(5).ToList();
            //Datos.ForEach(n => Console.Write($"{n}, "));

            //SKIP CON TAKE
            //List<int> Datos = Numero1.Skip(7).Take(6).ToList();
            //Datos.ForEach(n => Console.Write($"{n}, "));

            //SKIPWHILE (SALTAR MIENTRAS)
            //List<int> Datos = Numero1.SkipWhile(n => n < 5).ToList();
            //Datos.ForEach(n => Console.Write($"{n}, "));

            //TAKEWHILE(OBTENER MIENTRAS)
            //List<int> Datos = Numero1.TakeWhile(n => n < 5).ToList();
            //Datos.ForEach(n => Console.Write($"{n}, "));

            //SKIPWHILE CON TAKEWHILE
            //List<int> Datos = Numero1.SkipWhile(n => n < 5).TakeWhile(n => n < 8).ToList();
            //Datos.ForEach(n => Console.Write($"{n}, "));

            //CONCAT (CONCATENAR)
            //List<int> Datos = Numero1.Concat(Numero2).ToList();
            //Datos.ForEach(n => Console.Write($"{n}, "));

        }
    }
}
