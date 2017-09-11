using ReciclaMaisBrasil.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Models;
using Negocio.Business;

namespace ReciclaMaisBrasil.Controllers
{
    public class HomeController : Controller
    {
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
            Pessoa p = new Pessoa();
            p.IdUsuario = 0;
            p.NmPessoa = "Caio César Alves de Souza";
            p.NumEndereco = 129;
            p.NmEndereco = "Bejamin Constant";
            p.Pontuacao = 20000;
            p.CpfPessoa = "109.005.964-73";
            p.Cep = 4444444;
            p.Cidade = "Itabaiana";
            p.Bairro = "Centro";
            p.DtNasc = DateTime.Now;
            p.TpLogarouro = "Rua";
            p.Telefone = "(79)99122-4512";
            p.Email = "caio_cersa_@hotmail.com";
            p.Estado = "SE";
            SessionHelper.Set(0, p);

            return View("Index");
        }
    }
}