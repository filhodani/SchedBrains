namespace SchedBrains.View
{
    partial class FrmEvento
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
            this.pcbImgEvento = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataTermino = new System.Windows.Forms.DateTimePicker();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.btnContatos = new System.Windows.Forms.Button();
            this.cboPeriodicidade = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.flpEventos = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProviderEvento = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTrecho = new System.Windows.Forms.TextBox();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            this.dtpPeriodo = new System.Windows.Forms.DateTimePicker();
            this.cboPeriodicidadeBusca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEvento)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.splitContainer1.Panel1.Controls.Add(this.pcbImgEvento);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDataTermino);
            this.splitContainer1.Panel1.Controls.Add(this.txtLocal);
            this.splitContainer1.Panel1.Controls.Add(this.btnContatos);
            this.splitContainer1.Panel1.Controls.Add(this.cboPeriodicidade);
            this.splitContainer1.Panel1.Controls.Add(this.btnLimpar);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalvar);
            this.splitContainer1.Panel1.Controls.Add(this.lblDataInicio);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDataInicio);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescricao);
            this.splitContainer1.Panel1.Controls.Add(this.txtTitulo);
            this.splitContainer1.Panel1MinSize = 290;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.flpEventos);
            this.splitContainer1.Panel2MinSize = 480;
            this.splitContainer1.Size = new System.Drawing.Size(784, 450);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 5;
            // 
            // pcbImgEvento
            // 
            this.pcbImgEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbImgEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbImgEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbImgEvento.Image = global::SchedBrains.Properties.Resources.landscape;
            this.pcbImgEvento.Location = new System.Drawing.Point(12, 179);
            this.pcbImgEvento.Name = "pcbImgEvento";
            this.pcbImgEvento.Size = new System.Drawing.Size(265, 130);
            this.pcbImgEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImgEvento.TabIndex = 14;
            this.pcbImgEvento.TabStop = false;
            this.pcbImgEvento.Click += new System.EventHandler(this.pcbImgEvento_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data Término";
            // 
            // dtpDataTermino
            // 
            this.dtpDataTermino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataTermino.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataTermino.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataTermino.Location = new System.Drawing.Point(147, 330);
            this.dtpDataTermino.Name = "dtpDataTermino";
            this.dtpDataTermino.Size = new System.Drawing.Size(130, 23);
            this.dtpDataTermino.TabIndex = 5;
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.Location = new System.Drawing.Point(12, 41);
            this.txtLocal.MaxLength = 50;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.PlaceholderText = "Local";
            this.txtLocal.Size = new System.Drawing.Size(265, 23);
            this.txtLocal.TabIndex = 1;
            // 
            // btnContatos
            // 
            this.btnContatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContatos.Location = new System.Drawing.Point(12, 388);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(265, 23);
            this.btnContatos.TabIndex = 7;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            // 
            // cboPeriodicidade
            // 
            this.cboPeriodicidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPeriodicidade.DisplayMember = "Titulo";
            this.cboPeriodicidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodicidade.FormattingEnabled = true;
            this.cboPeriodicidade.Items.AddRange(new object[] {
            "Periodicidade",
            "Todos os dias",
            "A cada semana",
            "A cada 2 semanas",
            "A cada mês",
            "A cada ano",
            "Uma vez"});
            this.cboPeriodicidade.Location = new System.Drawing.Point(12, 359);
            this.cboPeriodicidade.Name = "cboPeriodicidade";
            this.cboPeriodicidade.Size = new System.Drawing.Size(265, 23);
            this.cboPeriodicidade.TabIndex = 6;
            this.cboPeriodicidade.ValueMember = "Id";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(147, 417);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 417);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(12, 312);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(63, 15);
            this.lblDataInicio.TabIndex = 3;
            this.lblDataInicio.Text = "Data Início";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataInicio.Location = new System.Drawing.Point(12, 330);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(129, 23);
            this.dtpDataInicio.TabIndex = 4;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(12, 70);
            this.txtDescricao.MaxLength = 250;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PlaceholderText = "Descrição";
            this.txtDescricao.Size = new System.Drawing.Size(265, 100);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.Location = new System.Drawing.Point(12, 12);
            this.txtTitulo.MaxLength = 50;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "Título";
            this.txtTitulo.Size = new System.Drawing.Size(265, 23);
            this.txtTitulo.TabIndex = 0;
            // 
            // flpEventos
            // 
            this.flpEventos.AutoScroll = true;
            this.flpEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.flpEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEventos.Location = new System.Drawing.Point(0, 0);
            this.flpEventos.Margin = new System.Windows.Forms.Padding(0);
            this.flpEventos.Name = "flpEventos";
            this.flpEventos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flpEventos.Size = new System.Drawing.Size(480, 450);
            this.flpEventos.TabIndex = 0;
            // 
            // errorProviderEvento
            // 
            this.errorProviderEvento.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderEvento.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(662, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTrecho
            // 
            this.txtTrecho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrecho.Location = new System.Drawing.Point(14, 12);
            this.txtTrecho.MaxLength = 26;
            this.txtTrecho.Name = "txtTrecho";
            this.txtTrecho.PlaceholderText = "Trecho do título, local ou descrição";
            this.txtTrecho.Size = new System.Drawing.Size(279, 23);
            this.txtTrecho.TabIndex = 0;
            // 
            // cboSituacao
            // 
            this.cboSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Items.AddRange(new object[] {
            "Situacao",
            "Aguardando",
            "Em andamento",
            "Pendente",
            "Concluído"});
            this.cboSituacao.Location = new System.Drawing.Point(299, 12);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(115, 23);
            this.cboSituacao.TabIndex = 1;
            // 
            // dtpPeriodo
            // 
            this.dtpPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPeriodo.Checked = false;
            this.dtpPeriodo.CustomFormat = "dd/MM/yyyy";
            this.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPeriodo.Location = new System.Drawing.Point(541, 12);
            this.dtpPeriodo.Name = "dtpPeriodo";
            this.dtpPeriodo.ShowCheckBox = true;
            this.dtpPeriodo.Size = new System.Drawing.Size(115, 23);
            this.dtpPeriodo.TabIndex = 3;
            // 
            // cboPeriodicidadeBusca
            // 
            this.cboPeriodicidadeBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPeriodicidadeBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodicidadeBusca.FormattingEnabled = true;
            this.cboPeriodicidadeBusca.Items.AddRange(new object[] {
            "Periodicidade",
            "Todos os dias",
            "A cada semana",
            "A cada 2 semanas",
            "A cada mês",
            "A cada ano",
            "Uma vez"});
            this.cboPeriodicidadeBusca.Location = new System.Drawing.Point(420, 12);
            this.cboPeriodicidadeBusca.Name = "cboPeriodicidadeBusca";
            this.cboPeriodicidadeBusca.Size = new System.Drawing.Size(115, 23);
            this.cboPeriodicidadeBusca.TabIndex = 3;
            // 
            // FrmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.cboSituacao);
            this.Controls.Add(this.cboPeriodicidadeBusca);
            this.Controls.Add(this.dtpPeriodo);
            this.Controls.Add(this.txtTrecho);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 540);
            this.Name = "FrmEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.FrmEvento_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEvento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtTitulo;
        private TextBox txtDescricao;
        private DateTimePicker dtpDataInicio;
        private Label lblDataInicio;
        private Button btnSalvar;
        private ErrorProvider errorProviderEvento;
        private FlowLayoutPanel flpEventos;
        private DateTimePicker dtpPeriodo;
        private ComboBox cboSituacao;
        private TextBox txtTrecho;
        private Button btnBuscar;
        private Button btnLimpar;
        private ComboBox cboPeriodicidadeBusca;
        private ComboBox cboPeriodicidade;
        private Button btnContatos;
        private TextBox txtLocal;
        private DateTimePicker dtpDataTermino;
        private Label label1;
        private PictureBox pcbImgEvento;
    }
}