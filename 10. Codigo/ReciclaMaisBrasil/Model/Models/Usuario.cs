using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public int Cep { get; set; }
        public string TpLogarouro { get; set; }
        public string Bairro { get; set; }
        public string NmEndereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int NumEndereco { get; set; }
        public string Complemento { get; set; }
        


        public Usuario(int IdUsuario, string Email)
        {
            this.IdUsuario = IdUsuario;
            this.Email = Email;
        }

        public Usuario() : this(0, null) { }

        public Usuario(string Email) : this(0, Email) { }
    }
}