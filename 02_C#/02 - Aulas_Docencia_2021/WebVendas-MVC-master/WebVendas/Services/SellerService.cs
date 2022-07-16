using System.Collections.Generic;
using System.Linq;
using WebVendas.Data;
using WebVendas.Models;

namespace WebVendas.Services
{
    public class SellerService
    {
        private readonly WebVendasContext _context; // dependencia do context, e readonly para não ser modificado

        public SellerService(WebVendasContext context) // para injeção de dependencia
        {
            _context = context;
        }

        // criar o Find da Lista que retornar uma lista com todos vendedores do banco na pagina do sistema.
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); // busca o vendendor e transforma em lista
        }

        public void Insert(Seller obj)
        {
            //=====>>> teste para pegar o primeiro departmente do banco <<<<<============
            //obj.Department = _context.Department.First();

            //Chamar e adicionar um novo objeto Vendedor na lista
            _context.Add(obj);

            //confirmar no banco de dados o adicionamento do novo vendedor
            _context.SaveChanges();
        }

    }
}
