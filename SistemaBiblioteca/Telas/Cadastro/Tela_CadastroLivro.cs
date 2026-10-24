using SistemaBiblioteca.Util;

namespace SistemaBiblioteca.Telas.Cadastro
{
    public partial class Tela_CadastroLivro : UserControl
    {
        private int idRegistro = 0;
        public Tela_CadastroLivro()
        {
            InitializeComponent();
        }
        public Tela_CadastroLivro(int idRegistro)
        {
            InitializeComponent();
            this.idRegistro = idRegistro;
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
