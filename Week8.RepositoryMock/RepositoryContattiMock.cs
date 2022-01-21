using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.InterfaceRepository;
using Week8.Core.Models;

namespace Week8.RepositoryMock
{
    public class RepositoryContattiMock : IRepositoryContatti
    {
        public static List<Contatto> Contatti = new List<Contatto>()
        {
            new Contatto{ ContattoID=1,Nome="Elena",Cognome="Verdi"},
            new Contatto{ ContattoID=2,Nome="Alessio",Cognome="Vitti"},
            new Contatto{ ContattoID=3,Nome="Maria",Cognome="Rossi"}
        };
        public Contatto Add(Contatto item)
        {
            Contatti.Add(item);
            return item;
        }

        public bool Delete(Contatto item)
        {
            Contatti.Remove(item);
            return true;
        }

        public IList<Contatto> Getall()
        {
            return Contatti;
        }

        public List<Contatto> GetAll()
        {
            return Contatti;
        }

        public Contatto GetByID(int ID)
        {
            
        }

        public Contatto Update(Contatto item)
        {
            foreach (var c in Contatti)
            {
                if (c.ContattoID == item.ContattoID)
                {
                    c.Nome = item.Nome;
                    c.Cognome = item.Cognome;
                    return c;
                }
            }
            return null;
        }

        
    }
}
