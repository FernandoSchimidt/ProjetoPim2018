using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPim.Classes
{
    public class PedidoVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataEntrega { get; set; }
        public DateTime DataCancelamento { get; set; }
        public DateTime DataRecebimento { get; set; }
        public int IdUsuarioVendedor { get; set; }
        public List<PedidoVendaItem> PedidoVendaItens{ get; set; }

        public PedidoVenda()
        {
            PedidoVendaItens = new List<PedidoVendaItem>();
        }

        public void Crud(PedidoVenda PedidoVenda)
        {

        }

        public List<PedidoVenda> ConsultaPorCliente(Cliente cliente)
        {
            return new List<PedidoVenda>();
        }

        public List<PedidoVenda> ConsultaPorDataEntrega(DateTime data)
        {
            return new List<PedidoVenda>();
        }

        public List<PedidoVenda> ConsultaPorDataCancelamento(DateTime data)
        {
            return new List<PedidoVenda>();
        }

        public List<PedidoVenda> ConsultaPorDataRecebimento(DateTime data)
        {
            return new List<PedidoVenda>();
        }

        public void EntregarPedido(PedidoVenda pedidoVenda, DateTime dataEntrega)
        {
            
        }

        public void ReceberPedido(PedidoVenda pedidoVenda)
        {

        }

        public void CancelarPedido(PedidoVenda pedidoVenda)
        {

        }

    }

}
