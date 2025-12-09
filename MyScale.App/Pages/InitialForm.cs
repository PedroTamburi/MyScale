using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;

namespace MyScale.App.Pages
{

    public partial class InitialForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private readonly IBaseRepository<Hospital> _hospitalRepository;
        private readonly IBaseRepository<HealthAgent> _agentRepository;
        public InitialForm(IBaseRepository<Hospital> hospitalRepository,IBaseRepository<HealthAgent> agentRepository)
        {
            InitializeComponent();

            _hospitalRepository = hospitalRepository;
            _agentRepository = agentRepository;

            //tela 
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

        private void foreverBtnRegister_Click(object sender, EventArgs e)
        {
            using (var registerForm = new RegisterForm(_hospitalRepository, _agentRepository))
            {
                registerForm.ShowDialog();
            }
            this.Show();
        }
    }
}


