using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context; // dependencia do context, e readonly para não ser modificado

        public DepartmentService(SalesWebMvcContext context) // para injeção de dependencia
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList(); //Busca os departamentos e ordenados por nome
        }
    }
}
