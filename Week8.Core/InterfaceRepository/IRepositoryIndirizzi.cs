using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.Models;

namespace Week8.Core.InterfaceRepository
{
    public interface IRepositoryIndirizzi : IRepository<Indirizzo>
    {
        public Indirizzo GetById(int ID);
    }
}
