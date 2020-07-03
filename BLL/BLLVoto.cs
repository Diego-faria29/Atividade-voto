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
    public class BLLVoto
    {
        private DALVoto DALobj;

        public BLLVoto(DALConexao cx)
        {
            DALobj = new DALVoto(cx);
        }

        public void Incluir(MODELOVoto modelo)
        {
            try
            {

                if (modelo.IDELEICAO1.ToString() == "")
                {
                    throw new ArgumentNullException("Id eleicao", "Cód da eleição não pode ser nulo");
                }
                if (modelo.IDURNA1.ToString() == "")
                {
                    throw new ArgumentNullException("Id URNA", "Cód da URNA não pode ser nulo");
                }
                if (modelo.IDPESSOA1.ToString() == "")
                {
                    throw new ArgumentNullException("ID PESSOA", "Não pode ser vazio");
                }
                if (modelo.NUMEROVOTO1.ToString() == "")
                {
                    throw new ArgumentNullException("Número voto", "Númeor do voto não pode ser vazio");
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
