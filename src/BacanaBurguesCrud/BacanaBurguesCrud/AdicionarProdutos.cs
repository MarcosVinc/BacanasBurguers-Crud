using BacanaBurgues.Repositorio;
using BacanasBurgues.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            /* ValidacaoProdutos validacao = new ValidacaoProdutos();
             var x = validacao.Validate(produto);
            if(x.IsValid){}
            else{}
             */
            produto.Nome = txtNome.Text;
            produto.Preco = decimal.Parse(txtPreco.Text);
            produto.Quantidade = int.Parse(txtQuantidade.Text);
            produto.Tipo = cbTipo.Text;
            produto.Lucro = int.Parse(cbLucro.Text);
            repositorio.Salvar(produto);
                    
        }
        public AdicionarProdutos(Produto produto)
        {


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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPreco_Click(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            var repositorio = new RepositorioDeProduto();
            produto.Identificador = txtID.Text;
            repositorio.Deletar(produto);
            MessageBox.Show(repositorio.mensagem);
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

            var produto = new Produto();
            var repositorio = new RepositorioDeProduto();

               produto.Identificador = txtID.Text;
               produto.Nome = txtNome.Text;
               produto.Preco = decimal.Parse(txtPreco.Text);
               produto.Quantidade = int.Parse(txtQuantidade.Text);
               produto.Tipo = cbTipo.Text;
               produto.Lucro = int.Parse(cbLucro.Text);
               repositorio.Alterar(produto);
               MessageBox.Show(repositorio.mensagem);
        }
    }
}
