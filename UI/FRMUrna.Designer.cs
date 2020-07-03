namespace PadraoDeProjetoEmCamadas
{
    partial class FRMUrna
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
            this.LBL_IDURNA = new System.Windows.Forms.Label();
            this.TXT_IDURNA = new System.Windows.Forms.TextBox();
            this.TXT_NOME = new System.Windows.Forms.TextBox();
            this.LBL_NOME = new System.Windows.Forms.Label();
            this.LBL_DESCRICAO = new System.Windows.Forms.Label();
            this.LBL_IP = new System.Windows.Forms.Label();
            this.TXT_IP = new System.Windows.Forms.TextBox();
            this.TXT_DESCRICAO = new System.Windows.Forms.RichTextBox();
            this.BTN_inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_IDURNA
            // 
            this.LBL_IDURNA.AutoSize = true;
            this.LBL_IDURNA.Location = new System.Drawing.Point(57, 39);
            this.LBL_IDURNA.Name = "LBL_IDURNA";
            this.LBL_IDURNA.Size = new System.Drawing.Size(67, 20);
            this.LBL_IDURNA.TabIndex = 0;
            this.LBL_IDURNA.Text = "ID Urna";
            // 
            // TXT_IDURNA
            // 
            this.TXT_IDURNA.Location = new System.Drawing.Point(61, 77);
            this.TXT_IDURNA.Name = "TXT_IDURNA";
            this.TXT_IDURNA.Size = new System.Drawing.Size(139, 26);
            this.TXT_IDURNA.TabIndex = 1;
            // 
            // TXT_NOME
            // 
            this.TXT_NOME.Location = new System.Drawing.Point(61, 170);
            this.TXT_NOME.Name = "TXT_NOME";
            this.TXT_NOME.Size = new System.Drawing.Size(401, 26);
            this.TXT_NOME.TabIndex = 2;
            // 
            // LBL_NOME
            // 
            this.LBL_NOME.AutoSize = true;
            this.LBL_NOME.Location = new System.Drawing.Point(57, 133);
            this.LBL_NOME.Name = "LBL_NOME";
            this.LBL_NOME.Size = new System.Drawing.Size(58, 20);
            this.LBL_NOME.TabIndex = 4;
            this.LBL_NOME.Text = "Nome ";
            // 
            // LBL_DESCRICAO
            // 
            this.LBL_DESCRICAO.AutoSize = true;
            this.LBL_DESCRICAO.Location = new System.Drawing.Point(57, 226);
            this.LBL_DESCRICAO.Name = "LBL_DESCRICAO";
            this.LBL_DESCRICAO.Size = new System.Drawing.Size(86, 20);
            this.LBL_DESCRICAO.TabIndex = 5;
            this.LBL_DESCRICAO.Text = "Descrição";
            // 
            // LBL_IP
            // 
            this.LBL_IP.AutoSize = true;
            this.LBL_IP.Location = new System.Drawing.Point(275, 39);
            this.LBL_IP.Name = "LBL_IP";
            this.LBL_IP.Size = new System.Drawing.Size(24, 20);
            this.LBL_IP.TabIndex = 6;
            this.LBL_IP.Text = "IP";
            // 
            // TXT_IP
            // 
            this.TXT_IP.Location = new System.Drawing.Point(279, 77);
            this.TXT_IP.Name = "TXT_IP";
            this.TXT_IP.Size = new System.Drawing.Size(100, 26);
            this.TXT_IP.TabIndex = 7;
            // 
            // TXT_DESCRICAO
            // 
            this.TXT_DESCRICAO.Location = new System.Drawing.Point(61, 249);
            this.TXT_DESCRICAO.Name = "TXT_DESCRICAO";
            this.TXT_DESCRICAO.Size = new System.Drawing.Size(401, 150);
            this.TXT_DESCRICAO.TabIndex = 9;
            this.TXT_DESCRICAO.Text = "";
            // 
            // BTN_inserir
            // 
            this.BTN_inserir.Location = new System.Drawing.Point(418, 67);
            this.BTN_inserir.Name = "BTN_inserir";
            this.BTN_inserir.Size = new System.Drawing.Size(76, 64);
            this.BTN_inserir.TabIndex = 10;
            this.BTN_inserir.Text = "Inserir";
            this.BTN_inserir.UseVisualStyleBackColor = true;
            this.BTN_inserir.Click += new System.EventHandler(this.BTN_inserir_Click);
            // 
            // FMRUrna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.BTN_inserir);
            this.Controls.Add(this.TXT_DESCRICAO);
            this.Controls.Add(this.TXT_IP);
            this.Controls.Add(this.LBL_IP);
            this.Controls.Add(this.LBL_DESCRICAO);
            this.Controls.Add(this.LBL_NOME);
            this.Controls.Add(this.TXT_NOME);
            this.Controls.Add(this.TXT_IDURNA);
            this.Controls.Add(this.LBL_IDURNA);
            this.Name = "FMRUrna";
            this.Text = "FMRUna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_IDURNA;
        private System.Windows.Forms.TextBox TXT_IDURNA;
        private System.Windows.Forms.TextBox TXT_NOME;
        private System.Windows.Forms.Label LBL_NOME;
        private System.Windows.Forms.Label LBL_DESCRICAO;
        private System.Windows.Forms.Label LBL_IP;
        private System.Windows.Forms.TextBox TXT_IP;
        private System.Windows.Forms.RichTextBox TXT_DESCRICAO;
        private System.Windows.Forms.Button BTN_inserir;
    }
}