using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.InterfaceRepository;
using Week8.Core.Models;

namespace Week8.RepositoryEntityFrameWork.RepositoryEF
{
    internal class RepositoryContattiEF : IRepositoryContatti
    {
        private readonly Context ctx;

        public RepositoryContattiEF()
        {
            this.ctx = new Context();
        }
        public Contatto Add(Contatto item)
        {
            using (var ctx = new Context())
            {
                ctx.Contatti.Add(item);
                ctx.SaveChanges();

            }
            return item;
        }

        public bool Delete(Contatto item)
        {
            using (var ctx = new Context())
            {
                ctx.Contatti.Remove(item);
                ctx.SaveChanges();

            }
            return true;
        }

        public IList<Contatto> Getall()
        {
            using (var ctx = new Context())
            {
                return ctx.Contatti.ToList();
            }
        }

        public List<Contatto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contatto GetByID(int ID)
        {
            using (var ctx = new Context())
            {
                // return ctx.Contatti.FirstOrDefault(d => d.ContattoID == ID);
                throw new NotImplementedException();
            }
        }

        public Contatto GetById(int contattoID)
        {
            throw new NotImplementedException();
        }

        public Contatto Update(Contatto item)
        {
            using (var ctx = new Context())
            {
                ctx.Contatti.Update(item);
                ctx.SaveChanges();

            }
            return item;
        }
    }
}
