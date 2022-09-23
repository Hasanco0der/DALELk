using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DALELk.Models;

namespace DALELk.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
           : base(options)
        {

        }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DALELk.Models.CategoryModel> CategoryModel { get; set; }
    }
}
