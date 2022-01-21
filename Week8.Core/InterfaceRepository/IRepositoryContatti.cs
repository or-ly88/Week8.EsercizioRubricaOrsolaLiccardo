using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.Models;

namespace Week8.Core.InterfaceRepository
{
    public interface IRepositoryContatti :IRepository<Contatto>
    {
        Contatto Add(Contatto item);
        public Contatto GetByID(int ID);
        public List<Contatto> GetAll();
        Contatto GetById(int contattoID);
    }
}
