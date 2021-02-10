namespace _4_013_Dictionary
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
            this.btnCarica = new System.Windows.Forms.Button();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Autore = new System.Windows.Forms.Label();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarica
            // 
            this.btnCarica.Location = new System.Drawing.Point(13, 13);
            this.btnCarica.Name = "btnCarica";
            this.btnCarica.Size = new System.Drawing.Size(130, 23);
            this.btnCarica.TabIndex = 0;
            this.btnCarica.Text = "Carica Dictionary";
            this.btnCarica.UseVisualStyleBackColor = true;
            this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(56, 43);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(87, 20);
            this.txtTitolo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titolo";
            // 
            // Autore
            // 
            this.Autore.AutoSize = true;
            this.Autore.Location = new System.Drawing.Point(13, 79);
            this.Autore.Name = "Autore";
            this.Autore.Size = new System.Drawing.Size(33, 13);
            this.Autore.TabIndex = 4;
            this.Autore.Text = "Titolo";
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(56, 73);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(87, 20);
            this.txtAutore.TabIndex = 3;
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(12, 99);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(130, 23);
            this.btnVisualizza.TabIndex = 5;
            this.btnVisualizza.Text = "Visualizza Dictionary";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.Autore);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.btnCarica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarica;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Autore;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Button btnVisualizza;
    }
}

