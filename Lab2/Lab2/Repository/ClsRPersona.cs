using Lab2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Repository
{
    class ClsRPersona
    {
        public void Guardar(persona persona)
        {
            using (almacendepersonasEntities conexionBd = new almacendepersonasEntities())
            {
                try
                {
                    //Para insertar la informacion en la base de datos.
                    conexionBd.persona.Add(persona);

                    //Para guardar los cambios.
                    conexionBd.SaveChanges();
                    MessageBox.Show("Guardado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos" + ex);
                }
            }
        }

        public List<persona> ListOfDataOfTablePersona()
        {
            using (almacendepersonasEntities conexionBd = new almacendepersonasEntities())
            {
                List<persona> ListaOfData = conexionBd.persona.ToList(); // = Selcet * from estudiante
                return ListaOfData;
            }
        }
    }
}
