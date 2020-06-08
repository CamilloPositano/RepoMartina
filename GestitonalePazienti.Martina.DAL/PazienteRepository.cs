using GestitonalePazienti.Martina.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestitonalePazienti.Martina.DAL
{
    public class PazienteRepository
    {
        private GestionalePazientiEntities _ctx;
        public PazienteRepository()
        {
            _ctx = new GestionalePazientiEntities();
        }
        public void Create(PazienteDAO paziente)
        {
            
            var pazienteEntity = new Paziente(paziente.Nome, paziente.Cognome, paziente.DataDiNascita,
                                              paziente.LuogoDiNascita, paziente.CodiceFiscale);
            _ctx.Paziente.Add(pazienteEntity);
            _ctx.SaveChanges();
        }
        public PazienteDAO Get(string nome)
        {
            var pzEntity = _ctx.Paziente.Where(p => p.Nome.Contains(nome))
                                        .FirstOrDefault();
            if (pzEntity == null)
                throw new Exception("Nessun paziente trovato");
            return new PazienteDAO(pzEntity.ID,pzEntity.Nome, pzEntity.Cognome, pzEntity.CodiceFiscale,
                                        pzEntity.LuogoDiNascita, pzEntity.DataDiNascita);
            
        }
        public List<PazienteDAO> GetAll()
        {
            var ctxPazienti = _ctx.Paziente.ToList();
            var repoPazienti = new List<PazienteDAO>();
            foreach (var paziente in ctxPazienti)
            {
                var pazienteDao = new PazienteDAO(paziente.ID, paziente.Nome, paziente.Cognome, paziente.CodiceFiscale,
                                                  paziente.LuogoDiNascita, paziente.DataDiNascita);
                repoPazienti.Add(pazienteDao);
            }
            return repoPazienti;
        }
        public List<PazienteDAO> GetPaginated(int size)
        {
            var ctxPazienti = _ctx.Paziente.Take(size).ToList();    
            var repoPazienti = new List<PazienteDAO>();
            foreach (var paziente in ctxPazienti)
            {
                var pazienteDao = new PazienteDAO(paziente.ID, paziente.Nome, paziente.Cognome, paziente.CodiceFiscale,
                                                  paziente.LuogoDiNascita, paziente.DataDiNascita);
                repoPazienti.Add(pazienteDao);
            }
            return repoPazienti;
        }
        public List<PazienteDAO> GetPaginated(int size, string value)
        {
            var ctxPazienti = _ctx.Paziente.Take(size)
                                           .Where(p => p.Nome.Contains(value) || p.Cognome.Contains(value))
                                           .ToList();
            var repoPazienti = new List<PazienteDAO>();
            foreach (var paziente in ctxPazienti)
            {
                var pazienteDao = new PazienteDAO(paziente.ID, paziente.Nome, paziente.Cognome, paziente.CodiceFiscale,
                                                  paziente.LuogoDiNascita, paziente.DataDiNascita);
                repoPazienti.Add(pazienteDao);
            }
            return repoPazienti;
        }
        public void Edit(PazienteDAO nuovoPaziente)
        {
            var pazienteOld = _ctx.Paziente.FirstOrDefault(p => p.ID == nuovoPaziente.ID);
            if (pazienteOld == null)
                throw new Exception("Paziente non trovato");
            var pazConCodiceFiscale = _ctx.Paziente.Where(p => p.ID != nuovoPaziente.ID).FirstOrDefault(p => p.CodiceFiscale == nuovoPaziente.CodiceFiscale);
            if (pazConCodiceFiscale != null)
                throw new Exception("Paziente gia presente con questo codice fiscale");

            pazienteOld.Nome = nuovoPaziente.Nome;
            pazienteOld.Cognome = nuovoPaziente.Cognome;
            pazienteOld.DataDiNascita = nuovoPaziente.DataDiNascita;
            pazienteOld.LuogoDiNascita = nuovoPaziente.LuogoDiNascita;
            pazienteOld.CodiceFiscale = nuovoPaziente.CodiceFiscale;

            _ctx.SaveChanges();
        }
    }
}
