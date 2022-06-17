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
            this.btnAnexos = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.cboEvento = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cboPrioridade = new System.Windows.Forms.ComboBox();
            this.lblDataMaximaConclusao = new System.Windows.Forms.Label();
            this.dtpDataMaximaConclusao = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.flpTarefas = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProviderTarefa = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTrecho = new System.Windows.Forms.TextBox();
            this.cboPrioridadeBusca = new System.Windows.Forms.ComboBox();
            this.dtpDataConclusao = new System.Windows.Forms.DateTimePicker();
            this.cboSituacao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTarefa)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnAnexos);
            this.splitContainer1.Panel1.Controls.Add(this.btnContatos);
            this.splitContainer1.Panel1.Controls.Add(this.cboEvento);
            this.splitContainer1.Panel1.Controls.Add(this.btnLimpar);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalvar);
            this.splitContainer1.Panel1.Controls.Add(this.cboPrioridade);
            this.splitContainer1.Panel1.Controls.Add(this.lblDataMaximaConclusao);
            this.splitContainer1.Panel1.Controls.Add(this.dtpDataMaximaConclusao);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescricao);
            this.splitContainer1.Panel1.Controls.Add(this.txtTitulo);
            this.splitContainer1.Panel1MinSize = 280;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.flpTarefas);
            this.splitContainer1.Panel2MinSize = 500;
            this.splitContainer1.Size = new System.Drawing.Size(784, 450);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnAnexos
            // 
            this.btnAnexos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnexos.Location = new System.Drawing.Point(13, 330);
            this.btnAnexos.Name = "btnAnexos";
            this.btnAnexos.Size = new System.Drawing.Size(123, 23);
            this.btnAnexos.TabIndex = 10;
            this.btnAnexos.Text = "Anexos";
            this.btnAnexos.UseVisualStyleBackColor = true;
            // 
            // btnContatos
            // 
            this.btnContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContatos.Location = new System.Drawing.Point(142, 330);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(123, 23);
            this.btnContatos.TabIndex = 9;
            this.btnContatos.Text = "Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            // 
            // cboEvento
            // 
            this.cboEvento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboEvento.DisplayMember = "Titulo";
            this.cboEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvento.FormattingEnabled = true;
            this.cboEvento.Items.AddRange(new object[] {
            "Evento"});
            this.cboEvento.Location = new System.Drawing.Point(12, 359);
            this.cboEvento.Name = "cboEvento";
            this.cboEvento.Size = new System.Drawing.Size(253, 23);
            this.cboEvento.TabIndex = 5;
            this.cboEvento.ValueMember = "Id";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Location = new System.Drawing.Point(142, 417);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(12, 417);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // cboPrioridade
            // 
            this.cboPrioridade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridade.FormattingEnabled = true;
            this.cboPrioridade.Items.AddRange(new object[] {
            "Prioridade",
            "Alta",
            "Média",
            "Baixa"});
            this.cboPrioridade.Location = new System.Drawing.Point(12, 388);
            this.cboPrioridade.Name = "cboPrioridade";
            this.cboPrioridade.Size = new System.Drawing.Size(253, 23);
            this.cboPrioridade.TabIndex = 6;
            // 
            // lblDataMaximaConclusao
            // 
            this.lblDataMaximaConclusao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataMaximaConclusao.AutoSize = true;
            this.lblDataMaximaConclusao.Location = new System.Drawing.Point(12, 283);
            this.lblDataMaximaConclusao.Name = "lblDataMaximaConclusao";
            this.lblDataMaximaConclusao.Size = new System.Drawing.Size(150, 15);
            this.lblDataMaximaConclusao.TabIndex = 3;
            this.lblDataMaximaConclusao.Text = "Data máxima de conclusão";
            // 
            // dtpDataMaximaConclusao
            // 
            this.dtpDataMaximaConclusao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataMaximaConclusao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDataMaximaConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataMaximaConclusao.Location = new System.Drawing.Point(12, 301);
            this.dtpDataMaximaConclusao.Name = "dtpDataMaximaConclusao";
            this.dtpDataMaximaConclusao.ShowCheckBox = true;
            this.dtpDataMaximaConclusao.Size = new System.Drawing.Size(253, 23);
            this.dtpDataMaximaConclusao.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(12, 41);
            this.txtDescricao.MaxLength = 2130;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PlaceholderText = "Descrição";
            this.txtDescricao.Size = new System.Drawing.Size(253, 235);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.Location = new System.Drawing.Point(12, 12);
            this.txtTitulo.MaxLength = 26;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderText = "Título";
            this.txtTitulo.Size = new System.Drawing.Size(253, 23);
            this.txtTitulo.TabIndex = 0;
            // 
            // flpTarefas
            // 
            this.flpTarefas.AutoScroll = true;
            this.flpTarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.flpTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTarefas.Location = new System.Drawing.Point(0, 0);
            this.flpTarefas.Margin = new System.Windows.Forms.Padding(0);
            this.flpTarefas.Name = "flpTarefas";
            this.flpTarefas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flpTarefas.Size = new System.Drawing.Size(500, 450);
            this.flpTarefas.TabIndex = 0;
            // 
            // errorProviderTarefa
            // 
            this.errorProviderTarefa.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTarefa.ContainerControl = this;
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
            // 
            // txtTrecho
            // 
            this.txtTrecho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrecho.Location = new System.Drawing.Point(14, 12);
            this.txtTrecho.MaxLength = 26;
            this.txtTrecho.Name = "txtTrecho";
            this.txtTrecho.PlaceholderText = "Trecho do título ou descrição";
            this.txtTrecho.Size = new System.Drawing.Size(279, 23);
            this.txtTrecho.TabIndex = 0;
            // 
            // cboPrioridadeBusca
            // 
            this.cboPrioridadeBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPrioridadeBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrioridadeBusca.FormattingEnabled = true;
            this.cboPrioridadeBusca.Items.AddRange(new object[] {
            "Prioridade",
            "Alta",
            "Média",
            "Baixa"});
            this.cboPrioridadeBusca.Location = new System.Drawing.Point(420, 12);
            this.cboPrioridadeBusca.Name = "cboPrioridadeBusca";
            this.cboPrioridadeBusca.Size = new System.Drawing.Size(115, 23);
            this.cboPrioridadeBusca.TabIndex = 2;
            // 
            // dtpDataConclusao
            // 
            this.dtpDataConclusao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataConclusao.Checked = false;
            this.dtpDataConclusao.CustomFormat = "dd/MM/yyyy";
            this.dtpDataConclusao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataConclusao.Location = new System.Drawing.Point(541, 12);
            this.dtpDataConclusao.Name = "dtpDataConclusao";
            this.dtpDataConclusao.ShowCheckBox = true;
            this.dtpDataConclusao.Size = new System.Drawing.Size(115, 23);
            this.dtpDataConclusao.TabIndex = 3;
            // 
            // cboSituacao
            // 
            this.cboSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacao.FormattingEnabled = true;
            this.cboSituacao.Items.AddRange(new object[] {
            "Situação",
            "Pendente",
            "Concluído"});
            this.cboSituacao.Location = new System.Drawing.Point(299, 12);
            this.cboSituacao.Name = "cboSituacao";
            this.cboSituacao.Size = new System.Drawing.Size(115, 23);
            this.cboSituacao.TabIndex = 1;
            // 
            // FrmTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.cboSituacao);
            this.Controls.Add(this.dtpDataConclusao);
            this.Controls.Add(this.cboPrioridadeBusca);
            this.Controls.Add(this.txtTrecho);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarefas";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTarefa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox txtTitulo;
        private TextBox txtDescricao;
        private DateTimePicker dtpDataMaximaConclusao;
        private Label lblDataMaximaConclusao;
        private ComboBox cboPrioridade;
        private Button btnSalvar;
        private ErrorProvider errorProviderTarefa;
        private FlowLayoutPanel flpTarefas;
        private DateTimePicker dtpDataConclusao;
        private ComboBox cboPrioridadeBusca;
        private TextBox txtTrecho;
        private Button btnBuscar;
        private Button btnLimpar;
        private ComboBox cboSituacao;
        private ComboBox cboEvento;
        private Button btnAnexos;
        private Button btnContatos;
    }
}