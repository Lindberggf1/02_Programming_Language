using Microsoft.AspNetCore.Mvc;
using WebVendas.Services;
using WebVendas.Models;
using WebVendas.Models.ViewModels;

namespace WebVendas.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;  //associacao
        private readonly DepartmentService _departmentService;  //associacao

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

        public IActionResult Create()
        {
            //pegar na base de dados os departamentos
            var departments = _departmentService.FindAll();

            //instancia um objeto viewMoldel ja iniciando com a lista de departments que buscamos
            var viewModel = new SellerFormViewModel { Departments = departments };

            //passsamos o obj viewModel para a view
            return View(viewModel);
        }

        //avisar que é via post
        [HttpPost]
        //Previnir ataques CSRF - ataques aproveitando a seção de autenticação aberta
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);// inserir o vendedor
            return RedirectToAction(nameof(Index)); // redirecionar para a pagina inicial
        }
    }
}
