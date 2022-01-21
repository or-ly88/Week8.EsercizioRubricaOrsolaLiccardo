using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.Models;

namespace Week8.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        List<Contatto> GetAllContatti();
        List<Indirizzo> GetAllIndirizzi();
        Esito AddNuovoContatto(Contatto nuovoContatto);
        Esito AddNuovoIndirizzo(Indirizzo nuovoIndirizzo);
        Esito RimuoviIndirizzo(int id);
        Esito RimuoviContatto(int id);
    }
}
