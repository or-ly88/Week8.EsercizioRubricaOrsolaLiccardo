using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week8.Core.Models;

namespace Week8.Core.InterfaceRepository
{
    public interface IRepository<T>
    {
        //operazioni in comune o operazioni di base a tutte le entità\models,in genere sono le CRUD
        public IList<T> Getall();
        public T Add(T item);
        public T Update(T item);
        public bool Delete(T item);
        Contatto GetByID(int ID);
        Indirizzo GetById(int ID);
    }
}
