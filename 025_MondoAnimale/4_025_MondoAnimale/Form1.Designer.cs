
namespace _4_025_MondoAnimale
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCavallo = new System.Windows.Forms.Button();
            this.btnUomo = new System.Windows.Forms.Button();
            this.btnCorvo = new System.Windows.Forms.Button();
            this.btnPinguino = new System.Windows.Forms.Button();
            this.btnGabbiano = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tonno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCavallo
            // 
            this.btnCavallo.Location = new System.Drawing.Point(107, 13);
            this.btnCavallo.Name = "btnCavallo";
            this.btnCavallo.Size = new System.Drawing.Size(75, 23);
            this.btnCavallo.TabIndex = 1;
            this.btnCavallo.Text = "Cavallo";
            this.btnCavallo.UseVisualStyleBackColor = true;
            this.btnCavallo.Click += new System.EventHandler(this.btnCavallo_Click);
            // 
            // btnUomo
            // 
            this.btnUomo.Location = new System.Drawing.Point(13, 42);
            this.btnUomo.Name = "btnUomo";
            this.btnUomo.Size = new System.Drawing.Size(75, 23);
            this.btnUomo.TabIndex = 2;
            this.btnUomo.Text = "Uomo";
            this.btnUomo.UseVisualStyleBackColor = true;
            this.btnUomo.Click += new System.EventHandler(this.btnUomo_Click);
            // 
            // btnCorvo
            // 
            this.btnCorvo.Location = new System.Drawing.Point(107, 42);
            this.btnCorvo.Name = "btnCorvo";
            this.btnCorvo.Size = new System.Drawing.Size(75, 23);
            this.btnCorvo.TabIndex = 3;
            this.btnCorvo.Text = "Corvo";
            this.btnCorvo.UseVisualStyleBackColor = true;
            this.btnCorvo.Click += new System.EventHandler(this.btnCorvo_Click);
            // 
            // btnPinguino
            // 
            this.btnPinguino.Location = new System.Drawing.Point(106, 71);
            this.btnPinguino.Name = "btnPinguino";
            this.btnPinguino.Size = new System.Drawing.Size(75, 23);
            this.btnPinguino.TabIndex = 5;
            this.btnPinguino.Text = "Pinguino";
            this.btnPinguino.UseVisualStyleBackColor = true;
            this.btnPinguino.Click += new System.EventHandler(this.btnPinguino_Click);
            // 
            // btnGabbiano
            // 
            this.btnGabbiano.Location = new System.Drawing.Point(12, 71);
            this.btnGabbiano.Name = "btnGabbiano";
            this.btnGabbiano.Size = new System.Drawing.Size(75, 23);
            this.btnGabbiano.TabIndex = 4;
            this.btnGabbiano.Text = "Gabbiano";
            this.btnGabbiano.UseVisualStyleBackColor = true;
            this.btnGabbiano.Click += new System.EventHandler(this.btnGabbiano_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 108);
            this.Controls.Add(this.btnPinguino);
            this.Controls.Add(this.btnGabbiano);
            this.Controls.Add(this.btnCorvo);
            this.Controls.Add(this.btnUomo);
            this.Controls.Add(this.btnCavallo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCavallo;
        private System.Windows.Forms.Button btnUomo;
        private System.Windows.Forms.Button btnCorvo;
        private System.Windows.Forms.Button btnPinguino;
        private System.Windows.Forms.Button btnGabbiano;
    }
}

