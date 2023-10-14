using Practica3._2.Entities;
namespace Practica3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Maestro Gus = new Maestro();
        private void buttonAgregarA_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(string.IsNullOrEmpty(textBoxNombre.Text) ||string.IsNullOrEmpty(textBoxApellido.Text) ||string.IsNullOrEmpty(textBoxCalificacion.Text))
            {
                //Si alguna casilla esta vacia no hace nada
            } 
            else
            {
                int calificacion = int.Parse(textBoxCalificacion.Text);
                if (calificacion < 0 || calificacion > 10)
                {
                    MessageBox.Show("La calificacion debe ser un número entre 0 y 10");
                } else
                {
                    string nombre = textBoxNombre.Text;
                    string apellido = textBoxApellido.Text;

                    Gus.AgregarAlumnoALista(nombre, apellido, calificacion);
                }
            }
            
            foreach (Alumno alumno in Gus.CuartoB)
            {
                listBox1.Items.Add($"{alumno.Nombre} | Materia: {alumno.Materia.Nombre} | Calificación: {alumno.Materia.Calificacion}");
            }
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxCalificacion.Clear();

        }

        private void buttonCalificar_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            Gus.CalificarAlumnos();
           
            foreach (Alumno alumno in Gus.Aprobados)
            {
                listBox2.Items.Add($"{alumno.Nombre} | Materia: {alumno.Materia.Nombre} | Calificación: {alumno.Materia.Calificacion}");
            }
            foreach (Alumno alumno in Gus.Reprobados)
            {
                listBox3.Items.Add($"{alumno.Nombre} | Materia: {alumno.Materia.Nombre} | Calificación: {alumno.Materia.Calificacion}");
            }
        }
    }
}