using ReciclaMaisBrasil.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Model.Models.Account;
using Negocio.Business;
using System.Web.Security;


namespace ReciclaMaisBrasil.Controllers
{
    public class HomeController : Controller
    {
        private GerenciadorPessoa gerenciadorP;
        private GerenciadorInstituicao gerenciadorI;
        public HomeController()
        {
            gerenciadorP = new GerenciadorPessoa();
            gerenciadorI = new GerenciadorInstituicao();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel dadosLogin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Obtendo o usuário.
                    dadosLogin.Senha = Criptografia.GerarHashSenha(dadosLogin.Login + dadosLogin.Senha);
                    Usuario usuario = gerenciadorP.ObterByLoginSenha(dadosLogin.Login, dadosLogin.Senha);
                    if(usuario == null)
                    {
                        usuario = gerenciadorI.ObterByLoginSenha(dadosLogin.Login, dadosLogin.Senha);
                    }
                    
                    // Autenticando.
                    if (usuario != null )
                    {
                        if (typeof(Pessoa) == usuario.GetType())
                            FormsAuthentication.SetAuthCookie(((Pessoa)usuario).CpfPessoa, dadosLogin.LembrarMe);
                        else
                            FormsAuthentication.SetAuthCookie(((Instituicao) usuario).DocInstituicao, dadosLogin.LembrarMe);

                        SessionHelper.Set(SessionKeys.USUARIO, usuario);
                        if (usuario.NvAcesso == ((int)Util.TipoUsuario.PESSOA) + 1)
                            return RedirectToAction("Index", "HistoricoUsuario");
                        else if (usuario.NvAcesso == ((int)Util.TipoUsuario.INSTITUICAO) + 1)
                            return RedirectToAction("Index", "HistoricoInstituicao");
                        else if (usuario.NvAcesso == ((int)Util.TipoUsuario.ADMCOMPRA) + 1)
                            return RedirectToAction("Index", "AdmCompra");
                        else if (usuario.NvAcesso == ((int)Util.TipoUsuario.ADM) + 1)
                            return RedirectToAction("Index","Administrador");
                    }
                }
                ModelState.AddModelError("", "Usuário e/ou senha inválidos.");
            }
            catch
            {
                ModelState.AddModelError("", "A autenticação falhou. Forneça informações válidas e tente novamente.");
            }
            return View();
        }
    }

}