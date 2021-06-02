using BacanaBurgues.Repositorio;
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
    public partial class TelaCliente : MetroFramework.Forms.MetroForm
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new BacanaBurgues();
            f.Closed += (s, args) => this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdicionarCliente novaform = new AdicionarCliente();
            novaform.Show();
        }


        private void TelaCliente_Load(object sender, EventArgs e)
        {
            var x = new RepositorioDeCliente();
            var produtos = x.Consulta();
            gwCliente.DataSource = produtos;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var x = new RepositorioDeCliente();
            var produtos = x.Consulta();
            gwCliente.DataSource = produtos;
        }


        private void gwCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AdicionarCliente f1 = new AdicionarCliente();
            var titulo = "Atualizar dados";
            f1.btSalvar.Visible = false;
            f1.btAlterarCliente.Visible = true;
            f1.btExcluir.Visible = true;
            /* f1.txtID.Visible = true;*/
            f1.lbTituloCliente.Text = titulo;
            f1.txtIDCliente.Text = this.gwCliente.CurrentRow.Cells[0].Value.ToString();
            f1.txtNome.Text = this.gwCliente.CurrentRow.Cells[1].Value.ToString();
            f1.txtEndereco.Text = this.gwCliente.CurrentRow.Cells[2].Value.ToString();
            f1.txtTelefone.Text = this.gwCliente.CurrentRow.Cells[3].Value.ToString();
            f1.txtCEP.Text = this.gwCliente.CurrentRow.Cells[4].Value.ToString(); 
            f1.ShowDialog();
        }
    }
}
/* his.Hide();
   Form f = new BacanaBurgues();
   f.Closed += (s, args) => this.Close();
*/