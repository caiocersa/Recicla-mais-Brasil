using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;


namespace Persistencia.Persistence
{
    public class PessoaPersistencia
    {
        private static List<Pessoa> listaPessoas;

        static PessoaPersistencia()
        {
            listaPessoas = new List<Pessoa>();
        }

        public Pessoa Adicionar(Pessoa pessoa)
        {
            pessoa.IdUsuario = listaPessoas.Count + 1;
            listaPessoas.Add(pessoa);
            return pessoa;
        }

        public void Editar(Pessoa pessoa)
        {
            int posicao = listaPessoas.FindIndex(e => e.IdUsuario == pessoa.IdUsuario);
            listaPessoas[posicao] = pessoa;
        }

        public void Remover(Pessoa pessoa)
        {
            int posicao = listaPessoas.FindIndex(e => e.IdUsuario == pessoa.IdUsuario);
            listaPessoas.RemoveAt(posicao);
        }

        public Pessoa Obter(Func<Pessoa, bool> where)
        {
            return listaPessoas.Where(where).FirstOrDefault();
        }

        public List<Pessoa> ObterTodos()
        {
            return listaPessoas;
        }

    }
}
