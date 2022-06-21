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
        public string imgPerfilAtual = null;

        public FrmContato()
        {
            InitializeComponent();
        }

        private void FrmContato_Load(object sender, EventArgs e)
        {
            cboTipoBusca.SelectedIndex = cboTipo.SelectedIndex = 0;

            listaContatos = ContatoController.Listar();
            if (listaContatos.Count > 0)
            {
                foreach (Contato contato in listaContatos)
                {
                    UscContato ucc = new UscContato();
                    ucc.frmContato = this;
                    ucc.Carregar(contato);
                    flpContatos.Controls.Add(ucc);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tipo = "";

            if (cboTipoBusca.SelectedIndex != 0)
                tipo = (cboTipoBusca.SelectedIndex-1).ToString();

            listaContatos = ContatoController.Pesquisar(txtBusca.Text.Trim(), tipo, chbFavoritos.Checked);

            flpContatos.Controls.Clear();
            if (listaContatos.Count > 0)
            {
                foreach (Contato contato in listaContatos)
                {
                    UscContato ucc = new UscContato();
                    ucc.frmContato = this;
                    ucc.Carregar(contato);
                    flpContatos.Controls.Add(ucc);
                }
            }
        }

        private void pcbImgPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg; *.jpeg; *.png; *.BMP;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pcbImgPerfil.Image = new Bitmap(ofd.FileName);
                    imgPerfilAtual = ofd.FileName;
                }
                catch (Exception)
                {
                    using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                        MessageBox.Show("Não foi possível carregar a foto", "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                if (telefone == "(  )      -")
                    telefone = "";

                string email = txtEmail.Text.Trim();

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

                string mensagem = "Contato cadastrado com sucesso!";

                if (ContatoAtual == null)
                {
                    int id = 1;
                    if (listaContatos.Count > 0)
                        id += listaContatos[^1].Id;

                    Contato ContatoAtual = new Contato(nome, sobrenome, apelido, email, dataNascimento, tipo, telefone, imgPerfilAtual);
                    listaContatos.Add(ContatoAtual);

                    ContatoController.Adicionar(ContatoAtual);

                    UscContato ucc = new UscContato();
                    ucc.frmContato = this;
                    ucc.Carregar(ContatoAtual);
                    flpContatos.Controls.Add(ucc);
                }
                else
                {
                    ContatoAtual.Nome = nome;
                    ContatoAtual.Sobrenome = sobrenome;
                    ContatoAtual.Apelido = apelido;
                    ContatoAtual.Email = email;
                    ContatoAtual.DataNascimento = dataNascimento;
                    ContatoAtual.Tipo = tipo;
                    ContatoAtual.Telefone = telefone;
                    ContatoAtual.Imagem = imgPerfilAtual;

                    int i = listaContatos.FindIndex(contato => contato.Id == ContatoAtual.Id);
                    listaContatos[i] = ContatoAtual;

                    ContatoController.Atualizar(ContatoAtual);

                    UscContatoAtual.Carregar(ContatoAtual);

                    mensagem = "Contato alterado com sucesso!";
                }

                using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                    MessageBox.Show(mensagem, "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparFormulario();
                ContatoAtual = null;
            }
        }

        public void limparFormulario()
        {
            txtNome.Text = txtSobrenome.Text = txtApelido.Text = txtTelefone.Text = txtEmail.Text = "";
            pcbImgPerfil.Image = Properties.Resources.avatar;
            imgPerfilAtual = null;
            dtpDataNascimento.Value = DateTime.Now;
            dtpDataNascimento.Checked = true;
            cboTipo.SelectedIndex = 0;
            txtNome.Focus();
            errorProviderContato.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparFormulario();
        }

        public void editarContato(int idContato, UscContato uscContatoAtual)
        {
            ContatoAtual = listaContatos.FirstOrDefault(contato => contato.Id == idContato);
            UscContatoAtual = uscContatoAtual;

            txtNome.Text = ContatoAtual.Nome.ToString();
            txtSobrenome.Text = ContatoAtual.Sobrenome.ToString();
            txtApelido.Text = ContatoAtual.Apelido.ToString();
            txtTelefone.Text = ContatoAtual.Telefone.ToString();
            txtEmail.Text = ContatoAtual.Email.ToString();

            if (ContatoAtual.Imagem != null && File.Exists(ContatoAtual.Imagem))
                pcbImgPerfil.Image = new Bitmap(ContatoAtual.Imagem);
            else
                pcbImgPerfil.Image = Properties.Resources.avatar;

            if (ContatoAtual.DataNascimento != null)
                dtpDataNascimento.Value = ContatoAtual.DataNascimento.Value;
            else
            {
                dtpDataNascimento.Value = DateTime.Now;
                dtpDataNascimento.Checked = false;
            }

            cboTipo.SelectedIndex = ((int)ContatoAtual.Tipo + 1);
        }

        public void favoritarContato(int idContato, UscContato uscContatoAtual)
        {
            ContatoAtual = listaContatos.FirstOrDefault(contato => contato.Id == idContato);
            UscContatoAtual = uscContatoAtual;

            ContatoAtual.AlterarFavorito();

            string mensagem = "Contato desfavoritado!";
            if (ContatoAtual.Favorito)
                mensagem = "Contato favoritado!";

            int i = listaContatos.FindIndex(contato => contato.Id == ContatoAtual.Id);
            listaContatos[i] = ContatoAtual;

            ContatoController.Atualizar(ContatoAtual);
            UscContatoAtual.Carregar(ContatoAtual);

            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                MessageBox.Show(mensagem, "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparFormulario();
            ContatoAtual = null;
        }

        public void excluirContato(int idContato)
        {
            ContatoAtual = listaContatos.FirstOrDefault(contato => contato.Id == idContato);
            ContatoController.Excluir(ContatoAtual);

            using (DialogCenteringService centeringService = new DialogCenteringService(this)) // center message box
                MessageBox.Show("Contato excluído com sucesso!", "SchedBrains", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparFormulario();
            ContatoAtual = null;
        }
    }
}
