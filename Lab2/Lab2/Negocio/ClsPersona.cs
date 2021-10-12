using Lab2.Data;
using Lab2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Negocio
{
    class ClsPersona : ClsRPersona
    {
        public void Guardando(persona per)
        {
            if (per.edadPersona <= 17)
            {
                MessageBox.Show("¡Eres menor de edad!");
            }
            else
            {
                Guardar(per);
                MessageBox.Show("Guardado");
            }
        }
    }
}
