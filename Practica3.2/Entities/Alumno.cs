using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._2.Entities
{
    internal class Alumno
    {
        double Matricula { get; set; }
        public string Nombre {  get; set; }
        public Materia Materia { get; set; }   
        Random ran = new();
        public Alumno(string nombre, string apellido, int calificacion)
        {
            Matricula = ran.NextDouble()*10000;
            Nombre = nombre + " " + apellido;
            Materia = new Materia(calificacion);
        }
    }
}
/*
 Práctica 3. Aprobados y Reprobados Crea una aplicación que solicite nombres de un alumno y sus respectivas 
calificaciones y los almacene en una lista, dicha aplicación tendrá que sacar a los alumnos que reprobaron 
con una calificación menor que siete y almacenarlos nuevamente en una lista de reprobados, la aplicación debe 
de mostrar a los alumnos que aprobaron y los alumnos que aprobaron.
 */