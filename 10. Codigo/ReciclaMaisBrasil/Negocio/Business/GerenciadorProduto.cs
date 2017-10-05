using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorProduto
    {
        private ProdutoPersistencia persistencia;

        public GerenciadorProduto()
        {
            persistencia = new ProdutoPersistencia();
        }

        public Produto Adicionar(Produto produto)
        {
            persistencia.Adicionar(produto);
            return produto;
        }

        public void Editar(Produto produto)
        {
            persistencia.Editar(produto);
        }

        public void Remover(Produto produto)
        {
            persistencia.Remover(produto);
        }

        public Produto Obter(int id)
        {
            return persistencia.Obter(p => p.IdProduto == id);
        }

        public List<Produto> ObterTodos()
        {
            return persistencia.ObterTodos();
        }

        public List<Produto> ObterTodosAdm(int id)
        {
            return persistencia.ObterTodosAdm(p => p.IdAdmProduto == id);
        }

    }
}
