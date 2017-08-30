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
        
    }
}
