using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas.Relatorios
{
    public partial class FRMRelEleicao : Form
    {
        public FRMRelEleicao()
        {
            InitializeComponent();
        }

        private void FRMRelEleicao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'a49gmoAH95DataSet.Eleicao'. Você pode movê-la ou removê-la conforme necessário.
            this.eleicaoTableAdapter.Fill(this.a49gmoAH95DataSet.Eleicao);

            this.reportViewer1.RefreshReport();
        }
    }
}
