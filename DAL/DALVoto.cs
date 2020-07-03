using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MODELO;
using System.Data;

namespace DAL
{
    public class DALVoto
    {
        private DALConexao conexao;

        public DALVoto(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(MODELOVoto modelo)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Voto (IDELEICAO, IDURNA, IDPESSOA, NUMEROVOTO)" +
                    "VALUES (@IDELEICAO, @IDURNA, @IDPESSOA, @NUMEROVOTO); SELECT LAST_INSERT_ID();";
                cmd.Parameters.AddWithValue("@IDELEICAO", modelo.IDELEICAO1);
                cmd.Parameters.AddWithValue("@IDURNA", modelo.IDURNA1);
                cmd.Parameters.AddWithValue("@IDPESSOA", modelo.IDPESSOA1);
                cmd.Parameters.AddWithValue("@NUMEROVOTO", modelo.NUMEROVOTO1);

                conexao.Conectar();
                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.IDELEICAO1 = idInserido;
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
