using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALEleitor
    {
        private DALConexao conexao;
        public DALEleitor(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(MODELOeleitor modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Eleitor (IDPESSOA, IDELEICAO, IDEMPRESA)" +
                    "VALUES (@IDPESSOA, @IDELEICAO, @IDEMPRESA ); SELECT LAST_INSERT_ID();";
                cmd.Parameters.AddWithValue("@IDPESSOA", modelo.IDPESSOA1);
                cmd.Parameters.AddWithValue("@IDELEICAO", modelo.IDELEICAO1);
                cmd.Parameters.AddWithValue("@IDEMPRESA", modelo.IDEMPRESA1);


                conexao.Conectar();
                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.IDPESSOA1 = idInserido;

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
