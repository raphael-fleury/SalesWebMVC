using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Department.Any() || _context.SalesRecord.Any())
                return;

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Frank Lucas", "lucaofoda007@gmail.com", new DateTime(1998, 2, 21), 1000, d1);
            Seller s2 = new Seller(2, "Frank Ocean", "lucaosdfsd07@gmail.com", new DateTime(1992, 7, 21), 2000, d2);
            Seller s3 = new Seller(3, "Fred Winston", "legtrhta007@gmail.com", new DateTime(1988, 8, 21), 2100, d3);
            Seller s4 = new Seller(4, "Amanda Klein", "lucatyjda007@gmail.com", new DateTime(1989, 2, 21), 1000, d4);
            Seller s5 = new Seller(5, "José Castro", "lewrf007@gmail.com", new DateTime(1977, 3, 21), 1000, d3);
            Seller s6 = new Seller(6, "Sarah Winter", "lujytjyta007@gmail.com", new DateTime(2004, 5, 21), 1000, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000, SaleStatus.BILLED, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2017, 10, 26), 11000, SaleStatus.BILLED, s4);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 30), 11000, SaleStatus.BILLED, s2);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 08, 25), 11000, SaleStatus.BILLED, s3);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4);

            _context.SaveChanges();
        }
    }
}
