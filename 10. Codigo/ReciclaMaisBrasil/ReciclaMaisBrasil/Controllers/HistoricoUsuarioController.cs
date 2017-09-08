using System.Web.Mvc;
using Model.Models;
using ReciclaMaisBrasil.Util;
using Jmelosegui.Mvc.GoogleMap;

namespace ReciclaMaisBrasil.Controllers
{
    public class HistoricoUsuarioController : Controller
    {
        // GET: HistoricoUsuario
        
        public ActionResult Index()
        {

            Pessoa user = (Pessoa) SessionHelper.Get(0);
            return View(user);
        }

        // GET: HistoricoUsuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HistoricoUsuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistoricoUsuario/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HistoricoUsuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HistoricoUsuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HistoricoUsuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HistoricoUsuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult map()
        {
            return PartialView();
        }

        public ActionResult Pontuacao()
        {
            Usuario user = (Usuario) SessionHelper.Get(0);
            return PartialView(user);
        }

        public ActionResult ExibirHistorico()
        {
            return PartialView();
        }
    }
}
