using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dsw2026Ej11.Collections
{
    public class CasoList
    {
        private List<Alumno> _listaAlumnos = new List<Alumno>();

        public void addAlumno(Alumno alumno)
        {
            _listaAlumnos.Add(alumno);
        }

        public List<Alumno> retornarAlumnos()
        {
            return _listaAlumnos;
        }

        public Alumno buscarPorNombre(string nombre)
        {
            foreach (var alu in _listaAlumnos)
            {
                if (alu.Nombre == nombre)
                {
                    return alu;
                }
            }
            return null;
        }

        public void eliminarAlumno(Alumno alumno)
        {
            _listaAlumnos.Remove(alumno);
        }

        public void eliminarAlumnoIndex(int index)
        {
            if (index >= 0 && index < _listaAlumnos.Count)
            {
                _listaAlumnos.RemoveAt(index);
            }
        }
    }
}
}
