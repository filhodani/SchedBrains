namespace SchedBrains.View
{
    partial class FrmContato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pcbImgPerfil = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.flpContatos = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProviderContato = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cboTipoBusca = new System.Windows.Forms.ComboBox();
            this.chbFavoritos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContato)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.splitContainer1.Panel1.Controls.Add(this.pcbImgPerfil);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmail);
            this.splitContainer1.Panel1.Controls.Add(this.txtTelefone);
            this.splitContainer1.Panel1.Controls.Add(this.txtApelido);
            this.splitContainer1.Panel1.Controls.Add(this.txtSobrenome);
            this.splitContainer1.Panel1.Controls.Add(this.btnLimpar);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalvar);
            this.splitContainer1.Panel1.Controls.Add(this.cboTipo);
            this.splitContainer1.Panel1.Controls.Add(this.lblDataNascimento);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDataNascimento);
            this.splitContainer1.Panel1.Controls.Add(this.txtNome);
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.flpContatos);
            this.splitContainer1.Panel2MinSize = 554;
            this.splitContainer1.Size = new System.Drawing.Size(785, 412);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 5;
            // 
            // pcbImgPerfil
            // 
            this.pcbImgPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbImgPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.pcbImgPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImgPerfil.Image = global::SchedBrains.Properties.Resources.avatar;
            this.pcbImgPerfil.Location = new System.Drawing.Point(48, 162);
            this.pcbImgPerfil.Name = "pcbImgPerfil";
            this.pcbImgPerfil.Size = new System.Drawing.Size(130, 130);
            this.pcbImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImgPerfil.TabIndex = 10;
            this.pcbImgPerfil.TabStop = false;
            this.pcbImgPerfil.Click += new System.EventHandler(this.pcbImgPerfil_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(14, 128);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(197, 23);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.Location = new System.Drawing.Point(14, 99);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(197, 23);
            this.txtTelefone.TabIndex = 3;
            // 
            // txtApelido
            // 
            this.txtApelido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApelido.Location = new System.Drawing.Point(14, 70);
            this.txtApelido.MaxLength = 10;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.PlaceholderText = "Apelido";
            this.txtApelido.Size = new System.Drawing.Size(197, 23);
            this.txtApelido.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSobrenome.Location = new System.Drawing.Point(14, 41);
            this.txtSobrenome.MaxLength = 50;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.PlaceholderText = "Sobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(197, 23);
            this.txtSobrenome.TabIndex = 1;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(116, 377);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(14, 377);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Tipo",
            "Profissional",
            "Pessoal"});
            this.cboTipo.Location = new System.Drawing.Point(14, 348);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(197, 23);
            this.cboTipo.TabIndex = 7;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(14, 301);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(114, 15);
            this.lblDataNascimento.TabIndex = 3;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataNascimento.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNascimento.Location = new System.Drawing.Point(14, 319);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.ShowCheckBox = true;
            this.dtpDataNascimento.Size = new System.Drawing.Size(197, 23);
            this.dtpDataNascimento.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(14, 12);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(197, 23);
            this.txtNome.TabIndex = 0;
            // 
            // flpContatos
            // 
            this.flpContatos.AutoScroll = true;
            this.flpContatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.flpContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContatos.Location = new System.Drawing.Point(0, 0);
            this.flpContatos.Margin = new System.Windows.Forms.Padding(0);
            this.flpContatos.Name = "flpContatos";
            this.flpContatos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flpContatos.Size = new System.Drawing.Size(554, 412);
            this.flpContatos.TabIndex = 0;
            // 
            // errorProviderContato
            // 
            this.errorProviderContato.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderContato.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(662, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.Location = new System.Drawing.Point(14, 12);
            this.txtBusca.MaxLength = 26;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Dados pessoais";
            this.txtBusca.Size = new System.Drawing.Size(441, 23);
            this.txtBusca.TabIndex = 0;
            // 
            // cboTipoBusca
            // 
            this.cboTipoBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBusca.FormattingEnabled = true;
            this.cboTipoBusca.Items.AddRange(new object[] {
            "Tipo",
            "Profissional",
            "Pessoal"});
            this.cboTipoBusca.Location = new System.Drawing.Point(461, 12);
            this.cboTipoBusca.Name = "cboTipoBusca";
            this.cboTipoBusca.Size = new System.Drawing.Size(115, 23);
            this.cboTipoBusca.TabIndex = 1;
            // 
            // chbFavoritos
            // 
            this.chbFavoritos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFavoritos.AutoSize = true;
            this.chbFavoritos.Location = new System.Drawing.Point(582, 14);
            this.chbFavoritos.Name = "chbFavoritos";
            this.chbFavoritos.Size = new System.Drawing.Size(74, 19);
            this.chbFavoritos.TabIndex = 2;
            this.chbFavoritos.Text = "Favoritos";
            this.chbFavoritos.UseVisualStyleBackColor = true;
            // 
            // FrmContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.chbFavoritos);
            this.Controls.Add(this.cboTipoBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.FrmContato_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtNome;
        private DateTimePicker dtpDataNascimento;
        private Label lblDataNascimento;
        private ComboBox cboTipo;
        private Button btnSalvar;
        private ErrorProvider errorProviderContato;
        private FlowLayoutPanel flpContatos;
        private ComboBox cboTipoBusca;
        private TextBox txtBusca;
        private Button btnBuscar;
        private Button btnLimpar;
        private TextBox txtSobrenome;
        private MaskedTextBox txtTelefone;
        private TextBox txtApelido;
        private TextBox txtEmail;
        private CheckBox chbFavoritos;
        private PictureBox pcbImgPerfil;
    }
}