using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class InstituicaoPersistencia
    {
        private static List<Instituicao> listaInstituicoes;

        static InstituicaoPersistencia()
        {
            listaInstituicoes = new List<Instituicao>();
        }

        public Instituicao Adicionar(Instituicao instituicao)
        {
            instituicao.IdUsuario = listaInstituicoes.Count + 1;
            listaInstituicoes.Add(instituicao);
            return instituicao;
        }

        public void Editar(Instituicao instituicao)
        {
            int posicao = listaInstituicoes.FindIndex(e => e.IdUsuario == instituicao.IdUsuario);
            listaInstituicoes[posicao] = instituicao;
        }

        public void Remover(Instituicao instituicao)
        {
            int posicao = listaInstituicoes.FindIndex(e => e.IdUsuario == instituicao.IdUsuario);
            listaInstituicoes.RemoveAt(posicao);
        }

        public Instituicao Obter(Func<Instituicao, bool> where)
        {
            return listaInstituicoes.Where(where).FirstOrDefault();
        }

        public List<Instituicao> ObterTodos()
        {
            return listaInstituicoes;
        }
    }
}
