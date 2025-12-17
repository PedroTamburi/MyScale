using FluentValidation;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using MyScale.Domain.Models;
using ReaLTaiizor.Forms;
using Microsoft.Extensions.DependencyInjection;
using MyScale.App.Infra; 
using MyScale.App.Pages; 
using MyScale.Domain.Entities;


namespace MyScale.App.Pages
{
    public partial class LoginForm : LostForm
    {
        private readonly IBaseRepository<Hospital> _hospitalRepository;
        private readonly IBaseRepository<HealthAgent> _agentRepository;
        private readonly IValidator<Hospital> _hospitalValidator;
        private readonly IValidator<HealthAgent> _healthAgentValidator;
        private readonly IMedicalShiftRepository _medicalShiftRepository;

        public LoginForm(
            IBaseRepository<Hospital> hospitalRepository, 
            IBaseRepository<HealthAgent> agentRepository, 
            IMedicalShiftRepository medicalShiftRepository,
            IValidator<Hospital> hospitalValidator,
            IValidator<HealthAgent> healthAgentValidator)
        {
            InitializeComponent();

            _hospitalRepository = hospitalRepository;
            _agentRepository = agentRepository;
            _hospitalValidator = hospitalValidator;
            _healthAgentValidator = healthAgentValidator;
            _medicalShiftRepository = medicalShiftRepository;

            //tela
            pBoxEyeVisible.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void AbrirSistema()
        {
            if (ConfigureDI.ServiceProvider == null)
            {
                MessageBox.Show("Erro Crítico: Serviços não configurados no Program.cs");
                return;
            }

            this.Hide();

            try
            {
                if (GlobalSession.IsHospital)
                {
                    // HOSPITAL
                    var formHospital = ConfigureDI.ServiceProvider.GetRequiredService<HospitalForm>();

                    formHospital.LoadUser(); // carrega os dados do hospital
                    formHospital.ShowDialog(); 
                }
                else
                {
                    // AGENTE DE SAÚDE
                    var formAgente = ConfigureDI.ServiceProvider.GetRequiredService<HealthAgentForm>();

                    formAgente.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o sistema: {ex.Message}");
            }
            finally
            {
                this.Close();
            }
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
                // Tenta achar Hospital
                var hospital = _hospitalRepository.Select().FirstOrDefault(h => (h.Email == email || h.CNPJ == email) && h.Password == senha);

                if (hospital != null)
                {
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

                // Tenta achar HelthAgent
                var agente = _agentRepository.Select().FirstOrDefault(a => (a.Email == email || a.Document == email) && a.Password == senha);

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
            using (var registerForm = new RegisterForm(_hospitalRepository, _agentRepository, _hospitalValidator, _healthAgentValidator))
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

    }
}
