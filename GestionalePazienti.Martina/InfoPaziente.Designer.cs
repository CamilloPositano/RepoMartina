namespace GestionalePazienti.Martina
{
    partial class InfoPaziente
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
            this.TitoloLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeTxt = new System.Windows.Forms.TextBox();
            this.cognomeTxt = new System.Windows.Forms.TextBox();
            this.codiceFiscaleTxt = new System.Windows.Forms.TextBox();
            this.luogoDiNascitaTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataDiNascitaTxt = new System.Windows.Forms.DateTimePicker();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.modificaBtn = new System.Windows.Forms.Button();
            this.eliminaBtn = new System.Windows.Forms.Button();
            this.annullaEditBtn = new System.Windows.Forms.Button();
            this.salvaEditBtn = new System.Windows.Forms.Button();
            this.indietroBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitoloLbl
            // 
            this.TitoloLbl.AutoSize = true;
            this.TitoloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitoloLbl.Location = new System.Drawing.Point(289, 50);
            this.TitoloLbl.Name = "TitoloLbl";
            this.TitoloLbl.Size = new System.Drawing.Size(213, 29);
            this.TitoloLbl.TabIndex = 0;
            this.TitoloLbl.Text = "INFO PAZIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "COGNOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "DATA DI NASCITA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "CODICE FISCALE";
            // 
            // nomeTxt
            // 
            this.nomeTxt.Location = new System.Drawing.Point(192, 130);
            this.nomeTxt.Name = "nomeTxt";
            this.nomeTxt.ReadOnly = true;
            this.nomeTxt.Size = new System.Drawing.Size(100, 22);
            this.nomeTxt.TabIndex = 5;
            this.nomeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cognomeTxt
            // 
            this.cognomeTxt.Location = new System.Drawing.Point(495, 130);
            this.cognomeTxt.Name = "cognomeTxt";
            this.cognomeTxt.ReadOnly = true;
            this.cognomeTxt.Size = new System.Drawing.Size(100, 22);
            this.cognomeTxt.TabIndex = 6;
            this.cognomeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codiceFiscaleTxt
            // 
            this.codiceFiscaleTxt.Location = new System.Drawing.Point(531, 255);
            this.codiceFiscaleTxt.Name = "codiceFiscaleTxt";
            this.codiceFiscaleTxt.ReadOnly = true;
            this.codiceFiscaleTxt.Size = new System.Drawing.Size(140, 22);
            this.codiceFiscaleTxt.TabIndex = 8;
            this.codiceFiscaleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // luogoDiNascitaTxt
            // 
            this.luogoDiNascitaTxt.Location = new System.Drawing.Point(335, 255);
            this.luogoDiNascitaTxt.Name = "luogoDiNascitaTxt";
            this.luogoDiNascitaTxt.ReadOnly = true;
            this.luogoDiNascitaTxt.Size = new System.Drawing.Size(135, 22);
            this.luogoDiNascitaTxt.TabIndex = 10;
            this.luogoDiNascitaTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.luogoDiNascitaTxt.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "LUOGO DI NASCITA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataDiNascitaTxt
            // 
            this.dataDiNascitaTxt.Enabled = false;
            this.dataDiNascitaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataDiNascitaTxt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDiNascitaTxt.Location = new System.Drawing.Point(127, 253);
            this.dataDiNascitaTxt.Name = "dataDiNascitaTxt";
            this.dataDiNascitaTxt.Size = new System.Drawing.Size(121, 26);
            this.dataDiNascitaTxt.TabIndex = 11;
            // 
            // idTxt
            // 
            this.idTxt.Enabled = false;
            this.idTxt.Location = new System.Drawing.Point(12, 39);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(37, 22);
            this.idTxt.TabIndex = 12;
            this.idTxt.Visible = false;
            // 
            // modificaBtn
            // 
            this.modificaBtn.BackColor = System.Drawing.Color.Chartreuse;
            this.modificaBtn.Location = new System.Drawing.Point(294, 352);
            this.modificaBtn.Name = "modificaBtn";
            this.modificaBtn.Size = new System.Drawing.Size(75, 36);
            this.modificaBtn.TabIndex = 13;
            this.modificaBtn.Text = "Modifica";
            this.modificaBtn.UseVisualStyleBackColor = false;
            this.modificaBtn.Click += new System.EventHandler(this.modificaBtn_Click);
            // 
            // eliminaBtn
            // 
            this.eliminaBtn.BackColor = System.Drawing.Color.Red;
            this.eliminaBtn.Location = new System.Drawing.Point(427, 352);
            this.eliminaBtn.Name = "eliminaBtn";
            this.eliminaBtn.Size = new System.Drawing.Size(75, 36);
            this.eliminaBtn.TabIndex = 14;
            this.eliminaBtn.Text = "Elimina";
            this.eliminaBtn.UseVisualStyleBackColor = false;
            // 
            // annullaEditBtn
            // 
            this.annullaEditBtn.Location = new System.Drawing.Point(335, 415);
            this.annullaEditBtn.Name = "annullaEditBtn";
            this.annullaEditBtn.Size = new System.Drawing.Size(75, 23);
            this.annullaEditBtn.TabIndex = 15;
            this.annullaEditBtn.Text = "Annulla";
            this.annullaEditBtn.UseVisualStyleBackColor = true;
            this.annullaEditBtn.Visible = false;
            this.annullaEditBtn.Click += new System.EventHandler(this.annullaEditBtn_Click);
            // 
            // salvaEditBtn
            // 
            this.salvaEditBtn.Location = new System.Drawing.Point(335, 390);
            this.salvaEditBtn.Name = "salvaEditBtn";
            this.salvaEditBtn.Size = new System.Drawing.Size(75, 23);
            this.salvaEditBtn.TabIndex = 16;
            this.salvaEditBtn.Text = "Salva";
            this.salvaEditBtn.UseVisualStyleBackColor = true;
            this.salvaEditBtn.Visible = false;
            this.salvaEditBtn.Click += new System.EventHandler(this.salvaEditBtn_Click);
            // 
            // indietroBtn
            // 
            this.indietroBtn.Location = new System.Drawing.Point(12, 10);
            this.indietroBtn.Name = "indietroBtn";
            this.indietroBtn.Size = new System.Drawing.Size(75, 23);
            this.indietroBtn.TabIndex = 17;
            this.indietroBtn.Text = "Indietro";
            this.indietroBtn.UseVisualStyleBackColor = true;
            this.indietroBtn.Click += new System.EventHandler(this.indietroBtn_Click);
            // 
            // InfoPaziente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.indietroBtn);
            this.Controls.Add(this.salvaEditBtn);
            this.Controls.Add(this.annullaEditBtn);
            this.Controls.Add(this.eliminaBtn);
            this.Controls.Add(this.modificaBtn);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.dataDiNascitaTxt);
            this.Controls.Add(this.luogoDiNascitaTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.codiceFiscaleTxt);
            this.Controls.Add(this.cognomeTxt);
            this.Controls.Add(this.nomeTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitoloLbl);
            this.Name = "InfoPaziente";
            this.Text = "InfoPaziente";
            this.Load += new System.EventHandler(this.InfoPaziente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitoloLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cognomeTxt;
        private System.Windows.Forms.TextBox codiceFiscaleTxt;
        private System.Windows.Forms.TextBox luogoDiNascitaTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dataDiNascitaTxt;
        private System.Windows.Forms.TextBox idTxt;
        public System.Windows.Forms.TextBox nomeTxt;
        private System.Windows.Forms.Button modificaBtn;
        private System.Windows.Forms.Button eliminaBtn;
        private System.Windows.Forms.Button annullaEditBtn;
        private System.Windows.Forms.Button salvaEditBtn;
        private System.Windows.Forms.Button indietroBtn;
    }
}