
namespace _4_017_Ereditarietà
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
            this.BtnMostro = new System.Windows.Forms.Button();
            this.BtnMannaro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMostro
            // 
            this.BtnMostro.Location = new System.Drawing.Point(12, 12);
            this.BtnMostro.Name = "BtnMostro";
            this.BtnMostro.Size = new System.Drawing.Size(148, 68);
            this.BtnMostro.TabIndex = 0;
            this.BtnMostro.Text = "Mostro";
            this.BtnMostro.UseVisualStyleBackColor = true;
            this.BtnMostro.Click += new System.EventHandler(this.BtnMostro_Click);
            // 
            // BtnMannaro
            // 
            this.BtnMannaro.Location = new System.Drawing.Point(166, 12);
            this.BtnMannaro.Name = "BtnMannaro";
            this.BtnMannaro.Size = new System.Drawing.Size(148, 68);
            this.BtnMannaro.TabIndex = 1;
            this.BtnMannaro.Text = "Mannaro";
            this.BtnMannaro.UseVisualStyleBackColor = true;
            this.BtnMannaro.Click += new System.EventHandler(this.BtnMannaro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 91);
            this.Controls.Add(this.BtnMannaro);
            this.Controls.Add(this.BtnMostro);
            this.Name = "Form1";
            this.Text = "MonsterLand";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMostro;
        private System.Windows.Forms.Button BtnMannaro;
    }
}

