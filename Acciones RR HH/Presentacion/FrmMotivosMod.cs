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
    public partial class FrmMotivosMod : Form
    {
        public FrmMotivosMod()
        {
            InitializeComponent();
        }

        private void FrmMotivosMod_Load(object sender, EventArgs e)
        {
            Acciones_RR_HH.Datos.Cat_ConsumoVaciones cart = new Datos.Cat_ConsumoVaciones();
            using (SISTEMAEntities context = new SISTEMAEntities())
            {
                dg1.DataSource = context.Cat_ConsumoVaciones.ToList();
    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SISTEMAEntities context = new SISTEMAEntities())
            {
                
                context.SaveChanges();
                context.AcceptAllChanges();
                MessageBox.Show("datos guardados");
            }
        }
    }
}
