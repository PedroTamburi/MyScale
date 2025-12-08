using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Util;

namespace MyScale.App.Pages
{

    public partial class InitialForm : MaterialForm
    {
        /// <summary>
        /// Centraliza o controle apenas na linha horizontal (Esquerda <-> Direita)
        /// Mantém a altura (Y) onde ela já estava.
        /// </summary>
        private void CentralizarHorizontalmente(Control controle)
        {
            if (controle == null) return;

            // A conta é: (Largura da Janela - Largura do Controle) / 2
            int x = (this.ClientSize.Width - controle.Width) / 2;

            // Atualiza apenas o Left (X), mantém o Top (Y) original
            controle.Left = x;
        }

        /// <summary>
        /// Centraliza o controle apenas na linha vertical (Topo <-> Baixo)
        /// Mantém a posição lateral (X) onde ela já estava.
        /// </summary>
        private void CentralizarVerticalmente(Control controle)
        {
            if (controle == null) return;

            // A conta é: (Altura da Janela - Altura do Controle) / 2
            int y = (this.ClientSize.Height - controle.Height) / 2;

            // Atualiza apenas o Top (Y), mantém o Left (X) original
            controle.Top = y;
        }
        private readonly MaterialSkinManager materialSkinManager;
        public InitialForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new MaterialColorScheme(
                MaterialPrimary.Teal500,
                MaterialPrimary.Teal700,
                MaterialPrimary.Teal100,
                MaterialAccent.LightBlue200,
                MaterialTextShade.WHITE
            );

        }
    }
}


