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
    public partial class TelaCadastro : Form
    {
        BindingList<string> errors = new BindingList<string>();

        public TelaCadastro()
        {
            InitializeComponent();
        }


        private void btSalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            var repositorio = new RepositorioUsuario();
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text; 
            ValidacaoUsuario validacao = new ValidacaoUsuario();
            ValidationResult x = validacao.Validate(usuario);
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
                repositorio.Salvar(usuario);
                MessageBox.Show(repositorio.mensagem);
            }
        }
    }
}
