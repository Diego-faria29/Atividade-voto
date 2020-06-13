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
    public class DALEleicao
    {
        private DALConexao conexao;

        public DALEleicao(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(MODELOEleicao modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Eleicao (IDELEICAO, IDEMPRESA, NOME, DESCRICAO, TIPOVOTO, MENSAGEMENCERRADO, MENSAGEMFIM, DATAINICIO, DATAFIM)" +
                    "VALUES (NULL, @IDEMPRESA, @NOME, @DESCRICAO, @TIPOVOTO, @MENSAGEMENCERRADO, @MENSAGEMFIM, @DATAINICIO, @DATAFIM); SELECT LAST_INSERT_ID();";
                cmd.Parameters.AddWithValue("@IDEMPRESA", modelo.IDEMPRESA1);
                cmd.Parameters.AddWithValue("@NOME", modelo.NOME1);
                cmd.Parameters.AddWithValue("@DESCRICAO", modelo.DESCRICAO1);
                cmd.Parameters.AddWithValue("@TIPOVOTO", modelo.TIPOVOTO1);
                cmd.Parameters.AddWithValue("@MENSAGEMENCERRADO", modelo.MENSSAGEMENCERRADO1);
                cmd.Parameters.AddWithValue("@MENSAGEMFIM", modelo.MENSSAGEMFIM1);
                cmd.Parameters.AddWithValue("@DATAINICIO", modelo.DATAINICIO1);
                cmd.Parameters.AddWithValue("@DATAFIM", modelo.DATAFIM1);

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

        public void Alterar(MODELOEleicao modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = " UPDATE Eleicao SET IDEMPRESA = @IDEMPRESA," +
                                  " NOME = @NOME," +
                                  " DESCRICAO = @DESCRICAO," +
                                  " TIPOVOTO = @TIPOVOTO," +
                                  " MENSAGEMENCERRADO = @MENSAGEMENCERRADO," +
                                  " MENSAGEMFIM = @MENSAGEMFIM," +
                                  " DATAINICIO = @DATAINICIO," +
                                  " DATAFIM = @DATAFIM" +
                                  " WHERE " +
                                  " IDELEICAO = @IDELEICAO";                               
                cmd.Parameters.AddWithValue("@IDEMPRESA", modelo.IDEMPRESA1);
                cmd.Parameters.AddWithValue("@NOME", modelo.NOME1);
                cmd.Parameters.AddWithValue("@DESCRICAO", modelo.DESCRICAO1);
                cmd.Parameters.AddWithValue("@TIPOVOTO", modelo.TIPOVOTO1);
                cmd.Parameters.AddWithValue("@MENSAGEMENCERRADO", modelo.MENSSAGEMENCERRADO1);
                cmd.Parameters.AddWithValue("@MENSAGEMFIM", modelo.MENSSAGEMFIM1);
                string datafim = modelo.DATAFIM1.ToString("yyyy-MM-dd HH:mm:ss");
                cmd.Parameters.AddWithValue("@DATAFIM", datafim);
                string datainicio = modelo.DATAINICIO1.ToString("yyyy-MM-dd HH:mm:ss");
                cmd.Parameters.AddWithValue("@DATAINICIO", datainicio);
                cmd.Parameters.AddWithValue("@IDELEICAO", modelo.IDELEICAO1);

                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
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

        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;

                cmd.CommandText = "DELETE FROM Eleicao WHERE IDELEICAO = @IDELEICAO";
                cmd.Parameters.AddWithValue("@IDELEICAO", codigo);
                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
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

        public DataTable Localizar(string texto)
        {
            DataTable tabela = new DataTable();
            string SQL = "SELECT * FROM Eleicao WHERE nome LIKE '%" + texto + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjetoConexao);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
