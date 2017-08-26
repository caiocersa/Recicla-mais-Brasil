using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    class Instituicao : Usuario
    {
        public String DocInstituicao { get; set; }
        public String PwInstituicao { get; set; }
        public String NmInstituicao { get; set; }
        public String NmResponsavel { get; set; }
        public int NumColeta { get; set; }
    }
}
