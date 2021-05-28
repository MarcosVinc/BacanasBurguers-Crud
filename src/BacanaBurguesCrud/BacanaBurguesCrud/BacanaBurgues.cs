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
            TelaProdutos novaform = new TelaProdutos();
            novaform.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            TelaCliente novaform = new TelaCliente();
            novaform.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            TelaCalcularProdutos novaform = new TelaCalcularProdutos();
            novaform.Show();

           
            

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            TelaTelefonesUteis novaform = new TelaTelefonesUteis();
            novaform.Show();
        }
    }
}
// Para fechar a tela atual ! 
// this.Hide();
//Form f = new NOME DA TELA();
//f.Closed += (s, args) => this.Close();