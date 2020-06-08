using GestionalePazienti.Martina.Domain;
using GestitonalePazienti.Martina.DAL;
using GestitonalePazienti.Martina.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionalePazienti.Martina.Business
{
    public class PazienteService
    {
        private PazienteRepository _repo;

        public PazienteService()
        {
            _repo = new PazienteRepository();
        }
        public void Create(Domain.Paziente paziente)
        {
            var pazienteDAO = new PazienteDAO(null, paziente.Nome, paziente.Cognome,
                                              paziente.CodiceFiscale, paziente.LuogoDiNascita,
                                              paziente.DataDiNascita);
            _repo.Create(pazienteDAO);
        }
        public Domain.Paziente Get(string nome)
        {
            var pzDAO = _repo.Get(nome);
            
            return new Domain.Paziente(pzDAO.ID,pzDAO.Nome, pzDAO.Cognome, pzDAO.CodiceFiscale, pzDAO.LuogoDiNascita,
                                       pzDAO.DataDiNascita);
        }
        public List<Domain.Paziente> GetAll()
        {
            var daoList = _repo.GetAll();
            var domainList = new List<Domain.Paziente>();
            foreach (var paziente in daoList)
            {
                var pazienteDomain = new Domain.Paziente(paziente.ID, paziente.Nome, paziente.Cognome, paziente.CodiceFiscale,
                                                         paziente.LuogoDiNascita, paziente.DataDiNascita);
                domainList.Add(pazienteDomain);
            }
            return domainList;
        }
        public List<Domain.Paziente> GetPaginated(int size)
        {
            var daoList = _repo.GetPaginated(size);
            var domainList = new List<Domain.Paziente>();
            foreach (var paziente in daoList)
            {
                var pazienteDomain = new Domain.Paziente(paziente.ID,paziente.Nome, paziente.Cognome, paziente.CodiceFiscale,
                                                         paziente.LuogoDiNascita, paziente.DataDiNascita);
                domainList.Add(pazienteDomain);
            }
            return domainList;
        }
        public List<Domain.Paziente> GetPaginated(int size, string valore)
        {
            var daoList = _repo.GetPaginated(size, valore);
            var domainList = new List<Domain.Paziente>();
            foreach (var paziente in daoList)
            {
                var pazienteDomain = new Domain.Paziente(paziente.ID, paziente.Nome, paziente.Cognome, paziente.CodiceFiscale,
                                                         paziente.LuogoDiNascita, paziente.DataDiNascita);
                domainList.Add(pazienteDomain);
            }
            return domainList;
        }
        public void Edit(Domain.Paziente nuovoPaziente)
        {
            var PazienteDAO = new PazienteDAO(nuovoPaziente.ID,nuovoPaziente.Nome,
                                              nuovoPaziente.Cognome,nuovoPaziente.CodiceFiscale,
                                              nuovoPaziente.LuogoDiNascita, nuovoPaziente.DataDiNascita) ;
            _repo.Edit(PazienteDAO);
        }
    }
}
