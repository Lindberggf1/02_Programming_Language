using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        //ATRIBUTOS BASICOS
        public int Id { get; set; }
        public string Name { get; set; }

        //ASSOCIACOES
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); // assim por que é UM DEPART PODE SER DE muitos VENDEDORES Na associação.
        
        //Construtores
        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //Metodos
        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSeller(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
