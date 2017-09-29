using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class TpReciclavel
    {
        public List<string> Reciclavel;

        public TpReciclavel()
        {
            this.Reciclavel = new List<string>();
            Reciclavel.Add("Papel/Papelão");
            Reciclavel.Add("Plástico");
            Reciclavel.Add("Vidro");
            Reciclavel.Add("Metal");
            Reciclavel.Add("Madeira");
            Reciclavel.Add("Resíduos Orgânicos");
            Reciclavel.Add("Resíduos Perigosos");
            Reciclavel.Add("Resíduos Radioativos");
        }
    }
}
