using System.Web.Mvc;
using Negocio.Business;
using Model.Models;
using ReciclaMaisBrasil.Util;
using Model.Models.Exceptions;
using System;
using Model.Models.Account;

namespace ReciclaMaisBrasil.Controllers
{
    public class PessoaController : Controller
    {
        private GerenciadorPessoa gerenciador;
        Pessoa user = (Pessoa) SessionHelper.Get(SessionKeys.USUARIO);
        

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
                    pessoa.PwPessoa = Criptografia.GerarHashSenha(pessoa.CpfPessoa + pessoa.PwPessoa);
                    pessoa.NvAcesso = 1;
                    gerenciador.Adicionar(pessoa);                   
                    return RedirectToAction("Index","Home");
                }
            }
            catch (Exception e)
            {
                throw new ControllerException("Cadastro não realizado, falha ao adicionar os campos. ", e);
            }
            return View();
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit()
        {

            return View(user);
            
        }

        // POST: Pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Pessoa usuario)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    gerenciador.Editar(usuario);
                    SessionHelper.Set(SessionKeys.USUARIO, usuario);
                    return RedirectToAction("Index", "HistoricoUsuario");
                }

            }
            catch
            {

            }
            return RedirectToAction("Index", "HistoricoUsuario");
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

        public ActionResult EditSenha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditSenha(SenhasModel senhaModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    senhaModel.NovaSenha = Criptografia.GerarHashSenha(user.CpfPessoa + senhaModel.NovaSenha);
                    senhaModel.SenhaAtual = Criptografia.GerarHashSenha(user.CpfPessoa + senhaModel.SenhaAtual);
                  if(user.PwPessoa == senhaModel.SenhaAtual && senhaModel.NovaSenha != user.PwPessoa) //Verificar se a senha nova é igual a senha da sessão
                    {
                        user.PwPessoa = senhaModel.NovaSenha;//Criptografar a senha
                        gerenciador.Editar(user);
                        return RedirectToAction("Index","HistoricoUsuario");
                    }
                }
            }catch
            {
                
            }
            return View("EditSenha","Pessoa");
        }
    }
}
