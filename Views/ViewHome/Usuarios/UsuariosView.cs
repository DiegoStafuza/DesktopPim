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
        private void button2_Click(object sender, EventArgs e)
        {
            AdicionaUsu addUsuView = new AdicionaUsu();
            addUsuView.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
