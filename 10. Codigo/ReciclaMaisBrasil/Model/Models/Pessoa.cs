using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Pessoa : Usuario
    {

        public string CpfPessoa { get; set; }
        public string PwPessoa { get; set; }
        public string NmPessoa { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNasc { get; set; }
        public int Pontuacao { get; set; }


    }
}