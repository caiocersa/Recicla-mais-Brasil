using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace ReciclaMaisBrasil.Controllers
{
    public class InstituicaoController : Controller
    {
        private GerenciadorInstituicao gerenciador;

        public InstituicaoController()
        {
            gerenciador = new GerenciadorInstituicao();
        }


        // GET: Instituicao
        public ActionResult Index()
        {
            return View(gerenciador.ObterTodos());
        }

        // GET: Instituicao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Instituicao/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Instituicao/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "idUsuario, NumColeta, NumEndereco")]Instituicao instituicao)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(instituicao);
                    return RedirectToAction("Index","Home");   
                }
            }
            catch
            {
               
            }
            return View();
        }

        // GET: Instituicao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Instituicao/Edit/5
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

        // GET: Instituicao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Instituicao/Delete/5
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

        public ActionResult Mostrar()
        {
            return View(gerenciador.ObterTodos());
        }
    }
}
