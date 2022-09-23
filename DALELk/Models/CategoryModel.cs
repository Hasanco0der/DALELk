using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DALELk.Models
{
    public class CategoryModel
    {
        public int id { get; set; }

        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "Please enter the Category name")]
        [StringLength(100, MinimumLength = 5)]
        public string Cat_Name { get; set; }
    }
}
