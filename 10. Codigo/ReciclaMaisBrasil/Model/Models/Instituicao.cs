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
        [Display(Name = "CPF/CNPJ:")]
        [StringLength(18,MinimumLength= 15)]
        public string DocInstituicao { get; set; } //Documento = CPF OU CNPJ

        [Required]
        [Display(Name = "Senha:")]
        [StringLength(35, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string PwInstituicao { get; set; } //Senha

        [Required]
        [Display(Name = "Instituição:")]
        [StringLength(100)]
        public string NmInstituicao { get; set; }

        [Required]
        [Display(Name = "Responsável:")]
        [StringLength(30)]
        public string NmResponsavel { get; set; }

        [Display(Name = "Quantidade de Coletas: ")]
        public int NumColeta { get; set; }

        public Instituicao(int IdUsuario, string Email)
        {
            this.IdUsuario = IdUsuario;
            this.Email = Email;
        }

        public Instituicao() : this(0, null) { }
    }
}
