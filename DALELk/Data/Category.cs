using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALELk.Data
{
    public class Category
    {
        public int id { get; set; }
        public string Cat_Name { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
