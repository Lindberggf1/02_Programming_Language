using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;  //associacao dependencia
        private readonly DepartmentService _departmentService;  //associacao dependencia

        public SellersController(SellerService sellersService, DepartmentService departmentService) // injecao de dependencia
        {
            _sellerService = sellersService;
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var list = _sellerService.FindAll(); // aqui chamamos os metodos
            return View(list); // aqui o controlador chama a lista e a constroi na view
        }

        public IActionResult Create() //para abrir os departamentos
        {
            var departments = _departmentService.FindAll(); // buscar todos os departamentos
            var viewModel = new SellerFormViewModel { Departments = departments }; // instancia objeto da view com a lista de departamentos
            return View(viewModel);
        }

        [HttpPost] //para mostar que o Create sera por Post
        [ValidateAntiForgeryToken] // Evitar ataques XSRF/CSRF
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller); //insere o novo Vendedor
            return RedirectToAction(nameof(Index)); // rediriciona para a pagina index -- nameof server para não precisar alterar aqui caso troque o nome da index
        }

        public IActionResult Delete(int? id) // tem o ? para indicar que é opcional o parametro
        {
            if (id == null)
            {
                return NotFound(); // vamos instanciar depois como pagina de erro
            }

            var obj = _sellerService.FindById(id.Value); // colocamos o Value para pegar caso ele exista, por conta do ?
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
