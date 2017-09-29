using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Pessoa : Usuario
    {
        [Required]
        [StringLength(14,MinimumLength = 14)]
        [Display(Name = "CPF :")]
        public string CpfPessoa { get; set; }

        [Required]
        [StringLength(35, MinimumLength = 6)]
        [Display(Name = "Senha :")]
        [DataType(DataType.Password)]
        public string PwPessoa { get; set; }

        [Required]
        [Display(Name = "Nome Completo :")]
        [StringLength(100)]
        public string NmPessoa { get; set; }

        [Display(Name = "Telefone :")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(14)]
        public string Telefone { get; set; }

        [Display(Name = "Nascimento :")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DtNasc { get; set; }

        [Display(Name = "Sua Pontuação:")]
        public int Pontuacao { get; set; }

        public Pessoa(int IdUsuario, string Email)
        {
            this.IdUsuario = IdUsuario;
            this.Email = Email;
        }

        public Pessoa() : this(0, null) { }

    }
}