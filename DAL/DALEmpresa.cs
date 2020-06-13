using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALEmpresa
    {
        private DALConexao conexao;

        public DALEmpresa(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir (MODELOEmpresa modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Empresa (IDEMPRESA, NOME, DESCRICAO, CODEMPRESA)" +
                    "VALUES (NULL, @NOME, @DESCRICAO, @CODEMPRESA); SELECT LAST_INSERT_ID();";
                cmd.Parameters.AddWithValue("@NOME", modelo.Nome);
                cmd.Parameters.AddWithValue("@DESCRICAO", modelo.Descricao);
                cmd.Parameters.AddWithValue("@CODEMPRESA", modelo.CODEmpresa);


                conexao.Conectar();
                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.IDEmpresa = idInserido;
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

        public void Alterar(MODELOEmpresa modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE Empresa SET NOME = @NOME," +
                                  " DESCRICAO = @DESCRICAO," +
                                  " CODEMPRESA = @CODEMPRESA," +
                                  " IDEMPRESA = @IDEMPRESA";
                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@DESCRICAO", modelo.Descricao);
                cmd.Parameters.AddWithValue("@CODEMPRESA", modelo.CODEmpresa);
                cmd.Parameters.AddWithValue("@IDEMPRESA", modelo.IDEmpresa);

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

                cmd.CommandText = "DELETE FROM Empresa WHERE IDEMPRESA = @IDEMPRESA";
                cmd.Parameters.AddWithValue("@IDEMPRESA", codigo);
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
            string SQL = "SELECT * FROM Empresa WHERE NOME LIKE '%" + texto + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjetoConexao);
            adapter.Fill(tabela);

            return tabela;
        }
    }
}
