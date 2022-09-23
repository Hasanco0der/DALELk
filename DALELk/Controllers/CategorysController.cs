using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DALELk.Data;
using DALELk.Models;
using DALELk.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DALELk.Controllers
{
    public class CategorysController : Controller
    {
        private readonly ICategory _ICategory;
        private readonly AppDBContext _context;

        public CategorysController(ICategory ICategory, AppDBContext context)
        {
            _ICategory = ICategory;
            _context = context;
        }

        // GET: Categories
        public async Task<IActionResult> Index()
        {
            var data = await _ICategory.GetAll();
            return View(data);
        }

        // GET: Categories/Create
        public async Task<IActionResult> Create(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        public async Task<IActionResult> Create(CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _ICategory.AddToTable(categoryModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(Create), new { isSuccess = true, bookId = id });
                }
            }
            return View();
        }

        // GET: Categories/Details
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                NotFound();
            }
            var data = await _ICategory.GetById(id);
            if (data == null)
            {
                NotFound();
            }

            return View(data);
        }



        // GET: Categories/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = await _context.Categorys.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }


        [HttpPost]
        
        public  IActionResult Edit(CategoryModel CategoryModel)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _ICategory.Updated(CategoryModel);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                        return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }
           
            return View(CategoryModel);
        }

        // GET: Categories/Delete
        public async Task<IActionResult> Delete(int? id, bool isSuccess = false)
        {
            ViewBag.IsSuccess = isSuccess;
            if (id == null)
            {
                return NotFound();
            }

            var data = await _context.Categorys
                .FirstOrDefaultAsync(m => m.id == id);
            if (data == null)
            {
                return NotFound();
            }

            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var data =  _ICategory.Delete(id);
            return RedirectToAction(nameof(Index),new { isSuccess = true });
        }

        private bool CategoryExists(int id)
        {
            return _context.Categorys.Any(e => e.id == id);
        }

    }
}
