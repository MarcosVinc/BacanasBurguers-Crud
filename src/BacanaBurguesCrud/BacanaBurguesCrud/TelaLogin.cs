using BacanaBurgues.Repositorio;
using BacanaBurgues.Repositorio.Modelo;
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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro novaform = new TelaCadastro();
            novaform.Show();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLogin.Text, txtSenha.Text);
           
            if (controle.mensagem.Equals("")) 
            {

                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BacanaBurgues bb = new BacanaBurgues();
                    this.Hide();
                    bb.Show();
                    
                }
                else 
                {
                    MessageBox.Show("Logim ou senha estão incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

