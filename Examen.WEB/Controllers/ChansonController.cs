using Examen.ApplicationCore.Domaine;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.WEB.Controllers
{
    public class ChansonController : Controller
    {
        IChansonService _chansonService;
        IArtisteService _artisteService;

        public ChansonController(IChansonService chansonService, IArtisteService artisteService)
        {
            _chansonService = chansonService;
            _artisteService = artisteService;
        }

        // GET: ChansonController
        public ActionResult Index()
        {
            return View(_chansonService.GetAll().OrderBy(c=>c.vuesYoutube).ToList());
        }

        // GET: ChansonController/Details/5
        public ActionResult Artiste(int id)
        {
            return View(_artisteService.GetById(id));
        }

        // GET: ChansonController/Create
        public ActionResult Create()
        {
            ViewBag.ArtisteList = new SelectList(_artisteService.GetAll().ToList(),"ArtisteId","Nom");
            return View();
        }

        // POST: ChansonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chanson chanson)
        {
            try
            {
                _chansonService.Add(chanson);
                _chansonService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChansonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_chansonService.GetById(id));
        }

        // POST: ChansonController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Chanson chanson)
        {
            try
            {
                chanson.ChansonId= id;
                _chansonService.Update(chanson);
                _chansonService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChansonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_chansonService.GetById(id));
        }

        // POST: ChansonController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Chanson chanson)
        {
            try
            {
                chanson.ChansonId = id;
                _chansonService.Delete(chanson);
                _chansonService.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
