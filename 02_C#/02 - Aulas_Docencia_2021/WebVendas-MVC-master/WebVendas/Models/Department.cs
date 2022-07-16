using System;
using System.Linq;
using System.Collections.Generic;

namespace WebVendas.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // USAMOS LIST por que UM DEPARTMENT PODE SER DE muitos VENDEDORES Na associação. 
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        //construtores
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
            //aqui vamos usar o LIQ com expressão Lambda  
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }

    }
}
