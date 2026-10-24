namespace SistemaBiblioteca.Telas.Cadastro
{
    partial class Tela_CadastroCategoria
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
            groupBox1 = new GroupBox();
            Btn_Novo = new Button();
            Btn_Excluir = new Button();
            Btn_Salvar = new Button();
            Gbox_DadosCadasrto = new GroupBox();
            Lbl_NomeLivro = new Label();
            Txt_NomeCategoria = new TextBox();
            groupBox1.SuspendLayout();
            Gbox_DadosCadasrto.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_Novo);
            groupBox1.Controls.Add(Btn_Excluir);
            groupBox1.Controls.Add(Btn_Salvar);
            groupBox1.Location = new Point(14, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(984, 91);
            groupBox1.TabIndex = 5;
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
            // Gbox_DadosCadasrto
            // 
            Gbox_DadosCadasrto.Controls.Add(Lbl_NomeLivro);
            Gbox_DadosCadasrto.Controls.Add(Txt_NomeCategoria);
            Gbox_DadosCadasrto.Location = new Point(8, 100);
            Gbox_DadosCadasrto.Name = "Gbox_DadosCadasrto";
            Gbox_DadosCadasrto.Size = new Size(990, 138);
            Gbox_DadosCadasrto.TabIndex = 4;
            Gbox_DadosCadasrto.TabStop = false;
            Gbox_DadosCadasrto.Text = "Dados cadastrais";
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
            // Txt_NomeCategoria
            // 
            Txt_NomeCategoria.Font = new Font("Segoe UI", 12F);
            Txt_NomeCategoria.Location = new Point(6, 79);
            Txt_NomeCategoria.Name = "Txt_NomeCategoria";
            Txt_NomeCategoria.Size = new Size(976, 34);
            Txt_NomeCategoria.TabIndex = 0;
            // 
            // Tela_CadastroCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(Gbox_DadosCadasrto);
            Name = "Tela_CadastroCategoria";
            Size = new Size(1131, 489);
            groupBox1.ResumeLayout(false);
            Gbox_DadosCadasrto.ResumeLayout(false);
            Gbox_DadosCadasrto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button Btn_Novo;
        private Button Btn_Excluir;
        private Button Btn_Salvar;
        private GroupBox Gbox_DadosCadasrto;
        private Label Lbl_NomeLivro;
        private TextBox Txt_NomeCategoria;
    }
}
