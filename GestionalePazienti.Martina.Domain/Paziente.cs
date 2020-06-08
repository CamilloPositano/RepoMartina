using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionalePazienti.Martina.Domain
{
    public class Paziente
    {
        public Paziente() { }
        public Paziente(int? ID, string nome, string cognome, string codiceFiscale, string luogoDiNascita,
                           DateTime dataDiNascita)
        {
            this.ID = ID;
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;
            LuogoDiNascita = luogoDiNascita;
            DataDiNascita = dataDiNascita;
            CognomeNome = cognome + " " + nome;
        }
        public int? ID { get; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string CognomeNome { get; set; }
        public int eta { get; set; }
        public string CodiceFiscale { get; set; }
        public string LuogoDiNascita { get; set; }
        public DateTime DataDiNascita { get; set; }
        
    }
}
