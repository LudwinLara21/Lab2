using Lab2.Data;
using Lab2.Negocio;
using Lab2.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object Guardado { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            persona per = new persona();
            per.nombrePersona = txtNombre.Text;
            per.edadPersona = int.Parse(txtEdad.Text);
            per.descripcionPersona = txtDescripcion.Text;

            ClsPersona clspersona = new ClsPersona();
            clspersona.Guardando(per);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMostrarInformacion formulario = new FrmMostrarInformacion();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que quieres salir?", "Estas por cerrar la ventana", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes) { 
            
                Application.Exit();
            }
        }
    }
}
