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
        private async void EditShiftForm_Load(object sender, EventArgs e)
        {
            try
            {
                _plantaoAtual = await _repository.GetByIdAsync(_shiftId);

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

        private async void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtPaymentAmount.Text, out decimal novoValor))
                {
                    MessageBox.Show("Valor inválido. Digite somente números e virgula!");
                    return;
                }

                _plantaoAtual.Update(
                    _novaDataInicio,
                    _novaDataFim,
                    DateOnly.FromDateTime(_novaDataInicio),
                    novoValor
                );

                // Manda o repositório salvar
                await _repository.UpdateAsync(_plantaoAtual);

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

        private async void btnExcluir_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tem certeza que deseja excluir este plantão?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                await _repository.DeleteAsync(_shiftId);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}

