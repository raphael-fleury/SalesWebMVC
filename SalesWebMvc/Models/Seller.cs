using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        #region Properties
        public int Id { get; set; }

        #region Name
        [Required(ErrorMessage = "{0} required")]
        [StringLength(80, ErrorMessage = "{0} size should be smaller than {1}")]

        public string Name { get; set; }
        #endregion

        #region Email
        [Required(ErrorMessage = "{0} required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]       
        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        #endregion

        #region Birth Date
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]

        public DateTime BirthDate { get; set; }
        #endregion

        #region Base Salary
        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(100, 50000, ErrorMessage = "{0} must be from {1} to {2}")]

        public double BaseSalary { get; set; }
        #endregion

        #region Department
        public Department Department { get; set; }

        [Display(Name = "Department Id")]
        public int DepartmentId { get; set; }
        #endregion

        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();
        #endregion

        #region Constructors
        public Seller() { }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        #endregion

        #region Methods
        public void AddSales(SalesRecord sr) => Sales.Add(sr);
        public void RemoveSales(SalesRecord sr) => Sales.Remove(sr);

        public double TotalSales(DateTime initial, DateTime final) => 
            Sales.Where(s => s.Date > initial && s.Date < final).Sum(s => s.Amount);
        #endregion
    }
}
