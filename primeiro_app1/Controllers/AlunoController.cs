using Microsoft.AspNetCore.Mvc;

namespace primeiro_app.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
