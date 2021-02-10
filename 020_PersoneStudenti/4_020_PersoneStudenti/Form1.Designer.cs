
namespace _4_020_PersoneStudenti
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSesso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAggiungiStudente = new System.Windows.Forms.Button();
            this.lblVoto = new System.Windows.Forms.Label();
            this.BtnAggiungi = new System.Windows.Forms.Button();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.NumEta = new System.Windows.Forms.NumericUpDown();
            this.BtnVisualizzaMedia = new System.Windows.Forms.Button();
            this.numVoti = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumEta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(71, 48);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cognome";
            // 
            // txtSesso
            // 
            this.txtSesso.Location = new System.Drawing.Point(71, 82);
            this.txtSesso.Name = "txtSesso";
            this.txtSesso.Size = new System.Drawing.Size(100, 20);
            this.txtSesso.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sesso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Età";
            // 
            // BtnAggiungiStudente
            // 
            this.BtnAggiungiStudente.Location = new System.Drawing.Point(239, 36);
            this.BtnAggiungiStudente.Name = "BtnAggiungiStudente";
            this.BtnAggiungiStudente.Size = new System.Drawing.Size(109, 37);
            this.BtnAggiungiStudente.TabIndex = 8;
            this.BtnAggiungiStudente.Text = "Genera";
            this.BtnAggiungiStudente.UseVisualStyleBackColor = true;
            this.BtnAggiungiStudente.Click += new System.EventHandler(this.BtnAggiungiStudente_Click);
            // 
            // lblVoto
            // 
            this.lblVoto.AutoSize = true;
            this.lblVoto.Location = new System.Drawing.Point(12, 316);
            this.lblVoto.Name = "lblVoto";
            this.lblVoto.Size = new System.Drawing.Size(25, 13);
            this.lblVoto.TabIndex = 9;
            this.lblVoto.Text = "Voti";
            // 
            // BtnAggiungi
            // 
            this.BtnAggiungi.Location = new System.Drawing.Point(229, 313);
            this.BtnAggiungi.Name = "BtnAggiungi";
            this.BtnAggiungi.Size = new System.Drawing.Size(91, 24);
            this.BtnAggiungi.TabIndex = 11;
            this.BtnAggiungi.Text = "Aggiungi";
            this.BtnAggiungi.UseVisualStyleBackColor = true;
            this.BtnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // listViewMain
            // 
            this.listViewMain.HideSelection = false;
            this.listViewMain.Location = new System.Drawing.Point(508, 13);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(121, 339);
            this.listViewMain.TabIndex = 12;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.List;
            this.listViewMain.SelectedIndexChanged += new System.EventHandler(this.listViewMain_SelectedIndexChanged);
            // 
            // NumEta
            // 
            this.NumEta.Location = new System.Drawing.Point(71, 116);
            this.NumEta.Name = "NumEta";
            this.NumEta.Size = new System.Drawing.Size(100, 20);
            this.NumEta.TabIndex = 14;
            // 
            // BtnVisualizzaMedia
            // 
            this.BtnVisualizzaMedia.Location = new System.Drawing.Point(338, 312);
            this.BtnVisualizzaMedia.Name = "BtnVisualizzaMedia";
            this.BtnVisualizzaMedia.Size = new System.Drawing.Size(91, 24);
            this.BtnVisualizzaMedia.TabIndex = 15;
            this.BtnVisualizzaMedia.Text = "Media";
            this.BtnVisualizzaMedia.UseVisualStyleBackColor = true;
            this.BtnVisualizzaMedia.Click += new System.EventHandler(this.BtnVisualizzaMedia_Click);
            // 
            // numVoti
            // 
            this.numVoti.Location = new System.Drawing.Point(71, 309);
            this.numVoti.Name = "numVoti";
            this.numVoti.Size = new System.Drawing.Size(100, 20);
            this.numVoti.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 364);
            this.Controls.Add(this.numVoti);
            this.Controls.Add(this.BtnVisualizzaMedia);
            this.Controls.Add(this.NumEta);
            this.Controls.Add(this.listViewMain);
            this.Controls.Add(this.BtnAggiungi);
            this.Controls.Add(this.lblVoto);
            this.Controls.Add(this.BtnAggiungiStudente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSesso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumEta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVoti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSesso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAggiungiStudente;
        private System.Windows.Forms.Label lblVoto;
        private System.Windows.Forms.Button BtnAggiungi;
        private System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.NumericUpDown NumEta;
        private System.Windows.Forms.Button BtnVisualizzaMedia;
        private System.Windows.Forms.NumericUpDown numVoti;
    }
}

