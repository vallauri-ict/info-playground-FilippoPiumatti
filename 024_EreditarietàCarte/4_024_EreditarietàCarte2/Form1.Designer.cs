
namespace _4_024_EreditarietàCarte2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtValore = new System.Windows.Forms.TextBox();
            this.txtSeme = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnCarta1 = new System.Windows.Forms.Button();
            this.btnCercaCarta = new System.Windows.Forms.Button();
            this.btnMescola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seme";
            // 
            // txtValore
            // 
            this.txtValore.Location = new System.Drawing.Point(57, 13);
            this.txtValore.Name = "txtValore";
            this.txtValore.Size = new System.Drawing.Size(100, 20);
            this.txtValore.TabIndex = 2;
            // 
            // txtSeme
            // 
            this.txtSeme.Location = new System.Drawing.Point(57, 40);
            this.txtSeme.Name = "txtSeme";
            this.txtSeme.Size = new System.Drawing.Size(100, 20);
            this.txtSeme.TabIndex = 3;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(189, 10);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 4;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnCarta1
            // 
            this.btnCarta1.Location = new System.Drawing.Point(15, 83);
            this.btnCarta1.Name = "btnCarta1";
            this.btnCarta1.Size = new System.Drawing.Size(249, 23);
            this.btnCarta1.TabIndex = 5;
            this.btnCarta1.Text = "Dammi prima carta mazzo";
            this.btnCarta1.UseVisualStyleBackColor = true;
            this.btnCarta1.Click += new System.EventHandler(this.btnCarta1_Click);
            // 
            // btnCercaCarta
            // 
            this.btnCercaCarta.Location = new System.Drawing.Point(189, 43);
            this.btnCercaCarta.Name = "btnCercaCarta";
            this.btnCercaCarta.Size = new System.Drawing.Size(75, 23);
            this.btnCercaCarta.TabIndex = 6;
            this.btnCercaCarta.Text = "Cerca";
            this.btnCercaCarta.UseVisualStyleBackColor = true;
            this.btnCercaCarta.Click += new System.EventHandler(this.btnCercaCarta_Click);
            // 
            // btnMescola
            // 
            this.btnMescola.Location = new System.Drawing.Point(15, 112);
            this.btnMescola.Name = "btnMescola";
            this.btnMescola.Size = new System.Drawing.Size(249, 23);
            this.btnMescola.TabIndex = 7;
            this.btnMescola.Text = "Mescola mazzo";
            this.btnMescola.UseVisualStyleBackColor = true;
            this.btnMescola.Click += new System.EventHandler(this.btnMescola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 158);
            this.Controls.Add(this.btnMescola);
            this.Controls.Add(this.btnCercaCarta);
            this.Controls.Add(this.btnCarta1);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtSeme);
            this.Controls.Add(this.txtValore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValore;
        private System.Windows.Forms.TextBox txtSeme;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnCarta1;
        private System.Windows.Forms.Button btnCercaCarta;
        private System.Windows.Forms.Button btnMescola;
    }
}

