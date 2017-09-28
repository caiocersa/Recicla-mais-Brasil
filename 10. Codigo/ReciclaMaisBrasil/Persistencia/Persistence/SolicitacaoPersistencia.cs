using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Model.Models;

namespace Persistencia.Persistence
{
    public class SolicitacaoPersistencia
    {
        private static List<SolicitacaoColeta> listaSolicitacoes;

        static SolicitacaoPersistencia()
        {
            listaSolicitacoes = new List<SolicitacaoColeta>();
        }

        public SolicitacaoColeta Adicionar(SolicitacaoColeta solicitacao)
        {
            solicitacao.IdSolicitacao = listaSolicitacoes.Count + 1;
            solicitacao.CodSolicitacao = listaSolicitacoes.Count + 1;
            listaSolicitacoes.Add(solicitacao);
            return solicitacao;
        }

        public void Editar(SolicitacaoColeta solicitacao)
        {
            int posicao = listaSolicitacoes.FindIndex(e => e.IdSolicitacao == solicitacao.IdSolicitacao);
            listaSolicitacoes[posicao] = solicitacao;
        }

        public void Remover(SolicitacaoColeta solicitacao)
        {
            int posicao = listaSolicitacoes.FindIndex(e => e.IdSolicitacao == solicitacao.IdSolicitacao);
            listaSolicitacoes.RemoveAt(posicao);
        }

        public SolicitacaoColeta Obter(Func<SolicitacaoColeta, bool> where)
        {
            return listaSolicitacoes.Where(where).FirstOrDefault();
        }

        public List<SolicitacaoColeta> ObterTodos()
        {
            return listaSolicitacoes;
        }
    }
}