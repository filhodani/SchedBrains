namespace SchedBrains.View
{
    partial class UscContato
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
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFavorito = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.pcbImgPerfil = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(13, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDataNascimento.Location = new System.Drawing.Point(165, 164);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(0, 17);
            this.lblDataNascimento.TabIndex = 2;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(13, 164);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(0, 17);
            this.lblTelefone.TabIndex = 3;
            // 
            // lblApelido
            // 
            this.lblApelido.AutoSize = true;
            this.lblApelido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApelido.Location = new System.Drawing.Point(13, 140);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(0, 17);
            this.lblApelido.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(97, 140);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 17);
            this.lblEmail.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditar,
            this.mnuFavorito,
            this.mnuExcluir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 70);
            // 
            // mnuEditar
            // 
            this.mnuEditar.Name = "mnuEditar";
            this.mnuEditar.Size = new System.Drawing.Size(120, 22);
            this.mnuEditar.Text = "Editar";
            this.mnuEditar.Click += new System.EventHandler(this.mnuEditar_Click);
            // 
            // mnuFavorito
            // 
            this.mnuFavorito.Name = "mnuFavorito";
            this.mnuFavorito.Size = new System.Drawing.Size(120, 22);
            this.mnuFavorito.Text = "Favoritar";
            this.mnuFavorito.Click += new System.EventHandler(this.mnuFavorito_Click);
            // 
            // mnuExcluir
            // 
            this.mnuExcluir.Name = "mnuExcluir";
            this.mnuExcluir.Size = new System.Drawing.Size(120, 22);
            this.mnuExcluir.Text = "Excluir";
            this.mnuExcluir.Click += new System.EventHandler(this.mnuExcluir_Click);
            // 
            // pcbImgPerfil
            // 
            this.pcbImgPerfil.Image = global::SchedBrains.Properties.Resources.avatar;
            this.pcbImgPerfil.Location = new System.Drawing.Point(81, 13);
            this.pcbImgPerfil.Name = "pcbImgPerfil";
            this.pcbImgPerfil.Size = new System.Drawing.Size(90, 90);
            this.pcbImgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImgPerfil.TabIndex = 6;
            this.pcbImgPerfil.TabStop = false;
            // 
            // UscContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pcbImgPerfil);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApelido);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.Name = "UscContato";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(252, 191);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImgPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Label label1;
        private Label lblDataNascimento;
        private Label lblTelefone;
        private Label lblApelido;
        private Label lblEmail;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuEditar;
        private ToolStripMenuItem mnuFavorito;
        private ToolStripMenuItem mnuExcluir;
        private PictureBox pcbImgPerfil;
    }
}
