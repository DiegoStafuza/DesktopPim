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
using DesktopPim.Views.ViewDuvidas;

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

        private void button1_Click(object sender, EventArgs e)
        {
            DvdCadUsu dvdCadUsu = new DvdCadUsu();
            ABrirFormDuvida(dvdCadUsu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DvdGeraFolha dvdGeraFolha = new DvdGeraFolha();
            ABrirFormDuvida(dvdGeraFolha);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DvdCadFunc dvdCadFunc = new DvdCadFunc();
            ABrirFormDuvida(dvdCadFunc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DvdProventoDesc dvdProventoDesc = new DvdProventoDesc();
            ABrirFormDuvida(dvdProventoDesc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DvdAttFunc dvdAttFunc = new DvdAttFunc();
            ABrirFormDuvida(dvdAttFunc);
        }
    }
}
