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
    public partial class FRMEmpresa : PadraoDeProjetoEmCamadas.frmModeloDeCadastro
    {
        public FRMEmpresa()
        {
            InitializeComponent();
        }

        public FRMEmpresa(frmPrincipal f)
        {
            InitializeComponent();
            //f.Font.Size = 30;
            f.Text = "Menu - Cadastro Empresa";
        }

        public void limparCampos()
        {
            TXTIDempresa.Clear();
            TXTnomeempresa.Clear();
            TXTDescricao.Clear();
            TXTCodigoEm.Clear();

        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            alterapropriedades(2);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEmpresa bllempresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();
                p.Nome = TXTnomeempresa.Text;
                p.Descricao = TXTDescricao.Text;
                p.CODEmpresa = TXTCodigoEm.Text;

                bllempresa.Incluir(p);
                TXTIDempresa.Text = p.IDEmpresa.ToString(); ;
                MessageBox.Show("Empresa inserida com sucesso. Id:" + p.IDEmpresa);

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

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLEmpresa bllempresa = new BLLEmpresa(cx);

                MODELOEmpresa p = new MODELOEmpresa();
                p.Nome = TXTnomeempresa.Text;
                p.Descricao = TXTDescricao.Text;
                p.CODEmpresa = TXTCodigoEm.Text;

                bllempresa.Alterar(p);
                MessageBox.Show("Usuario alterado com sucesso.");

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
                BLLEmpresa bllempresa = new BLLEmpresa(cx);
                bllempresa.Excluir(Convert.ToInt32(TXTIDempresa.Text));
                MessageBox.Show("Empresa excluido com sucesso.");

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

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            alterapropriedades(1);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            FRMLocalizarEM f = new FRMLocalizarEM();
            f.ShowDialog();

            popularcampos(f.modelempresa);

            alterapropriedades(3);
        }

        private void popularcampos(MODELOEmpresa p)
        {
            if (p != null)
            {
               
                TXTnomeempresa.Text = p.Nome;
                TXTDescricao.Text = p.Descricao;
                TXTCodigoEm.Text = p.CODEmpresa;
                TXTIDempresa.Text = p.IDEmpresa.ToString();
  

            }
        }

        private void TXTIDempresa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
