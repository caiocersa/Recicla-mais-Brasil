using System.Web.Mvc;
using Negocio.Business;
using Model.Models;
using ReciclaMaisBrasil.Util;

namespace ReciclaMaisBrasil.Controllers
{
    public class PessoaController : Controller
    {
        private GerenciadorPessoa gerenciador;
        Pessoa user = (Pessoa) SessionHelper.Get(SessionKeys.PESSOA);
        

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
                    //Inserindo cadastrado na Sessão RETIRAR DEPOIS
                    SessionHelper.Set(0, pessoa);
                    return RedirectToAction("Index","Home");
                }
            }
            catch
            {

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
                    SessionHelper.Set(SessionKeys.PESSOA, usuario);
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
    }
}
