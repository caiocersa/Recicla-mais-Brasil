using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio.Business;
using Model.Models;

namespace ReciclaMaisBrasil.Controllers
{
    public class PessoaController : Controller
    {
        private GerenciadorPessoa gerenciador;

        public PessoaController()
        {
            gerenciador = new GerenciadorPessoa();
        }

        // GET: Pessoa
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pessoa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pessoa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "IdUsuario, Pontuacao, NvAcesso")] Pessoa pessoa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciador.Adicionar(pessoa);
                    return RedirectToAction("Index","Home");
                }
            }
            catch
            {

            }
            return View();
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pessoa/Edit/5
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

        // GET: Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pessoa/Delete/5
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

        public ActionResult List()
        {
            return View(gerenciador.ObterTodos());
        }

        public ActionResult teste()
        {
            return View();
        }
    }
}
