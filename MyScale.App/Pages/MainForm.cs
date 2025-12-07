using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Util;

namespace MyScale.App.Pages
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public MainForm()
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