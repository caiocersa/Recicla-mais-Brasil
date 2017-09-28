using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;
using Persistencia.Persistence;

namespace Negocio.Business
{
    public class GerenciadorSolicitacao
    {
        private SolicitacaoPersistencia persistencia;

        public GerenciadorSolicitacao()
        {
            persistencia = new SolicitacaoPersistencia();
        }

        public SolicitacaoColeta Adicionar(SolicitacaoColeta solicitacao)
        {
            persistencia.Adicionar(solicitacao);
            return solicitacao;
        }

        public void Editar(SolicitacaoColeta solicitacao)
        {
            persistencia.Editar(solicitacao);
        }

        public void Remover(SolicitacaoColeta solicitacao)
        {
            persistencia.Remover(solicitacao);
        }

        public SolicitacaoColeta Obter(int id)
        {
            return persistencia.Obter(e => e.IdSolicitacao == id);
        }

        public List<SolicitacaoColeta> ObterTodos()
        {
            return persistencia.ObterTodos();
        }

        
    }
}
