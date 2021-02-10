namespace _4_009_PrintSpooler
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreaElemento = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreaElemento
            // 
            this.btnCreaElemento.Location = new System.Drawing.Point(12, 38);
            this.btnCreaElemento.Name = "btnCreaElemento";
            this.btnCreaElemento.Size = new System.Drawing.Size(180, 23);
            this.btnCreaElemento.TabIndex = 0;
            this.btnCreaElemento.Text = "Crea nuovo elemento";
            this.btnCreaElemento.UseVisualStyleBackColor = true;
            this.btnCreaElemento.Click += new System.EventHandler(this.btnCreaElemento_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.BackColor = System.Drawing.Color.Salmon;
            this.btnStampa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStampa.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnStampa.Location = new System.Drawing.Point(608, 38);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(180, 23);
            this.btnStampa.TabIndex = 1;
            this.btnStampa.Text = "Stampa";
            this.btnStampa.UseVisualStyleBackColor = false;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 382);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnCreaElemento);
            this.Name = "Form1";
            this.Text = "Spooler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreaElemento;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

