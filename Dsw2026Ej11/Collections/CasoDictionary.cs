using Dsw2026Ej11.Domain;
using System;
using System.Collections.Generic;

namespace Dsw2026Ej11.Collections
{
    public class CasoDictionary
    {
        private Dictionary<int, Alumno> _diccionarioAlumnos = new Dictionary<int, Alumno>();

        public void agregarAlumno(Alumno alumno, int clave)
        {
            if (!_diccionarioAlumnos.ContainsKey(clave))
            {
                _diccionarioAlumnos.Add(clave, alumno);
            }
        }

        public Dictionary<int, Alumno> retornarDiccionario()
        {
            return _diccionarioAlumnos;
        }

        public Alumno buscarAlumno(int clave)
        {
            if (_diccionarioAlumnos.ContainsKey(clave))
            {
                return _diccionarioAlumnos[clave];
            }
            return null;
        }

        public void eliminarAlumno(int clave)
        {
            _diccionarioAlumnos.Remove(clave);
        }
    }
}
}
