using DALELk.Data;
using DALELk.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALELk.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly AppDBContext _context = null;
        private readonly IConfiguration _configuration;

        public CategoryRepository(AppDBContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<int> AddToTable(CategoryModel model)
        {
            var newCategory = new Category()
            {
                Cat_Name = model.Cat_Name, 
            };

            await _context.Categorys.AddAsync(newCategory);
            await _context.SaveChangesAsync();
            return newCategory.id;
        }


        public int Updated(CategoryModel model)
        {
            var newCategory = new Category()
            {
                Cat_Name = model.Cat_Name,
            };
            _context.Categorys.Update(newCategory);
            _context.SaveChanges();
            return newCategory.id;
        }


    

        public async Task<List<CategoryModel>> GetAll()
        {
            return await _context.Categorys
                .Select(categor => new CategoryModel()
                {
                    id=categor.id,
                    Cat_Name= categor.Cat_Name

                }).ToListAsync();
        }

        public async Task<CategoryModel> GetById(int id)
        {
            return await _context.Categorys.Where(x => x.id == id)
                .Select(Cat => new CategoryModel()
                {
                   id=Cat.id,
                   Cat_Name=Cat.Cat_Name
                }).FirstOrDefaultAsync();
        }

        public bool Delete(int id)
        {
            var data = _context.Categorys.Find(id);
            _context.Categorys.Remove(data);
            _context.SaveChanges();
            return true;
        }
    }
}
