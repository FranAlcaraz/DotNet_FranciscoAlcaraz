using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP6___Ejercicio
{
    public partial class Form1 : Form
    {
        List<string> misNotas = new List<string>();
        List<string> alumnos = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            llenarComboBox();
        }

        private void llenarComboBox()
        {
            List<Materia> listaMaterias = new List<Materia>()
            {
                new Materia { Nombre = "Base de Datos III"},
                new Materia { Nombre = "Analisis y metodologia de sistemas"},
                new Materia { Nombre = "Redes y comunicacion" },
                new Materia { Nombre = "Aplicaciones Moviles"},
                new Materia { Nombre = "Plataformas de Desarrollo"}
            };

            comboMateria.DataSource = listaMaterias;

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            string legajo;
            string fecha;
            string nota;
            string materia;

            
            nombre = txt_nombre.Text;
            apellido = txt_apellido.Text;
            legajo = txt_legajo.Text;
            fecha = txt_fecha.Text;
            nota = txt_nota.Text;
            materia = comboMateria.Text;
            
            misNotas.Add(materia);
            misNotas.Add(fecha);
            misNotas.Add(nota);

            listAlumnos.DataSource = null;
            listAlumnos.DataSource = misNotas;
            alumnos.Add(nombre);
            alumnos.Add(apellido);
            alumnos.Add(legajo);
            alumnos.Add(materia);
            alumnos.Add(fecha);
            alumnos.Add(nota);

            comboMateria.Refresh();
            txt_fecha.Clear();
            txt_nota.Clear();

            listNotas.DataSource = null;
            listNotas.DataSource = alumnos;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  }

        private void limpiarNotas_Click(object sender, EventArgs e)
        {
            listAlumnos.DataSource = null;
        }
    }
}
