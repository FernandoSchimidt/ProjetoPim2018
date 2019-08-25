using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class Transportadora : Pessoa
    {
        public string TipoVeiculo { get; set; }

        public void Crud(Transportadora pessoa)
        {

        }

        public List<Transportadora> ConsultaPorNome(string nome)
        {
            return new List<Transportadora>();
        }

        public List<Transportadora> ConsultaPorEmail(string email)
        {
            return new List<Transportadora>();
        }

        public List<Transportadora> ConsultaPorTipo(string tipoTransporte)
        {
            return new List<Transportadora>();
        }

    }

}
