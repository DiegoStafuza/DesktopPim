using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopPim.Views;

namespace DesktopPim.Views
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ABrirFormFilho(Form formularioFilho)
        {
            if (panel1.Controls.Count > 0)
            {
                panel1.Controls.RemoveAt(0);
            }

            formularioFilho.TopLevel = false;
            formularioFilho.Dock = DockStyle.Fill;
            panel1.Controls.Add(formularioFilho);
            panel1.Tag = formularioFilho;
            formularioFilho.Show();
        }

        private void PayrollBtn_Click(object sender, EventArgs e)
        {
            PayrollView payrollView = new();
            ABrirFormFilho(payrollView);
        }

        private void PeopleBtn_Click(object sender, EventArgs e)
        {
            UsuariosView usuariosView = new();
            ABrirFormFilho(usuariosView);
        }
    }
}
