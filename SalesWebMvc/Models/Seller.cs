using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public List<SalesRecord> Sales { get; set; } 

        public void AddSales(SalesRecord sr) { }
        public void RemoveSales(SalesRecord sr) { }
        public double TotalSales(DateTime initial, DateTime final) { return 5.0; }
    }
}
