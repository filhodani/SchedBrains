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
    public partial class UscTarefa : UserControl
    {
        public UscTarefa()
        {
            InitializeComponent();
        }

        public void Carregar(Tarefa t)
        {
            IdTarefa = t.Id;
            TituloTarefa = t.Titulo;

            var prioridade = t.Prioridade;
            var situacao = t.Situacao;

            Situacao = t.Situacao.ToString();

            if (situacao == SituacaoTarefa.Pendente)
            {
                if (prioridade == PrioridadeTarefa.Alta)
                    lblTitulo.ForeColor = Color.Crimson;
                else if (prioridade == PrioridadeTarefa.Média)
                    lblTitulo.ForeColor = Color.DodgerBlue;
                else if (prioridade == PrioridadeTarefa.Baixa)
                    lblTitulo.ForeColor = Color.LimeGreen;

                //lblSituacao.ForeColor = Color.Chocolate;
                mnuEditar.Visible = true;
                mnuConcluir.Visible = true;
            }
            else if (situacao == SituacaoTarefa.Concluído)
            {
                this.BackColor = Color.FromArgb(230, 235, 235);
                lblTitulo.ForeColor = Color.DarkGreen;
                lblSituacao.ForeColor = Color.DarkGreen;

                mnuEditar.Visible = false;
                mnuConcluir.Visible = false;
            }


            if (t.DataMaximaConclusao != null)
                DataConclusao = t.DataMaximaConclusao.Value.ToString().Substring(0, 16);
            else
                DataConclusao = "";


            string descricao = "";
            if (t.Descricao != null)
                if (t.Descricao.Length > 500)
                    descricao = $"{t.Descricao.ToString().Substring(0, 500)}...";
                else
                    descricao = t.Descricao;

            DescricaoTarefa = descricao;
        }

        public int IdTarefa { get; set; }

        public string TituloTarefa
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value; }
        }

        public string DescricaoTarefa
        {
            get { return lblDescricao.Text; }
            set { lblDescricao.Text = value; }
        }

        public string DataConclusao
        {
            get { return lblData.Text; }
            set { lblData.Text = value; }
        }
        public string Situacao
        {
            get { return lblSituacao.Text; }
            set { lblSituacao.Text = value; }
        }

        public FrmTarefa frmTarefa { get; set; }

        private void mnuEditar_Click(object sender, EventArgs e)
        {
            if (Situacao != SituacaoTarefa.Concluído.ToString())
            {
                frmTarefa.editarTarefa(IdTarefa, this);
            }
        }

        private void mnuConcluir_Click(object sender, EventArgs e)
        {
            if (Situacao != SituacaoTarefa.Concluído.ToString())
            {
                DialogResult dr;
                using (DialogCenteringService centeringService = new DialogCenteringService(frmTarefa)) // center message box
                    dr = MessageBox.Show("Tem certeza de que deseja concluir esta tarefa?", "SchedBrains", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.OK)
                    frmTarefa.concluirTarefa(IdTarefa, this);
            }
        }

        private void mnuExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            using (DialogCenteringService centeringService = new DialogCenteringService(frmTarefa)) // center message box
                dr = MessageBox.Show("Tem certeza de que deseja excluir esta tarefa?", "SchedBrains", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                frmTarefa.excluirTarefa(IdTarefa);
                Parent.Controls.Remove(this);
            }
        }
    }
}
