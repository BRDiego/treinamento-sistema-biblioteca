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
    public partial class Tela_Pesquisa : UserControl
    {
        public Tela_Pesquisa()
        {
            InitializeComponent();
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
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
