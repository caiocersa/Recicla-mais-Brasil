using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    class Usuario
    {

        public String Email { get; set; }
        public int Cep { get; set; }
        public String TpLogarouro { get; set; }
        public String Bairro { get; set; }
        public String NmEndereco { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public int NumEndereco { get; set; }
        public String Complemento { get; set; }
        public int NvAcesso { get; set; }
    }
}