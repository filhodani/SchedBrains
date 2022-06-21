using SchedBrains.Helpers;
using SchedBrains.Model;
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
    public partial class UscEvento : UserControl
    {
        public UscEvento()
        {
            InitializeComponent();
        }

        public void Carregar(Evento e)
        {
            IdEvento = e.Id;

            Imagem = e.Imagem;
            if (Imagem != null && File.Exists(Imagem))
                pcbImgEvento.Image = new Bitmap(Imagem);
            else
                pcbImgEvento.Image = Properties.Resources.landscape;

            Titulo = e.Titulo;
            Local = e.Local;
            Descricao = e.Descricao;

            DataInicio = $"Início: { e.DataInicio.ToString().Substring(0, 16)}";
            DataTermino = $"Término: { e.DataTermino.ToString().Substring(0, 16)}";

            Situacao = e.Situacao.ToString();
            if (Situacao != SituacaoTarefa.Concluído.ToString())
            {
                mnuEditar.Visible = true;
                mnuConcluir.Visible = true;
            }
            else
            {
                this.BackColor = Color.FromArgb(230, 235, 235);
                lblTitulo.ForeColor = Color.DarkGreen;
                lblSituacao.ForeColor = Color.DarkGreen;

                mnuEditar.Visible = false;
                mnuConcluir.Visible = false;
            }
        }

        public int IdEvento { get; set; }

        public FrmEvento frmEvento { get; set; }

        public string? Imagem { get; set; }

        public string Titulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }
        public string Local
        {
            get { return lblLocal.Text; }
            set { lblLocal.Text = value; }
        }
        public string Descricao
        {
            get { return lblDescricao.Text; }
            set { lblDescricao.Text = value; }
        }
        public string DataInicio
        {
            get { return lblDataInicio.Text; }
            set { lblDataInicio.Text = value; }
        }
        public string DataTermino
        {
            get { return lblDataTermino.Text; }
            set { lblDataTermino.Text = value; }
        }
        public string Situacao
        {
            get { return lblSituacao.Text; }
            set { lblSituacao.Text = value; }
        }

        private void mnuEditar_Click(object sender, EventArgs e)
        {
            if (Situacao != SituacaoEvento.Concluído.ToString())
                frmEvento.editarEvento(IdEvento, this);
        }

        private void mnuConcluir_Click(object sender, EventArgs e)
        {
            if (Situacao != SituacaoEvento.Concluído.ToString())
            {
                DialogResult dr;
                using (DialogCenteringService centeringService = new DialogCenteringService(frmEvento)) // center message box
                    dr = MessageBox.Show("Tem certeza de que deseja concluir este evento?", "SchedBrains", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                    frmEvento.concluirEvento(IdEvento, this);
            }
        }

        private void mnuExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            using (DialogCenteringService centeringService = new DialogCenteringService(frmEvento)) // center message box
                dr = MessageBox.Show("Tem certeza de que deseja excluir este evento?", "SchedBrains", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                frmEvento.excluirEvento(IdEvento);
                Parent.Controls.Remove(this);
            }
        }
    }
}
