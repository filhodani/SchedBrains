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
    public partial class UscContato : UserControl
    {
        public UscContato()
        {
            InitializeComponent();
        }

        public void Carregar(Contato c)
        {
            IdContato = c.Id;
            Nome = $"{c.Nome} {c.Sobrenome}";

            if (c.Apelido != "")
                Apelido = c.Apelido;
            else
                Apelido = "";

            if (c.Email != "")
                Email = c.Email;
            else
                Email = "";

            if (c.Telefone != "")
                Telefone = c.Telefone;
            else
                Telefone = "";


            if (c.DataNascimento != null)
                DataNascimento = c.DataNascimento.Value.ToString().Substring(0, 10);
            else
                DataNascimento = "";
        }

        public int IdContato { get; set; }

        public FrmContato frmContato { get; set; }

        public string Nome
        {
            get { return lblNome.Text; }
            set { lblNome.Text = value; }
        }

        public string Apelido
        {
            get { return lblApelido.Text; }
            set { lblApelido.Text = value; }
        }

        public string Email
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }

        /*public string Imagem
        {
            get { return lblImagem.Text; }
            set { lblImagem.Text = value; }
        }*/

        public string Telefone
        {
            get { return lblTelefone.Text; }
            set { lblTelefone.Text = value; }
        }

        public string DataNascimento
        {
            get { return lblDataNascimento.Text; }
            set { lblDataNascimento.Text = value; }
        }

        private void mnuEditar_Click(object sender, EventArgs e)
        {

        }

        private void mnuFavorito_Click(object sender, EventArgs e)
        {

        }

        private void mnuExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
