using GestionalePazienti.Martina.Business;
using GestionalePazienti.Martina.Domain;
using GestionalePazienti.Martina.Domain.CustomExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionalePazienti.Martina
{
    public partial class InfoPaziente : Form
    {
        PazienteService _service;
        Paziente paziente;
        public InfoPaziente()
        {
            _service = new PazienteService();

            InitializeComponent();

        }
        public InfoPaziente(int ID, string nome, string cognome, string luogoDiNascita, DateTime dataDiNascita, string codiceFiscale)
        {
            _service = new PazienteService();
            InitializeComponent();
            idTxt.Text = ID.ToString();
            paziente = new Paziente(ID, nome, cognome, codiceFiscale, luogoDiNascita, dataDiNascita);
            nomeTxt.Text = paziente.Nome;
            cognomeTxt.Text = paziente.Cognome;
            luogoDiNascitaTxt.Text = paziente.LuogoDiNascita;
            dataDiNascitaTxt.Value = paziente.DataDiNascita;
            codiceFiscaleTxt.Text = paziente.CodiceFiscale;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoPaziente_Load(object sender, EventArgs e)
        {

        }

        private void modificaBtn_Click(object sender, EventArgs e)
        {
            nomeTxt.ReadOnly = false;
            cognomeTxt.ReadOnly = false;
            dataDiNascitaTxt.Enabled = true;
            luogoDiNascitaTxt.ReadOnly = false;
            codiceFiscaleTxt.ReadOnly = false;
            annullaEditBtn.Visible = true;
            salvaEditBtn.Visible = true;
        }

        private void annullaEditBtn_Click(object sender, EventArgs e)
        {
            nomeTxt.ReadOnly = true;
            nomeTxt.Text = paziente.Nome;
            cognomeTxt.ReadOnly = true;
            cognomeTxt.Text = paziente.Cognome;
            dataDiNascitaTxt.Enabled = false;
            dataDiNascitaTxt.Value = paziente.DataDiNascita;
            luogoDiNascitaTxt.ReadOnly = true;
            luogoDiNascitaTxt.Text = paziente.LuogoDiNascita;
            codiceFiscaleTxt.ReadOnly = true;
            codiceFiscaleTxt.Text = paziente.CodiceFiscale;
            annullaEditBtn.Visible = false;
            salvaEditBtn.Visible = false;
        }

        private void salvaEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var nuovoPaziente = new Paziente(Convert.ToInt32(idTxt.Text), nomeTxt.Text, cognomeTxt.Text,
                                             codiceFiscaleTxt.Text, luogoDiNascitaTxt.Text, dataDiNascitaTxt.Value);
                _service.Edit(nuovoPaziente);

                MessageBox.Show("Utente modificato");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Errore nel salvataggio \n Errore: {ex.Message}");
            }
        }

        private void indietroBtn_Click(object sender, EventArgs e)
        {
            var homeForm = new FormAggiuntaPaziente();
            homeForm.Show();
        }
    }
}
