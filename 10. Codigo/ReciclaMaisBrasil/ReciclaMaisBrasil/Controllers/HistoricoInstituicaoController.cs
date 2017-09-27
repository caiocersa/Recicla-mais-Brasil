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

        Instituicao inst = (Instituicao)SessionHelper.Get(SessionKeys.USUARIO);

        [Authenticated]
        [CustomAuthorize(NivelAcesso = Util.TipoUsuario.INSTITUICAO, MetodoAcao = "Index", Controladora = "HistoricoInstituicao")]
        public ActionResult Index()
        {
            return View();
        }

        [Authenticated]
        [CustomAuthorize(NivelAcesso = Util.TipoUsuario.INSTITUICAO, MetodoAcao = "Pontuacao", Controladora = "HistoricoInstituicao")]
        public ActionResult Pontuacao()
        {
            return PartialView();
        }


    }
}
