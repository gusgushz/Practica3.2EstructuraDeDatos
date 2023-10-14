using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._2.Entities
{
    internal class Maestro
    {
        public List<Alumno> CuartoB = new();
        public List<Alumno> Reprobados = new();
        public List<Alumno> Aprobados = new();
        public void AgregarAlumnoALista(string nombre, string apellido, int calificacion)
        {
            CuartoB.Add(new Alumno(nombre, apellido, calificacion));
        }
        public void CalificarAlumnos()
        {
            foreach (Alumno alumno in CuartoB)
            {
                if(Reprobados.Contains(alumno)|| Aprobados.Contains(alumno))
                {
                    //si ya existe el alumno en alguna de las listas no hace nada, pero si no existe lo agrega a alguna
                } 
                else
                {
                    if (alumno.Materia.Calificacion < 7)
                    {
                        Reprobados.Add(alumno);
                    }
                    else
                    {
                        Aprobados.Add(alumno);
                    }
                }
            }
        }
    }
}
