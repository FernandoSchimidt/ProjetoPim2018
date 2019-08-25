using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class Cliente : Pessoa
    {
        public decimal LimiteCredito { get; set; }

        public void Crud(Cliente pessoa)
        {

        }

        public List<Cliente> ConsultaPorNome(string nome)
        {
            return new List<Cliente>();
        }

        public List<Cliente> ConsultaPorEmail(string email)
        {
            return new List<Cliente>();
        }

    }

}
