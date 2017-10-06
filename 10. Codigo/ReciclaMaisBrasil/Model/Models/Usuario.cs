using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [Display(Name = "Email: ")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "CEP: ")]
        public int Cep { get; set; }

        [Required]
        [Display(Name = "Logadouro: ")]
        [StringLength(4)]
        public string TpLogarouro { get; set; }

        [Required]
        [Display(Name = "Bairro: ")]
        [StringLength(100)]
        public string Bairro { get; set; }

        [Required]
        [Display(Name = "Endereço: ")]
        [StringLength(100)]
        public string NmEndereco { get; set; }

        [Required]
        [Display(Name = "Cidade: ")]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Required]
        [Display(Name = "Estado: ")]
        [StringLength(2,MinimumLength = 2)]
        public string Estado { get; set; }

        [Required]
        [Display(Name = "Numero: ")]
        public int NumEndereco { get; set; }

        
        [Display(Name = "Complemento: ")]
        [StringLength(12, MinimumLength = 2)]
        public string Complemento { get; set; }


        public int NvAcesso { get; set; }

        public Usuario(int IdUsuario, string Email)
        {
            this.IdUsuario = IdUsuario;
            this.Email = Email;
        }

        public Usuario() : this(0, null) { }

        public Usuario(string Email) : this(0, Email) { }
    }
}