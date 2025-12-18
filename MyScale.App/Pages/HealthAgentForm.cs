using MyScale.App;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using MyScale.Repository.Repository;
using ReaLTaiizor.Forms;
using System.Xml;

namespace MyScale.App.Pages
{
    public partial class HealthAgentForm : LostForm
    {
        private readonly IMedicalShiftRepository _medicalShiftRepository;
        private readonly IBaseRepository<HealthAgent> _agentRepository;
        public HealthAgentForm(IMedicalShiftRepository medicalShiftRepository, IBaseRepository<HealthAgent> agentRepository)
        {
            InitializeComponent();
            _medicalShiftRepository = medicalShiftRepository;
            _agentRepository = agentRepository;

            gridShifts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gridShifts.BackgroundColor = Color.White;
        }
        private void tabControlAgenteShifts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControlAgenteShifts.SelectedIndex == 1) // Aba "Meus Plantões"
            {
                CarregarMeusPlantoes();
            }
            else if (tabControlAgenteShifts.SelectedIndex == 0) // Aba "Disponíveis"
            {
                CarregarPlantoesDisponiveis();
            }
        }
        #region plantoes disponiveis
        private void HealthAgentForm_Load(object sender, EventArgs e)
        {
            this.Text = $"MyScale - Agente";

            CarregarPlantoesDisponiveis();
            CarregarDadosPerfil();
        }
        private void CarregarPlantoesDisponiveis()
        {
            try
            {
                var plantoes = _medicalShiftRepository.GetAvailableShifts();

                var listaVisual = plantoes.Select(p => new
                {
                    Id = p.Id,
                    Hospital = p.Hospital?.Name ?? "Sem Nome",
                    Data = p.Date.ToString("dd/MM/yyyy"),
                    Horario = $"{p.StartTime:HH:mm} - {p.EndTime:HH:mm}",
                    Valor = p.PaymentAmount.ToString("C2")
                }).ToList();

                gridShifts.DataSource = listaVisual;

                ConfigurarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar plantões: " + ex.Message);
            }
        }

        private void ConfigurarGrid()
        {
            if (gridShifts.Columns["Id"] != null)
            {
                gridShifts.Columns["Id"].Visible = false;
            }
            gridShifts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridShifts.MultiSelect = false;
            gridShifts.ReadOnly = true;
        }
        private void gridShifts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = gridShifts.Rows[e.RowIndex];
            if (row.Cells["Id"].Value == null) return;
            int shiftId = (int)row.Cells["Id"].Value;

            try
            {
                var plantaoDesejado = _medicalShiftRepository.Select(shiftId, new List<string> { "Hospital", "Hospital.Address" });

                if (plantaoDesejado == null) return;

                bool temConflito = _medicalShiftRepository.HasTimeConflict(
                    GlobalSession.UserId,
                    plantaoDesejado.Date,
                    plantaoDesejado.StartTime,
                    plantaoDesejado.EndTime
                );

                if (temConflito)
                {
                    MessageBox.Show(
                        "Você não pode aceitar este plantão pois já possui outro agendado neste mesmo horário (ou em horários que se cruzam)!",
                        "Conflito de Agenda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                string nomeHospital = plantaoDesejado.Hospital.Name;

                var end = plantaoDesejado.Hospital.Address;
                string rua = end.Street;
                string numero = end.Number;
                string cidade = end.City;

                string mensagem =
                    $"Deseja aceitar este plantão?\n\n" +
                    $"Hospital: {nomeHospital}\n" +
                    $"Endereço: {rua}, {numero} - {cidade}\n" +
                    $"Data: {plantaoDesejado.Date}\n" +
                    $"Horário: {plantaoDesejado.StartTime:HH:mm} às {plantaoDesejado.EndTime:HH:mm}\n" +
                    $"Valor: R$ {plantaoDesejado.PaymentAmount:F2}";

                var resultado = MessageBox.Show(
                    mensagem,
                    "Confirmar Plantão",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    plantaoDesejado.HealthAgentId = GlobalSession.UserId;
                    _medicalShiftRepository.Update(plantaoDesejado);
                    MessageBox.Show("Plantão aceito com sucesso! Bom trabalho.");
                    CarregarPlantoesDisponiveis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar: " + ex.Message);
            }
        }
        #endregion

        #region meus plantoes
        private void CarregarMeusPlantoes()
        {
            try
            {
                // 1. Busca no banco usando o ID da sessão global
                var meusPlantoes = _medicalShiftRepository.GetByHealthAgentId(GlobalSession.UserId);

                // 2. Formata para exibir no Grid
                var listaVisual = meusPlantoes.Select(p => new
                {
                    Id = p.Id,
                    Hospital = p.Hospital?.Name ?? "Sem Nome",
                    Data = p.Date.ToString("dd/MM/yyyy"),
                    Horario = $"{p.StartTime:HH:mm} - {p.EndTime:HH:mm}",
                    Valor = p.PaymentAmount.ToString("C2"),
                    Status = "Confirmado" // Só pra diferenciar visualmente
                }).ToList();

                // 3. Joga no novo Grid
                gridMyShifts.DataSource = listaVisual;

                // 4. Configura as colunas (igual fizemos no outro)
                ConfigurarGridMeusPlantoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar seus plantões: " + ex.Message);
            }
        }

        private void ConfigurarGridMeusPlantoes()
        {
            // Configurações visuais para o grid não ficar feio
            if (gridMyShifts.Columns["Id"] != null) gridMyShifts.Columns["Id"].Visible = false;

            gridMyShifts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMyShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMyShifts.MultiSelect = false;
            gridMyShifts.ReadOnly = true;

        }
        #endregion

        #region usuario
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

        private void linkLblDeleteAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var resp = MessageBox.Show(
                "ATENÇÃO: Você tem certeza que deseja EXCLUIR sua conta?\n\n" +
                "Todos os seus plantões agendados ficarão disponíveis para outros agentes.\n" +
                "Essa ação não pode ser desfeita.",
                "Excluir Conta Permanentemente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)
            {
                try
                {
                    int meuId = GlobalSession.UserId;
                    //libera plantoes do agente antes de deletar
                    _medicalShiftRepository.ReleaseShiftsByAgentId(meuId);
                    //deleta agente
                    _agentRepository.Delete(meuId);

                    MessageBox.Show("Sua conta foi excluída e os plantões foram liberados.");

                    GlobalSession.UsuarioLogado = null;
                    System.Windows.Forms.Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir conta: " + ex.Message);
                }
            }
        }

        private void CarregarDadosPerfil()
        {
            try
            {
                var agente = _agentRepository.Select(GlobalSession.UserId);

                if (agente != null)
                {
                    // Dados pessoais
                    lblName.Text = $"Nome: {agente.Name}";
                    lblEmail.Text = $"Email: {agente.Email}";
                    lblDocument.Text = $"Documento (CPF): {agente.Document}";
                    lblUsername.Text = $"Nome de usuario: {agente.Username}";
                    lblBirthDate.Text = $"Data de nascimento: {agente.BirthDate.ToString("dd/MM/yyyy")}";

                    // Endereço 
                    lblStreet.Text = $"Rua: {agente.Address.Street}";
                    lblNumber.Text = $"Nº: {agente.Address.Number}";
                    lblNeighborhood.Text = $"Bairro: {agente.Address.Neighborhood}";
                    lblCity.Text = $"Cidade: {agente.Address.City}";
                    lblState.Text = $" Estado: {agente.Address.State}";
                    lblZipCode.Text = $"CEP: {agente.Address.ZipCode}";
                    lblComplement.Text = $"Complemento: {agente.Address.Complement ?? "---"}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar perfil: " + ex.Message);
            }
        }

        private void linkLblEditInformations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var editForm = new EditAgentProfileForm(GlobalSession.UserId, _agentRepository))
            {
                var resultado = editForm.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    CarregarDadosPerfil();
                }
            }
        }
        #endregion


        private void gridMyShifts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // id da linha clicada
            var row = gridMyShifts.Rows[e.RowIndex];
            if (row.Cells["Id"].Value == null) return;

            int shiftId = (int)row.Cells["Id"].Value;

            using (var infoForm = new ShiftInformationForm(shiftId, _medicalShiftRepository))
            {
                var result = infoForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CarregarMeusPlantoes();       
                    CarregarPlantoesDisponiveis();
                }
            }
        }
    }
}
