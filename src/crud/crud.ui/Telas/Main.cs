using crud.ui.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud.ui
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var form2 = new ControlProduto(); // Declara o form2
            PainelPrincipal.Controls.Add(form2);

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var form3 = new ControlLista();
            PainelPrincipal.Controls.Add(form3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var form4 = new ControlAddClientes();
            PainelPrincipal.Controls.Add(form4);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var form5 = new ControlTelefone();
            PainelPrincipal.Controls.Add(form5);
        }
    }
}
