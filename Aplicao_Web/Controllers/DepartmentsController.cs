using Aplicacao_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacao_Web.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Nome = "Eletronics" });
            list.Add(new Department { Id = 2, Nome = "Fashion" });

            return View(list);
        }
    }
}
