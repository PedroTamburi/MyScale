using MyScale.App.UseCases.Commands.Shifts;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using ReaLTaiizor.Forms;
using MyScale.Domain.Interfaces;
using MyScale.App;
using ReaLTaiizor.Manager;

namespace MyScale.App.Pages
{
    public partial class InitialForm : LostForm
    {
        private readonly IBaseRepository<Hospital> _hospitalRepository;
        private readonly IBaseRepository<HealthAgent> _agentRepository;
        private readonly IMedicalShiftRepository _medicalShiftRepository;

        private DateTime? _startTimeShiftSelected;
        private DateTime? _endTimeShiftSelected;
        private DateTime? _baseDateSelected;

        public string UserProfile { get; private set; }
        public InitialForm(
            IBaseRepository<Hospital> hospitalRepository, 
            IBaseRepository<HealthAgent> agentRepository, 
            IMedicalShiftRepository medicalShiftRepository)
        {
            InitializeComponent();

            _hospitalRepository = hospitalRepository;
            _agentRepository = agentRepository;
            _medicalShiftRepository = medicalShiftRepository;
        }

        public void LoadUser(string userType)
        {
            UserProfile = userType;
            this.Text = $"MyScale - Acesso: {userType}";
            AccessConfiguration();
        }

        private void AccessConfiguration()
        {
            if (GlobalSession.IsHospital || UserProfile == "Hospital")
            {
                tabPageHospital.Visible = true;
            }
            else
            {
                tabPageHealthAgent.Visible = true;
            }
        }
        private void Clean()
        {
            txtPaymentAmount.Text = "";
            lblPaymentAmount.Text = "Valor do pagamento: R$ __,__";
            lblDia.Text = "Dia: __/__/____";
            lblInicio.Text = "Início do plantão: __:__";
            lblFim.Text = "Fim do plantão: __:__";
            lbllDuracao.Text = "Duração: _ horas";
            _startTimeShiftSelected = null;
            _endTimeShiftSelected = null;
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            using (var formCalendario = new calendarForm())
            {
                var resultado = formCalendario.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    _startTimeShiftSelected = formCalendario.DataInicioEscolhida;
                    _endTimeShiftSelected = formCalendario.DataFimEscolhida;

                    lblDia.Text = $"Dia {_startTimeShiftSelected.Value:dd/MM/yyyy}";
                    lblInicio.Text = $"Início: {_startTimeShiftSelected.Value:HH:mm}";
                    lblFim.Text = $"Fim: {_endTimeShiftSelected.Value:HH:mm}";

                    TimeSpan duracao = _endTimeShiftSelected.Value - _startTimeShiftSelected.Value;
                    lbllDuracao.Text = $"Duração: {duracao.TotalHours} horas";
                }
            }
        }

        private void txtPaymentAmount_Leave(object sender, EventArgs e)
        {
            lblPaymentAmount.Text = $"Valor do pagamento: R$ {txtPaymentAmount.Text}";
        }

        private async void btnCriarPlantao_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validações
                if (_startTimeShiftSelected == null || _endTimeShiftSelected == null)
                {
                    MessageBox.Show("Por favor, selecione a data e o horário do plantão.",
                                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtPaymentAmount.Text))
                {
                    MessageBox.Show("Informe o valor do pagamento.");
                    return;
                }

                // 2. Recupera usuário da SESSÃO GLOBAL (MUDANÇA AQUI)
                if (GlobalSession.UsuarioLogado == null)
                {
                    MessageBox.Show("Sessão perdida. Faça login novamente.");
                    this.Close();
                    return;
                }

                // 3. Monta a Entidade DIRETAMENTE (Sem Command)
                // Convertemos o texto do valor para decimal com segurança
                if (!decimal.TryParse(txtPaymentAmount.Text, out decimal valorPagamento))
                {
                    MessageBox.Show("Valor inválido. Digite apenas números e vírgula.");
                    return;
                }

                var novoPlantao = new MedicalShift(
                    id: 0,
                    startTime: _startTimeShiftSelected.Value,
                    endTime: _endTimeShiftSelected.Value,
                    date: DateOnly.FromDateTime(_startTimeShiftSelected.Value),
                    paymentAmount: valorPagamento,
                    hospitalId: GlobalSession.UserId 
                );

                // 4. Salva usando o REPOSITÓRIO (Sem Mediator)
                await _medicalShiftRepository.AddAsync(novoPlantao);

                // 5. Sucesso
                MessageBox.Show("Plantão criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    
