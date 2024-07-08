using System;
using System.Collections;
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
        public double Basesalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        #region métodos construtores
        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double basesalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            Basesalary = basesalary;
            Department = department;
        }
        #endregion

        #region método adicionar vendedor
        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        #endregion

        #region método remover vendedor
        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        #endregion

        #region método que retorna total de vendas de um vendendor
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
        #endregion
    }
}
