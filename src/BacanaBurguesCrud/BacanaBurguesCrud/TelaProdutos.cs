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
    public partial class TelaProdutos : MetroFramework.Forms.MetroForm
    {
        public TelaProdutos()
        {
           
            InitializeComponent();

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
            var x = new RepositorioDeProduto();
            var produtos = x.Consulta();
            gwProdutos.DataSource = produtos;
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
            
            AdicionarProdutos f1 = new AdicionarProdutos();
            var titulo = "Atualizar dados";
            f1.btAlterar.Visible = true;
            f1.btExcluir.Visible = true;
           /* f1.txtID.Visible = true;*/
            f1.lbTitulo.Text = titulo;
            f1.txtID.Text = this.gwProdutos.CurrentRow.Cells[0].Value.ToString();
            f1.txtNome.Text = this.gwProdutos.CurrentRow.Cells[1].Value.ToString();
            f1.cbTipo.Text = this.gwProdutos.CurrentRow.Cells[2].Value.ToString();
            f1.txtQuantidade.Text = this.gwProdutos.CurrentRow.Cells[3].Value.ToString();
            f1.cbLucro.Text = this.gwProdutos.CurrentRow.Cells[5].Value.ToString();
            f1.txtPreco.Text = this.gwProdutos.CurrentRow.Cells[4].Value.ToString();
            f1.ShowDialog();
            

        }

        private void gwProdutos_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
       


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void gwProdutos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
