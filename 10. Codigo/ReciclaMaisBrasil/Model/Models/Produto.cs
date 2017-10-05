using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Produto
    {
        [Key]
        [Display(Name ="ID Produto:")]
        public int IdProduto { get; set; }

        [Display(Name = "ID Administrador Produto:")]
        public int IdAdmProduto { get; set; }

        [Required]
        [Display(Name ="Nome do Produto:")]
        public string NmProduto { get; set; }

        [Required]
        [Display(Name ="Descrição do Produto:")]
        public string DescProduto { get; set; }
        [Required]
        [Display(Name ="Quantidade :")]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Valor:")]
        public int Valor { get; set; }

        [Display(Name ="Foto do Produto:")]
        [DataType(DataType.Url)]
        public Byte FotoProduto { get; set; }

        public Produto()
        {
        }

    }
}
