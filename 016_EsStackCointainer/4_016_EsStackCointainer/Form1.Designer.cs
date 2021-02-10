namespace _4_016_EsStackContainer
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
            this.numTara = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.btnCarica = new System.Windows.Forms.Button();
            this.btnScarica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // numTara
            // 
            this.numTara.Location = new System.Drawing.Point(136, 105);
            this.numTara.Name = "numTara";
            this.numTara.Size = new System.Drawing.Size(45, 20);
            this.numTara.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codice";
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(81, 50);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 20);
            this.txtCodice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tara";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(35, 82);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 4;
            this.lblPeso.Text = "Peso";
            // 
            // numPeso
            // 
            this.numPeso.Location = new System.Drawing.Point(136, 80);
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(45, 20);
            this.numPeso.TabIndex = 5;
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(38, 139);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(143, 23);
            this.btnCarica.TabIndex = 6;
            this.btnCarica.Text = "Carica";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // btnScarica
            // 
            this.btnScarica.Location = new System.Drawing.Point(38, 168);
            this.btnScarica.Name = "btnScarica";
            this.btnScarica.Size = new System.Drawing.Size(143, 23);
            this.btnScarica.TabIndex = 7;
            this.btnScarica.Text = "Scarica";
            this.btnScarica.UseVisualStyleBackColor = true;
            this.btnScarica.Click += new System.EventHandler(this.btnScarica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 251);
            this.Controls.Add(this.btnScarica);
            this.Controls.Add(this.btnCarica);
            this.Controls.Add(this.numPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.NumericUpDown numPeso;
        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.Button btnScarica;
    }
}

