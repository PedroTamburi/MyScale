using MyScale.App.Pages;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using MyScale.Domain.Models;
using MyScale.Domain.Interfaces; 
using MyScale.App; 
using MyScale.Repository.Repository;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;


namespace MyScale.App.Pages
{
    public partial class LoginForm : LostForm
    {
        private readonly IBaseRepository<Hospital> _hospitalRepository;
        private readonly IBaseRepository<HealthAgent> _agentRepository;
        private readonly IMedicalShiftRepository _medicalShiftRepository;

        public LoginForm(
            IBaseRepository<Hospital> hospitalRepository, 
            IBaseRepository<HealthAgent> agentRepository, 
            IMedicalShiftRepository medicalShiftRepository)
        {
            InitializeComponent();

            _hospitalRepository = hospitalRepository;
            _agentRepository = agentRepository;
            _medicalShiftRepository = medicalShiftRepository;

            //tela
            pBoxEyeVisible.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void AbrirSistema()
        {
            this.Hide();

            var initialForm = new InitialForm(_hospitalRepository, _agentRepository, _medicalShiftRepository);

            if (GlobalSession.UsuarioLogado != null)
            {
                initialForm.LoadUser(GlobalSession.UsuarioLogado.Type.ToString());
            }

            initialForm.ShowDialog();
            this.Close();
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
                // 1. Tenta achar HOSPITAL
                var hospital = _hospitalRepository.Select()
                    .FirstOrDefault(h => (h.Email == email || h.CNPJ == email) && h.Password == senha);

                if (hospital != null)
                {
                    // Preenche a Sessão
                    GlobalSession.UsuarioLogado = new LoggedUser
                    {
                        Id = hospital.Id,
                        Name = hospital.Name,
                        Email = hospital.Email,
                        Type = UserType.Hospital
                    };

                    AbrirSistema(); 
                    return;
                }

                // 2. Tenta achar AGENTE DE SAÚDE
                var agente = _agentRepository.Select()
                    .FirstOrDefault(a => (a.Email == email || a.Document == email) && a.Password == senha);

                if (agente != null)
                {
                    GlobalSession.UsuarioLogado = new LoggedUser
                    {
                        Id = agente.Id,
                        Name = agente.Name,
                        Email = agente.Email,
                        Type = UserType.HealthAgent
                    };

                    AbrirSistema();
                    return;
                }

                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
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
