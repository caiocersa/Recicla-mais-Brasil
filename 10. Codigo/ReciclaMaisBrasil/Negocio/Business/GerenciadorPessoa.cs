using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorPessoa
    {
        private PessoaPersistencia persistencia;

        public GerenciadorPessoa()
        {
            persistencia = new PessoaPersistencia();
        }

        public Pessoa Adicionar(Pessoa pessoa)
        {
            persistencia.Adicionar(pessoa);
            return pessoa;
        }

        public void Editar(Pessoa pessoa)
        {
            persistencia.Editar(pessoa);
        }

        public void Remover(Pessoa pessoa)
        {
            persistencia.Remover(pessoa);
        }

        public Pessoa Obter(int id)
        {
            return persistencia.Obter(e => e.IdUsuario == id);
        }

        public List<Pessoa> ObterTodos()
        {
            return persistencia.ObterTodos();
        }
    }
}
