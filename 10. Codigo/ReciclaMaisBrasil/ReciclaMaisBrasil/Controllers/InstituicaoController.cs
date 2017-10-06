using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;
using ReciclaMaisBrasil.Util;
using Model.Models.Exceptions;
using Model.Models.Account;

namespace ReciclaMaisBrasil.Controllers
{
    public class InstituicaoController : Controller
    {
        Instituicao inst = (Instituicao) SessionHelper.Get(SessionKeys.USUARIO);
        private GerenciadorInstituicao gerenciador;

        public InstituicaoController()
        {
            gerenciador = new GerenciadorInstituicao();
        }


        // GET: Instituicao
        public ActionResult Index()
        {
            return View();
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
                    instituicao.PwInstituicao = Criptografia.GerarHashSenha(instituicao.DocInstituicao + instituicao.PwInstituicao);
                    instituicao.NvAcesso = 2;
                    gerenciador.Adicionar(instituicao);
                    return RedirectToAction("Index","Home");   
                }
            }
            catch (Exception e)
            {
                throw new ControllerException("Cadastro não realizado, falha ao adicionar os campos. ", e);
            }
            return View();
        }

        // GET: Instituicao/Edit/5
        [Authenticated]
        [CustomAuthorize (NivelAcesso = Util.TipoUsuario.INSTITUICAO, MetodoAcao ="Index",Controladora ="Home")]
        public ActionResult Edit()
        {
            return View(inst);
        }

        // POST: Instituicao/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection formColletion)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Instituicao inst = new Instituicao();
                    TryUpdateModel<Instituicao>(inst, formColletion.ToValueProvider());
                    gerenciador.Editar(inst);
                    SessionHelper.Set(SessionKeys.USUARIO, inst);
                    return RedirectToAction("Index", "HistoricoInstituicao");
                }
                return RedirectToAction("Index");
            }
            catch
            {
            }
            return RedirectToAction("Index", "HistoricoInstituicao");
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

        [Authenticated]
        [CustomAuthorize(NivelAcesso = Util.TipoUsuario.INSTITUICAO, MetodoAcao = "Index", Controladora = "Home")]
        public ActionResult EditSenha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditSenha(SenhasModel senhasModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    senhasModel.NovaSenha = Criptografia.GerarHashSenha(inst.DocInstituicao + senhasModel.NovaSenha);
                    senhasModel.SenhaAtual = Criptografia.GerarHashSenha(inst.DocInstituicao + senhasModel.SenhaAtual);
                    if (inst.PwInstituicao == senhasModel.SenhaAtual && senhasModel.NovaSenha != inst.PwInstituicao) //Verificar se a senha nova é igual a senha da sessão
                    {
                        inst.PwInstituicao = senhasModel.NovaSenha;//Criptografar a senha
                        gerenciador.Editar(inst);
                        return RedirectToAction("Index", "HistoricoInstituicao");
                    }

                }

            }
            catch
            {
                
            }
            return View("EditSenha", "Instituicao");
        }
    }
}
