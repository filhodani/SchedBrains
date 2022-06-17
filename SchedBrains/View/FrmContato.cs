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
    public partial class FrmContato : Form
    {
        public List<Contato> listaContatos = new List<Contato>();
        public Contato? ContatoAtual = null;
        public UscContato UscContatoAtual = null;

        public FrmContato()
        {
            InitializeComponent();
        }

        private void FrmContato_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tipo = "";

            if (cboTipoBusca.SelectedIndex != 0)
                tipo = (cboTipoBusca.SelectedIndex-1).ToString();

            /*listaContatos = ContatoController.Pesquisar(txtBusca.Text.Trim(), tipo, chbFavoritos.Checked);

            flpContatos.Controls.Clear();
            if (listaContatos.Count > 0)
            {
                foreach (Contato tarefa in listaContatos)
                {
                    UscContato uct = new UscContato();
                    uct.frmContato = this;
                    uct.Carregar(tarefa);
                    flpContatos.Controls.Add(uct);
                }
            }*/
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool erro = false;
            errorProviderContato.Clear();

            if (txtNome.Text.Trim() == "")
            {
                erro = true;
                errorProviderContato.SetError(txtNome, "Informe o nome do contato!");
            }

            if (txtSobrenome.Text.Trim() == "")
            {
                erro = true;
                errorProviderContato.SetError(txtSobrenome, "Informe o sobrenome do contato!");
            }

            if (txtEmail.Text.Trim() != "")
            {
                if (!new Contato().EmailValido(txtEmail.Text.Trim()))
                {
                    erro = true;
                    errorProviderContato.SetError(txtEmail, "Email inválido!");
                }
            }

            if (dtpDataNascimento.Checked && dtpDataNascimento.Value > DateTime.Today)
            {
                erro = true;
                errorProviderContato.SetError(dtpDataNascimento, "Data de nascimento inválida!");
            }

            if (cboTipo.SelectedIndex == 0)
            {
                erro = true;
                errorProviderContato.SetError(cboTipo, "Defina o tipo do contato!");
            }

            if (erro == false)
            {
                string nome = txtNome.Text.Trim();
                string sobrenome = txtSobrenome.Text.Trim();
                string apelido = txtApelido.Text.Trim();
                string telefone = txtTelefone.Text.Trim();
                string email = txtEmail.Text.Trim();
                string imagem = "";

                DateTime? dataNascimento = null;
                if (dtpDataNascimento.Checked)
                {
                    dataNascimento = new DateTime(dtpDataNascimento.Value.Year,
                        dtpDataNascimento.Value.Month, dtpDataNascimento.Value.Day,
                        dtpDataNascimento.Value.Hour, dtpDataNascimento.Value.Minute, 0);
                }

                TipoContato tipo = TipoContato.Profissional;
                if (cboTipo.SelectedItem.ToString() == "Pessoal")
                    tipo = TipoContato.Pessoal;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = txtSobrenome.Text = txtApelido.Text = txtTelefone.Text = txtEmail.Text = "";
            dtpDataNascimento.Value = DateTime.Now;
            dtpDataNascimento.Checked = true;
            cboTipo.SelectedIndex = 0;
            txtNome.Focus();
            errorProviderContato.Clear();
        }
    }
}
