namespace PadraoDeProjetoEmCamadas
{
    partial class FRMEleitor
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
            this.TXT_IDPESSOA = new System.Windows.Forms.TextBox();
            this.TXT_IDELEICAO = new System.Windows.Forms.TextBox();
            this.TXT_IDEMPRESA = new System.Windows.Forms.TextBox();
            this.LBL_IDPESSOA = new System.Windows.Forms.Label();
            this.LBL_ELEICAO = new System.Windows.Forms.Label();
            this.LBL_EMPRESA = new System.Windows.Forms.Label();
            this.BTN_INSERIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_IDPESSOA
            // 
            this.TXT_IDPESSOA.Location = new System.Drawing.Point(12, 51);
            this.TXT_IDPESSOA.Name = "TXT_IDPESSOA";
            this.TXT_IDPESSOA.Size = new System.Drawing.Size(100, 26);
            this.TXT_IDPESSOA.TabIndex = 0;
            // 
            // TXT_IDELEICAO
            // 
            this.TXT_IDELEICAO.Location = new System.Drawing.Point(12, 130);
            this.TXT_IDELEICAO.Name = "TXT_IDELEICAO";
            this.TXT_IDELEICAO.Size = new System.Drawing.Size(100, 26);
            this.TXT_IDELEICAO.TabIndex = 1;
            // 
            // TXT_IDEMPRESA
            // 
            this.TXT_IDEMPRESA.Location = new System.Drawing.Point(12, 208);
            this.TXT_IDEMPRESA.Name = "TXT_IDEMPRESA";
            this.TXT_IDEMPRESA.Size = new System.Drawing.Size(100, 26);
            this.TXT_IDEMPRESA.TabIndex = 2;
            // 
            // LBL_IDPESSOA
            // 
            this.LBL_IDPESSOA.AutoSize = true;
            this.LBL_IDPESSOA.Location = new System.Drawing.Point(8, 28);
            this.LBL_IDPESSOA.Name = "LBL_IDPESSOA";
            this.LBL_IDPESSOA.Size = new System.Drawing.Size(85, 20);
            this.LBL_IDPESSOA.TabIndex = 3;
            this.LBL_IDPESSOA.Text = "ID pessoa";
            // 
            // LBL_ELEICAO
            // 
            this.LBL_ELEICAO.AutoSize = true;
            this.LBL_ELEICAO.Location = new System.Drawing.Point(12, 107);
            this.LBL_ELEICAO.Name = "LBL_ELEICAO";
            this.LBL_ELEICAO.Size = new System.Drawing.Size(84, 20);
            this.LBL_ELEICAO.TabIndex = 4;
            this.LBL_ELEICAO.Text = "ID eleicao";
            // 
            // LBL_EMPRESA
            // 
            this.LBL_EMPRESA.AutoSize = true;
            this.LBL_EMPRESA.Location = new System.Drawing.Point(12, 185);
            this.LBL_EMPRESA.Name = "LBL_EMPRESA";
            this.LBL_EMPRESA.Size = new System.Drawing.Size(98, 20);
            this.LBL_EMPRESA.TabIndex = 5;
            this.LBL_EMPRESA.Text = "ID Empresa";
            // 
            // BTN_INSERIR
            // 
            this.BTN_INSERIR.Location = new System.Drawing.Point(214, 233);
            this.BTN_INSERIR.Name = "BTN_INSERIR";
            this.BTN_INSERIR.Size = new System.Drawing.Size(88, 68);
            this.BTN_INSERIR.TabIndex = 6;
            this.BTN_INSERIR.Text = "Inserir";
            this.BTN_INSERIR.UseVisualStyleBackColor = true;
            this.BTN_INSERIR.Click += new System.EventHandler(this.BTN_INSERIR_Click);
            // 
            // FRMEleitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 313);
            this.Controls.Add(this.BTN_INSERIR);
            this.Controls.Add(this.LBL_EMPRESA);
            this.Controls.Add(this.LBL_ELEICAO);
            this.Controls.Add(this.LBL_IDPESSOA);
            this.Controls.Add(this.TXT_IDEMPRESA);
            this.Controls.Add(this.TXT_IDELEICAO);
            this.Controls.Add(this.TXT_IDPESSOA);
            this.Name = "FRMEleitor";
            this.Text = "FRMEleitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_IDPESSOA;
        private System.Windows.Forms.TextBox TXT_IDELEICAO;
        private System.Windows.Forms.TextBox TXT_IDEMPRESA;
        private System.Windows.Forms.Label LBL_IDPESSOA;
        private System.Windows.Forms.Label LBL_ELEICAO;
        private System.Windows.Forms.Label LBL_EMPRESA;
        private System.Windows.Forms.Button BTN_INSERIR;
    }
}