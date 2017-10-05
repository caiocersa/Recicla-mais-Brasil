using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;
using ReciclaMaisBrasil.Util;

namespace ReciclaMaisBrasil.Controllers
{
    public class AdmProdutoController : Controller
    {
        public GerenciadorProduto gerenciadoraP;
        public Pessoa user = (Pessoa) SessionHelper.Get(SessionKeys.USUARIO);

        public AdmProdutoController()
        {
            gerenciadoraP = new GerenciadorProduto();
        }
        // GET: AdmProduto
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdmProduto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdmProduto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdmProduto/Create
        [HttpPost]
        public ActionResult Create(Produto prod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    prod.IdAdmProduto = user.IdUsuario;
                    gerenciadoraP.Adicionar(prod);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmProduto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdmProduto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Produto prod)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    gerenciadoraP.Editar(prod);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmProduto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdmProduto/Delete/5
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
            return View(gerenciadoraP.ObterTodosAdm);
        }
    }
}
