namespace PadraoDeProjetoEmCamadas
{
    partial class FRMVoto
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
            this.TXT_IDELEICAO = new System.Windows.Forms.TextBox();
            this.TXT_IDURNA = new System.Windows.Forms.TextBox();
            this.TXT_IDPESSOA = new System.Windows.Forms.TextBox();
            this.TXT_NUMEROVOTO = new System.Windows.Forms.TextBox();
            this.LBL_IDELEICAO = new System.Windows.Forms.Label();
            this.LBL_IDURNA = new System.Windows.Forms.Label();
            this.LBL_IDPESSOA = new System.Windows.Forms.Label();
            this.LBL_NUMEROVOTO = new System.Windows.Forms.Label();
            this.BTN_INSERIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_IDELEICAO
            // 
            this.TXT_IDELEICAO.Location = new System.Drawing.Point(12, 75);
            this.TXT_IDELEICAO.Name = "TXT_IDELEICAO";
            this.TXT_IDELEICAO.Size = new System.Drawing.Size(183, 26);
            this.TXT_IDELEICAO.TabIndex = 0;
            // 
            // TXT_IDURNA
            // 
            this.TXT_IDURNA.Location = new System.Drawing.Point(10, 207);
            this.TXT_IDURNA.Name = "TXT_IDURNA";
            this.TXT_IDURNA.Size = new System.Drawing.Size(185, 26);
            this.TXT_IDURNA.TabIndex = 1;
            // 
            // TXT_IDPESSOA
            // 
            this.TXT_IDPESSOA.Location = new System.Drawing.Point(12, 138);
            this.TXT_IDPESSOA.Name = "TXT_IDPESSOA";
            this.TXT_IDPESSOA.Size = new System.Drawing.Size(183, 26);
            this.TXT_IDPESSOA.TabIndex = 2;
            // 
            // TXT_NUMEROVOTO
            // 
            this.TXT_NUMEROVOTO.Location = new System.Drawing.Point(9, 283);
            this.TXT_NUMEROVOTO.Name = "TXT_NUMEROVOTO";
            this.TXT_NUMEROVOTO.Size = new System.Drawing.Size(186, 26);
            this.TXT_NUMEROVOTO.TabIndex = 3;
            // 
            // LBL_IDELEICAO
            // 
            this.LBL_IDELEICAO.AutoSize = true;
            this.LBL_IDELEICAO.Location = new System.Drawing.Point(23, 35);
            this.LBL_IDELEICAO.Name = "LBL_IDELEICAO";
            this.LBL_IDELEICAO.Size = new System.Drawing.Size(86, 20);
            this.LBL_IDELEICAO.TabIndex = 4;
            this.LBL_IDELEICAO.Text = "ID Eleição";
            // 
            // LBL_IDURNA
            // 
            this.LBL_IDURNA.AutoSize = true;
            this.LBL_IDURNA.Location = new System.Drawing.Point(23, 184);
            this.LBL_IDURNA.Name = "LBL_IDURNA";
            this.LBL_IDURNA.Size = new System.Drawing.Size(67, 20);
            this.LBL_IDURNA.TabIndex = 5;
            this.LBL_IDURNA.Text = "ID Urna";
            // 
            // LBL_IDPESSOA
            // 
            this.LBL_IDPESSOA.AutoSize = true;
            this.LBL_IDPESSOA.Location = new System.Drawing.Point(23, 115);
            this.LBL_IDPESSOA.Name = "LBL_IDPESSOA";
            this.LBL_IDPESSOA.Size = new System.Drawing.Size(87, 20);
            this.LBL_IDPESSOA.TabIndex = 6;
            this.LBL_IDPESSOA.Text = "ID Pessoa";
            // 
            // LBL_NUMEROVOTO
            // 
            this.LBL_NUMEROVOTO.AutoSize = true;
            this.LBL_NUMEROVOTO.Location = new System.Drawing.Point(23, 256);
            this.LBL_NUMEROVOTO.Name = "LBL_NUMEROVOTO";
            this.LBL_NUMEROVOTO.Size = new System.Drawing.Size(104, 20);
            this.LBL_NUMEROVOTO.TabIndex = 7;
            this.LBL_NUMEROVOTO.Text = "Número voto";
            // 
            // BTN_INSERIR
            // 
            this.BTN_INSERIR.Location = new System.Drawing.Point(238, 275);
            this.BTN_INSERIR.Name = "BTN_INSERIR";
            this.BTN_INSERIR.Size = new System.Drawing.Size(112, 42);
            this.BTN_INSERIR.TabIndex = 8;
            this.BTN_INSERIR.Text = "INSERIR";
            this.BTN_INSERIR.UseVisualStyleBackColor = true;
            this.BTN_INSERIR.Click += new System.EventHandler(this.BTN_INSERIR_Click_1);
            // 
            // FRMVoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 336);
            this.Controls.Add(this.BTN_INSERIR);
            this.Controls.Add(this.LBL_NUMEROVOTO);
            this.Controls.Add(this.LBL_IDPESSOA);
            this.Controls.Add(this.LBL_IDURNA);
            this.Controls.Add(this.LBL_IDELEICAO);
            this.Controls.Add(this.TXT_NUMEROVOTO);
            this.Controls.Add(this.TXT_IDPESSOA);
            this.Controls.Add(this.TXT_IDURNA);
            this.Controls.Add(this.TXT_IDELEICAO);
            this.Name = "FRMVoto";
            this.Text = "FRMVoto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_IDELEICAO;
        private System.Windows.Forms.TextBox TXT_IDURNA;
        private System.Windows.Forms.TextBox TXT_IDPESSOA;
        private System.Windows.Forms.TextBox TXT_NUMEROVOTO;
        private System.Windows.Forms.Label LBL_IDELEICAO;
        private System.Windows.Forms.Label LBL_IDURNA;
        private System.Windows.Forms.Label LBL_IDPESSOA;
        private System.Windows.Forms.Label LBL_NUMEROVOTO;
        private System.Windows.Forms.Button BTN_INSERIR;
    }
}