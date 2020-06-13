using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using MODELO;

namespace PadraoDeProjetoEmCamadas
{
    public partial class FRMLocalizarEM : Form
    {
        public MODELOEmpresa modelempresa;
        public FRMLocalizarEM()
        {
            InitializeComponent();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLEmpresa bllempresa = new BLLEmpresa(cx);
            DataTable tabela = bllempresa.Localizar(TXTBusca.Text);
            DGVDados.DataSource = tabela;
        }


        private void DGVDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modelempresa = new MODELOEmpresa();

           
            this.modelempresa.IDEmpresa = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modelempresa.Nome = DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.modelempresa.Descricao = DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modelempresa.CODEmpresa = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();


            this.Close();
        }
    }
}
