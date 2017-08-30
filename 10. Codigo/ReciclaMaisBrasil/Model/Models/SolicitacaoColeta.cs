using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class SolicitacaoColeta
    {

        public string Reciclavel { get; set; }
        public DateTime DtSolicitacao { get; set; }
        public byte FotoReciclavel { get; set; }
        public string DescReciclavel { get; set; }
        public int Status { get; set; }
        public int Pontuacao { get; set; }

    }
}
