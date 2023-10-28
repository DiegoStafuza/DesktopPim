using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPim.Views
{
    public partial class UsuariosView : Form
    {
        public UsuariosView()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicando!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("clicando!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("clicando!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
