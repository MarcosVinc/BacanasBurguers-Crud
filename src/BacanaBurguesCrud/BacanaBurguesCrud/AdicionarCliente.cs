using BacanaBurgues.Repositorio;
using BacanaBurgues.Repositorio.Validação;
using BacanasBurgues.Entidades;
using BacanasBurgues.Entidades.Ultilitarios;
using FluentValidation.Results;
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
        BindingList<string> errors = new BindingList<string>();
        public AdicionarCliente()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            var repositorio = new RepositorioDeCliente();

                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Cep = ConversorDeNumeros.ConvertaStringParaInt(txtCEP.Text, 1);
                cliente.Telefone = txtTelefone.Text;

                    ValidacaoCliente validacao = new ValidacaoCliente();
                    ValidationResult x = validacao.Validate(cliente);
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
                        repositorio.Salvar(cliente);
                        MessageBox.Show(repositorio.mensagem);
                    }


        }


        private void btAlterarCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            var repositorio = new RepositorioDeCliente();

                cliente.Identificador = txtIDCliente.Text;
                cliente.Nome = txtNome.Text;
                cliente.Endereco = txtEndereco.Text;
                cliente.Cep = ConversorDeNumeros.ConvertaStringParaInt(txtCEP.Text, 1);
                cliente.Telefone = txtTelefone.Text;

                    ValidacaoCliente validacao = new ValidacaoCliente();
                    ValidationResult x = validacao.Validate(cliente);
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
                        repositorio.Alterar(cliente);
                        MessageBox.Show(repositorio.mensagem);
                    }
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
