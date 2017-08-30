using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Instituicao : Usuario
    {
        public string DocInstituicao { get; set; }
        public string PwInstituicao { get; set; }
        public string NmInstituicao { get; set; }
        public string NmResponsavel { get; set; }
        public int NumColeta { get; set; }

        public Instituicao(int IdUsuario, string Email)
        {
            this.IdUsuario = IdUsuario;
            this.Email = Email;
        }

        public Instituicao() : this(0, null) { }
    }
}
