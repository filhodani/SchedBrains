using SchedBrains.Controller;
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
    public partial class FrmTarefa : FrmPadrao
    {

        public List<Tarefa> listaTarefas = new List<Tarefa>();
        public Tarefa? TarefaAtual = null;
        public UscTarefa UscTarefaAtual = null;

        public FrmTarefa()
        {
            InitializeComponent();
        }

        private void FrmTarefa_Load(object sender, EventArgs e)
        {
            cboSituacao.SelectedIndex = cboPrioridadeBusca.SelectedIndex = cboEvento.SelectedIndex = cboPrioridade.SelectedIndex = 0;

            //Fazer: Preencher cboEvento com títulos dos eventos
            //cboEvento.DataSource = listaTarefas;

            listaTarefas = TarefaController.Listar();
            if (listaTarefas.Count > 0)
            {
                foreach (Tarefa tarefa in listaTarefas)
                {
                    UscTarefa uct = new UscTarefa();
                    uct.frmTarefa = this;
                    uct.Carregar(tarefa);
                    flpTarefas.Controls.Add(uct);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool erro = false;
            errorProviderTarefa.Clear();

            if (txtTitulo.Text.Trim() == "")
            {
                erro = true;
                errorProviderTarefa.SetError(txtTitulo, "É necessário informar um título para a tarefa!");
            }

            if (cboPrioridade.SelectedIndex == 0)
            {
                erro = true;
                errorProviderTarefa.SetError(cboPrioridade, "Defina a prioridade da tarefa!");
            }

            if (dtpDataMaximaConclusao.Checked && dtpDataMaximaConclusao.Value < DateTime.Now)
            {
                erro = true;
                errorProviderTarefa.SetError(dtpDataMaximaConclusao, "Data de conclusão inválida!");
            }

            if (erro == false)
            {
                string titulo = txtTitulo.Text.Trim();
                string descricao = txtDescricao.Text.Trim();

                DateTime? dataMaximaConclusao = null;
                if (dtpDataMaximaConclusao.Checked)
                {
                    dataMaximaConclusao = new DateTime(dtpDataMaximaConclusao.Value.Year,
                        dtpDataMaximaConclusao.Value.Month, dtpDataMaximaConclusao.Value.Day,
                        dtpDataMaximaConclusao.Value.Hour, dtpDataMaximaConclusao.Value.Minute, 0);
                }

                PrioridadeTarefa prioridade = PrioridadeTarefa.Alta;
                if (cboPrioridade.SelectedItem.ToString() == "Média")
                    prioridade = PrioridadeTarefa.Média;
                else if (cboPrioridade.SelectedItem.ToString() == "Baixa")
                    prioridade = PrioridadeTarefa.Baixa;

                string mensagem = "Tarefa cadastrada com sucesso!";

                if (TarefaAtual == null)
                {
                    int id = 1;
                    if (listaTarefas.Count > 0)
                        id += listaTarefas[^1].Id;

                    Tarefa TarefaAtual = new Tarefa(titulo, descricao, dataMaximaConclusao, prioridade, null, null, null, SituacaoTarefa.Pendente);
                    //Tarefa TarefaAtual = new Tarefa { Id = id, DataCriacao = DateTime.Now, Titulo = titulo, Descricao = descricao, DataMaximaConclusao = dataMaximaConclusao, Prioridade = prioridade, Anexos = null, Evento = null, Contatos = null, Situacao = SituacaoTarefa.Pendente };
                    listaTarefas.Add(TarefaAtual);

                    TarefaController.Adicionar(TarefaAtual);

                    UscTarefa uct = new UscTarefa();
                    uct.frmTarefa = this;
                    uct.Carregar(TarefaAtual);
                    flpTarefas.Controls.Add(uct);
                }
                else
                {
                    TarefaAtual.Titulo = titulo;
                    TarefaAtual.Descricao = descricao;
                    TarefaAtual.DataMaximaConclusao = dataMaximaConclusao;
                    TarefaAtual.Prioridade = prioridade;

                    int i = listaTarefas.FindIndex(tarefa => tarefa.Id == TarefaAtual.Id);
                    listaTarefas[i] = TarefaAtual;

                    TarefaController.Atualizar(TarefaAtual);

                    UscTarefaAtual.Carregar(TarefaAtual);

                    mensagem = "Tarefa alterada com sucesso!";
                }

                using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                    MessageBox.Show(mensagem, "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparFormulario();
                TarefaAtual = null;
            }
        }

        public void limparFormulario()
        {
            txtTitulo.Text = "";
            txtDescricao.Text = "";
            dtpDataMaximaConclusao.Value = DateTime.Now;
            dtpDataMaximaConclusao.Checked = true;
            cboPrioridade.SelectedIndex = 0;
            txtTitulo.Focus();
            errorProviderTarefa.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        private void btnAnexos_Click(object sender, EventArgs e)
        {
            //FrmAnexo frmAnexo = new FrmAnexo();
            //frmAnexo.ShowDialog();
        }

        public void editarTarefa(int idTarefa, UscTarefa uscTarefaAtual)
        {
            TarefaAtual = listaTarefas.FirstOrDefault(tarefa => tarefa.Id == idTarefa);
            UscTarefaAtual = uscTarefaAtual;

            txtTitulo.Text = TarefaAtual.Titulo.ToString();
            txtDescricao.Text = TarefaAtual.Descricao.ToString();
            if (TarefaAtual.DataMaximaConclusao != null)
                dtpDataMaximaConclusao.Value = TarefaAtual.DataMaximaConclusao.Value;
            else
            {
                dtpDataMaximaConclusao.Value = DateTime.Now;
                dtpDataMaximaConclusao.Checked = false;
            }
            cboPrioridade.SelectedIndex = ((int)TarefaAtual.Prioridade + 1);
        }

        public void concluirTarefa(int idTarefa, UscTarefa uscTarefaAtual)
        {
            TarefaAtual = listaTarefas.FirstOrDefault(tarefa => tarefa.Id == idTarefa);
            UscTarefaAtual = uscTarefaAtual;

            TarefaAtual.Situacao = SituacaoTarefa.Concluído;

            int i = listaTarefas.FindIndex(tarefa => tarefa.Id == TarefaAtual.Id);
            listaTarefas[i] = TarefaAtual;

            TarefaController.Atualizar(TarefaAtual);
            UscTarefaAtual.Carregar(TarefaAtual);

            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                MessageBox.Show("Tarefa concluída!", "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparFormulario();
            TarefaAtual = null;
        }

        public void excluirTarefa(int idTarefa)
        {
            TarefaAtual = listaTarefas.FirstOrDefault(tarefa => tarefa.Id == idTarefa);
            TarefaController.Excluir(TarefaAtual);

            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                MessageBox.Show("Tarefa excluída com sucesso!", "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparFormulario();
            TarefaAtual = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string situacao = "";
            string prioridade = "";

            if (cboSituacao.SelectedIndex != 0)
                situacao = cboSituacao.Text.Trim();

            if (cboPrioridadeBusca.SelectedIndex != 0)
                prioridade = cboPrioridadeBusca.Text.Trim();

            listaTarefas = TarefaController.Pesquisar(txtTrecho.Text.Trim(), situacao, prioridade, dtpDataConclusao.Checked, dtpDataConclusao.Value);

            flpTarefas.Controls.Clear();
            if (listaTarefas.Count > 0)
            {
                foreach (Tarefa tarefa in listaTarefas)
                {
                    UscTarefa uct = new UscTarefa();
                    uct.frmTarefa = this;
                    uct.Carregar(tarefa);
                    flpTarefas.Controls.Add(uct);
                }
            }
        }
    }
}
