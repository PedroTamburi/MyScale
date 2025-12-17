using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using ReaLTaiizor.Forms;
using MyScale.Domain.Interfaces;
using MyScale.App;
using ReaLTaiizor.Manager;

namespace MyScale.App.Pages
{
    public partial class HospitalForm : LostForm
    {
        private readonly IBaseRepository<Hospital> _hospitalRepository;
        private readonly IMedicalShiftRepository _medicalShiftRepository;

        private DateTime? _startTimeShiftSelected;
        private DateTime? _endTimeShiftSelected;

        public HospitalForm(
            IBaseRepository<Hospital> hospitalRepository,
            IMedicalShiftRepository medicalShiftRepository)
        {
            InitializeComponent();

            // tela
            poisonPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            gridShifts.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // DI
            _hospitalRepository = hospitalRepository;
            _medicalShiftRepository = medicalShiftRepository;
        }

        #region Métodos de Carregamento (LoadUser)

        public async void LoadUser()
        {
            this.Text = $"MyScale - Hospital";

            await CarregarPlantoesHospital();
            CarregarDadosPerfil();
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

        #region Criar Plantão (Lógica do Calendário e Botão)

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
                await CarregarPlantoesHospital(); // Atualiza a lista
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Consultar Plantões (Grid)

        private async Task CarregarPlantoesHospital()
        {
            try
            {
                // Busca plantões criados por este hospital (GlobalSession.UserId)
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
            gridShifts.AutoGenerateColumns = true;
            gridShifts.ReadOnly = true;
            gridShifts.AllowUserToAddRows = false;
            gridShifts.AllowUserToDeleteRows = false;
            gridShifts.MultiSelect = false;
            gridShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridShifts.RowHeadersVisible = false;
            gridShifts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilo
            gridShifts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            gridShifts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridShifts.ColumnHeadersHeight = 35;
            gridShifts.EnableHeadersVisualStyles = false;
            gridShifts.ColumnHeadersDefaultCellStyle.BackColor = Color.SeaGreen;

            // Colunas para Ocultar
            OcultarColuna("Id");
            OcultarColuna("HospitalId");
            OcultarColuna("HealthAgentId");
            OcultarColuna("Hospital");
            OcultarColuna("HealthAgent");
            OcultarColuna("CreatedDate");
            OcultarColuna("UpdatedDate");

            // Colunas para Formatar
            ConfigurarColuna("Date", "Data", "dd/MM/yyyy");
            ConfigurarColuna("StartTime", "Início", "HH:mm");
            ConfigurarColuna("EndTime", "Fim", "HH:mm");
            ConfigurarColuna("PaymentAmount", "Valor", "C2");
            ConfigurarColuna("IsOpen", "Disponível", "null"); // True/False

            // Ordem
            if (gridShifts.Columns["Date"] != null) gridShifts.Columns["Date"].DisplayIndex = 0;
            if (gridShifts.Columns["StartTime"] != null) gridShifts.Columns["StartTime"].DisplayIndex = 1;
            if (gridShifts.Columns["EndTime"] != null) gridShifts.Columns["EndTime"].DisplayIndex = 2;
        }

        private void OcultarColuna(string nomeColuna)
        {
            if (gridShifts.Columns[nomeColuna] != null)
                gridShifts.Columns[nomeColuna].Visible = false;
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
                        _ = CarregarPlantoesHospital();
                    }
                }
            }
        }
        #endregion

        #region Perfil do Hospital

        private void CarregarDadosPerfil()
        {
            try
            {
                var hospital = _hospitalRepository.Select(GlobalSession.UserId);

                if (hospital != null)
                {
                    lblName.Text = $"Nome: {hospital.Name}";
                    lblMunicipalRegistry.Text = $"Registro Municipal: {hospital.MunicipalRegistry}";
                    lblCNPJ.Text = $"CNPJ: {hospital.CNPJ}";
                    lblFoundationDate.Text = $"Data de fundação: {hospital.FoundationDate:dd/MM/yyyy}";
                    lblEmail.Text = $"Email: {hospital.Email}";
                    lblUsername.Text = hospital.Username;

                    // Endereço
                    lblStreet.Text = $"Rua: {hospital.Address.Street}";
                    lblNumber.Text = $"Numero: {hospital.Address.Number}";
                    lblNeighborhood.Text = $"Bairro: {hospital.Address.Neighborhood}";
                    lblCity.Text = $"Cidade: {hospital.Address.City}";
                    lblState.Text = $"Estado: {hospital.Address.State}";
                    lblZipCode.Text = $"CEP: {hospital.Address.ZipCode}";
                    lblComplement.Text = $"Complemento: {hospital.Address.Complement}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar perfil: {ex.Message}");
            }
        }

        private void labelEdit4_Click(object sender, EventArgs e)
        {
            using (var formEdicao = new EditHospitalProfileForm(GlobalSession.UserId, _hospitalRepository))
            {
                var resultado = formEdicao.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    CarregarDadosPerfil();
                }
            }
        }

        private async void lblExcluirConta_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show(
                "ATENÇÃO: Você está prestes a excluir sua conta permanentemente.\n\n" +
                "Isso apagará seus dados, seu endereço e TODOS os plantões cadastrados.\n\n" +
                "Tem certeza absoluta que deseja continuar?",
                "Excluir Conta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    // 1. Apaga plantões
                    var plantoes = await _medicalShiftRepository.GetByHospitalIdAsync(GlobalSession.UserId);
                    foreach (var plantao in plantoes)
                    {
                        await _medicalShiftRepository.DeleteAsync(plantao.Id);
                    }

                    // 2. Apaga o Hospital
                    _hospitalRepository.Delete(GlobalSession.UserId);

                    MessageBox.Show("Conta excluída com sucesso.", "Adeus!");
                    System.Windows.Forms.Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir: {ex.Message}");
                }
            }
        }

        private void linkLblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var resposta = MessageBox.Show(
                "Tem certeza que deseja sair do sistema?",
                "Fazer Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                GlobalSession.UsuarioLogado = null;

                System.Windows.Forms.Application.Restart();
            }
        }
        #endregion
    }
}