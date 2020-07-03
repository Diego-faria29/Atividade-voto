using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOCandidato
    {
        private Int32 IDPESSOA;
        private Int32 IDELEICAO;
        private Int32 IDEMPRESA;
        private Int32 NUMERO;
        private string SLOGAN;
        private string DESCRICAO;
        private byte[] FOTO;

        public int IDPESSOA1 { get => IDPESSOA; set => IDPESSOA = value; }
        public int IDELEICAO1 { get => IDELEICAO; set => IDELEICAO = value; }
        public int IDEMPRESA1 { get => IDEMPRESA; set => IDEMPRESA = value; }
        public int NUMERO1 { get => NUMERO; set => NUMERO = value; }
        public string SLOGAN1 { get => SLOGAN; set => SLOGAN = value; }
        public string DESCRICAO1 { get => DESCRICAO; set => DESCRICAO = value; }
        public byte[] FOTO1 { get => FOTO; set => FOTO = value; }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;

                FileInfo arqImagem = new FileInfo(imgCaminho);
                FileStream fs = new FileStream(imgCaminho, FileMode.Open,
                    FileAccess.Read, FileShare.Read);
                FOTO1 = new byte[Convert.ToInt32(arqImagem.Length)];
                int IBytes = fs.Read(FOTO1, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /*Transformar arquivo em Bytes em uma imagem*/
        public Bitmap getImagem()
        {
            MemoryStream mStream = new MemoryStream();
            mStream.Write(FOTO1, 0, Convert.ToInt32(FOTO1.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
