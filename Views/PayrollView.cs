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
    public partial class PayrollView : Form
    {
        public PayrollView()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste click!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
