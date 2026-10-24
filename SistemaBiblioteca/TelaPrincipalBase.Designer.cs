namespace SistemaBiblioteca
{
    partial class TelaPrincipalBase
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
            components = new System.ComponentModel.Container();
            Pnl_PainelBase = new Panel();
            menuStrip1 = new MenuStrip();
            casdastrosToolStripMenuItem = new ToolStripMenuItem();
            livrosToolStripMenuItem = new ToolStripMenuItem();
            categoriaToolStripMenuItem = new ToolStripMenuItem();
            operacioanlToolStripMenuItem = new ToolStripMenuItem();
            estoqueToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            fecharTelaAtualToolStripMenuItem = new ToolStripMenuItem();
            Pnl_PainelBase.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_PainelBase
            // 
            Pnl_PainelBase.Controls.Add(menuStrip1);
            Pnl_PainelBase.Dock = DockStyle.Fill;
            Pnl_PainelBase.Location = new Point(0, 0);
            Pnl_PainelBase.Margin = new Padding(2, 2, 2, 2);
            Pnl_PainelBase.Name = "Pnl_PainelBase";
            Pnl_PainelBase.Size = new Size(1006, 531);
            Pnl_PainelBase.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { casdastrosToolStripMenuItem, operacioanlToolStripMenuItem, estoqueToolStripMenuItem, fecharTelaAtualToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1006, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // casdastrosToolStripMenuItem
            // 
            casdastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { livrosToolStripMenuItem, categoriaToolStripMenuItem });
            casdastrosToolStripMenuItem.Name = "casdastrosToolStripMenuItem";
            casdastrosToolStripMenuItem.Size = new Size(88, 24);
            casdastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // livrosToolStripMenuItem
            // 
            livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            livrosToolStripMenuItem.Size = new Size(157, 26);
            livrosToolStripMenuItem.Text = "Livros";
            livrosToolStripMenuItem.Click += livrosToolStripMenuItem_Click;
            // 
            // categoriaToolStripMenuItem
            // 
            categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            categoriaToolStripMenuItem.Size = new Size(157, 26);
            categoriaToolStripMenuItem.Text = "Categoria";
            categoriaToolStripMenuItem.Click += categoriaToolStripMenuItem_Click;
            // 
            // operacioanlToolStripMenuItem
            // 
            operacioanlToolStripMenuItem.Name = "operacioanlToolStripMenuItem";
            operacioanlToolStripMenuItem.Size = new Size(104, 24);
            operacioanlToolStripMenuItem.Text = "Operacional";
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new Size(76, 24);
            estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // fecharTelaAtualToolStripMenuItem
            // 
            fecharTelaAtualToolStripMenuItem.Name = "fecharTelaAtualToolStripMenuItem";
            fecharTelaAtualToolStripMenuItem.Size = new Size(132, 24);
            fecharTelaAtualToolStripMenuItem.Text = "Fechar tela atual";
            fecharTelaAtualToolStripMenuItem.Click += fecharTelaAtualToolStripMenuItem_Click;
            // 
            // TelaPrincipalBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 531);
            Controls.Add(Pnl_PainelBase);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "TelaPrincipalBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipalBase";
            WindowState = FormWindowState.Maximized;
            Pnl_PainelBase.ResumeLayout(false);
            Pnl_PainelBase.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnl_PainelBase;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem casdastrosToolStripMenuItem;
        private ToolStripMenuItem livrosToolStripMenuItem;
        private ToolStripMenuItem operacioanlToolStripMenuItem;
        private ToolStripMenuItem estoqueToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem categoriaToolStripMenuItem;
        private ToolStripMenuItem fecharTelaAtualToolStripMenuItem;
    }
}