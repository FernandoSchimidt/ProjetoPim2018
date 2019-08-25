using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class TipoMovimento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
                     
        public void Crud(TipoMovimento TipoMovimento)
        {

        }

        public List<TipoMovimento> ConsultaPorNome(string nome)
        {
            return new List<TipoMovimento>();
        }

    }

}
