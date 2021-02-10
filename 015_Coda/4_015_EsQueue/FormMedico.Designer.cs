namespace _4_015_EsQueue
{
    partial class FormMedico
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
            this.btnProssimoPaziente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProssimoPaziente
            // 
            this.btnProssimoPaziente.Location = new System.Drawing.Point(13, 13);
            this.btnProssimoPaziente.Name = "btnProssimoPaziente";
            this.btnProssimoPaziente.Size = new System.Drawing.Size(187, 23);
            this.btnProssimoPaziente.TabIndex = 0;
            this.btnProssimoPaziente.Text = "Prossimo Paziente";
            this.btnProssimoPaziente.UseVisualStyleBackColor = true;
            this.btnProssimoPaziente.Click += new System.EventHandler(this.btnProssimoPaziente_Click);
            // 
            // FormMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProssimoPaziente);
            this.Name = "FormMedico";
            this.Text = "FormMedico";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProssimoPaziente;
    }
}