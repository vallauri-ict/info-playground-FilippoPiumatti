namespace _01_MultiForm
{
    partial class FormFiglia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenitore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenitore
            // 
            this.btnGenitore.Location = new System.Drawing.Point(12, 12);
            this.btnGenitore.Name = "btnGenitore";
            this.btnGenitore.Size = new System.Drawing.Size(118, 23);
            this.btnGenitore.TabIndex = 0;
            this.btnGenitore.Text = "Cerca Form Padre";
            this.btnGenitore.UseVisualStyleBackColor = true;
            this.btnGenitore.Click += new System.EventHandler(this.btnGenitore_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenitore);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenitore;
    }
}