using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool PessoaFisica { get; set; }
        public string Documento { get; set; }
        public List<Endereco> Enderecos { get; set; }

        public Pessoa()
        {
            Enderecos = new List<Endereco>();
        }

        public void Crud(Pessoa pessoa)
        {

        }

        public List<Pessoa> ConsultaPorNome(string nome)
        {
            return new List<Pessoa>();
        }

        public List<Pessoa> ConsultaPorEmail(string email)
        {
            return new List<Pessoa>();
        }

    }

}
