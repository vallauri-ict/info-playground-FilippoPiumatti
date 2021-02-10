namespace _01_MultiForm
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
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnForm2B = new System.Windows.Forms.Button();
            this.txtPassata = new System.Windows.Forms.TextBox();
            this.btnPassaTxt = new System.Windows.Forms.Button();
            this.btnApriFormModale = new System.Windows.Forms.Button();
            this.lblNomeFormMain = new System.Windows.Forms.Label();
            this.txtNomeFormMain = new System.Windows.Forms.TextBox();
            this.txtEtaFormMain = new System.Windows.Forms.TextBox();
            this.lblEtaFormMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(13, 13);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(75, 23);
            this.btnForm2.TabIndex = 0;
            this.btnForm2.Text = "Apri Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // btnForm2B
            // 
            this.btnForm2B.Location = new System.Drawing.Point(94, 13);
            this.btnForm2B.Name = "btnForm2B";
            this.btnForm2B.Size = new System.Drawing.Size(75, 23);
            this.btnForm2B.TabIndex = 1;
            this.btnForm2B.Text = "Apri Form2B";
            this.btnForm2B.UseVisualStyleBackColor = true;
            this.btnForm2B.Click += new System.EventHandler(this.btnForm2B_Click);
            // 
            // txtPassata
            // 
            this.txtPassata.Location = new System.Drawing.Point(13, 42);
            this.txtPassata.Name = "txtPassata";
            this.txtPassata.Size = new System.Drawing.Size(100, 20);
            this.txtPassata.TabIndex = 2;
            // 
            // btnPassaTxt
            // 
            this.btnPassaTxt.Location = new System.Drawing.Point(119, 42);
            this.btnPassaTxt.Name = "btnPassaTxt";
            this.btnPassaTxt.Size = new System.Drawing.Size(141, 23);
            this.btnPassaTxt.TabIndex = 3;
            this.btnPassaTxt.Text = "Passa TextBox a Form2";
            this.btnPassaTxt.UseVisualStyleBackColor = true;
            this.btnPassaTxt.Click += new System.EventHandler(this.btnPassaTxt_Click);
            // 
            // btnApriFormModale
            // 
            this.btnApriFormModale.Location = new System.Drawing.Point(13, 124);
            this.btnApriFormModale.Name = "btnApriFormModale";
            this.btnApriFormModale.Size = new System.Drawing.Size(139, 23);
            this.btnApriFormModale.TabIndex = 4;
            this.btnApriFormModale.Text = "Apri Form Modale";
            this.btnApriFormModale.UseVisualStyleBackColor = true;
            this.btnApriFormModale.Click += new System.EventHandler(this.btnApriFormModale_Click);
            // 
            // lblNomeFormMain
            // 
            this.lblNomeFormMain.AutoSize = true;
            this.lblNomeFormMain.Location = new System.Drawing.Point(10, 161);
            this.lblNomeFormMain.Name = "lblNomeFormMain";
            this.lblNomeFormMain.Size = new System.Drawing.Size(35, 13);
            this.lblNomeFormMain.TabIndex = 5;
            this.lblNomeFormMain.Text = "Nome";
            // 
            // txtNomeFormMain
            // 
            this.txtNomeFormMain.Location = new System.Drawing.Point(52, 158);
            this.txtNomeFormMain.Name = "txtNomeFormMain";
            this.txtNomeFormMain.ReadOnly = true;
            this.txtNomeFormMain.Size = new System.Drawing.Size(100, 20);
            this.txtNomeFormMain.TabIndex = 6;
            // 
            // txtEtaFormMain
            // 
            this.txtEtaFormMain.Location = new System.Drawing.Point(52, 184);
            this.txtEtaFormMain.Name = "txtEtaFormMain";
            this.txtEtaFormMain.ReadOnly = true;
            this.txtEtaFormMain.Size = new System.Drawing.Size(100, 20);
            this.txtEtaFormMain.TabIndex = 8;
            // 
            // lblEtaFormMain
            // 
            this.lblEtaFormMain.AutoSize = true;
            this.lblEtaFormMain.Location = new System.Drawing.Point(10, 187);
            this.lblEtaFormMain.Name = "lblEtaFormMain";
            this.lblEtaFormMain.Size = new System.Drawing.Size(23, 13);
            this.lblEtaFormMain.TabIndex = 7;
            this.lblEtaFormMain.Text = "Età";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEtaFormMain);
            this.Controls.Add(this.lblEtaFormMain);
            this.Controls.Add(this.txtNomeFormMain);
            this.Controls.Add(this.lblNomeFormMain);
            this.Controls.Add(this.btnApriFormModale);
            this.Controls.Add(this.btnPassaTxt);
            this.Controls.Add(this.txtPassata);
            this.Controls.Add(this.btnForm2B);
            this.Controls.Add(this.btnForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnForm2B;
        private System.Windows.Forms.TextBox txtPassata;
        private System.Windows.Forms.Button btnPassaTxt;
        private System.Windows.Forms.Button btnApriFormModale;
        private System.Windows.Forms.Label lblNomeFormMain;
        private System.Windows.Forms.TextBox txtNomeFormMain;
        private System.Windows.Forms.TextBox txtEtaFormMain;
        private System.Windows.Forms.Label lblEtaFormMain;
    }
}

