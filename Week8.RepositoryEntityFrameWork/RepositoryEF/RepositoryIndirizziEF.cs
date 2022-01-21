using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.InterfaceRepository;
using Week8.Core.Models;

namespace Week8.RepositoryEntityFrameWork.RepositoryEF
{
    internal class RepositoryIndirizziEF : IRepositoryIndirizzi
    {
        public Indirizzo Add(Indirizzo item)
        {
            using (var ctx = new Context())
            {
                ctx.Indirizzi.Add(item);
                ctx.SaveChanges();

            }
            return item;
        }

        public bool Delete(Indirizzo item)
        {
            using (var ctx = new Context())
            {
                ctx.Indirizzi.Remove(item);
                ctx.SaveChanges();

            }
            return true;
        }

        public IList<Indirizzo> Getall()
        {
            using (var ctx = new Context())
            {
                return ctx.Indirizzi.ToList();
            }
        }

        public Indirizzo GetByCode(int ID)
        {
            throw new NotImplementedException();
        }

        public Indirizzo GetById(int ID)
        {
            throw new NotImplementedException();
        }

        public Indirizzo Update(Indirizzo item)
        {
            using (var ctx = new Context())
            {
                ctx.Indirizzi.Update(item);
                ctx.SaveChanges();

            }
            return item;
        }

        Contatto IRepository<Indirizzo>.GetByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
