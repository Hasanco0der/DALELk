using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DALELk.Data
{
    public class Doctor
    {
        public int id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ShahadaDec { get; set; }
        public string Workhoure { get; set; }
        public string AddressAsas { get; set; }
        public string AddressJanbi { get; set; }
        public string CoverImageUrl { get; set; }
        public int Categoryid { get; set; }
        public Category Categorys { get; set; }
    }
}
