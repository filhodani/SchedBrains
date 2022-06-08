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

        private void btnTarefa_Click(object sender, EventArgs e)
        {
            FrmTarefa frmTarefa = new FrmTarefa();
            frmTarefa.ShowDialog();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {

        }
    }
}
