using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALELk.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<int> AddToTable(T model);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
