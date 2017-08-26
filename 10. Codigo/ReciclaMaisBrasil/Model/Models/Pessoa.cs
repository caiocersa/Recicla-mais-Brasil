using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    class Pessoa : Usuario
    {
        public int id_usuario { get; set; }
        public string CpfPessoa { get; set; }
        public string PwPessoa { get; set; }
        public string NmPessoa { get; set; }
        public string Telefone { get; set; }
        public DateTime DtNasc { get; set; }
        public int Pontuacao { get; set; }

        public Pessoa(int id_usuario, string CpfPessoa)
        {
            this.id_usuario = id_usuario;
            this.CpfPessoa = CpfPessoa;
        }
    }
}