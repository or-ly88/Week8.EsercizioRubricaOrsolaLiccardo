using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.InterfaceRepository;
using Week8.Core.Models;

namespace Week8.Core.BusinessLayer
{
    //classe che implementa l'interfaccia IBusinessLayer
    public class BusinessLayer : IBusinessLayer
    {
        //proprietà di questa classe
        public readonly IRepositoryContatti contattiRepo;
        public readonly IRepositoryIndirizzi indirizziRepo;

        //costruttore
        public BusinessLayer(IRepositoryContatti contatti, IRepositoryIndirizzi indirizzi)
        {
            contattiRepo = contatti;
            indirizziRepo = indirizzi;
            

        }

        public Esito AddNuovoContatto(Contatto nuovoContatto)
        {
            //controllo se il contatto inserito è già esistente
            
            Contatto contattoEsistente = contattiRepo.GetById(nuovoContatto.ContattoID);
            //aggiungo un controllo
            if (contattoEsistente == null)
            {
                contattiRepo.Add(nuovoContatto);
                return new Esito { Messaggio = "Contatto aggiunto correttamente", isOk = true };
            }
            else
            {
                return new Esito { Messaggio = "Impossibile aggiungere un nuovo contatto perché già esiste", isOk = false };
            }
        }

        public Esito AddNuovoIndirizzo(Indirizzo nuovoIndirizzo)
        {
            throw new NotImplementedException();
        }

        public List<Contatto> GetAllContatti()
        {
            return contattiRepo.GetAll().ToList();
        }

        public List<Indirizzo> GetAllIndirizzi()
        {
            throw new NotImplementedException();
        }

        public Esito RimuoviIndirizzo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
