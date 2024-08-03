using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }

        //Validação [required]
        [Required(ErrorMessage = "{0} Obrigatório")] //Obrigatório informar o nome
        [StringLength(30, MinimumLength = 3, ErrorMessage = "{0} entre {2} à {1} caracteres")] //limitação de tamanho de string
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [EmailAddress(ErrorMessage = "Formato Inválido")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} Obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} Obrigatório")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} Entre {1} à {2}")]
        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Basesalary { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; } // FK
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
            //DepartmentId = departmenId;
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
