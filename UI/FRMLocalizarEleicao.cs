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
    public partial class FRMLocalizarEleicao : Form
    {
        public MODELOEleicao modeleleicao;
        public FRMLocalizarEleicao()
        {
            InitializeComponent();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLEleicao blleleicao = new BLLEleicao(cx);
            DataTable tabela = blleleicao.Localizar(TXTBusca.Text);
            DGVDados.DataSource = tabela;

        }

        private void DGVDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.modeleleicao = new MODELOEleicao();

            this.modeleleicao.IDELEICAO1 = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value);
            this.modeleleicao.IDEMPRESA1  = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[1].Value);
            this.modeleleicao.NOME1       = DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.modeleleicao.DESCRICAO1  = DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.modeleleicao.TIPOVOTO1 = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[4].Value);
            this.modeleleicao.MENSSAGEMENCERRADO1 = DGVDados.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.modeleleicao.MENSSAGEMFIM1 = DGVDados.Rows[e.RowIndex].Cells[6].Value.ToString();
            DateTime datainicio           = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[7].Value.ToString());
            this.modeleleicao.DATAINICIO1 = datainicio;
            DateTime datafim              = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[8].Value.ToString());
            this.modeleleicao.DATAFIM1    = datafim;

            this.Close();
        }
    }
    
}

