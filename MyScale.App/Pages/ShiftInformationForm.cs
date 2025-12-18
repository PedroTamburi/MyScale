using MyScale.Domain.Entities;
using MyScale.Domain.Interfaces;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyScale.App.Pages
{
    public partial class ShiftInformationForm : Form
    {
        private readonly int _shiftId;
        private readonly IMedicalShiftRepository _repository;
        private MedicalShift _plantaoAtual;

        // Construtor recebe o ID e o Repositório
        public ShiftInformationForm(int shiftId, IMedicalShiftRepository repository)
        {
            InitializeComponent();
            _shiftId = shiftId;
            _repository = repository;

            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                // ^busca plantao trazendo hospital e endereco
                _plantaoAtual = _repository.Select(_shiftId, new List<string> { "Hospital", "Hospital.Address" });

                if (_plantaoAtual == null)
                {
                    MessageBox.Show("Plantão não encontrado.");
                    this.Close();
                    return;
                }

                // Hospital
                lblName.Text = $"Nome: {_plantaoAtual.Hospital.Name}";
                lblMunicipalRegistry.Text = $"Registro Municipal: {_plantaoAtual.Hospital.MunicipalRegistry}";
                lblCNPJ.Text = $"CNPJ: {_plantaoAtual.Hospital.CNPJ}";
                lblFoundationDate.Text = $"Data de fundação: {_plantaoAtual.Hospital.FoundationDate.ToShortDateString()}";
                lblEmail.Text = $"Email: {_plantaoAtual.Hospital.Email}";
                lblRegisterDate.Text = $"Data de registro: {_plantaoAtual.Hospital.RegisterDate.ToShortDateString()}";

                // Endereço
                var end = _plantaoAtual.Hospital.Address;
                lblStreet.Text = $"Rua: {end.Street} ";
                lblNumber.Text = $"Nº: {end.Number}";
                lblNeighborhood.Text = $" Bairro: {end.Neighborhood}";
                lblCity.Text = $"Cidade: {end.City}";
                lblState.Text = $"Estado: {end.State}";
                lblZipCode.Text = $"CEP: {end.ZipCode}";
                lblComplement.Text = $"Complemento: {end.Complement}";

                // Plantão
                lblPaymentAmount.Text = $"Valor: R$ {_plantaoAtual.PaymentAmount:F2}";
                lblDate.Text = $"Data: {_plantaoAtual.Date.ToString()}";
                lblHour.Text = $"Horario: {_plantaoAtual.StartTime:HH:mm} às {_plantaoAtual.EndTime:HH:mm}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDesistir_Click(object sender, EventArgs e)
        {
            var confirmacao = MessageBox.Show(
                "Tem certeza que deseja desistir deste plantão?\nIsso pode afetar sua reputação com o hospital.",
                "Desistir do Plantão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    _plantaoAtual.HealthAgentId = null;

                    _repository.Update(_plantaoAtual);

                    MessageBox.Show("Você desistiu do plantão com sucesso.");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao desistir: " + ex.Message);
                }
            }
        }
    }
}