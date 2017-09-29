using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class SolicitacaoColeta
    {
        [Key]
        [Display(Name = "ID Solicitação:")]
        public int IdSolicitacao { get; set; }

        [Display(Name = "ID Pessoa:")]
        [Required]
        public int IdPessoa { get; set; }

        [Display(Name = "Instituição:")]
        [Required]
        public int IdInstituicao { get; set; }

        [Key]
        [Display(Name = "Codigo da Solicitação:")]
        public int CodSolicitacao { get; set; }

        [Required]
        [StringLength(maximumLength:45)]
        [Display(Name = "Reciclavel:")]
        public string Reciclavel { get; set; }
        
        [Required]
        [Display(Name = "Descrição:")]
        [StringLength(maximumLength:100)]
        public string DescReciclavel { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "Foto:")]
        public byte FotoReciclavel { get; set; }

        [Required]
        [Display(Name = "Tipo de Solicitação:")]
        public char TpSolicitacao { get; set; }

        [Display(Name = "Status:")]
        public int Status { get; set; }

        [Display(Name = "Pontuação:")]
        public int Pontuacao { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Data de Abertura:")]
        public DateTime DtAbertura { get; set; }

        [Display(Name = "Data em Andamento:")]
        [DataType(DataType.DateTime)]
        public DateTime DtEmAndamento { get; set; }

        public SolicitacaoColeta(int IdSolicitacao, int CodSolicitacao)
        {
            this.IdSolicitacao = IdSolicitacao;
            this.CodSolicitacao = CodSolicitacao;
        }

        public SolicitacaoColeta() : this(0, 0) { }

        public SolicitacaoColeta(int CodSolicitacao) : this (0,CodSolicitacao) {}

    }


}
