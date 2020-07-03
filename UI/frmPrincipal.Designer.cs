namespace PadraoDeProjetoEmCamadas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeEleiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatoriosPrincipal,
            this.inserirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(796, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.eleiçãoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // eleiçãoToolStripMenuItem
            // 
            this.eleiçãoToolStripMenuItem.Name = "eleiçãoToolStripMenuItem";
            this.eleiçãoToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.eleiçãoToolStripMenuItem.Text = "Eleição";
            this.eleiçãoToolStripMenuItem.Click += new System.EventHandler(this.eleiçãoToolStripMenuItem_Click);
            // 
            // relatoriosPrincipal
            // 
            this.relatoriosPrincipal.BackColor = System.Drawing.Color.Black;
            this.relatoriosPrincipal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem1,
            this.relatórioDeEleiçãoToolStripMenuItem});
            this.relatoriosPrincipal.ForeColor = System.Drawing.Color.White;
            this.relatoriosPrincipal.Name = "relatoriosPrincipal";
            this.relatoriosPrincipal.Size = new System.Drawing.Size(90, 24);
            this.relatoriosPrincipal.Text = "Relatórios";
            // 
            // empresaToolStripMenuItem1
            // 
            this.empresaToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.empresaToolStripMenuItem1.Name = "empresaToolStripMenuItem1";
            this.empresaToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.empresaToolStripMenuItem1.Text = "Relatório de Empresa";
            this.empresaToolStripMenuItem1.Click += new System.EventHandler(this.empresaToolStripMenuItem1_Click);
            // 
            // relatórioDeEleiçãoToolStripMenuItem
            // 
            this.relatórioDeEleiçãoToolStripMenuItem.Name = "relatórioDeEleiçãoToolStripMenuItem";
            this.relatórioDeEleiçãoToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.relatórioDeEleiçãoToolStripMenuItem.Text = "Relatório de Eleição";
            this.relatórioDeEleiçãoToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeEleiçãoToolStripMenuItem_Click);
            // 
            // inserirToolStripMenuItem
            // 
            this.inserirToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.inserirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urnaToolStripMenuItem,
            this.votoToolStripMenuItem,
            this.eleitorToolStripMenuItem,
            this.candidatoToolStripMenuItem});
            this.inserirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.inserirToolStripMenuItem.Name = "inserirToolStripMenuItem";
            this.inserirToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.inserirToolStripMenuItem.Text = "Inserir";
            // 
            // urnaToolStripMenuItem
            // 
            this.urnaToolStripMenuItem.Name = "urnaToolStripMenuItem";
            this.urnaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.urnaToolStripMenuItem.Text = "Urna";
            this.urnaToolStripMenuItem.Click += new System.EventHandler(this.urnaToolStripMenuItem_Click);
            // 
            // votoToolStripMenuItem
            // 
            this.votoToolStripMenuItem.Name = "votoToolStripMenuItem";
            this.votoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.votoToolStripMenuItem.Text = "Voto";
            this.votoToolStripMenuItem.Click += new System.EventHandler(this.votoToolStripMenuItem_Click);
            // 
            // eleitorToolStripMenuItem
            // 
            this.eleitorToolStripMenuItem.Name = "eleitorToolStripMenuItem";
            this.eleitorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eleitorToolStripMenuItem.Text = "Eleitor";
            this.eleitorToolStripMenuItem.Click += new System.EventHandler(this.eleitorToolStripMenuItem_Click);
            // 
            // candidatoToolStripMenuItem
            // 
            this.candidatoToolStripMenuItem.Name = "candidatoToolStripMenuItem";
            this.candidatoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.candidatoToolStripMenuItem.Text = "Candidato";
            this.candidatoToolStripMenuItem.Click += new System.EventHandler(this.candidatoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 465);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosPrincipal;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeEleiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatoToolStripMenuItem;
    }
}