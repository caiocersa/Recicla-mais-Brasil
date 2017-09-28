using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorInstituicao
    {
            private InstituicaoPersistencia persistencia;

            public GerenciadorInstituicao()
            {
                persistencia = new InstituicaoPersistencia();
            }

            public Instituicao Adicionar(Instituicao instituicao)
            {
                persistencia.Adicionar(instituicao);
                return instituicao;
            }

            public void Editar(Instituicao instituicao)
            {
                persistencia.Editar(instituicao);
            }

            public void Remover(Instituicao instituicao)
            {
                persistencia.Remover(instituicao);
            }

            public Instituicao Obter(int id)
            {
                return persistencia.Obter(e => e.IdUsuario == id);
            }

            public List<Instituicao> ObterTodos()
            {
                return persistencia.ObterTodos();
            }

        public List<Instituicao> ObterTodosInstituicao()
        {
            var query = from instituicao in persistencia.ObterTodos().AsQueryable()
                        select new Instituicao
                        {
                            IdUsuario = instituicao.IdUsuario,
                            NmInstituicao = instituicao.NmInstituicao
                        };
            return query.ToList();
        }

        public Instituicao ObterByLoginSenha(string login, string senha)
            {
                return persistencia.Obter(e => e.DocInstituicao.ToLowerInvariant().Equals(login.ToLowerInvariant()) &&
                    e.PwInstituicao.ToLowerInvariant().Equals(senha.ToLowerInvariant()));
            }

    }
}
