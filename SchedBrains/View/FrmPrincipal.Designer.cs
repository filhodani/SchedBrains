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
            this.btnTarefa = new System.Windows.Forms.Button();
            this.btnContato = new System.Windows.Forms.Button();
            this.btnEvento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTarefa
            // 
            this.btnTarefa.Location = new System.Drawing.Point(115, 164);
            this.btnTarefa.Name = "btnTarefa";
            this.btnTarefa.Size = new System.Drawing.Size(75, 23);
            this.btnTarefa.TabIndex = 0;
            this.btnTarefa.Text = "Tarefa";
            this.btnTarefa.UseVisualStyleBackColor = true;
            this.btnTarefa.Click += new System.EventHandler(this.btnTarefa_Click);
            // 
            // btnContato
            // 
            this.btnContato.Location = new System.Drawing.Point(287, 164);
            this.btnContato.Name = "btnContato";
            this.btnContato.Size = new System.Drawing.Size(75, 23);
            this.btnContato.TabIndex = 1;
            this.btnContato.Text = "Contato";
            this.btnContato.UseVisualStyleBackColor = true;
            // 
            // btnEvento
            // 
            this.btnEvento.Location = new System.Drawing.Point(474, 164);
            this.btnEvento.Name = "btnEvento";
            this.btnEvento.Size = new System.Drawing.Size(75, 23);
            this.btnEvento.TabIndex = 2;
            this.btnEvento.Text = "Evento";
            this.btnEvento.UseVisualStyleBackColor = true;
            this.btnEvento.Click += new System.EventHandler(this.btnEvento_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEvento);
            this.Controls.Add(this.btnContato);
            this.Controls.Add(this.btnTarefa);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTarefa;
        private Button btnContato;
        private Button btnEvento;
    }
}