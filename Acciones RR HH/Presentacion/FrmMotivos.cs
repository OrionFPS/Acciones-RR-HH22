using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Acciones_RR_HH.Datos;

namespace Acciones_RR_HH.Presentacion
{
    public partial class FrmMotivos : Form
    {
        public FrmMotivos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se crea el objeto del nuevo registro
            Acciones_RR_HH.Datos.Cat_ConsumoVaciones catVac = new Acciones_RR_HH.Datos.Cat_ConsumoVaciones();
            //se le asignan los datos del form
            catVac.Nombre = nombre.Text;
            catVac.Descripción = descipcion.Text;

            //con este codigo se guardan los datos en la BD
            using (SISTEMAEntities context = new SISTEMAEntities())
            {
                context.Cat_ConsumoVaciones.AddObject(catVac);
                context.SaveChanges();
                MessageBox.Show("datos guardados");
            }
            
        }

        private void FrmMotivos_Load(object sender, EventArgs e)
        {

        }
    }
}
