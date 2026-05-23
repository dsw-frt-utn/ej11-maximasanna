using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dsw2026Ej11.Collections
{
    public static class CasoLinq
    {
        private static List<Libro> _libros = Repository.GetLibros();

        public static double GetTotalPrecio()
        {
            return _libros.Sum(x => x.Precio);
        }

        public static Libro GetPrimero()
        {
            return _libros.First();
        }

        public static Libro GetUltimo()
        {
            return _libros.Last();
        }

        public static double GetMenorPrecio()
        {
            return _libros.Min(x => x.Precio);
        }

        public static double GetMayorPrecio()
        {
            return _libros.Max(x => x.Precio);
        }

        public static double GetPromedioPrecios()
        {
            return _libros.Average(x => x.Precio);
        }

        public static List<Libro> GetMayorPromedio()
        {
            double promedio = GetPromedioPrecios();
            return _libros.Where(x => x.Precio > promedio).ToList();
        }

        public static List<Libro> GetListById()
        {
            return _libros.Where(x => x.Id > 15).ToList();
        }

        public static List<Libro> GetLibros()
        {
            return _libros;
        }

        public static List<Libro> Ordenar()
        {
            return _libros.OrderByDescending(x => x.Precio).ToList();
        }
    }
}