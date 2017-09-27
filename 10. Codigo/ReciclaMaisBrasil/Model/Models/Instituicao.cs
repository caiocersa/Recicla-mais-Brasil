using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Instituicao : Usuario
    {
        [Required]
        [Display(Name = "CPF/CNPJ")]
        public string DocInstituicao { get; set; } //Documento = CPF OU CNPJ
        [Display(Name = "Senha")]
        public string PwInstituicao { get; set; } //Senha
        [Display(Name = "Instituição")]
        public string NmInstituicao { get; set; }
        [Display(Name = "Responsável")]
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
