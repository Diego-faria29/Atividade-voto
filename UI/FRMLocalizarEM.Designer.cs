﻿namespace PadraoDeProjetoEmCamadas
{
    partial class FRMLocalizarEM
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
            this.DGVDados = new System.Windows.Forms.DataGridView();
            this.LBLBusca = new System.Windows.Forms.Label();
            this.TXTBusca = new System.Windows.Forms.TextBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDados)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVDados
            // 
            this.DGVDados.AllowUserToAddRows = false;
            this.DGVDados.AllowUserToDeleteRows = false;
            this.DGVDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDados.Location = new System.Drawing.Point(12, 61);
            this.DGVDados.Name = "DGVDados";
            this.DGVDados.ReadOnly = true;
            this.DGVDados.Size = new System.Drawing.Size(413, 150);
            this.DGVDados.TabIndex = 4;
            this.DGVDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVDados_CellDoubleClick);
            // 
            // LBLBusca
            // 
            this.LBLBusca.AutoSize = true;
            this.LBLBusca.Location = new System.Drawing.Point(12, 19);
            this.LBLBusca.Name = "LBLBusca";
            this.LBLBusca.Size = new System.Drawing.Size(96, 13);
            this.LBLBusca.TabIndex = 5;
            this.LBLBusca.Text = "Localizar por nome";
            // 
            // TXTBusca
            // 
            this.TXTBusca.Location = new System.Drawing.Point(12, 35);
            this.TXTBusca.Name = "TXTBusca";
            this.TXTBusca.Size = new System.Drawing.Size(332, 20);
            this.TXTBusca.TabIndex = 6;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(350, 32);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscar.TabIndex = 7;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // LocalizarEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 221);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.TXTBusca);
            this.Controls.Add(this.LBLBusca);
            this.Controls.Add(this.DGVDados);
            this.Name = "LocalizarEM";
            this.Text = "LocalizarEM";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView DGVDados;
        private System.Windows.Forms.Label LBLBusca;
        private System.Windows.Forms.TextBox TXTBusca;
        private System.Windows.Forms.Button BTNBuscar;
    }
}