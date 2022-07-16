using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context; // dependencia do context, e readonly para não ser modificado

        public SellerService(SalesWebMvcContext context) // para injeção de dependencia
        {
            _context = context;
        }

        // criar o Find da Lista
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); // busca o vendendor e transforma em lista
        }

        public void Insert(Seller obj)
        {
            //obj.Department = _context.Department.First(); // inserir o primeiro departament para evitar erros caso não passar.
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int Id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == Id); // buscar se exist o vendendo, caso nao passa null
        }

        public void Remove (int id)
        {
            var obj = _context.Seller.Find(id); //buscar o vendedor
            _context.Seller.Remove(obj); // remover do dataset
            _context.SaveChanges(); // Salvar e atualizar o banco de dados.

        }
    }
}
