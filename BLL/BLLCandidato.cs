using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class BLLCandidato
    {
        private DALCandidato DALobj;

        public BLLCandidato(DALConexao cx)
        {
            DALobj = new DALCandidato(cx);
        }

        public void Incluir(MODELOCandidato modelo)
        {
            try
            {

                if (modelo.IDPESSOA1.ToString() == "")
                {
                    throw new ArgumentNullException("IDPessoa", "Nao pode ser vazio.");
                }
                if (modelo.IDELEICAO1.ToString() == "")
                {
                    throw new ArgumentNullException("IDEleicao", "ID não foi preenchido");
                }
                if (modelo.IDEMPRESA1.ToString() == "")
                {
                    throw new ArgumentNullException("IDEmpresa", "ID não pose ser vazio");
                }
                if (modelo.NUMERO1.ToString() == "")
                {
                    throw new ArgumentNullException("Número", "não pose ser vazio");
                }
                

                DALobj.Incluir(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
