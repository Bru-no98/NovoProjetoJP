using Microsoft.AspNetCore.Mvc;

namespace NovoProjeto.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
