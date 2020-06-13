namespace PadraoDeProjetoEmCamadas
{
    partial class FRMEmpresa
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
            this.LBLidempresa = new System.Windows.Forms.Label();
            this.LBLNome = new System.Windows.Forms.Label();
            this.LBLDescricao = new System.Windows.Forms.Label();
            this.LBLCodEmpresa = new System.Windows.Forms.Label();
            this.TXTIDempresa = new System.Windows.Forms.TextBox();
            this.TXTnomeempresa = new System.Windows.Forms.TextBox();
            this.TXTDescricao = new System.Windows.Forms.TextBox();
            this.TXTCodigoEm = new System.Windows.Forms.TextBox();
            this.painel_campos.SuspendLayout();
            this.Painel_botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_campos
            // 
            this.painel_campos.Controls.Add(this.TXTCodigoEm);
            this.painel_campos.Controls.Add(this.TXTDescricao);
            this.painel_campos.Controls.Add(this.TXTnomeempresa);
            this.painel_campos.Controls.Add(this.TXTIDempresa);
            this.painel_campos.Controls.Add(this.LBLCodEmpresa);
            this.painel_campos.Controls.Add(this.LBLDescricao);
            this.painel_campos.Controls.Add(this.LBLNome);
            this.painel_campos.Controls.Add(this.LBLidempresa);
            this.painel_campos.Size = new System.Drawing.Size(443, 156);
            // 
            // Painel_botoes
            // 
            this.Painel_botoes.Size = new System.Drawing.Size(443, 54);
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
            // LBLidempresa
            // 
            this.LBLidempresa.AutoSize = true;
            this.LBLidempresa.Location = new System.Drawing.Point(26, 20);
            this.LBLidempresa.Name = "LBLidempresa";
            this.LBLidempresa.Size = new System.Drawing.Size(62, 13);
            this.LBLidempresa.TabIndex = 0;
            this.LBLidempresa.Text = "ID Empresa";
            // 
            // LBLNome
            // 
            this.LBLNome.AutoSize = true;
            this.LBLNome.Location = new System.Drawing.Point(26, 53);
            this.LBLNome.Name = "LBLNome";
            this.LBLNome.Size = new System.Drawing.Size(35, 13);
            this.LBLNome.TabIndex = 1;
            this.LBLNome.Text = "Nome";
            // 
            // LBLDescricao
            // 
            this.LBLDescricao.AutoSize = true;
            this.LBLDescricao.Location = new System.Drawing.Point(26, 85);
            this.LBLDescricao.Name = "LBLDescricao";
            this.LBLDescricao.Size = new System.Drawing.Size(55, 13);
            this.LBLDescricao.TabIndex = 2;
            this.LBLDescricao.Text = "Descricao";
            // 
            // LBLCodEmpresa
            // 
            this.LBLCodEmpresa.AutoSize = true;
            this.LBLCodEmpresa.Location = new System.Drawing.Point(26, 114);
            this.LBLCodEmpresa.Name = "LBLCodEmpresa";
            this.LBLCodEmpresa.Size = new System.Drawing.Size(73, 13);
            this.LBLCodEmpresa.TabIndex = 3;
            this.LBLCodEmpresa.Text = "Cod. Empresa";
            // 
            // TXTIDempresa
            // 
            this.TXTIDempresa.Enabled = false;
            this.TXTIDempresa.Location = new System.Drawing.Point(119, 17);
            this.TXTIDempresa.Name = "TXTIDempresa";
            this.TXTIDempresa.Size = new System.Drawing.Size(72, 20);
            this.TXTIDempresa.TabIndex = 4;
            // 
            // TXTnomeempresa
            // 
            this.TXTnomeempresa.Location = new System.Drawing.Point(119, 50);
            this.TXTnomeempresa.Name = "TXTnomeempresa";
            this.TXTnomeempresa.Size = new System.Drawing.Size(316, 20);
            this.TXTnomeempresa.TabIndex = 5;
            // 
            // TXTDescricao
            // 
            this.TXTDescricao.Location = new System.Drawing.Point(119, 82);
            this.TXTDescricao.Name = "TXTDescricao";
            this.TXTDescricao.Size = new System.Drawing.Size(316, 20);
            this.TXTDescricao.TabIndex = 6;
            // 
            // TXTCodigoEm
            // 
            this.TXTCodigoEm.Location = new System.Drawing.Point(119, 114);
            this.TXTCodigoEm.Name = "TXTCodigoEm";
            this.TXTCodigoEm.Size = new System.Drawing.Size(316, 20);
            this.TXTCodigoEm.TabIndex = 7;
            // 
            // FRMEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 234);
            this.Name = "FRMEmpresa";
            this.Text = "FRMEmpresa";
            this.painel_campos.ResumeLayout(false);
            this.painel_campos.PerformLayout();
            this.Painel_botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXTCodigoEm;
        private System.Windows.Forms.TextBox TXTDescricao;
        private System.Windows.Forms.TextBox TXTnomeempresa;
        private System.Windows.Forms.TextBox TXTIDempresa;
        private System.Windows.Forms.Label LBLCodEmpresa;
        private System.Windows.Forms.Label LBLDescricao;
        private System.Windows.Forms.Label LBLNome;
        private System.Windows.Forms.Label LBLidempresa;
    }
}