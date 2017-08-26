using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    class Solicitacao_Coleta
    {
        private String Reciclavel { get; set; }
        private DateTime DtSolicitacao { get; set; }
        private Byte FotoReciclavel { get; set; }
        private String DescReciclavel { get; set; }
        private int Status { get; set; }
        private int Pontuacao { get; set; }
    }
}
