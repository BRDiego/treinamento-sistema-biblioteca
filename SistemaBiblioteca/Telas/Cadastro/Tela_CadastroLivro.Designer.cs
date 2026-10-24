namespace SistemaBiblioteca.Telas.Cadastro
{
    partial class Tela_CadastroLivro
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
            Gbox_DadosCadasrto = new GroupBox();
            label2 = new Label();
            Txt_AnoPublicacao = new TextBox();
            label1 = new Label();
            Txt_Autor = new TextBox();
            Lbl_NomeLivro = new Label();
            Txt_Nome = new TextBox();
            Btn_Salvar = new Button();
            Btn_Excluir = new Button();
            groupBox1 = new GroupBox();
            Btn_Novo = new Button();
            Gbox_DadosCadasrto.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Gbox_DadosCadasrto
            // 
            Gbox_DadosCadasrto.Controls.Add(label2);
            Gbox_DadosCadasrto.Controls.Add(Txt_AnoPublicacao);
            Gbox_DadosCadasrto.Controls.Add(label1);
            Gbox_DadosCadasrto.Controls.Add(Txt_Autor);
            Gbox_DadosCadasrto.Controls.Add(Lbl_NomeLivro);
            Gbox_DadosCadasrto.Controls.Add(Txt_Nome);
            Gbox_DadosCadasrto.Location = new Point(3, 112);
            Gbox_DadosCadasrto.Name = "Gbox_DadosCadasrto";
            Gbox_DadosCadasrto.Size = new Size(990, 288);
            Gbox_DadosCadasrto.TabIndex = 2;
            Gbox_DadosCadasrto.TabStop = false;
            Gbox_DadosCadasrto.Text = "Dados cadastrais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(835, 129);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 6;
            label2.Text = "Ano Publicação";
            // 
            // Txt_AnoPublicacao
            // 
            Txt_AnoPublicacao.Font = new Font("Segoe UI", 12F);
            Txt_AnoPublicacao.Location = new Point(835, 160);
            Txt_AnoPublicacao.Name = "Txt_AnoPublicacao";
            Txt_AnoPublicacao.Size = new Size(147, 34);
            Txt_AnoPublicacao.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(6, 129);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
            label1.TabIndex = 4;
            label1.Text = "Autor";
            // 
            // Txt_Autor
            // 
            Txt_Autor.Font = new Font("Segoe UI", 12F);
            Txt_Autor.Location = new Point(6, 160);
            Txt_Autor.Name = "Txt_Autor";
            Txt_Autor.Size = new Size(823, 34);
            Txt_Autor.TabIndex = 3;
            // 
            // Lbl_NomeLivro
            // 
            Lbl_NomeLivro.AutoSize = true;
            Lbl_NomeLivro.Font = new Font("Segoe UI", 12F);
            Lbl_NomeLivro.Location = new Point(6, 48);
            Lbl_NomeLivro.Name = "Lbl_NomeLivro";
            Lbl_NomeLivro.Size = new Size(66, 28);
            Lbl_NomeLivro.TabIndex = 1;
            Lbl_NomeLivro.Text = "Nome";
            // 
            // Txt_Nome
            // 
            Txt_Nome.Font = new Font("Segoe UI", 12F);
            Txt_Nome.Location = new Point(6, 79);
            Txt_Nome.Name = "Txt_Nome";
            Txt_Nome.Size = new Size(976, 34);
            Txt_Nome.TabIndex = 0;
            // 
            // Btn_Salvar
            // 
            Btn_Salvar.Font = new Font("Segoe UI", 12F);
            Btn_Salvar.Location = new Point(259, 26);
            Btn_Salvar.Name = "Btn_Salvar";
            Btn_Salvar.Size = new Size(144, 54);
            Btn_Salvar.TabIndex = 2;
            Btn_Salvar.Text = "Salvar";
            Btn_Salvar.UseVisualStyleBackColor = true;
            Btn_Salvar.Click += Btn_Salvar_Click;
            // 
            // Btn_Excluir
            // 
            Btn_Excluir.Font = new Font("Segoe UI", 12F);
            Btn_Excluir.Location = new Point(501, 26);
            Btn_Excluir.Name = "Btn_Excluir";
            Btn_Excluir.Size = new Size(144, 54);
            Btn_Excluir.TabIndex = 7;
            Btn_Excluir.Text = "Excluir";
            Btn_Excluir.UseVisualStyleBackColor = true;
            Btn_Excluir.Click += Btn_Excluir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_Novo);
            groupBox1.Controls.Add(Btn_Excluir);
            groupBox1.Controls.Add(Btn_Salvar);
            groupBox1.Location = new Point(9, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 91);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ações";
            // 
            // Btn_Novo
            // 
            Btn_Novo.Font = new Font("Segoe UI", 12F);
            Btn_Novo.Location = new Point(17, 26);
            Btn_Novo.Name = "Btn_Novo";
            Btn_Novo.Size = new Size(144, 54);
            Btn_Novo.TabIndex = 8;
            Btn_Novo.Text = "Novo";
            Btn_Novo.UseVisualStyleBackColor = true;
            Btn_Novo.Click += Btn_Novo_Click;
            // 
            // Tela_CadastroLivro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(groupBox1);
            Controls.Add(Gbox_DadosCadasrto);
            Margin = new Padding(2);
            Name = "Tela_CadastroLivro";
            Size = new Size(1280, 720);
            Gbox_DadosCadasrto.ResumeLayout(false);
            Gbox_DadosCadasrto.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Gbox_DadosCadasrto;
        private Label label2;
        private TextBox Txt_Autor;
        private Label label1;
        private TextBox Txt_AnoPublicacao;
        private Button Btn_Salvar;
        private Label Lbl_NomeLivro;
        private TextBox Txt_Nome;
        private Button Btn_Excluir;
        private GroupBox groupBox1;
        private Button Btn_Novo;
    }
}
