using BacanaBurgues.Repositorio;
using BacanasBurgues.Entidades;
using BacanasBurgues.Entidades.Ultilitarios;
using FluentValidation.Results;
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
        BindingList<string> errors = new BindingList<string>();
        public AdicionarProdutos()

        {
            InitializeComponent();
            
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
            produto.Preco = ConversorDeNumeros.ConvertaStringParaDecimal(txtPreco.Text, 2); //  ConvertaStringParaDecimal "Metodo" (txtPreco.Text "Valor de entrada", 2 "casas depois da virgula"); 
            produto.Quantidade = ConversorDeNumeros.ConvertaStringParaInt(txtQuantidade.Text, 1);
            produto.Tipo = cbTipo.Text;
            produto.Lucro = ConversorDeNumeros.ConvertaStringParaInt(cbLucro.Text, 1);

            ValidacaoProdutos validacao = new ValidacaoProdutos();
            ValidationResult x = validacao.Validate(produto);
            if (x.IsValid == false)
            {
                foreach (ValidationFailure failure in x.Errors)
                {
                    errors.Add($"{failure.PropertyName} : {failure.ErrorMessage}");
                    MessageBox.Show($"Erro ao preencher :{failure.PropertyName}," +
                        $"+ mensagem do erro : {failure.ErrorMessage} ");
                }
            }
            else {
                repositorio.Salvar(produto);
                MessageBox.Show(repositorio.mensagem);
            }

               /* repositorio.Salvar(produto);
                MessageBox.Show(repositorio.mensagem);*/
     

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
            produto.Preco = ConversorDeNumeros.ConvertaStringParaDecimal(txtPreco.Text, 2); //  ConvertaStringParaDecimal "Metodo" (txtPreco.Text "Valor de entrada", 2 "casas depois da virgula"); 
            produto.Quantidade = ConversorDeNumeros.ConvertaStringParaInt(txtQuantidade.Text, 1);
            produto.Tipo = cbTipo.Text;
            produto.Lucro = ConversorDeNumeros.ConvertaStringParaInt(cbLucro.Text, 1);

            ValidacaoProdutos validacao = new ValidacaoProdutos();
            ValidationResult x = validacao.Validate(produto);
            if (x.IsValid == false)
            {
                foreach (ValidationFailure failure in x.Errors)
                {
                    errors.Add($"{failure.PropertyName} : {failure.ErrorMessage}");
                    MessageBox.Show($"Erro ao preencher :{failure.PropertyName}," +
                        $"+ mensagem do erro : {failure.ErrorMessage} ");
                }
            }
            else
            {
                repositorio.Alterar(produto);
                MessageBox.Show(repositorio.mensagem);
            }
        }


    }
}
