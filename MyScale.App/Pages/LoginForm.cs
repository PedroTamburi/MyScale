using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Repository.Repository;
using MyScale.App.Pages;


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

            //tela
            pBoxEyeVisible.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha e-mail e senha!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // --- TENTATIVA 1: É UM HOSPITAL? ---
                var hospital = _hospitalRepository.Select().FirstOrDefault(h => h.Email == email && h.Password == senha);

                if (hospital != null)
                {
                    AbrirSistema("Hospital");
                    return;
                }

                // --- TENTATIVA 2: É UM AGENTE? ---
                // Nota: Agentes as vezes logam com CPF. Se quiser permitir CPF ou Email:
                // .FirstOrDefault(a => (a.Email == email || a.Document == email) && a.Password == senha);
                var agente = _agentRepository.Select()
                    .FirstOrDefault(a => a.Email == email && a.Password == senha);

                if (agente != null)
                {
                    AbrirSistema("HealthAgent");
                    return;
                }

                // --- NÃO ACHOU NINGUÉM ---
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro de conexão: {ex.Message}");
            }
        }
        private void foxButton1_Click(object sender, EventArgs e)
        {
            using (var registerForm = new RegisterForm(_hospitalRepository, _agentRepository))
            {
                registerForm.ShowDialog();
            }
            this.Show();
        }

        private void AbrirSistema(string perfil)
        {
            this.Hide();

            var initialForm = new InitialForm(_hospitalRepository, _agentRepository);

            // --- AQUI ESTÁ A MÁGICA ---
            // Passamos a função do usuário
            initialForm.LoadUser(perfil);
            initialForm.ShowDialog(); // Abre o sistema e trava o código aqui até fechar

            this.Close(); // Fecha o login quando o sistema fechar
        }

        private void pBoxEyeHidden_Click(object sender, EventArgs e)
        {
            pBoxEyeHidden.Visible = false;
            pBoxEyeVisible.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
        }

        private void pBoxEyeVisible_Click(object sender, EventArgs e)
        {
            pBoxEyeHidden.Visible = true;
            pBoxEyeVisible.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
