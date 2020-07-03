using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALCandidato
    {
        private DALConexao conexao;
        public DALCandidato(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(MODELOCandidato modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Candidato (IDPESSOA, IDELEICAO, IDEMPRESA, NUMERO, SLOGAN, DESCRICAO, FOTO)" +
                    "VALUES (@IDPESSOA, @IDELEICAO, @IDEMPRESA, @NUMERO, @SLOGAN, @DESCRICAO, @FOTO); @SELECT LAST_INSERT_ID();";
                cmd.Parameters.AddWithValue("@IDPESSOA", modelo.IDPESSOA1);
                cmd.Parameters.AddWithValue("@IDELEICAO", modelo.DESCRICAO1);
                cmd.Parameters.AddWithValue("@IDEMPRESA", modelo.IDEMPRESA1);
                cmd.Parameters.AddWithValue("@NUMERO", modelo.NUMERO1);
                cmd.Parameters.AddWithValue("@SLOGAN", modelo.SLOGAN1);
                cmd.Parameters.AddWithValue("@DESCRICAO", modelo.DESCRICAO1);
                cmd.Parameters.AddWithValue("@FOTO", modelo.FOTO1);


              
                conexao.Conectar();
              
             //   int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
             /*  modelo.IDPESSOA1 = idInserido;*/
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }

        }
    }
}
