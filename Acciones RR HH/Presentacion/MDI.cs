using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Acciones_RR_HH
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void controlDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acciones_RR_HH.Presentacion.FrmMotivos frm = new Presentacion.FrmMotivos();
            frm.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acciones_RR_HH.Presentacion.FrmMotivosMod frm = new Presentacion.FrmMotivosMod();
            frm.Show();
        }
    }
}
