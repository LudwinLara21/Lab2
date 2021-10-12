using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Negocio
{
    class ClsPersona
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
