using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopPim.View;

namespace DesktopPim.Views
{
    public partial class DuvidasView : Form
    {
        public DuvidasView()
        {
            InitializeComponent();
        }
        private void ABrirFormDuvida(Form formularioDuvida)
        {
            if (panelDuvidas.Controls.Count > 0)
            {
                panelDuvidas.Controls.RemoveAt(0);
            }

            formularioDuvida.TopLevel = false;
            formularioDuvida.Dock = DockStyle.Fill;
            panelDuvidas.Controls.Add(formularioDuvida);
            panelDuvidas.Tag = formularioDuvida;
            formularioDuvida.Show();
        }
    }
}
