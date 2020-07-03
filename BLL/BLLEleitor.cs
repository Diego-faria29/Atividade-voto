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
    public class BLLEleitor
    {
        private DALEleitor DALobj;

        public BLLEleitor(DALConexao cx)
        {
            DALobj = new DALEleitor(cx);
        }

        public void Incluir(MODELOeleitor modelo)
        {
            try
            {

                if (modelo.IDPESSOA1.ToString() == "")
                {
                    throw new ArgumentNullException("IDPESSOA", "CÓD  da pessoa não pode ser nulo.");
                }
                if (modelo.IDELEICAO1.ToString() == "")
                {
                    throw new ArgumentNullException("Id eleicao", "Cód da eleição não pode ser nulo");
                }
                if (modelo.IDEMPRESA1.ToString() == "")
                {
                    throw new ArgumentNullException("ID Empresa", "Não pode ser vazio");
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
