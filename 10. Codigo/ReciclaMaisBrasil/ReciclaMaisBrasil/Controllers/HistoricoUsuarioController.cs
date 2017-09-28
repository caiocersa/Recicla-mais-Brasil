using System.Web.Mvc;
using Model.Models;
using ReciclaMaisBrasil.Util;
using Jmelosegui.Mvc.GoogleMap;
using System.Web.Security;

namespace ReciclaMaisBrasil.Controllers
{

    public class HistoricoUsuarioController : Controller
    {
        Pessoa user = (Pessoa) SessionHelper.Get(SessionKeys.USUARIO);
        // GET: HistoricoUsuario

        [Authenticated]
        [CustomAuthorize(NivelAcesso = Util.TipoUsuario.PESSOA, MetodoAcao = "Index", Controladora = "Home")]
        public ActionResult Index()
        {
            return View(user);
        }

        [Authenticated]
        [CustomAuthorize(NivelAcesso = Util.TipoUsuario.PESSOA, MetodoAcao = "Map", Controladora = "HistoricoUsuario")]
        public ActionResult Map()
        {
            return PartialView();
        }

        [Authenticated]
        [CustomAuthorize(NivelAcesso = Util.TipoUsuario.PESSOA, MetodoAcao = "Pontuacao", Controladora = "HistoricoUsuario")]
        public ActionResult Pontuacao()
        {
            
            return PartialView(user);
        }

        [Authenticated]
        [CustomAuthorize(NivelAcesso = Util.TipoUsuario.PESSOA, MetodoAcao = "ExibirHistorico", Controladora = "HistoricoUsuario")]
        public ActionResult ExibirHistorico()
        {
            return PartialView();
        }

        [Authenticated]
        public ActionResult Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                FormsAuthentication.SignOut();
                Session.Abandon();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
