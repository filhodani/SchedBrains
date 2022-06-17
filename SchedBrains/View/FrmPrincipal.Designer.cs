namespace SchedBrains.View
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuContatos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTarefas = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContatos,
            this.mnuEventos,
            this.mnuTarefas,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuContatos
            // 
            this.mnuContatos.Name = "mnuContatos";
            this.mnuContatos.Size = new System.Drawing.Size(67, 20);
            this.mnuContatos.Text = "Contatos";
            this.mnuContatos.Click += new System.EventHandler(this.mnuContatos_Click);
            // 
            // mnuEventos
            // 
            this.mnuEventos.Name = "mnuEventos";
            this.mnuEventos.Size = new System.Drawing.Size(60, 20);
            this.mnuEventos.Text = "Eventos";
            this.mnuEventos.Click += new System.EventHandler(this.mnuEventos_Click);
            // 
            // mnuTarefas
            // 
            this.mnuTarefas.Name = "mnuTarefas";
            this.mnuTarefas.Size = new System.Drawing.Size(55, 20);
            this.mnuTarefas.Text = "Tarefas";
            this.mnuTarefas.Click += new System.EventHandler(this.mnuTarefas_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuContatos;
        private ToolStripMenuItem mnuEventos;
        private ToolStripMenuItem mnuTarefas;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}