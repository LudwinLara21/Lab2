using Lab2.Data;
using Lab2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Repository
{
    class ClsRPersona : IPersona
    {
        public void Guardar(persona persona)
        {
            using (almacendepersonasEntities conexionBd = new almacendepersonasEntities())
            {
                try
                {
                    conexionBd.persona.Add(persona);
                    conexionBd.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos" + ex);
                }
            }
        }

        public List<persona> listardatos()
        {
            using (almacendepersonasEntities conexionBd = new almacendepersonasEntities())
            {
                List<persona> ListaOfData = conexionBd.persona.ToList();
                return ListaOfData;
            }
        }
    }
}