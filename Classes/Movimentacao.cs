using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public int IdProduto { get; set; }
        public DateTime Data { get; set; }
        public decimal SaldoAnterior { get; set; }
        public decimal Quantidade { get; set; }
        public int IdTipoMovimento{ get; set; }
        public string Documento { get; set; }

        public void Crud(Movimentacao Movimentacao)
        {

        }

        public List<Movimentacao> ConsultaPorProduto(Produto produto)
        {
            return new List<Movimentacao>();
        }

        public List<Movimentacao> ConsultaPorTipo(TipoMovimento tipoMovimento)
        {
            return new List<Movimentacao>();
        }

        public void BaixaPedidoVenda(PedidoVenda pedidoVenda)
        {
            
        }
        
        public void BaixarPedidoCompra(PedidoCompra pedidoCompra)
        {

        }

        public void CorrigirSaldo(Produto produto, decimal novoSaldo)
        {

        }

    }

}
