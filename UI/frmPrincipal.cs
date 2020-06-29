using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMEmpresa em = new FRMEmpresa(this);
            em.ShowDialog();
            em.Dispose();
            this.Text = "Menu";
        }

        private void eleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMEleicao el = new FRMEleicao(this);
            el.ShowDialog();
            el.Dispose();
            this.Text = "Menu";
        }

        private void empresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Relatorios.FRMRelEmpresa form = new Relatorios.FRMRelEmpresa();
            form.Show();
        }

        private void relatórioDeEleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios.FRMRelEleicao form = new Relatorios.FRMRelEleicao();
            form.Show();
        }
    }
}
