using BacanaBurgues.Repositorio;
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

            cliente.Nome = txtNome.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Cep = int.Parse(txtCEP.Text);
            cliente.Telefone = txtTelefone.Text;
            repositorio.Salvar(cliente);


        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {
          
        }
    }
}
