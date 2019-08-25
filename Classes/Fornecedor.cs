using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class Fornecedor : Pessoa
    {
        public decimal ValorMinimo { get; set; }

        public void Crud(Fornecedor pessoa)
        {

        }

        public List<Fornecedor> ConsultaPorNome(string nome)
        {
            return new List<Fornecedor>();
        }

        public List<Fornecedor> ConsultaPorEmail(string email)
        {
            return new List<Fornecedor>();
        }

    }

}
