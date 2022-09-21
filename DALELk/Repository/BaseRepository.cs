using DALELk.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALELk.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected AppDBContext _context;
        public BaseRepository(AppDBContext context)
        {
            _context = context;
        }
        public Task<int> AddToTable(T model)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
