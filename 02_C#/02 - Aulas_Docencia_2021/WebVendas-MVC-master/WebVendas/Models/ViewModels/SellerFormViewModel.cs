using System.Collections.Generic;
namespace WebVendas.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }

        //para listar de departamentos
        public ICollection<Department> Departments { get; set; }
    }
}
