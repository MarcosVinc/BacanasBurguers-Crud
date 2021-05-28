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
    public partial class AdicionarProdutos : MetroFramework.Forms.MetroForm
    {
        public AdicionarProdutos()
        {
            InitializeComponent();
        }

        private void AdicionarProdutos_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new BacanaBurgues();
            f.Closed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            var repositorio = new RepositorioDeProduto();

            produto.Nome = txtNome.Text;
            produto.Preco = double.Parse(txtPreco.Text);
            produto.Quantidade = int.Parse(txtQuantidade.Text);
            produto.Tipo = cbTipo.Text;
            produto.Lucro = double.Parse(cbLucro.Text);
            repositorio.Salvar(produto);
            MessageBox.Show(repositorio.mensagem);
            

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
