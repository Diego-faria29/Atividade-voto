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
    public partial class FRMCandidato : Form
    {
        private string fotocandidato = "";

        


        public FRMCandidato(frmPrincipal f)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            f.Text = "Menu - Inserir candidato";
        }


        public void limparCampos()
        {
            TXT_IDPESSOA.Clear();
            TXT_IDELEICAO.Clear();
            TXT_IDEMPRESA.Clear();
            TXT_NUMERO.Clear();
            TXT_SLOGAN.Clear();
            TXT_DESCRICAO.Clear();
            PB_FOTO.Image = null;

        }
        private void BTN_INSERIR_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLCandidato bllcandidato = new BLLCandidato(cx);

                MODELOCandidato p = new MODELOCandidato();
                p.IDPESSOA1 = Convert.ToInt32(TXT_IDPESSOA.Text);
                p.IDELEICAO1 = Convert.ToInt32(TXT_IDELEICAO.Text);
                p.IDEMPRESA1 = Convert.ToInt32(TXT_IDEMPRESA.Text);
                p.NUMERO1 = Convert.ToInt32(TXT_NUMERO.Text);
                p.SLOGAN1 = TXT_SLOGAN.Text;
                p.DESCRICAO1 = TXT_DESCRICAO.Text;
                p.CarregaImagem(fotocandidato);

                bllcandidato.Incluir(p);
             
                MessageBox.Show("Inserido com sucesso !" );

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

        private void BTN_BUSCAR_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ShowDialog();
            if (!string.IsNullOrEmpty(op.FileName))
            {
                fotocandidato = op.FileName;
                PB_FOTO.Load(fotocandidato);
            }
        }

        private void BTN_REMOVER_Click(object sender, EventArgs e)
        {
            
                fotocandidato = "";
                PB_FOTO.Image = null;
            
        }
    }
    
}
