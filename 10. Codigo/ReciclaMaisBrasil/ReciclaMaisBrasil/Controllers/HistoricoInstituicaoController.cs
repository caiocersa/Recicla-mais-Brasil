using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using ReciclaMaisBrasil.Util;

namespace ReciclaMaisBrasil.Controllers
{

    public class HistoricoInstituicaoController : Controller
    {

        Instituicao inst = (Instituicao)SessionHelper.Get(SessionKeys.INSTITUICAO);

        // GET: HistoricoInstituicao
        public ActionResult Index()
        {
            return View();
        }

        // GET: HistoricoInstituicao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HistoricoInstituicao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistoricoInstituicao/Create
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

        public ActionResult Pontuacao()
        {
            return PartialView();
        }

        // GET: HistoricoInstituicao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HistoricoInstituicao/Edit/5
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

        // GET: HistoricoInstituicao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HistoricoInstituicao/Delete/5
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
    }
}
