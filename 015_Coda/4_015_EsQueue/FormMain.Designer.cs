namespace _4_015_EsQueue
{
    partial class FormMain
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numEta = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbColore = new System.Windows.Forms.ComboBox();
            this.btnInserisciPaziente = new System.Windows.Forms.Button();
            this.btnMassima = new System.Windows.Forms.Button();
            this.btnMinima = new System.Windows.Forms.Button();
            this.numTemp = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numEta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(72, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(72, 40);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Età";
            // 
            // numEta
            // 
            this.numEta.Location = new System.Drawing.Point(72, 70);
            this.numEta.Name = "numEta";
            this.numEta.Size = new System.Drawing.Size(100, 20);
            this.numEta.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Colore";
            // 
            // cmbColore
            // 
            this.cmbColore.FormattingEnabled = true;
            this.cmbColore.Items.AddRange(new object[] {
            "ROSSO",
            "GIALLO",
            "VERDE",
            "BIANCO"});
            this.cmbColore.Location = new System.Drawing.Point(272, 40);
            this.cmbColore.Name = "cmbColore";
            this.cmbColore.Size = new System.Drawing.Size(121, 21);
            this.cmbColore.TabIndex = 7;
            // 
            // btnInserisciPaziente
            // 
            this.btnInserisciPaziente.Location = new System.Drawing.Point(89, 96);
            this.btnInserisciPaziente.Name = "btnInserisciPaziente";
            this.btnInserisciPaziente.Size = new System.Drawing.Size(255, 23);
            this.btnInserisciPaziente.TabIndex = 8;
            this.btnInserisciPaziente.Text = "Inserisci paziente";
            this.btnInserisciPaziente.UseVisualStyleBackColor = true;
            this.btnInserisciPaziente.Click += new System.EventHandler(this.btnInserisciPaziente_Click);
            // 
            // btnMassima
            // 
            this.btnMassima.Location = new System.Drawing.Point(72, 180);
            this.btnMassima.Name = "btnMassima";
            this.btnMassima.Size = new System.Drawing.Size(164, 23);
            this.btnMassima.TabIndex = 9;
            this.btnMassima.Text = "Temperatura massima";
            this.btnMassima.UseVisualStyleBackColor = true;
            this.btnMassima.Click += new System.EventHandler(this.btnMassima_Click);
            // 
            // btnMinima
            // 
            this.btnMinima.Location = new System.Drawing.Point(252, 180);
            this.btnMinima.Name = "btnMinima";
            this.btnMinima.Size = new System.Drawing.Size(164, 23);
            this.btnMinima.TabIndex = 10;
            this.btnMinima.Text = "Temperatura minima";
            this.btnMinima.UseVisualStyleBackColor = true;
            this.btnMinima.Click += new System.EventHandler(this.btnMinima_Click);
            // 
            // numTemp
            // 
            this.numTemp.Location = new System.Drawing.Point(293, 16);
            this.numTemp.Name = "numTemp";
            this.numTemp.Size = new System.Drawing.Size(100, 20);
            this.numTemp.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Temperatura";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numTemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMinima);
            this.Controls.Add(this.btnMassima);
            this.Controls.Add(this.btnInserisciPaziente);
            this.Controls.Add(this.cmbColore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numEta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "FormMain";
            this.Text = "InserisciPaziente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numEta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbColore;
        private System.Windows.Forms.Button btnInserisciPaziente;
        private System.Windows.Forms.Button btnMassima;
        private System.Windows.Forms.Button btnMinima;
        private System.Windows.Forms.NumericUpDown numTemp;
        private System.Windows.Forms.Label label5;
    }
}

