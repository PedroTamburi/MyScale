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
            poisonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gridShifts.BorderStyle = System.Windows.Forms.BorderStyle.None;

            _hospitalRepository = hospitalRepository;
            _agentRepository = agentRepository;
            _medicalShiftRepository = medicalShiftRepository;
        }
        #region criar plantão
        #region metodos
        public void LoadUser(string userType)
        {
            UserProfile = userType;
            this.Text = $"MyScale - Acesso: {userType}";
            AccessConfiguration();
            if (GlobalSession.IsHospital)
            {
                CarregarPlantoesHospital(); 
            }
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
        #endregion
        #region eventos
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

                if (GlobalSession.UsuarioLogado == null)
                {
                    MessageBox.Show("Sessão perdida. Faça login novamente.");
                    this.Close();
                    return;
                }

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
                await _medicalShiftRepository.AddAsync(novoPlantao);

                MessageBox.Show("Plantão criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
                CarregarPlantoesHospital();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #endregion

        #region consultar plantões
        private async void CarregarPlantoesHospital()
        {
            try
            {
                if (!GlobalSession.IsHospital) return;

                var listaPlantoes = await _medicalShiftRepository.GetByHospitalIdAsync(GlobalSession.UserId);

                gridShifts.DataSource = listaPlantoes;

                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar plantões: {ex.Message}");
            }
        }

        private void ConfigurarGrid()
        {
            // 1. LIMPEZA GERAL
            gridShifts.AutoGenerateColumns = true;
            gridShifts.ReadOnly = true;            
            gridShifts.AllowUserToAddRows = false; 
            gridShifts.AllowUserToDeleteRows = false;
            gridShifts.MultiSelect = false;
            gridShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            gridShifts.RowHeadersVisible = false;  
            gridShifts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. ESTILO DO CABEÇALHO
            gridShifts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridShifts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridShifts.ColumnHeadersHeight = 35;
            gridShifts.EnableHeadersVisualStyles = false; 
            gridShifts.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;

            // 3. OCULTAR COLUNAS TÉCNICAS (IDs, Chaves estrangeiras, Datas de log)
            OcultarColuna("Id");
            OcultarColuna("HospitalId");
            OcultarColuna("HealthAgentId");
            OcultarColuna("Hospital");    
            OcultarColuna("HealthAgent"); 
            OcultarColuna("CreatedDate");
            OcultarColuna("UpdatedDate");

            // 4. FORMATAR E RENOMEAR COLUNAS 
            ConfigurarColuna("Date", "Data", "dd/MM/yyyy");
            ConfigurarColuna("StartTime", "Início", "HH:mm");
            ConfigurarColuna("EndTime", "Fim", "HH:mm"); 
            ConfigurarColuna("PaymentAmount", "Valor", "C2");
            ConfigurarColuna("IsOpen", "Disponível", "null");

            if (gridShifts.Columns["Date"] != null) gridShifts.Columns["Date"].DisplayIndex = 0;
            if (gridShifts.Columns["StartTime"] != null) gridShifts.Columns["StartTime"].DisplayIndex = 1;
            if (gridShifts.Columns["EndTime"] != null) gridShifts.Columns["EndTime"].DisplayIndex = 2;

        }

        private void OcultarColuna(string nomeColuna)
        {
            if (gridShifts.Columns[nomeColuna] != null)
            {
                gridShifts.Columns[nomeColuna].Visible = false;
            }
        }

        private void ConfigurarColuna(string nomeColuna, string novoTitulo, string formato)
        {
            if (gridShifts.Columns[nomeColuna] != null)
            {
                gridShifts.Columns[nomeColuna].HeaderText = novoTitulo;
                gridShifts.Columns[nomeColuna].DefaultCellStyle.Format = formato;
                gridShifts.Columns[nomeColuna].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        #endregion

        #region editar plantoes
        private void gridShifts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (gridShifts.Rows[e.RowIndex].Cells["Id"].Value is int idPlantao)
            {
                using (var editForm = new EditShiftForm(idPlantao, _medicalShiftRepository))
                {
                    var resultado = editForm.ShowDialog();

                    if (resultado == DialogResult.OK)
                    {
                        CarregarPlantoesHospital();
                    }
                }
            }
        }
        #endregion
    }
}
    
