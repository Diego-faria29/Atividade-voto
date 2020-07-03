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
    public partial class FRMUrna : Form
    {
       

   
        public FRMUrna(frmPrincipal f)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            f.Text = "Menu - Inserir Urna";
        }



        public void limparCampos()
        {
            TXT_IDURNA.Clear();
            TXT_NOME.Clear();
            TXT_DESCRICAO.Clear();
            TXT_IP.Clear();

        }
   

        private void BTN_inserir_Click(object sender, EventArgs e)
        {
                try
                {
                    DadosDaConexao dc = new DadosDaConexao();
                    DALConexao cx = new DALConexao(dc.StringDeConexao);

                    BLLUrna bllurna = new BLLUrna(cx);

                    MODELOUrna p = new MODELOUrna();
                    p.NOME1 = TXT_NOME.Text;
                    p.DESCRICAO1 = TXT_DESCRICAO.Text;
                    p.IP1 = Convert.ToInt32(TXT_IP.Text);

                    bllurna.Incluir(p);
                    TXT_IDURNA.Text = p.IDURNA1.ToString(); ;
                    MessageBox.Show("Inserido com sucesso id:" + p.IDURNA1);

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
