using SchedBrains.Helpers;
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
    public partial class FrmPadrao : Form
    {
        public FrmPadrao()
        {
            InitializeComponent();
        }

        private void FrmPadrao_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                dr = MessageBox.Show("Tem certeza de que deseja sair?", "SchedBrain", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);


            if (dr == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
