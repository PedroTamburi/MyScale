using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;

namespace MyScale.App.Pages
{
    public partial class InitialForm : LostForm
    {
        private readonly IBaseRepository<Hospital> _hospitalRepository;
        private readonly IBaseRepository<HealthAgent> _agentRepository;

        public string UserProfile { get; private set; }
        public InitialForm(IBaseRepository<Hospital> hospitalRepository, IBaseRepository<HealthAgent> agentRepository)
        {
            InitializeComponent();

            _hospitalRepository = hospitalRepository;
            _agentRepository = agentRepository;
        }
        
        public void LoadUser(string userType)
        {
            UserProfile = userType;

            this.Text = $"MyScale - Acesso: {userType}";

            AccessConfiguration();
        }
        private void AccessConfiguration()
        {
            // Supondo que seu TabControl se chame 'materialTabControl1'
            if (UserProfile == "Hospital")
            {
                tabPageHospital.Visible = true;
                // materialTabControl1.TabPages.Remove(tabAgenteMinhasVisitas);
            }
            else if (UserProfile == "HealthAgent")
            {
                tabPageHealthAgent.Visible = true;
                // materialTabControl1.TabPages.Remove(tabHospitalGestaoEquipe);
            }
        }

    }
}
