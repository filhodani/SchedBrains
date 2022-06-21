namespace SchedBrains.View
{
    partial class UscEvento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UscEvento));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pcbImgEvento = new System.Windows.Forms.PictureBox();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblDataTermino = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgEvento)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(13, 135);
            this.lblTitulo.MaximumSize = new System.Drawing.Size(189, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 51);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Alameda Raymundo Ruzzante 523 - Jardim Parati II B";
            // 
            // pcbImgEvento
            // 
            this.pcbImgEvento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbImgEvento.Image = global::SchedBrains.Properties.Resources.landscape;
            this.pcbImgEvento.Location = new System.Drawing.Point(13, 13);
            this.pcbImgEvento.Name = "pcbImgEvento";
            this.pcbImgEvento.Size = new System.Drawing.Size(189, 110);
            this.pcbImgEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImgEvento.TabIndex = 1;
            this.pcbImgEvento.TabStop = false;
            // 
            // lblLocal
            // 
            this.lblLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(13, 191);
            this.lblLocal.MaximumSize = new System.Drawing.Size(189, 0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(189, 30);
            this.lblLocal.TabIndex = 2;
            this.lblLocal.Text = "Alameda Raymundo Ruzzante 523 - Jardim Parati II B";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(13, 229);
            this.lblDescricao.MaximumSize = new System.Drawing.Size(189, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(188, 120);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = resources.GetString("lblDescricao.Text");
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Location = new System.Drawing.Point(13, 365);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(127, 15);
            this.lblDataInicio.TabIndex = 4;
            this.lblDataInicio.Text = "Inicio 21/06/2022 12:35";
            // 
            // lblSituacao
            // 
            this.lblSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSituacao.ForeColor = System.Drawing.Color.DimGray;
            this.lblSituacao.Location = new System.Drawing.Point(130, 405);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(88, 15);
            this.lblSituacao.TabIndex = 5;
            this.lblSituacao.Text = "Em andamento";
            // 
            // lblDataTermino
            // 
            this.lblDataTermino.AutoSize = true;
            this.lblDataTermino.Location = new System.Drawing.Point(13, 386);
            this.lblDataTermino.Name = "lblDataTermino";
            this.lblDataTermino.Size = new System.Drawing.Size(147, 15);
            this.lblDataTermino.TabIndex = 6;
            this.lblDataTermino.Text = "Término:  21/06/2022 12:35";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditar,
            this.mnuConcluir,
            this.mnuExcluir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 70);
            // 
            // mnuEditar
            // 
            this.mnuEditar.Name = "mnuEditar";
            this.mnuEditar.Size = new System.Drawing.Size(119, 22);
            this.mnuEditar.Text = "Editar";
            this.mnuEditar.Click += new System.EventHandler(this.mnuEditar_Click);
            // 
            // mnuConcluir
            // 
            this.mnuConcluir.Name = "mnuConcluir";
            this.mnuConcluir.Size = new System.Drawing.Size(119, 22);
            this.mnuConcluir.Text = "Concluir";
            this.mnuConcluir.Click += new System.EventHandler(this.mnuConcluir_Click);
            // 
            // mnuExcluir
            // 
            this.mnuExcluir.Name = "mnuExcluir";
            this.mnuExcluir.Size = new System.Drawing.Size(119, 22);
            this.mnuExcluir.Text = "Excluir";
            this.mnuExcluir.Click += new System.EventHandler(this.mnuExcluir_Click);
            // 
            // UscEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblDataTermino);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lblDataInicio);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.pcbImgEvento);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.Name = "UscEvento";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(215, 430);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgEvento)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private PictureBox pcbImgEvento;
        private Label lblLocal;
        private Label lblDescricao;
        private Label lblDataInicio;
        private Label lblSituacao;
        private Label lblDataTermino;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuEditar;
        private ToolStripMenuItem mnuExcluir;
        private ToolStripMenuItem mnuConcluir;
    }
}
