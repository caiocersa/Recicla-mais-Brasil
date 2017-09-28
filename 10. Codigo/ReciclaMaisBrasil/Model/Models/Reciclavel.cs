using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class Reciclavel
    {
        public List<string> tpReciclavel;

        public Reciclavel()
        {
            this.tpReciclavel = new List<string>();
            tpReciclavel.Add("Papel/Papelão");
            tpReciclavel.Add("Plástico");
            tpReciclavel.Add("Vidro");
            tpReciclavel.Add("Metal");
            tpReciclavel.Add("Madeira");
            tpReciclavel.Add("Resíduos Orgânicos");
            tpReciclavel.Add("Resíduos Perigosos");
            tpReciclavel.Add("Resíduos Radioativos");
        }
    }
}
