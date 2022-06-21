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
    public partial class FrmEvento : Form
    {

        public List<Evento> listaEventos = new List<Evento>();
        public Evento? EventoAtual = null;
        public UscEvento UscEventoAtual = null;
        public string imgEventoAtual = null;

        public FrmEvento()
        {
            InitializeComponent();
        }

        private void FrmEvento_Load(object sender, EventArgs e)
        {
            cboPeriodicidade.SelectedIndex = 0;

            listaEventos = EventoController.Listar();
            if (listaEventos.Count > 0)
            {
                foreach (Evento evento in listaEventos)
                {
                    UscEvento uce = new UscEvento();
                    uce.frmEvento = this;
                    uce.Carregar(evento);
                    flpEventos.Controls.Add(uce);
                }
            }
        }

        private void pcbImgEvento_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg; *.jpeg; *.png; *.BMP;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pcbImgEvento.Image = new Bitmap(ofd.FileName);
                    imgEventoAtual = ofd.FileName;
                }
                catch (Exception)
                {
                    using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                        MessageBox.Show("Não foi possível carregar a imagem", "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool erro = false;
            errorProviderEvento.Clear();

            if (txtTitulo.Text.Trim() == "")
            {
                erro = true;
                errorProviderEvento.SetError(txtTitulo, "É necessário informar um título para o evento!");
            }

            if (txtLocal.Text.Trim() == "")
            {
                erro = true;
                errorProviderEvento.SetError(txtLocal, "Informe o local do evento!");
            }

            if (txtDescricao.Text.Trim() == "")
            {
                erro = true;
                errorProviderEvento.SetError(txtDescricao, "Informe a descrição do evento!");
            }

            if (cboPeriodicidade.SelectedIndex == 0)
            {
                erro = true;
                errorProviderEvento.SetError(cboPeriodicidade, "Defina a periodicidade do evento!");
            }

            if (dtpDataInicio.Value < DateTime.Now)
            {
                erro = true;
                errorProviderEvento.SetError(dtpDataInicio, "Data de início inválida!");
            }

            if (dtpDataTermino.Value < DateTime.Now)
            {
                erro = true;
                errorProviderEvento.SetError(dtpDataTermino, "Data de conclusão inválida!");
            }

            if (erro == false)
            {
                string titulo = txtTitulo.Text.Trim();
                string local = txtLocal.Text.Trim();
                string descricao = txtDescricao.Text.Trim();

                DateTime dataInicio = new DateTime(dtpDataInicio.Value.Year,
                        dtpDataInicio.Value.Month, dtpDataInicio.Value.Day,
                        dtpDataInicio.Value.Hour, dtpDataInicio.Value.Minute, 0);

                DateTime dataTermino = new DateTime(dtpDataTermino.Value.Year,
                        dtpDataTermino.Value.Month, dtpDataTermino.Value.Day,
                        dtpDataTermino.Value.Hour, dtpDataTermino.Value.Minute, 0);

                PeriodicidadeEvento periodicidade = PeriodicidadeEvento.Todos_os_dias;
                if (cboPeriodicidade.SelectedItem.ToString() == "A cada semana")
                    periodicidade = PeriodicidadeEvento.A_cada_semana;
                else if (cboPeriodicidade.SelectedItem.ToString() == "A cada 2 semanas")
                    periodicidade = PeriodicidadeEvento.A_cada_2_semanas;
                else if (cboPeriodicidade.SelectedItem.ToString() == "A cada mês")
                    periodicidade = PeriodicidadeEvento.A_cada_mês;
                else if (cboPeriodicidade.SelectedItem.ToString() == "A cada ano")
                    periodicidade = PeriodicidadeEvento.A_cada_ano;
                else if (cboPeriodicidade.SelectedItem.ToString() == "Uma vez")
                    periodicidade = PeriodicidadeEvento.Uma_vez;

                string? contatos = null;

                string mensagem = "Evento cadastrado com sucesso!";

                if (EventoAtual == null)
                {
                    int id = 1;
                    if (listaEventos.Count > 0)
                        id += listaEventos[^1].Id;

                    Evento EventoAtual = new Evento(titulo, local, descricao, dataInicio, dataTermino, periodicidade, SituacaoEvento.Aguardando, contatos, imgEventoAtual);
                    listaEventos.Add(EventoAtual);

                    EventoController.Adicionar(EventoAtual);

                    UscEvento uce = new UscEvento();
                    uce.frmEvento = this;
                    uce.Carregar(EventoAtual);
                    flpEventos.Controls.Add(uce);
                }
                else
                {
                    EventoAtual.Titulo = titulo;
                    EventoAtual.Local = local;
                    EventoAtual.Descricao = descricao;
                    EventoAtual.DataInicio = dataInicio;
                    EventoAtual.DataTermino = dataTermino;
                    EventoAtual.Periodicidade = periodicidade;
                    EventoAtual.Contatos = contatos;
                    EventoAtual.Imagem = imgEventoAtual;

                    int i = listaEventos.FindIndex(evento => evento.Id == EventoAtual.Id);
                    listaEventos[i] = EventoAtual;

                    EventoController.Atualizar(EventoAtual);

                    UscEventoAtual.Carregar(EventoAtual);

                    mensagem = "Evento alterado com sucesso!";
                }

                using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                    MessageBox.Show(mensagem, "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparFormulario();
                EventoAtual = null;
            }
        }

        public void limparFormulario()
        {
            txtTitulo.Text = txtLocal.Text = txtDescricao.Text = "";
            pcbImgEvento.Image = Properties.Resources.landscape;
            imgEventoAtual = null;
            dtpDataInicio.Value = DateTime.Now;
            dtpDataTermino.Value = DateTime.Now;
            cboPeriodicidade.SelectedIndex = 0;
            txtTitulo.Focus();
            errorProviderEvento.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        public void editarEvento(int idEvento, UscEvento uscEventoAtual)
        {
            EventoAtual = listaEventos.FirstOrDefault(evento => evento.Id == idEvento);
            UscEventoAtual = uscEventoAtual;

            txtTitulo.Text = EventoAtual.Titulo.ToString();
            txtLocal.Text = EventoAtual.Local.ToString();
            txtDescricao.Text = EventoAtual.Descricao.ToString();

            if (EventoAtual.Imagem != null && File.Exists(EventoAtual.Imagem))
            {
                imgEventoAtual = EventoAtual.Imagem;
                pcbImgEvento.Image = new Bitmap(EventoAtual.Imagem);
            }
            else
                pcbImgEvento.Image = Properties.Resources.landscape;

            dtpDataInicio.Value = EventoAtual.DataInicio;
            dtpDataTermino.Value = EventoAtual.DataTermino;

            cboPeriodicidade.SelectedIndex = ((int)EventoAtual.Periodicidade + 1);
        }

        public void concluirEvento(int idEvento, UscEvento uscEventoAtual)
        {
            EventoAtual = listaEventos.FirstOrDefault(evento => evento.Id == idEvento);
            UscEventoAtual = uscEventoAtual;

            EventoAtual.Situacao = SituacaoEvento.Concluído;

            int i = listaEventos.FindIndex(evento => evento.Id == EventoAtual.Id);
            listaEventos[i] = EventoAtual;

            EventoController.Atualizar(EventoAtual);
            UscEventoAtual.Carregar(EventoAtual);

            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                MessageBox.Show("Evento concluído!", "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparFormulario();
            EventoAtual = null;
        }

        public void excluirEvento(int idEvento)
        {
            EventoAtual = listaEventos.FirstOrDefault(evento => evento.Id == idEvento);
            EventoController.Excluir(EventoAtual);

            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                MessageBox.Show("Evento excluído com sucesso!", "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparFormulario();
            EventoAtual = null;
        }
    }
}
