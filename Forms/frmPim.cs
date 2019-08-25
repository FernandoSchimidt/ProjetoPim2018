using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ProjetoPim.Classes;

namespace ProjetoPim
{
    public partial class frmPim : Form
    {
        private List<Cliente> _lstClientes;
        private List<Endereco> _lstEnderecos;

        private Cliente _clienteNaTela;
        private Endereco _enderecoTela;


        public frmPim()
        {
            InitializeComponent();
            _lstClientes = new List<Cliente>();
            _lstEnderecos = new List<Endereco>();
            _clienteNaTela = null;
            _enderecoTela = null;
        }


        private void frmPim_Load(object sender, System.EventArgs e)
        {
            // carregar dados de exmplo
            int y = 1;
            for (int i = 1; i < 100; i++)
            {
                var objCliente = new Cliente() { Id = i, Nome = "Nome " + i, Telefone = "(19) 99327-323" + i };

                var objEndereco = new Endereco() { Id = y, Logradouro = "Endereco " + y, Numero = y.ToString(), Cidade = "Campinas", Uf = "SP" };
                _lstEnderecos.Add(objEndereco);
                objCliente.Enderecos.Add(objEndereco);
                y++;
                objEndereco = new Endereco() { Id = y, Logradouro = "Endereco Cobranca" + y, Numero = y.ToString(), Cidade = "Campinas", Uf = "SP" };
                _lstEnderecos.Add(objEndereco);
                objCliente.Enderecos.Add(objEndereco);
                y++;

                _lstClientes.Add(objCliente);

            }

            btnClienteListar_Click(null, null);


        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            this.Close();

        }


        private void btnClienteGravar_Click(object sender, System.EventArgs e)
        {
            try
            {
                _clienteNaTela = _lstClientes.Find(f => f == _clienteNaTela);
                if (_clienteNaTela == null)
                {
                    int ultimoCodigo = 0;
                    if (_lstClientes.Count > 0)
                        ultimoCodigo = _lstClientes.Max(m => m.Id);
                    ultimoCodigo++;
                    _clienteNaTela = new Cliente();
                    _clienteNaTela.Id = ultimoCodigo;
                    _lstClientes.Add(_clienteNaTela);
                }
                _clienteNaTela.Nome = txtNome.Text;
                _clienteNaTela.Telefone = txtTelefone.Text;
                _clienteNaTela.Email = txtEmail.Text;
                btnClienteListar_Click(null, null);
                btnEnderecoListar_Click(null, null);
            }
            catch (System.Exception)
            {

                throw;
            }
          
        }

        private void btnClienteExcluir_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (_clienteNaTela == null)
                {
                    MessageBox.Show("SELECIONE UM CLIENTE PARA EXCLUSÃO");
                    return;
                }

                for (int i = 0; i < _clienteNaTela.Enderecos.Count; i++)
                {
                    _lstEnderecos.Remove(_clienteNaTela.Enderecos[i]);
                }

                _lstClientes.Remove(_clienteNaTela);
                btnNovo_Click(null, null);
                btnClienteListar_Click(null, null);
            }
            catch (System.Exception)
            {

                throw;
            }
           
        }

        private void btnClienteListar_Click(object sender, System.EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _lstClientes;
               
            }
            catch (System.Exception)
            {

                throw;
            }
         
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            try
            {
                _clienteNaTela = null;
                txtNome.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                btnEnderecoNovo_Click(null, null);
                dataGridView2.DataSource = new List<Endereco>();
                txtNome.Focus();

            }
            catch (System.Exception)
            {

                throw;
            }
         
        }


        private void btnEnderecoNovo_Click(object sender, System.EventArgs e)
        {
            try
            {
                _enderecoTela = null;
                txtEndereco.Text = "";
                txtNumero.Text = "";
                txtComplemento.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtUf.Text = "";
                txtCep.Text = "";
                txtEndereco.Focus();
            }
            catch (System.Exception)
            {

                throw;
            }
          

        }

        private void btnEnderecoGravar_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (_clienteNaTela == null)
                {
                    MessageBox.Show("SELECIONE O CLIENTE ANTES DE GRAVAR O ENDEREÇO");
                    return;
                }

                _enderecoTela = _lstEnderecos.Find(f => f == _enderecoTela);
                if (_enderecoTela == null)
                {
                    int ultimoCodigo = 0;
                    if (_lstEnderecos.Count > 0)
                        ultimoCodigo = _lstEnderecos.Max(m => m.Id);
                    ultimoCodigo++;
                    _enderecoTela = new Endereco();
                    _enderecoTela.Id = ultimoCodigo;
                    _lstEnderecos.Add(_enderecoTela);
                    _clienteNaTela.Enderecos.Add(_enderecoTela);
                }

                _enderecoTela.Logradouro = txtEndereco.Text;
                _enderecoTela.Numero = txtNumero.Text;
                _enderecoTela.Complemento = txtComplemento.Text;
                _enderecoTela.Bairro = txtBairro.Text;
                _enderecoTela.Cidade = txtCidade.Text;
                _enderecoTela.Uf = txtUf.Text;
                _enderecoTela.Cep = txtCep.Text;
                btnEnderecoListar_Click(null, null);
            }
            catch (System.Exception)
            {

                throw;
            }
           

        }

        private void btnEnderecoExcluir_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (_clienteNaTela == null)
                {
                    MessageBox.Show("SELECIONE O CLIENTE ANTES DE EXCLUIR O ENDEREÇO");
                    return;
                }
                if (_enderecoTela == null)
                {
                    MessageBox.Show("SELECIONE UM ENDEREÇO PARA EXCLUSÃO");
                    return;
                }

                _clienteNaTela.Enderecos.Remove(_enderecoTela);
                _lstEnderecos.Remove(_enderecoTela);
                btnEnderecoNovo_Click(null, null);
                btnEnderecoListar_Click(null, null);
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }

        private void btnEnderecoListar_Click(object sender, System.EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = _clienteNaTela.Enderecos;
            }
            catch (System.Exception)
            {

                throw;
            }
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _clienteNaTela = _lstClientes.Find(f => f == dataGridView1.Rows[e.RowIndex].DataBoundItem);
            if (_clienteNaTela != null)
            {
                txtNome.Text = _clienteNaTela.Nome;
                txtTelefone.Text = _clienteNaTela.Telefone;
                txtEmail.Text = _clienteNaTela.Email;
                btnEnderecoNovo_Click(null, null);
                btnEnderecoListar_Click(null, null);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _enderecoTela = _lstEnderecos.Find(f => f == dataGridView2.Rows[e.RowIndex].DataBoundItem);
            if (_enderecoTela != null)
            {
                txtEndereco.Text = _enderecoTela.Logradouro;
                txtNumero.Text = _enderecoTela.Numero;
                txtComplemento.Text = _enderecoTela.Complemento;
                txtBairro.Text = _enderecoTela.Bairro;
                txtCidade.Text = _enderecoTela.Cidade;
                txtUf.Text = _enderecoTela.Uf;
                txtCep.Text = _enderecoTela.Cep;
            }
        }
    }
}
