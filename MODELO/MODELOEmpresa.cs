using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEmpresa
    {
        private Int32 IDEMPRESA;
        private string NOME;
        private string DESCRICAO;
        private string CODEMPRESA;

        public int IDEmpresa { get => IDEMPRESA; set => IDEMPRESA = value; }
        public string Nome { get => NOME; set => NOME = value; }
        public string Descricao { get => DESCRICAO; set => DESCRICAO = value; }
        public string CODEmpresa { get => CODEMPRESA; set => CODEMPRESA = value; }
    }
}
