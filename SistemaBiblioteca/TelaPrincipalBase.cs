using SistemaBiblioteca.Telas.Cadastro;
using SistemaBiblioteca.Util;

namespace SistemaBiblioteca
{
    public partial class TelaPrincipalBase : Form
    {
        private FuncoesTelas _funcoes = new FuncoesTelas();

        public TelaPrincipalBase()
        {
            InitializeComponent();
        }

        public void ExibirTela(UserControl screen)
        {
            var menuTelas = Pnl_PainelBase.Controls[menuStrip1.Name];
            Pnl_PainelBase.Controls.Clear();

            Panel screenContainer = new Panel();

            screenContainer.Size = new Size(
                screen.Width + 2,
                screen.Height + 2
            );

            screenContainer.BorderStyle = BorderStyle.FixedSingle;

            screenContainer.Left =
                (Pnl_PainelBase.ClientSize.Width - screenContainer.Width) / 2;

            screenContainer.Top =
                (Pnl_PainelBase.ClientSize.Height - screenContainer.Height) / 2;

            screen.Dock = DockStyle.Fill;

            screenContainer.Controls.Add(screen);
            Pnl_PainelBase.Controls.Add(menuTelas);
            Pnl_PainelBase.Controls.Add(screenContainer);
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ExibirTela(new Tela_CadastroLivro());
            }
            catch (Exception ex)
            {
                _funcoes.ExibirErro(ex);
            }
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ExibirTela(new Tela_CadastroCategoria());
            }
            catch (Exception ex)
            {
                _funcoes.ExibirErro(ex);
            }
        }

        private void fecharTelaAtualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var painel = Pnl_PainelBase;

                for (int index = 1; index < painel.Controls.Count; index++)
                {
                    painel.Controls.RemoveAt(index);
                }
            }
            catch (Exception ex)
            {
                _funcoes.ExibirErro(ex);
            }
        }
    }
}
