using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        #region método construtores
        public Department()
        {
        }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion
        #region método que adiciona vendedor na lista de vendedores
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        #endregion
        #region Método que calcula as vendas do departamento dentro de um intervalo de datas
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }


        #endregion
    }
}
