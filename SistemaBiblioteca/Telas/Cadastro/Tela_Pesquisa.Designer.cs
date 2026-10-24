namespace SistemaBiblioteca.Telas.Cadastro
{
    partial class Tela_Pesquisa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Page_BuscaLivro = new TabPage();
            Lbl_NomeLivro = new Label();
            Txt_NomeLivro = new TextBox();
            Page_Categoria = new TabPage();
            Lbl_NomeCategoria = new Label();
            Txt_NomeCategoria = new TextBox();
            Grd_ResultadoBusca = new DataGridView();
            Btn_Pesquisar = new Button();
            tabControl1.SuspendLayout();
            Page_BuscaLivro.SuspendLayout();
            Page_Categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Grd_ResultadoBusca).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Page_BuscaLivro);
            tabControl1.Controls.Add(Page_Categoria);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1175, 139);
            tabControl1.TabIndex = 0;
            // 
            // Page_BuscaLivro
            // 
            Page_BuscaLivro.Controls.Add(Lbl_NomeLivro);
            Page_BuscaLivro.Controls.Add(Txt_NomeLivro);
            Page_BuscaLivro.Location = new Point(4, 29);
            Page_BuscaLivro.Name = "Page_BuscaLivro";
            Page_BuscaLivro.Padding = new Padding(3);
            Page_BuscaLivro.Size = new Size(1167, 106);
            Page_BuscaLivro.TabIndex = 0;
            Page_BuscaLivro.Text = "Livro";
            Page_BuscaLivro.UseVisualStyleBackColor = true;
            // 
            // Lbl_NomeLivro
            // 
            Lbl_NomeLivro.AutoSize = true;
            Lbl_NomeLivro.Font = new Font("Segoe UI", 12F);
            Lbl_NomeLivro.Location = new Point(6, 20);
            Lbl_NomeLivro.Name = "Lbl_NomeLivro";
            Lbl_NomeLivro.Size = new Size(66, 28);
            Lbl_NomeLivro.TabIndex = 2;
            Lbl_NomeLivro.Text = "Nome";
            // 
            // Txt_NomeLivro
            // 
            Txt_NomeLivro.Font = new Font("Segoe UI", 12F);
            Txt_NomeLivro.Location = new Point(6, 51);
            Txt_NomeLivro.Name = "Txt_NomeLivro";
            Txt_NomeLivro.Size = new Size(976, 34);
            Txt_NomeLivro.TabIndex = 1;
            // 
            // Page_Categoria
            // 
            Page_Categoria.Controls.Add(Lbl_NomeCategoria);
            Page_Categoria.Controls.Add(Txt_NomeCategoria);
            Page_Categoria.Location = new Point(4, 29);
            Page_Categoria.Name = "Page_Categoria";
            Page_Categoria.Padding = new Padding(3);
            Page_Categoria.Size = new Size(1167, 106);
            Page_Categoria.TabIndex = 1;
            Page_Categoria.Text = "Categoria";
            Page_Categoria.UseVisualStyleBackColor = true;
            // 
            // Lbl_NomeCategoria
            // 
            Lbl_NomeCategoria.AutoSize = true;
            Lbl_NomeCategoria.Font = new Font("Segoe UI", 12F);
            Lbl_NomeCategoria.Location = new Point(6, 16);
            Lbl_NomeCategoria.Name = "Lbl_NomeCategoria";
            Lbl_NomeCategoria.Size = new Size(66, 28);
            Lbl_NomeCategoria.TabIndex = 4;
            Lbl_NomeCategoria.Text = "Nome";
            // 
            // Txt_NomeCategoria
            // 
            Txt_NomeCategoria.Font = new Font("Segoe UI", 12F);
            Txt_NomeCategoria.Location = new Point(6, 47);
            Txt_NomeCategoria.Name = "Txt_NomeCategoria";
            Txt_NomeCategoria.Size = new Size(976, 34);
            Txt_NomeCategoria.TabIndex = 3;
            // 
            // Grd_ResultadoBusca
            // 
            Grd_ResultadoBusca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grd_ResultadoBusca.Location = new Point(7, 205);
            Grd_ResultadoBusca.Name = "Grd_ResultadoBusca";
            Grd_ResultadoBusca.RowHeadersWidth = 51;
            Grd_ResultadoBusca.Size = new Size(1167, 453);
            Grd_ResultadoBusca.TabIndex = 1;
            // 
            // Btn_Pesquisar
            // 
            Btn_Pesquisar.Location = new Point(1009, 148);
            Btn_Pesquisar.Name = "Btn_Pesquisar";
            Btn_Pesquisar.Size = new Size(165, 51);
            Btn_Pesquisar.TabIndex = 2;
            Btn_Pesquisar.Text = "Pesquisar";
            Btn_Pesquisar.UseVisualStyleBackColor = true;
            Btn_Pesquisar.Click += Btn_Pesquisar_Click;
            // 
            // Tela_Pesquisa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Btn_Pesquisar);
            Controls.Add(Grd_ResultadoBusca);
            Controls.Add(tabControl1);
            Name = "Tela_Pesquisa";
            Size = new Size(1181, 661);
            tabControl1.ResumeLayout(false);
            Page_BuscaLivro.ResumeLayout(false);
            Page_BuscaLivro.PerformLayout();
            Page_Categoria.ResumeLayout(false);
            Page_Categoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Grd_ResultadoBusca).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Page_BuscaLivro;
        private TabPage Page_Categoria;
        private DataGridView Grd_ResultadoBusca;
        private Button Btn_Pesquisar;
        private TextBox Txt_NomeLivro;
        private Label Lbl_NomeLivro;
        private Label Lbl_NomeCategoria;
        private TextBox Txt_NomeCategoria;
    }
}
