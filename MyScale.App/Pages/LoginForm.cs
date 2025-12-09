using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Repository.Repository;


namespace MyScale.App.Pages
{
    public partial class LoginForm : LostForm
    {
        private readonly IBaseRepository<Hospital> _hospitalRepository;
        private readonly IBaseRepository<HealthAgent> _agentRepository;
        public LoginForm(IBaseRepository<Hospital> hospitalRepository, IBaseRepository<HealthAgent> agentRepository)
        {
            InitializeComponent();

            _hospitalRepository = hospitalRepository;
            _agentRepository = agentRepository;

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void foxButton1_Click(object sender, EventArgs e)
        {
            using (var registerForm = new RegisterForm(_hospitalRepository, _agentRepository))
            {
                registerForm.ShowDialog();
            }
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var initialForm = new InitialForm();
            initialForm.ShowDialog();
            this.Close();
        }
    }
}
