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
    public partial class FormAggiuntaPaziente : Form
    {
        PazienteService PazienteService;
        public FormAggiuntaPaziente()
        {
            PazienteService = new PazienteService();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AggiungiPazienteBtn_Click(object sender, EventArgs e)
        {
            var paziente = new Paziente(
                                   null,
                                   NomeTXT.Text,
                                   CognomeTxt.Text,
                                   CodiceFiscaleTxt.Text,
                                   LuogoDiNascitaTxt.Text,
                                   DataDiNascitaInput.Value
                                );
            try
            {
                PazienteService.Create(paziente);
                MessageBox.Show("Paziente aggiunto!");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Errore nell'aggiunta del paziente! \n Errore: {ex.Message}");
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AggiungiPazientePanel.Visible = true;
            RicercaPazientePanel.Visible = false;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cercaPazienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RicercaPazientePanel.Visible = true;
            AggiungiPazientePanel.Visible = false;

        }

        private void CercaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RisultatoRicerca.Items.Clear();
                RisultatoRicerca.DisplayMember = "CognomeNome";
                RisultatoRicerca.ValueMember = "ID";


                var pazienti = PazienteService.GetPaginated(10, NomePazienteTxt.Text);
                foreach (var paziente in pazienti)
                {
                    RisultatoRicerca.Items.Add(paziente);
                }
            }
            catch (PazienteNonTrovatoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nella ricerca. \n Messaggio: {ex.Message}");
            }

        }

        private void Sudgest(AutoCompleteStringCollection collection)
        {
            NomePazienteTxt.AutoCompleteCustomSource = collection;
        }

        private void NomePazienteTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var paziente = (Paziente)RisultatoRicerca.SelectedItem;
            var formInfoPaziente = new InfoPaziente(paziente.ID.Value, paziente.Nome, paziente.Cognome, paziente.LuogoDiNascita,
                                                    paziente.DataDiNascita, paziente.CodiceFiscale);
            formInfoPaziente.ShowDialog();
        }
    }
}
