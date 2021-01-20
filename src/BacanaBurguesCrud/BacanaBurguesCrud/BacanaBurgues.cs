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
    public partial class BacanaBurgues : MetroFramework.Forms.MetroForm
    {
        public BacanaBurgues()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            TelaCadastrar novaform = new TelaCadastrar();
            novaform.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            TelaProduto novaform = new TelaProduto();
            novaform.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            TelaCliente novaform = new TelaCliente();
            novaform.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            CalcularProdutos novaform = new CalcularProdutos();
            novaform.Show();

        }
    }
}
// Para fechar a tela atual ! 
// this.Hide();
//Form f = new NOME DA TELA();
//f.Closed += (s, args) => this.Close();