using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._2.Entities
{
    internal class Materia
    {
        string[] Materias = {"Programación","Matemáticas","Español","Taller Lectura","Diseño de Apps","Servicios WEB","Estructura de Datos","Inglés","IoT"}; //9
        public string Nombre { get; set; }
        public int Calificacion {  get; set; }
        Random ran = new();
        public Materia(int calificacion) 
        {
            Nombre = Materias[6];
            //Nombre = Materias[ran.Next(0, 10)];
            Calificacion = calificacion;
        }
    }
}
