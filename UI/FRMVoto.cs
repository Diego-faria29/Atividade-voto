using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DAL;
using BLL;
using MODELO;

namespace PadraoDeProjetoEmCamadas
{
    public partial class FRMVoto : Form
    {
        private frmPrincipal frmPrincipal;

        public FRMVoto()
        {
            InitializeComponent();
        }

        public FRMVoto(frmPrincipal f)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            f.Text = "Menu - Inserir voto";
        }



        public void limparCampos()
        {
            TXT_IDELEICAO.Clear();
            TXT_IDURNA.Clear();
            TXT_IDPESSOA.Clear();
            TXT_NUMEROVOTO.Clear();

        }



        private void BTN_INSERIR_Click_1(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLVoto bllvoto = new BLLVoto(cx);

                MODELOVoto p = new MODELOVoto();
                p.IDELEICAO1 = Convert.ToInt32(TXT_IDELEICAO.Text);
                p.IDURNA1 = Convert.ToInt32(TXT_IDURNA.Text);
                p.IDPESSOA1 = Convert.ToInt32(TXT_IDPESSOA.Text);
                p.NUMEROVOTO1 = Convert.ToInt32(TXT_NUMEROVOTO.Text);

                bllvoto.Incluir(p);

                MessageBox.Show("Inserido com sucesso:");

                limparCampos();

            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro j'a existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao inserir errro geral:" + ex.Message);
            }
        }
    }
}
