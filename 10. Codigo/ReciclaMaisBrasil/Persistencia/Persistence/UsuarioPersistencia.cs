using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Models;

namespace Persistencia.Persistence
{
    public class UsuarioPersistencia
    {
        private static List<TipoUsuario> listaTipoUsuario;

        static UsuarioPersistencia()
        {
            listaTipoUsuario = new List<TipoUsuario>()
            {
                new TipoUsuario(){ Id = 1, Descricao = "Pessoa" },
                new TipoUsuario(){ Id = 2, Descricao = "Instituição" },
                new TipoUsuario(){ Id = 3, Descricao = "Administrador de Compras" },
                new TipoUsuario(){ Id = 4, Descricao = "Administrador"}
            };           
        }


        public TipoUsuario ObterTipoUsuario(Func<TipoUsuario, bool> where)
        {
            return listaTipoUsuario.Where(where).FirstOrDefault();
        }
    }
}
