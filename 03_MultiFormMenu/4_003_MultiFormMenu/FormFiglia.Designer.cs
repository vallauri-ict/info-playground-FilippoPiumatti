namespace _4_003_MultiFormMenu
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
            this.btnCercaPadre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCercaPadre
            // 
            this.btnCercaPadre.Location = new System.Drawing.Point(67, 28);
            this.btnCercaPadre.Name = "btnCercaPadre";
            this.btnCercaPadre.Size = new System.Drawing.Size(139, 31);
            this.btnCercaPadre.TabIndex = 0;
            this.btnCercaPadre.Text = "Cerca Padre";
            this.btnCercaPadre.UseVisualStyleBackColor = true;
            this.btnCercaPadre.Click += new System.EventHandler(this.btnCercaPadre_Click);
            // 
            // FormFiglia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 71);
            this.Controls.Add(this.btnCercaPadre);
            this.Name = "FormFiglia";
            this.Text = "FormFiglia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCercaPadre;
    }
}