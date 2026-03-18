using Microsoft.AspNetCore.Mvc;

namespace primeiro_app.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nota = "Aluno MB";
            ViewData["Escola"] = "Basilides de Godoy";
            return View();
        }

        public IActionResult Teste()
        {
            TempData["MSG_EX"] = "Mensagem do TempData";
            return RedirectToAction("Resultado");
        }

        public IActionResult Resultado()
        {
            if (TempData["MSG_EX"] != null)
                ViewBag.Exemplo = "Aluno ETEC MB";
            return View();
        }
    }
}