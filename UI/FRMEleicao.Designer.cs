namespace PadraoDeProjetoEmCamadas
{
    partial class FRMEleicao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBLIDele = new System.Windows.Forms.Label();
            this.LBLIDem = new System.Windows.Forms.Label();
            this.LBLNome = new System.Windows.Forms.Label();
            this.LBLDescricao = new System.Windows.Forms.Label();
            this.LBLMensagemEnc = new System.Windows.Forms.Label();
            this.LBLMensagemFim = new System.Windows.Forms.Label();
            this.LBLTipoVoto = new System.Windows.Forms.Label();
            this.LBLDataInicio = new System.Windows.Forms.Label();
            this.LBLDatafim = new System.Windows.Forms.Label();
            this.RICHTXTMsgConcluido = new System.Windows.Forms.RichTextBox();
            this.RICHTXTMsgEnc = new System.Windows.Forms.RichTextBox();
            this.TXTdescricao = new System.Windows.Forms.RichTextBox();
            this.TXTNome = new System.Windows.Forms.TextBox();
            this.TXTIDEmpresa = new System.Windows.Forms.TextBox();
            this.TXTIDEleicao = new System.Windows.Forms.TextBox();
            this.CB_TipoVoto = new System.Windows.Forms.ComboBox();
            this.DTPinicio = new System.Windows.Forms.DateTimePicker();
            this.DTPfim = new System.Windows.Forms.DateTimePicker();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.DTPfim);
            this.painel_campos.Controls.Add(this.DTPinicio);
            this.painel_campos.Controls.Add(this.CB_TipoVoto);
            this.painel_campos.Controls.Add(this.TXTIDEleicao);
            this.painel_campos.Controls.Add(this.TXTIDEmpresa);
            this.painel_campos.Controls.Add(this.TXTNome);
            this.painel_campos.Controls.Add(this.TXTdescricao);
            this.painel_campos.Controls.Add(this.RICHTXTMsgEnc);
            this.painel_campos.Controls.Add(this.RICHTXTMsgConcluido);
            this.painel_campos.Controls.Add(this.LBLDatafim);
            this.painel_campos.Controls.Add(this.LBLDataInicio);
            this.painel_campos.Controls.Add(this.LBLTipoVoto);
            this.painel_campos.Controls.Add(this.LBLMensagemFim);
            this.painel_campos.Controls.Add(this.LBLMensagemEnc);
            this.painel_campos.Controls.Add(this.LBLDescricao);
            this.painel_campos.Controls.Add(this.LBLNome);
            this.painel_campos.Controls.Add(this.LBLIDem);
            this.painel_campos.Controls.Add(this.LBLIDele);
            this.painel_campos.Size = new System.Drawing.Size(736, 241);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Location = new System.Drawing.Point(169, 259);
            this.Painel_botoes.Size = new System.Drawing.Size(442, 54);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // LBLIDele
            // 
            this.LBLIDele.AutoSize = true;
            this.LBLIDele.Location = new System.Drawing.Point(242, 12);
            this.LBLIDele.Name = "LBLIDele";
            this.LBLIDele.Size = new System.Drawing.Size(56, 13);
            this.LBLIDele.TabIndex = 0;
            this.LBLIDele.Text = "ID Eleicao";
            // 
            // LBLIDem
            // 
            this.LBLIDem.AutoSize = true;
            this.LBLIDem.Location = new System.Drawing.Point(242, 98);
            this.LBLIDem.Name = "LBLIDem";
            this.LBLIDem.Size = new System.Drawing.Size(62, 13);
            this.LBLIDem.TabIndex = 1;
            this.LBLIDem.Text = "ID Empresa";
            // 
            // LBLNome
            // 
            this.LBLNome.AutoSize = true;
            this.LBLNome.Location = new System.Drawing.Point(9, 54);
            this.LBLNome.Name = "LBLNome";
            this.LBLNome.Size = new System.Drawing.Size(35, 13);
            this.LBLNome.TabIndex = 2;
            this.LBLNome.Text = "Nome";
            // 
            // LBLDescricao
            // 
            this.LBLDescricao.AutoSize = true;
            this.LBLDescricao.Location = new System.Drawing.Point(9, 141);
            this.LBLDescricao.Name = "LBLDescricao";
            this.LBLDescricao.Size = new System.Drawing.Size(55, 13);
            this.LBLDescricao.TabIndex = 3;
            this.LBLDescricao.Text = "Descrição";
            // 
            // LBLMensagemEnc
            // 
            this.LBLMensagemEnc.AutoSize = true;
            this.LBLMensagemEnc.Location = new System.Drawing.Point(588, 127);
            this.LBLMensagemEnc.Name = "LBLMensagemEnc";
            this.LBLMensagemEnc.Size = new System.Drawing.Size(111, 13);
            this.LBLMensagemEnc.TabIndex = 4;
            this.LBLMensagemEnc.Text = "Mensagem Encerrado";
            // 
            // LBLMensagemFim
            // 
            this.LBLMensagemFim.AutoSize = true;
            this.LBLMensagemFim.Location = new System.Drawing.Point(573, 12);
            this.LBLMensagemFim.Name = "LBLMensagemFim";
            this.LBLMensagemFim.Size = new System.Drawing.Size(143, 13);
            this.LBLMensagemFim.TabIndex = 5;
            this.LBLMensagemFim.Text = "Mensagem Votos concluidos";
            // 
            // LBLTipoVoto
            // 
            this.LBLTipoVoto.AutoSize = true;
            this.LBLTipoVoto.Location = new System.Drawing.Point(9, 98);
            this.LBLTipoVoto.Name = "LBLTipoVoto";
            this.LBLTipoVoto.Size = new System.Drawing.Size(67, 13);
            this.LBLTipoVoto.TabIndex = 6;
            this.LBLTipoVoto.Text = "Tipo de voto";
            // 
            // LBLDataInicio
            // 
            this.LBLDataInicio.AutoSize = true;
            this.LBLDataInicio.Location = new System.Drawing.Point(242, 144);
            this.LBLDataInicio.Name = "LBLDataInicio";
            this.LBLDataInicio.Size = new System.Drawing.Size(74, 13);
            this.LBLDataInicio.TabIndex = 7;
            this.LBLDataInicio.Text = "Data de início";
            // 
            // LBLDatafim
            // 
            this.LBLDatafim.AutoSize = true;
            this.LBLDatafim.Location = new System.Drawing.Point(255, 201);
            this.LBLDatafim.Name = "LBLDatafim";
            this.LBLDatafim.Size = new System.Drawing.Size(46, 13);
            this.LBLDatafim.TabIndex = 8;
            this.LBLDatafim.Text = "Data fim";
            // 
            // RICHTXTMsgConcluido
            // 
            this.RICHTXTMsgConcluido.Location = new System.Drawing.Point(552, 31);
            this.RICHTXTMsgConcluido.Name = "RICHTXTMsgConcluido";
            this.RICHTXTMsgConcluido.Size = new System.Drawing.Size(181, 93);
            this.RICHTXTMsgConcluido.TabIndex = 9;
            this.RICHTXTMsgConcluido.Text = "";
            // 
            // RICHTXTMsgEnc
            // 
            this.RICHTXTMsgEnc.Location = new System.Drawing.Point(552, 141);
            this.RICHTXTMsgEnc.Name = "RICHTXTMsgEnc";
            this.RICHTXTMsgEnc.Size = new System.Drawing.Size(181, 93);
            this.RICHTXTMsgEnc.TabIndex = 10;
            this.RICHTXTMsgEnc.Text = "";
            // 
            // TXTdescricao
            // 
            this.TXTdescricao.Location = new System.Drawing.Point(85, 141);
            this.TXTdescricao.Name = "TXTdescricao";
            this.TXTdescricao.Size = new System.Drawing.Size(151, 93);
            this.TXTdescricao.TabIndex = 11;
            this.TXTdescricao.Text = "";
            // 
            // TXTNome
            // 
            this.TXTNome.Location = new System.Drawing.Point(85, 54);
            this.TXTNome.Name = "TXTNome";
            this.TXTNome.Size = new System.Drawing.Size(462, 20);
            this.TXTNome.TabIndex = 14;
            // 
            // TXTIDEmpresa
            // 
            this.TXTIDEmpresa.Location = new System.Drawing.Point(322, 98);
            this.TXTIDEmpresa.Name = "TXTIDEmpresa";
            this.TXTIDEmpresa.Size = new System.Drawing.Size(74, 20);
            this.TXTIDEmpresa.TabIndex = 15;
            // 
            // TXTIDEleicao
            // 
            this.TXTIDEleicao.Enabled = false;
            this.TXTIDEleicao.Location = new System.Drawing.Point(322, 12);
            this.TXTIDEleicao.Name = "TXTIDEleicao";
            this.TXTIDEleicao.Size = new System.Drawing.Size(63, 20);
            this.TXTIDEleicao.TabIndex = 16;
            // 
            // CB_TipoVoto
            // 
            this.CB_TipoVoto.FormattingEnabled = true;
            this.CB_TipoVoto.Location = new System.Drawing.Point(85, 95);
            this.CB_TipoVoto.Name = "CB_TipoVoto";
            this.CB_TipoVoto.Size = new System.Drawing.Size(151, 21);
            this.CB_TipoVoto.TabIndex = 27;
            // 
            // DTPinicio
            // 
            this.DTPinicio.Location = new System.Drawing.Point(322, 141);
            this.DTPinicio.Name = "DTPinicio";
            this.DTPinicio.Size = new System.Drawing.Size(225, 20);
            this.DTPinicio.TabIndex = 28;
            // 
            // DTPfim
            // 
            this.DTPfim.Location = new System.Drawing.Point(322, 201);
            this.DTPfim.Name = "DTPfim";
            this.DTPfim.Size = new System.Drawing.Size(225, 20);
            this.DTPfim.TabIndex = 29;
            // 
            // FRMEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 320);
            this.Name = "FRMEleicao";
            this.Text = "FRMEleicao";
            this.Load += new System.EventHandler(this.FRMEleicao_Load);
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBLDatafim;
        private System.Windows.Forms.Label LBLDataInicio;
        private System.Windows.Forms.Label LBLTipoVoto;
        private System.Windows.Forms.Label LBLMensagemFim;
        private System.Windows.Forms.Label LBLMensagemEnc;
        private System.Windows.Forms.Label LBLDescricao;
        private System.Windows.Forms.Label LBLNome;
        private System.Windows.Forms.Label LBLIDem;
        private System.Windows.Forms.Label LBLIDele;
        private System.Windows.Forms.TextBox TXTIDEleicao;
        private System.Windows.Forms.TextBox TXTIDEmpresa;
        private System.Windows.Forms.TextBox TXTNome;
        private System.Windows.Forms.RichTextBox TXTdescricao;
        private System.Windows.Forms.RichTextBox RICHTXTMsgEnc;
        private System.Windows.Forms.RichTextBox RICHTXTMsgConcluido;
        private System.Windows.Forms.ComboBox CB_TipoVoto;
        private System.Windows.Forms.DateTimePicker DTPfim;
        private System.Windows.Forms.DateTimePicker DTPinicio;
    }
}