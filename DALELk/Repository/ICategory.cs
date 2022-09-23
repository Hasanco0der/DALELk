using DALELk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALELk.Repository
{
    public interface ICategory
    {
        Task<int> AddToTable(CategoryModel model);
        Task<List<CategoryModel>> GetAll();
        Task<CategoryModel> GetById(int id);
        int Updated(CategoryModel model);
        bool Delete(int id);
    }
}
