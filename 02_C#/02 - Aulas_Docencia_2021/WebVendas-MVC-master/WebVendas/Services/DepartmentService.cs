using System.Collections.Generic;
using System.Linq;
using WebVendas.Data;
using WebVendas.Models;

namespace WebVendas.Services
{
    public class DepartmentService
    {
        private readonly WebVendasContext _context; // dependencia do context, e readonly para não ser modificado

        public DepartmentService(WebVendasContext context) // para injeção de dependencia
        {
            _context = context;
        }

        //retornar todos departamentos
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
