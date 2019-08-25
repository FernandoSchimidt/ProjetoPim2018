using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }


        public void Crud(Endereco Endereco)
        {

        }

        public List<Endereco> ConsultaPorLogradouro(string logradouro)
        {
            return new List<Endereco>();
        }

        public List<Endereco> ConsultaPorCep(string cep)
        {
            return new List<Endereco>();
        }

    }

}
