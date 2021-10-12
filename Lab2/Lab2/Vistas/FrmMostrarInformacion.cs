using Lab2.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Vistas
{
    public partial class FrmMostrarInformacion : Form
    {
        public FrmMostrarInformacion()
        {
            InitializeComponent();
        }

        private void ListPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClsPersona persona = new ClsPersona();
            var ok = persona.listardatos();

            foreach (var iterar in ok)
            {
                ListPersona.Rows.Add(iterar.nombrePersona, iterar.edadPersona, iterar.descripcionPersona);
            }
        }
    }
}
