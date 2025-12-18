using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using ReaLTaiizor.Forms;

namespace MyScale.App.Pages
{
    public partial class EditShiftForm : Form
    {

        private readonly IMedicalShiftRepository _repository;
        private readonly int _shiftId;
        private MedicalShift _plantaoAtual;

        // variaveis temporarias para edicao
        private DateTime _novaDataInicio;
        private DateTime _novaDataFim;

        //recebe o Id e o repositorio do plantao a ser editado
        public EditShiftForm(int shiftId, IMedicalShiftRepository repository)
        {
            InitializeComponent();
            _shiftId = shiftId;
            _repository = repository;
        }
        private void EditShiftForm_Load(object sender, EventArgs e)
        {
            try
            {
                _plantaoAtual = _repository.Select(_shiftId);

                if (_plantaoAtual == null)
                {
                    MessageBox.Show("Plantão não encontrado!");
                    this.Close();
                    return;
                }

                _novaDataInicio = _plantaoAtual.StartTime;
                _novaDataFim = _plantaoAtual.EndTime;

                txtPaymentAmount.Text = _plantaoAtual.PaymentAmount.ToString("F2");
                AtualizarLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar: {ex.Message}");
            }
        }

        private void AtualizarLabels()
        {
            lblDate.Text = $"Dia: {_novaDataInicio:dd/MM/yyyy}";
            lblStartTime.Text = $"Início: {_novaDataInicio:HH:mm}";
            lblEndTime.Text = $"Fim: {_novaDataFim:HH:mm}";
            txtPaymentAmount.Text = $"{txtPaymentAmount.Text}";
        }

        private void btnChangeDate_Click(object sender, EventArgs e)
        {
            using (var calendario = new calendarForm())
            {
                if (calendario.ShowDialog() == DialogResult.OK)
                {
                    _novaDataInicio = calendario.DataInicioEscolhida;
                    _novaDataFim = calendario.DataFimEscolhida;
                    AtualizarLabels();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // valida valor
                if (!decimal.TryParse(txtPaymentAmount.Text, out decimal novoValor))
                {
                    MessageBox.Show("Valor inválido. Digite somente números e vírgula!");
                    return;
                }
                
                // valida horario
                if (_novaDataInicio.TimeOfDay >= _novaDataFim.TimeOfDay)
                {
                    MessageBox.Show("O horário final deve ser maior que o inicial.");
                    return;
                }

                _plantaoAtual.StartTime = _novaDataInicio;
                _plantaoAtual.EndTime = _novaDataFim;
                _plantaoAtual.Date = DateOnly.FromDateTime(_novaDataInicio);
                _plantaoAtual.PaymentAmount = novoValor;

                _repository.Update(_plantaoAtual);

                MessageBox.Show("Plantão atualizado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (_plantaoAtual.HealthAgentId != null)
            {
                MessageBox.Show("Você não pode excluir um plantão que já foi aceito por um agente!");
                return;
            }

            var confirm = MessageBox.Show("Tem certeza que deseja excluir este plantão?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                _repository.Delete(_shiftId);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

