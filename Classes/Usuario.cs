using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class Usuario : Pessoa
    {
        public string Login { get; set; }

        public void Crud(Usuario pessoa)
        {

        }

        public List<Usuario> ConsultaPorNome(string nome)
        {
            return new List<Usuario>();
        }

        public List<Usuario> ConsultaPorEmail(string email)
        {
            return new List<Usuario>();
        }

    }

}
