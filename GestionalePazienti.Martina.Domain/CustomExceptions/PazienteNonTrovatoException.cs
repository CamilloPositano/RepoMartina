using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionalePazienti.Martina.Domain.CustomExceptions
{
    public class PazienteNonTrovatoException : Exception
    {
        public PazienteNonTrovatoException():base("Paziente non torvato") { }
        public PazienteNonTrovatoException(string message) : base(message) { }
    }
}
