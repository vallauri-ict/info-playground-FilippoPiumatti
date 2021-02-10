namespace _4_003_MultiFormMenu
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.leggiValoreBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.inviaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFormFigliaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leggiValoreBtn,
            this.inviaToolStripMenuItem,
            this.apriFormFigliaToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // leggiValoreBtn
            // 
            this.leggiValoreBtn.Name = "leggiValoreBtn";
            this.leggiValoreBtn.Size = new System.Drawing.Size(83, 20);
            this.leggiValoreBtn.Text = "&Leggi valore";
            this.leggiValoreBtn.Click += new System.EventHandler(this.leggiValoreBtn_Click);
            // 
            // inviaToolStripMenuItem
            // 
            this.inviaToolStripMenuItem.Name = "inviaToolStripMenuItem";
            this.inviaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.inviaToolStripMenuItem.Text = "&Invia";
            this.inviaToolStripMenuItem.Click += new System.EventHandler(this.inviaToolStripMenuItem_Click);
            // 
            // apriFormFigliaToolStripMenuItem
            // 
            this.apriFormFigliaToolStripMenuItem.Name = "apriFormFigliaToolStripMenuItem";
            this.apriFormFigliaToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.apriFormFigliaToolStripMenuItem.Text = "&Apri Form Figlia";
            this.apriFormFigliaToolStripMenuItem.Click += new System.EventHandler(this.apriFormFigliaToolStripMenuItem_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(12, 27);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "toolStrip";
            // 
            // toolStripLbl
            // 
            this.toolStripLbl.Name = "toolStripLbl";
            this.toolStripLbl.Size = new System.Drawing.Size(43, 17);
            this.toolStripLbl.Text = "Pronto";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.esciToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.esciToolStripMenuItem.Text = "&Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem leggiValoreBtn;
        private System.Windows.Forms.ToolStripMenuItem inviaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriFormFigliaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLbl;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
    }
}