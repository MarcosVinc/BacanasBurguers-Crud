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
    public partial class AdicionarTelefonesUteis : MetroFramework.Forms.MetroForm
    {
        public AdicionarTelefonesUteis()
        {
            InitializeComponent();
        }

        private void AdicionarTelefonesUteis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var _telefonesuteis = new TelefonesUteis();
            var repositorio = new RepositorioDeTelefonesUteis();

                _telefonesuteis.Nome = txtNomeTelefonesUteis.Text;
                _telefonesuteis.Telefone = txtTelefonesUteis.Text;
                repositorio.Salvar(_telefonesuteis);
                MessageBox.Show(repositorio.mensagem);
        }

        private void txtNomes(object sender, EventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            var telefone = new TelefonesUteis();
            var repositorio = new RepositorioDeTelefonesUteis();

                telefone.Identificador = txtID.Text;
                telefone.Nome = txtNomeTelefonesUteis.Text;
                telefone.Telefone = txtTelefonesUteis.Text;
                repositorio.Alterar(telefone);
                MessageBox.Show(repositorio.mensagem);

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var telefones = new TelefonesUteis();
            var repositorio = new RepositorioDeTelefonesUteis();
            telefones.Identificador = txtID.Text;
            repositorio.Deletar(telefones);
            MessageBox.Show(repositorio.mensagem);
        }
    }
}
