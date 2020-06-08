namespace GestionalePazienti.Martina
{
    partial class FormAggiuntaPaziente
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
            this.NomeTXT = new System.Windows.Forms.TextBox();
            this.CognomeTxt = new System.Windows.Forms.TextBox();
            this.CodiceFiscaleTxt = new System.Windows.Forms.TextBox();
            this.LuogoDiNascitaTxt = new System.Windows.Forms.TextBox();
            this.TitoloLbl = new System.Windows.Forms.Label();
            this.NomeLbl = new System.Windows.Forms.Label();
            this.CognomeLbl = new System.Windows.Forms.Label();
            this.CodiceFiscaleLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataDiNascitaLbl = new System.Windows.Forms.Label();
            this.DataDiNascitaInput = new System.Windows.Forms.DateTimePicker();
            this.AggiungiPazienteBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cercaPazienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AggiungiPazientePanel = new System.Windows.Forms.Panel();
            this.RicercaPazientePanel = new System.Windows.Forms.Panel();
            this.apriPazienteBtn = new System.Windows.Forms.Button();
            this.RisultatoRicerca = new System.Windows.Forms.ListBox();
            this.RisultatoTxt = new System.Windows.Forms.Label();
            this.CercaBtn = new System.Windows.Forms.Button();
            this.NomePazienteTxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.AggiungiPazientePanel.SuspendLayout();
            this.RicercaPazientePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomeTXT
            // 
            this.NomeTXT.Location = new System.Drawing.Point(73, 99);
            this.NomeTXT.Name = "NomeTXT";
            this.NomeTXT.Size = new System.Drawing.Size(100, 22);
            this.NomeTXT.TabIndex = 0;
            // 
            // CognomeTxt
            // 
            this.CognomeTxt.Location = new System.Drawing.Point(179, 99);
            this.CognomeTxt.Name = "CognomeTxt";
            this.CognomeTxt.Size = new System.Drawing.Size(100, 22);
            this.CognomeTxt.TabIndex = 1;
            // 
            // CodiceFiscaleTxt
            // 
            this.CodiceFiscaleTxt.Location = new System.Drawing.Point(285, 99);
            this.CodiceFiscaleTxt.Name = "CodiceFiscaleTxt";
            this.CodiceFiscaleTxt.Size = new System.Drawing.Size(100, 22);
            this.CodiceFiscaleTxt.TabIndex = 2;
            // 
            // LuogoDiNascitaTxt
            // 
            this.LuogoDiNascitaTxt.Location = new System.Drawing.Point(394, 99);
            this.LuogoDiNascitaTxt.Name = "LuogoDiNascitaTxt";
            this.LuogoDiNascitaTxt.Size = new System.Drawing.Size(100, 22);
            this.LuogoDiNascitaTxt.TabIndex = 3;
            // 
            // TitoloLbl
            // 
            this.TitoloLbl.AutoSize = true;
            this.TitoloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitoloLbl.Location = new System.Drawing.Point(280, 27);
            this.TitoloLbl.Name = "TitoloLbl";
            this.TitoloLbl.Size = new System.Drawing.Size(222, 29);
            this.TitoloLbl.TabIndex = 5;
            this.TitoloLbl.Text = "Aggiungi paziente";
            // 
            // NomeLbl
            // 
            this.NomeLbl.AutoSize = true;
            this.NomeLbl.Location = new System.Drawing.Point(102, 79);
            this.NomeLbl.Name = "NomeLbl";
            this.NomeLbl.Size = new System.Drawing.Size(45, 17);
            this.NomeLbl.TabIndex = 6;
            this.NomeLbl.Text = "Nome";
            // 
            // CognomeLbl
            // 
            this.CognomeLbl.AutoSize = true;
            this.CognomeLbl.Location = new System.Drawing.Point(196, 79);
            this.CognomeLbl.Name = "CognomeLbl";
            this.CognomeLbl.Size = new System.Drawing.Size(68, 17);
            this.CognomeLbl.TabIndex = 7;
            this.CognomeLbl.Text = "Cognome";
            // 
            // CodiceFiscaleLbl
            // 
            this.CodiceFiscaleLbl.AutoSize = true;
            this.CodiceFiscaleLbl.Location = new System.Drawing.Point(286, 79);
            this.CodiceFiscaleLbl.Name = "CodiceFiscaleLbl";
            this.CodiceFiscaleLbl.Size = new System.Drawing.Size(99, 17);
            this.CodiceFiscaleLbl.TabIndex = 8;
            this.CodiceFiscaleLbl.Text = "Codice Fiscale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Luogo di Nascita";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DataDiNascitaLbl
            // 
            this.DataDiNascitaLbl.AutoSize = true;
            this.DataDiNascitaLbl.Location = new System.Drawing.Point(511, 79);
            this.DataDiNascitaLbl.Name = "DataDiNascitaLbl";
            this.DataDiNascitaLbl.Size = new System.Drawing.Size(104, 17);
            this.DataDiNascitaLbl.TabIndex = 10;
            this.DataDiNascitaLbl.Text = "Data di Nascita";
            this.DataDiNascitaLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // DataDiNascitaInput
            // 
            this.DataDiNascitaInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDiNascitaInput.Location = new System.Drawing.Point(514, 99);
            this.DataDiNascitaInput.Name = "DataDiNascitaInput";
            this.DataDiNascitaInput.Size = new System.Drawing.Size(101, 22);
            this.DataDiNascitaInput.TabIndex = 11;
            // 
            // AggiungiPazienteBtn
            // 
            this.AggiungiPazienteBtn.Location = new System.Drawing.Point(636, 95);
            this.AggiungiPazienteBtn.Name = "AggiungiPazienteBtn";
            this.AggiungiPazienteBtn.Size = new System.Drawing.Size(75, 30);
            this.AggiungiPazienteBtn.TabIndex = 12;
            this.AggiungiPazienteBtn.Text = "Aggiungi";
            this.AggiungiPazienteBtn.UseVisualStyleBackColor = true;
            this.AggiungiPazienteBtn.Click += new System.EventHandler(this.AggiungiPazienteBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.cercaPazienteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 26);
            this.toolStripMenuItem1.Text = "Gestione Pazienti";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(212, 26);
            this.toolStripMenuItem2.Text = "Aggiungi Paziente";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cercaPazienteToolStripMenuItem
            // 
            this.cercaPazienteToolStripMenuItem.Name = "cercaPazienteToolStripMenuItem";
            this.cercaPazienteToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.cercaPazienteToolStripMenuItem.Text = "Cerca Paziente";
            this.cercaPazienteToolStripMenuItem.Click += new System.EventHandler(this.cercaPazienteToolStripMenuItem_Click);
            // 
            // AggiungiPazientePanel
            // 
            this.AggiungiPazientePanel.Controls.Add(this.TitoloLbl);
            this.AggiungiPazientePanel.Controls.Add(this.AggiungiPazienteBtn);
            this.AggiungiPazientePanel.Controls.Add(this.NomeTXT);
            this.AggiungiPazientePanel.Controls.Add(this.DataDiNascitaInput);
            this.AggiungiPazientePanel.Controls.Add(this.CognomeTxt);
            this.AggiungiPazientePanel.Controls.Add(this.DataDiNascitaLbl);
            this.AggiungiPazientePanel.Controls.Add(this.CodiceFiscaleTxt);
            this.AggiungiPazientePanel.Controls.Add(this.label1);
            this.AggiungiPazientePanel.Controls.Add(this.LuogoDiNascitaTxt);
            this.AggiungiPazientePanel.Controls.Add(this.CodiceFiscaleLbl);
            this.AggiungiPazientePanel.Controls.Add(this.NomeLbl);
            this.AggiungiPazientePanel.Controls.Add(this.CognomeLbl);
            this.AggiungiPazientePanel.Location = new System.Drawing.Point(12, 26);
            this.AggiungiPazientePanel.Name = "AggiungiPazientePanel";
            this.AggiungiPazientePanel.Size = new System.Drawing.Size(776, 398);
            this.AggiungiPazientePanel.TabIndex = 14;
            this.AggiungiPazientePanel.Visible = false;
            // 
            // RicercaPazientePanel
            // 
            this.RicercaPazientePanel.Controls.Add(this.apriPazienteBtn);
            this.RicercaPazientePanel.Controls.Add(this.RisultatoRicerca);
            this.RicercaPazientePanel.Controls.Add(this.RisultatoTxt);
            this.RicercaPazientePanel.Controls.Add(this.CercaBtn);
            this.RicercaPazientePanel.Controls.Add(this.NomePazienteTxt);
            this.RicercaPazientePanel.Controls.Add(this.NameLbl);
            this.RicercaPazientePanel.Controls.Add(this.label2);
            this.RicercaPazientePanel.Location = new System.Drawing.Point(12, 26);
            this.RicercaPazientePanel.Name = "RicercaPazientePanel";
            this.RicercaPazientePanel.Size = new System.Drawing.Size(776, 398);
            this.RicercaPazientePanel.TabIndex = 15;
            this.RicercaPazientePanel.Visible = false;
            // 
            // apriPazienteBtn
            // 
            this.apriPazienteBtn.Location = new System.Drawing.Point(533, 249);
            this.apriPazienteBtn.Name = "apriPazienteBtn";
            this.apriPazienteBtn.Size = new System.Drawing.Size(75, 23);
            this.apriPazienteBtn.TabIndex = 12;
            this.apriPazienteBtn.Text = "Apri";
            this.apriPazienteBtn.UseVisualStyleBackColor = true;
            this.apriPazienteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RisultatoRicerca
            // 
            this.RisultatoRicerca.FormattingEnabled = true;
            this.RisultatoRicerca.ItemHeight = 16;
            this.RisultatoRicerca.Location = new System.Drawing.Point(394, 127);
            this.RisultatoRicerca.Name = "RisultatoRicerca";
            this.RisultatoRicerca.Size = new System.Drawing.Size(366, 116);
            this.RisultatoRicerca.TabIndex = 11;
            // 
            // RisultatoTxt
            // 
            this.RisultatoTxt.AutoSize = true;
            this.RisultatoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RisultatoTxt.Location = new System.Drawing.Point(529, 95);
            this.RisultatoTxt.Name = "RisultatoTxt";
            this.RisultatoTxt.Size = new System.Drawing.Size(84, 20);
            this.RisultatoTxt.TabIndex = 10;
            this.RisultatoTxt.Text = "Risultato";
            // 
            // CercaBtn
            // 
            this.CercaBtn.Location = new System.Drawing.Point(294, 94);
            this.CercaBtn.Name = "CercaBtn";
            this.CercaBtn.Size = new System.Drawing.Size(75, 23);
            this.CercaBtn.TabIndex = 8;
            this.CercaBtn.Text = "Cerca";
            this.CercaBtn.UseVisualStyleBackColor = true;
            this.CercaBtn.Click += new System.EventHandler(this.CercaBtn_Click);
            // 
            // NomePazienteTxt
            // 
            this.NomePazienteTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NomePazienteTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NomePazienteTxt.Location = new System.Drawing.Point(136, 95);
            this.NomePazienteTxt.Name = "NomePazienteTxt";
            this.NomePazienteTxt.Size = new System.Drawing.Size(152, 22);
            this.NomePazienteTxt.TabIndex = 7;
            this.NomePazienteTxt.TextChanged += new System.EventHandler(this.NomePazienteTxt_TextChanged);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(23, 95);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(107, 17);
            this.NameLbl.TabIndex = 6;
            this.NameLbl.Text = "Nome paziente:";
            this.NameLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ricerca Paziente";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // FormAggiuntaPaziente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RicercaPazientePanel);
            this.Controls.Add(this.AggiungiPazientePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAggiuntaPaziente";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.AggiungiPazientePanel.ResumeLayout(false);
            this.AggiungiPazientePanel.PerformLayout();
            this.RicercaPazientePanel.ResumeLayout(false);
            this.RicercaPazientePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeTXT;
        private System.Windows.Forms.TextBox CognomeTxt;
        private System.Windows.Forms.TextBox CodiceFiscaleTxt;
        private System.Windows.Forms.TextBox LuogoDiNascitaTxt;
        private System.Windows.Forms.Label TitoloLbl;
        private System.Windows.Forms.Label NomeLbl;
        private System.Windows.Forms.Label CognomeLbl;
        private System.Windows.Forms.Label CodiceFiscaleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DataDiNascitaLbl;
        private System.Windows.Forms.DateTimePicker DataDiNascitaInput;
        private System.Windows.Forms.Button AggiungiPazienteBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cercaPazienteToolStripMenuItem;
        private System.Windows.Forms.Panel AggiungiPazientePanel;
        private System.Windows.Forms.Panel RicercaPazientePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label RisultatoTxt;
        private System.Windows.Forms.Button CercaBtn;
        private System.Windows.Forms.TextBox NomePazienteTxt;
        private System.Windows.Forms.ListBox RisultatoRicerca;
        private System.Windows.Forms.Button apriPazienteBtn;
    }
}

