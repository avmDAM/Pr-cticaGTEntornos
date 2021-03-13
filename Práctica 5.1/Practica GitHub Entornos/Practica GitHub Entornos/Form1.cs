using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Practica_GitHub_Entornos
{
    public partial class Form1 : Form
    {
        Alumnos misAlumnos = new Alumnos();
        public Form1()
        {
            InitializeComponent();
        }
        
        class Alumno
        {
            private string nombre;
            private int nota;
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public int Nota
            {
                get { return nota; }
                set
                {
                    if (value >= 0 && value <= 10)
                        nota = value;
                }
            }
            public Boolean Aprobado
            {
                get
                {
                    if (nota >= 5)
                        return true;
                    else
                        return false;
                }
            }
        }
        class Alumnos
        {
            private ArrayList listaAlumnos = new ArrayList();

            // Agrega un nuevo alumno a la lista
            //        
            public void Agregar(Alumno alu)
            {
                listaAlumnos.Add(alu);
            }

            // Devuelve el alumno que está en la posición num
            //
            public Alumno Obtener(int num)
            {
                if (num >= 0 && num <= listaAlumnos.Count)
                {
                    return ((Alumno)listaAlumnos[num]);
                }
                return null;
            }

            // Devuelve la nota media de los alumnos
            //
            public float Media
            {
                get
                {
                    if (listaAlumnos.Count == 0)
                        return 0;
                    else
                    {
                        float media = 0;
                        for (int i = 0; i < listaAlumnos.Count; i++)
                        {
                            media += ((Alumno)listaAlumnos[i]).Nota;
                        }
                        return (media / listaAlumnos.Count);
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aluNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void aluNota_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaAlumnos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno miAlumno = new Alumno();
            string miAlumnoStr, miAlumnoNotaText;

            miAlumno.Nombre = aluNombre.Text;
            miAlumno.Nota = Convert.ToInt32(aluNota.Text);
            if (miAlumno.Nota < 5)
            {
                miAlumnoNotaText = "Suspenso";
            }
            else if (miAlumno.Nota >= 5 && miAlumno.Nota < 6)
            {
                miAlumnoNotaText = "Aprobado";
            }
            else if (miAlumno.Nota >= 6 && miAlumno.Nota < 7)
            {
                miAlumnoNotaText = "Bien";
            }
            else if (miAlumno.Nota >=7 && miAlumno.Nota < 9)
            {
                miAlumnoNotaText = "Notable";
            }
            else
            {
                miAlumnoNotaText = "Sobresaliente";
            }

            miAlumnoStr = aluNombre.Text + " " + aluNota.Text + " " +
            miAlumnoNotaText + Environment.NewLine;
            listaAlumnos.AppendText(miAlumnoStr);
            misAlumnos.Agregar(miAlumno);
        }

        

        



    }
}
