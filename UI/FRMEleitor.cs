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
    public partial class FRMEleitor : Form
    {
        private frmPrincipal frmPrincipal;
        public FRMEleitor()
        {
            InitializeComponent();
        }
        public FRMEleitor(frmPrincipal f)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            f.Text = "Menu - Inserir eleitor";
        }



        public void limparCampos()
        {
            TXT_IDPESSOA.Clear();
            TXT_IDELEICAO.Clear();
            TXT_IDEMPRESA.Clear();

        }

           

        private void BTN_INSERIR_Click(object sender, EventArgs e)
        {
                try
                {
                    DadosDaConexao dc = new DadosDaConexao();
                    DALConexao cx = new DALConexao(dc.StringDeConexao);

                    BLLEleitor bllvoto = new BLLEleitor(cx);

                    MODELOeleitor p = new MODELOeleitor();
                    p.IDPESSOA1 = Convert.ToInt32(TXT_IDPESSOA.Text);
                    p.IDELEICAO1 = Convert.ToInt32(TXT_IDELEICAO.Text);
                    p.IDEMPRESA1 = Convert.ToInt32(TXT_IDEMPRESA.Text);

                    bllvoto.Incluir(p);

                    MessageBox.Show("Inserido com sucesso ");

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
