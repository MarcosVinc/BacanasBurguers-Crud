using BacanaBurgues.Repositorio;
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
    public partial class TelaProdutos : MetroFramework.Forms.MetroForm
    {
        public TelaProdutos()
        {
            InitializeComponent();
            CarregarProdutos();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdicionarProdutos novaform = new AdicionarProdutos();
            novaform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new BacanaBurgues();
            f.Closed += (s, args) => this.Close();
        }

        private void TelaCadastrar_Load(object sender, EventArgs e)
        {

        }
        private void CarregarProdutos()
        {
            var x = new RepositorioDeProduto();
            var produtos = x.Consulta();
            gwProdutos.DataSource = produtos;



        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var x = new RepositorioDeProduto();
            var produtos = x.Consulta();
            gwProdutos.DataSource = produtos;

        }

        private void gwProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
