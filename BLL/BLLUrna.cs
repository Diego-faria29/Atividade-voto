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
    public class BLLUrna
    {
        private DALUrna DALobj;

        public BLLUrna(DALConexao cx)
        {
            DALobj = new DALUrna(cx);
        }

        public void Incluir(MODELOUrna modelo)
        {
            try
            {

                if (modelo.NOME1 == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }
                if (modelo.IP1.ToString() == "")
                {
                    throw new ArgumentNullException("IP", "IP não foi preenchido");
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
