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
    public class SolicitarController : Controller
    {
        GerenciadorSolicitacao gerenciador = new GerenciadorSolicitacao();
        Pessoa user = (Pessoa)SessionHelper.Get(SessionKeys.USUARIO);
        // GET: Solicitar
        public ActionResult Index()
        {
            return View();
        }

        // GET: Solicitar/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Solicitar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Solicitar/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "IdSolicitacao, CodSolicitacao, DtAbertura, DtEmAndamento,Status")]SolicitacaoColeta solicitacao)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    solicitacao.Status = 0;
                    solicitacao.IdPessoa = user.IdUsuario;
                    solicitacao.DtAbertura = DateTime.Now;
                    gerenciador.Adicionar(solicitacao);
                    return RedirectToAction("Index","HistoricoUsuario");
                }
               
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: Solicitar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Solicitar/Edit/5
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

        // GET: Solicitar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Solicitar/Delete/5
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
