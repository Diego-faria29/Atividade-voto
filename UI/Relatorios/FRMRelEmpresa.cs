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
    public partial class FRMRelEmpresa : Form
    {
        public FRMRelEmpresa()
        {
            InitializeComponent();
        }

        private void FRMRelEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'a49gmoAH95DataSet.Empresa'. Você pode movê-la ou removê-la conforme necessário.
            this.empresaTableAdapter.Fill(this.a49gmoAH95DataSet.Empresa);

            this.reportViewer1.RefreshReport();
        }
    }
}
