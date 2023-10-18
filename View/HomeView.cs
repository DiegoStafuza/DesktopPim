using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPim.View
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void payrollBtn_Click(object sender, EventArgs e)
        {
            PayrollView payrollView = new PayrollView();
            payrollView.Show();
        }
    }
}
