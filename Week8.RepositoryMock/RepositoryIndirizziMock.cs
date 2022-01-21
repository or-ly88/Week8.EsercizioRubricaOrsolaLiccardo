using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.InterfaceRepository;
using Week8.Core.Models;

namespace Week8.RepositoryMock
{
    public class RepositoryIndirizziMock : IRepositoryIndirizzi
    {
        public static List<Indirizzo> Indirizzi = new List<Indirizzo>()
        {
            new Indirizzo{IndirizzoID=1,Tipologia="Residenza",Via="Leopardi",Città="Mugnano di Napoli",CAP="80018",Provincia="Napoli",Nazione="Italia" },
            new Indirizzo{IndirizzoID=2,Tipologia="Domicilio",Via="Merliani",Città="Napoli",CAP="800100",Provincia="Napoli",Nazione="Italia" }
        };
        public Indirizzo Add(Indirizzo item)
        {
            Indirizzi.Add(item);
            return item;
        }

        public bool Delete(Indirizzo item)
        {
            Indirizzi.Remove(item);
            return true;
        }

        public IList<Indirizzo> Getall()
        {
            throw new NotImplementedException();
        }

        public Indirizzo GetByCode(int ID)
        {
            return Indirizzi.FirstOrDefault(i => i.IndirizzoID == ID);
        }

        public Indirizzo GetById(int ID)
        {
            throw new NotImplementedException();
        }

        public Indirizzo Update(Indirizzo item)
        {
            foreach (var i in Indirizzi)
            {
                if (i.IndirizzoID == item.IndirizzoID )
                {
                    i.Tipologia = item.Tipologia;
                    i.Via = item.Via;
                    i.Città =item.Città;
                    i.CAP = item.CAP;
                    i.Provincia = item.Provincia;
                    i.Nazione = item.Nazione;
                    return i;
                }
            }
            return null;
        }

        Contatto IRepository<Indirizzo>.GetByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
