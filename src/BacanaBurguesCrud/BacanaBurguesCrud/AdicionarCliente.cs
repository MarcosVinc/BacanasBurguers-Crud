using BacanaBurgues.Repositorio;
using BacanaBurgues.Repositorio.Validação;
using BacanasBurgues.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BacanaBurguesCrud
{
    public partial class AdicionarCliente : MetroFramework.Forms.MetroForm
    {
        public AdicionarCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            var repositorio = new RepositorioDeCliente();
            /*ValidacaoCliente validacao = new ValidacaoCliente();
            var x = validacao.Validate(cliente);
            if(x.isValid){}
            else{}*/

                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Cep = int.Parse(txtCEP.Text);
                cliente.Telefone = txtTelefone.Text;
                repositorio.Salvar(cliente);
                MessageBox.Show(repositorio.mensagem);
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
          
        }

        private void AdicionarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btAlterarCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            var repositorio = new RepositorioDeCliente();

                cliente.Identificador = txtIDCliente.Text;
                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Telefone = txtTelefone.Text;
                cliente.Cep = int.Parse(txtCEP.Text);
                repositorio.Alterar(cliente);
                MessageBox.Show(repositorio.mensagem);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            var repositorio = new RepositorioDeCliente();
            cliente.Identificador = txtIDCliente.Text;
            repositorio.Deletar(cliente);
            MessageBox.Show(repositorio.mensagem);
        }
    }
}
