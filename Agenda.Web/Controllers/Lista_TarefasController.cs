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
            if (obj.Tipo == obj.Descrição)
            {
                ModelState.AddModelError("Tipo", "Os campos Tipo e Descrição não podem ser iguais");
            }

            if (ModelState.IsValid)
            {
                _db.Listas_Tarefas.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "A Lista foi criada com sucesso.";
                return RedirectToAction("Index");
            }

            TempData["error"] = "Não foi possivel criar a Lista.";

            return View(obj);
        }

        public IActionResult Editar(int lista_tarefasId)
        {
            Lista_Tarefas? obj = _db.Listas_Tarefas.FirstOrDefault(u => u.Id == lista_tarefasId);

            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Editar(Lista_Tarefas obj)
        {

            if (ModelState.IsValid)
            {
                _db.Listas_Tarefas.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "A Lista foi editada com sucesso.";
                return RedirectToAction("Index");
            }

            TempData["error"] = "Não foi possivel editar a Lista.";

            return View(obj);
        }

        public IActionResult Apagar(int lista_tarefasId)
        {
            Lista_Tarefas? obj = _db.Listas_Tarefas.FirstOrDefault(u => u.Id == lista_tarefasId);

            if (obj is null)
            {
                return RedirectToAction("Error", "Home");
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Apagar(Lista_Tarefas obj)
        {
            Lista_Tarefas? objFromDb = _db.Listas_Tarefas.FirstOrDefault(u => u.Id == obj.Id);

            if (objFromDb is not null)
            {
                _db.Listas_Tarefas.Remove(objFromDb);
                _db.SaveChanges();
                TempData["success"] = "A Lista foi apagada com sucesso.";
                return RedirectToAction("Index");
            }

            TempData["error"] = "Não foi possivel apagar a Lista.";

            return View(obj);
        }
    }
}
