using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class GrupoProduto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
                     
        public void Crud(GrupoProduto GrupoProduto)
        {

        }

        public List<GrupoProduto> ConsultaPorNome(string nome)
        {
            return new List<GrupoProduto>();
        }

    }

}
