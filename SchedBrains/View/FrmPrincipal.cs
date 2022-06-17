using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedBrains.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuContatos_Click(object sender, EventArgs e)
        {
            FrmContato frmContato = new FrmContato();
            frmContato.ShowDialog();
        }

        private void mnuEventos_Click(object sender, EventArgs e)
        {
            FrmEvento frmEvento = new FrmEvento();
            frmEvento.ShowDialog();
        }

        private void mnuTarefas_Click(object sender, EventArgs e)
        {
            FrmTarefa frmTarefa = new FrmTarefa();
            frmTarefa.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
