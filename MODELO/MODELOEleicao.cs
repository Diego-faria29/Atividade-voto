using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOEleicao
    {
        private int IDELEICAO;
        private int IDEMPRESA;
        private string NOME;
        private string DESCRICAO;
        private int TIPOVOTO;
        private string MENSSAGEMENCERRADO;
        private string MENSSAGEMFIM;
        private DateTime DATAINICIO;
        private DateTime DATAFIM;

        public int IDELEICAO1 { get => IDELEICAO; set => IDELEICAO = value; }
        public int IDEMPRESA1 { get => IDEMPRESA; set => IDEMPRESA = value; }
        public string NOME1 { get => NOME; set => NOME = value; }
        public string DESCRICAO1 { get => DESCRICAO; set => DESCRICAO = value; }
        public int TIPOVOTO1 { get => TIPOVOTO; set => TIPOVOTO = value; }
        public string MENSSAGEMENCERRADO1 { get => MENSSAGEMENCERRADO; set => MENSSAGEMENCERRADO = value; }
        public string MENSSAGEMFIM1 { get => MENSSAGEMFIM; set => MENSSAGEMFIM = value; }
        public DateTime DATAINICIO1 { get => DATAINICIO; set => DATAINICIO = value; }
        public DateTime DATAFIM1 { get => DATAFIM; set => DATAFIM = value; }
    }
}
