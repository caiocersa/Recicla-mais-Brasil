using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class ProdutoPersistencia
    {
        private static List<Produto> listaProdutos;

        static ProdutoPersistencia()
        {
            listaProdutos = new List<Produto>();
        }

        public Produto Adicionar(Produto produto)
        {
            produto.IdProduto = listaProdutos.Count + 1;
            listaProdutos.Add(produto);
            return produto;
        }

        public void Editar(Produto produto)
        {
            int posicao = listaProdutos.FindIndex(p => p.IdProduto == produto.IdProduto);
            listaProdutos[posicao] = produto;
        }

        public void Remover(Produto produto)
        {
            int posicao = listaProdutos.FindIndex(p => p.IdProduto == produto.IdProduto);
            listaProdutos.RemoveAt(posicao);
        }

        public Produto Obter(Func<Produto, bool> where)
        {
            return listaProdutos.Where(where).FirstOrDefault();
        }

        public List<Produto> ObterTodos()
        {
            return listaProdutos;
        }

        public List<Produto> ObterTodosAdm(Func<Produto,bool> where)
        {
            return listaProdutos.Where(where).ToList();
        }
    }
}
