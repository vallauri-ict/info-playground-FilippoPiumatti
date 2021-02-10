
namespace _4_026_EsercizioStagisti
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCitta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClasse = new System.Windows.Forms.ComboBox();
            this.cmbSezione = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAzienda = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numOre = new System.Windows.Forms.NumericUpDown();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.btnElimina = new System.Windows.Forms.Button();
            this.numPosElimina = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvStagisti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numOre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosElimina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStagisti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(65, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(64, 41);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cognome";
            // 
            // txtCitta
            // 
            this.txtCitta.Location = new System.Drawing.Point(64, 71);
            this.txtCitta.Name = "txtCitta";
            this.txtCitta.Size = new System.Drawing.Size(100, 20);
            this.txtCitta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Città";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Classe";
            // 
            // cmbClasse
            // 
            this.cmbClasse.FormattingEnabled = true;
            this.cmbClasse.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbClasse.Location = new System.Drawing.Point(251, 13);
            this.cmbClasse.Name = "cmbClasse";
            this.cmbClasse.Size = new System.Drawing.Size(100, 21);
            this.cmbClasse.TabIndex = 7;
            // 
            // cmbSezione
            // 
            this.cmbSezione.FormattingEnabled = true;
            this.cmbSezione.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbSezione.Location = new System.Drawing.Point(251, 41);
            this.cmbSezione.Name = "cmbSezione";
            this.cmbSezione.Size = new System.Drawing.Size(100, 21);
            this.cmbSezione.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sezione";
            // 
            // cmbSpec
            // 
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Items.AddRange(new object[] {
            "INF",
            "ELT",
            "MEC",
            "LSA"});
            this.cmbSpec.Location = new System.Drawing.Point(249, 68);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(100, 21);
            this.cmbSpec.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Spec";
            // 
            // cmbAzienda
            // 
            this.cmbAzienda.FormattingEnabled = true;
            this.cmbAzienda.Items.AddRange(new object[] {
            "AZIENDA1",
            "AZIENDA2",
            "AZIENDA3",
            "AZIENDA4"});
            this.cmbAzienda.Location = new System.Drawing.Point(65, 109);
            this.cmbAzienda.Name = "cmbAzienda";
            this.cmbAzienda.Size = new System.Drawing.Size(100, 21);
            this.cmbAzienda.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Azienda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ore";
            // 
            // numOre
            // 
            this.numOre.Location = new System.Drawing.Point(251, 109);
            this.numOre.Name = "numOre";
            this.numOre.Size = new System.Drawing.Size(100, 20);
            this.numOre.TabIndex = 15;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(16, 160);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(148, 23);
            this.btnInserisci.TabIndex = 16;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(201, 160);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(148, 23);
            this.btnRicerca.TabIndex = 17;
            this.btnRicerca.Text = "Ricerca Azienda";
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.ForeColor = System.Drawing.Color.Red;
            this.btnElimina.Location = new System.Drawing.Point(12, 189);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(333, 23);
            this.btnElimina.TabIndex = 19;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // numPosElimina
            // 
            this.numPosElimina.Location = new System.Drawing.Point(171, 224);
            this.numPosElimina.Name = "numPosElimina";
            this.numPosElimina.Size = new System.Drawing.Size(100, 20);
            this.numPosElimina.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Posizione";
            // 
            // dgvStagisti
            // 
            this.dgvStagisti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStagisti.Location = new System.Drawing.Point(368, 10);
            this.dgvStagisti.Name = "dgvStagisti";
            this.dgvStagisti.Size = new System.Drawing.Size(429, 256);
            this.dgvStagisti.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numPosElimina);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnElimina);
            this.Controls.Add(this.dgvStagisti);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.numOre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbAzienda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSpec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbSezione);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbClasse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCitta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPosElimina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStagisti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCitta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClasse;
        private System.Windows.Forms.ComboBox cmbSezione;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAzienda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numOre;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnRicerca;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.NumericUpDown numPosElimina;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvStagisti;
    }
}

