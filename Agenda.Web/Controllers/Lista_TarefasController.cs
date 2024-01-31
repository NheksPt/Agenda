using Agenda.Domain.Entities;
using Agenda.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Agenda.Web.Controllers
{
    public class Lista_TarefasController : Controller
    {
        private readonly ApplicationDbContext _db;

        public Lista_TarefasController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var lista = _db.Listas_Tarefas.ToList();
            return View(lista);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Lista_Tarefas obj)
        {
            if (ModelState.IsValid)
            { 
            _db.Listas_Tarefas.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
