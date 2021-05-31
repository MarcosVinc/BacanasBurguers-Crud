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
    public partial class TelaTelefonesUteis : MetroFramework.Forms.MetroForm
    {
        public TelaTelefonesUteis()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new BacanaBurgues();
            f.Closed += (s, args) => this.Close();
        }

        private void TelaTelefonesUteis_Load(object sender, EventArgs e)
        {
            var x = new RepositorioDeTelefonesUteis();
            var produtos = x.Consulta();
            gwTelefonesUteis.DataSource = produtos;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdicionarTelefonesUteis novaform = new AdicionarTelefonesUteis();
            novaform.Show();
        }

        private void gwTelefonesUteis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var x = new RepositorioDeTelefonesUteis();
            var produtos = x.Consulta();
            gwTelefonesUteis.DataSource = produtos;
        }

        private void gwTelefonesUteis_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AdicionarTelefonesUteis f1 = new AdicionarTelefonesUteis();
            var titulo = "Atualizar dados";
            f1.btAlterar.Visible = true;
            f1.btExcluir.Visible = true;
            /* f1.txtID.Visible = true;*/
            f1.lbTitulo.Text = titulo;
            f1.txtID.Text = this.gwTelefonesUteis.CurrentRow.Cells[0].Value.ToString();
            f1.txtNomeTelefonesUteis.Text = this.gwTelefonesUteis.CurrentRow.Cells[1].Value.ToString();
            f1.txtTelefonesUteis.Text = this.gwTelefonesUteis.CurrentRow.Cells[2].Value.ToString();
            f1.ShowDialog();
        }
    }
}
