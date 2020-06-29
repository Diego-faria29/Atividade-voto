namespace PadraoDeProjetoEmCamadas.Relatorios
{
    partial class FRMRelEleicao
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.a49gmoAH95DataSet = new PadraoDeProjetoEmCamadas.a49gmoAH95DataSet();
            this.eleicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eleicaoTableAdapter = new PadraoDeProjetoEmCamadas.a49gmoAH95DataSetTableAdapters.EleicaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.a49gmoAH95DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleicaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.eleicaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PadraoDeProjetoEmCamadas.Relatorios.RELeleicao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // a49gmoAH95DataSet
            // 
            this.a49gmoAH95DataSet.DataSetName = "a49gmoAH95DataSet";
            this.a49gmoAH95DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eleicaoBindingSource
            // 
            this.eleicaoBindingSource.DataMember = "Eleicao";
            this.eleicaoBindingSource.DataSource = this.a49gmoAH95DataSet;
            // 
            // eleicaoTableAdapter
            // 
            this.eleicaoTableAdapter.ClearBeforeFill = true;
            // 
            // FRMRelEleicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FRMRelEleicao";
            this.Text = "FRMRelEleicao";
            this.Load += new System.EventHandler(this.FRMRelEleicao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.a49gmoAH95DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleicaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private a49gmoAH95DataSet a49gmoAH95DataSet;
        private System.Windows.Forms.BindingSource eleicaoBindingSource;
        private a49gmoAH95DataSetTableAdapters.EleicaoTableAdapter eleicaoTableAdapter;
    }
}