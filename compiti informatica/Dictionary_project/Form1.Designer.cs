namespace Dictionary_project
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
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblAutore = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(47, 82);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 59);
            this.btnInserisci.TabIndex = 0;
            this.btnInserisci.Text = "inserisci libro";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(47, 178);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 48);
            this.btnVisualizza.TabIndex = 1;
            this.btnVisualizza.Text = "visualizza libro";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Location = new System.Drawing.Point(157, 104);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(32, 13);
            this.lblTitolo.TabIndex = 2;
            this.lblTitolo.Text = "titolo:";
            // 
            // lblAutore
            // 
            this.lblAutore.AutoSize = true;
            this.lblAutore.Location = new System.Drawing.Point(157, 196);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(43, 13);
            this.lblAutore.TabIndex = 3;
            this.lblAutore.Text = "autore: ";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(206, 102);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo.TabIndex = 4;
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(206, 196);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(100, 20);
            this.txtAutore.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.lblAutore);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnInserisci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnVisualizza;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblAutore;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.TextBox txtAutore;
    }
}

