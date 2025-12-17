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

            // pega os dados da linha clicada
            var row = gridShifts.Rows[e.RowIndex];

            // verifica se tem ID válido
            if (row.Cells["Id"].Value == null) return;
            int shiftId = (int)row.Cells["Id"].Value;

            try
            {
                var plantaoDesejado = _medicalShiftRepository.Select(shiftId);

                if (plantaoDesejado != null) 
                {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar horários: " + ex.Message);
                return;
            }

            // confirmação visual
            string hospital = row.Cells["Hospital"].Value.ToString();
            string data = row.Cells["Data"].Value.ToString();
            string valor = row.Cells["Valor"].Value.ToString();
            string horario = row.Cells["Horario"].Value.ToString();

            var msg = MessageBox.Show(
                $"Deseja aceitar este plantão?\n\n" +
                $"Hospital: {hospital}\n" +
                $"Data: {data}\n" +
                $"Horário: {horario}\n" +
                $"Valor: {valor}",
                "Confirmar Plantão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (msg == DialogResult.Yes)
            {
                try
                {
                    // chama o metodo de aceitar plantao
                    _medicalShiftRepository.AcceptShift(shiftId, GlobalSession.UserId);

                    MessageBox.Show("Plantão aceito com sucesso! Bom trabalho.");

                    // atualiza plantoes disp
                    CarregarPlantoesDisponiveis();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao aceitar: " + ex.Message);
                }
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


    }
}
