using SistemaBiblioteca.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaBiblioteca.Telas.Cadastro
{
    public partial class Tela_CadastroCategoria : UserControl
    {
        private int idCategoriaAtual = 0;
        public Tela_CadastroCategoria()
        {
            InitializeComponent();
        }
        public Tela_CadastroCategoria(int idRegistro)
        {
            InitializeComponent();
            idCategoriaAtual = idRegistro;
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                FuncoesTelas.GetInstance().ExibirErro(ex);
            }
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                FuncoesTelas.GetInstance().ExibirErro(ex);
            }

        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                FuncoesTelas.GetInstance().ExibirErro(ex);
            }
        }
    }
}
