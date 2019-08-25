using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal SaldoEstoque { get; set; }
        public int IdGrupoProduto { get; set; }
               
        public void Crud(Produto Produto)
        {

        }

        public List<Produto> ConsultaPorNome(string nome)
        {
            return new List<Produto>();
        }

    }

}
