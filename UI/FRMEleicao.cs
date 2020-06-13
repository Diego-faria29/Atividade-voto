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
using MySql.Data.MySqlClient;

namespace PadraoDeProjetoEmCamadas
{
    public partial class FRMEleicao : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        public FRMEleicao()
        {
            InitializeComponent();
        }

        public FRMEleicao(frmPrincipal f)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            f.Text = "Menu - Cadastro Eleicao";
        }
        public void limparCampos()
        {
            TXTIDEleicao.Clear();
            TXTNome.Clear();
            RICHTXTMsgConcluido.Clear();
            RICHTXTMsgEnc.Clear();
            DTPfim.Text = "";
            DTPinicio.Text = "";
            CB_TipoVoto.SelectedItem = null;
            TXTdescricao.Clear();
            TXTIDEmpresa.Clear();
            
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
 
                alterapropriedades(2);
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            alterapropriedades(1);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao blleleicao = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                p.NOME1= TXTNome.Text;
                p.MENSSAGEMFIM1 = RICHTXTMsgConcluido.Text;
                p.MENSSAGEMENCERRADO1 = RICHTXTMsgEnc.Text;

                switch (CB_TipoVoto.SelectedItem.ToString())
                {
                    case "Não secreto":
                        p.TIPOVOTO1 = 0;
                        break;
                    case "Secreto":
                        p.TIPOVOTO1 = 1;
                        break;
                }

                p.IDEMPRESA1 = Convert.ToInt32(TXTIDEmpresa.Text);
                p.DESCRICAO1 = TXTdescricao.Text;
                p.DATAINICIO1 = new DateTime(DTPinicio.Value.Year,
                    DTPinicio.Value.Month,
                    DTPinicio.Value.Day);
                p.DATAFIM1 = new DateTime(DTPfim.Value.Year,
                DTPfim.Value.Month,
                DTPfim.Value.Day);


                blleleicao.Incluir(p);
                TXTIDEleicao.Text = p.IDELEICAO1.ToString(); ;
                MessageBox.Show("Usuario inserido com sucesso id:" + p.IDELEICAO1);

                limparCampos();
                alterapropriedades(1);
                
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

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEleicao blleleicao = new BLLEleicao(cx);

                MODELOEleicao p = new MODELOEleicao();
                p.NOME1 = TXTNome.Text;
                p.MENSSAGEMFIM1 = RICHTXTMsgConcluido.Text;
                p.MENSSAGEMENCERRADO1 = RICHTXTMsgEnc.Text;

                switch (CB_TipoVoto.SelectedItem.ToString())
                {
                    case "Não secreto":
                        p.TIPOVOTO1 = 0;
                        break;
                    case "Secreto":
                        p.TIPOVOTO1 = 1;
                        break;
                }

                p.IDEMPRESA1 = Convert.ToInt32(TXTIDEmpresa.Text);
                p.DESCRICAO1 = TXTdescricao.Text;
                p.DATAINICIO1 = new DateTime(DTPinicio.Value.Year,
                    DTPinicio.Value.Month,
                    DTPinicio.Value.Day);
                p.DATAFIM1 = new DateTime(DTPfim.Value.Year,
                DTPfim.Value.Month,
                DTPfim.Value.Day);
                p.IDELEICAO1 = Convert.ToInt32(TXTIDEleicao.Text);


                blleleicao.Alterar(p);
                MessageBox.Show("Alterado com sucesso.");

                limparCampos();
                alterapropriedades(1);

            }
            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro já existe no banco de dados");
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

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLEleicao bllpessoa = new BLLEleicao(cx);
                bllpessoa.Excluir(Convert.ToInt32(TXTIDEleicao.Text));
                MessageBox.Show("Usuario excluido com sucesso.");

                limparCampos();
                alterapropriedades(1);
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao excluir erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir erro geral:" + ex.Message);
            }
        }

        private void FRMEleicao_Load(object sender, EventArgs e)
        {
            CB_TipoVoto.Items.Add("Secreto");
            CB_TipoVoto.Items.Add("Não secreto");
        }

        private void popularcampos(MODELOEleicao p)
        {
            if (p != null)
            {
                DTPinicio.Text = Convert.ToString(p.DATAINICIO1);
                DTPfim.Text = Convert.ToString(p.DATAFIM1);
                TXTNome.Text = p.NOME1 ;
                RICHTXTMsgConcluido.Text = p.MENSSAGEMFIM1;
                RICHTXTMsgEnc.Text = p.MENSSAGEMENCERRADO1;
                TXTIDEleicao.Text = p.IDELEICAO1.ToString();
                TXTdescricao.Text = p.DESCRICAO1;
                TXTIDEmpresa.Text = p.IDEMPRESA1.ToString();
                switch (p.TIPOVOTO1)
                {
                    case 0:
                        CB_TipoVoto.SelectedItem = "Não secreto";
                        break;
                    case 1:
                        CB_TipoVoto.SelectedItem = "Secreto";
                        break;

                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FRMLocalizarEleicao f = new FRMLocalizarEleicao();
            f.ShowDialog();

            popularcampos(f.modeleleicao);

            alterapropriedades(3);
        }
    }
}
