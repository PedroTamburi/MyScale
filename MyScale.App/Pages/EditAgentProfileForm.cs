using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyScale.App.Pages
{
    public partial class EditAgentProfileForm : Form
    {
        private readonly IBaseRepository<HealthAgent> _repository;
        private readonly int _agentId;
        private HealthAgent _agenteAtual;

        public EditAgentProfileForm(int agentId, IBaseRepository<HealthAgent> repository)
        {
            InitializeComponent();
            _agentId = agentId;
            _repository = repository;

            pBoxEyeVisible.Visible = false;
            txtPassword.UseSystemPasswordChar = true;

            CarregarDados();
        }

        private void CarregarDados()
        {
            try
            {
                _agenteAtual = _repository.Select(_agentId, new List<string> { "Address" });

                if (_agenteAtual == null)
                {
                    MessageBox.Show("Erro ao carregar perfil.");
                    this.Close();
                    return;
                }

                txtName.Text = _agenteAtual.Name;
                txtEmail.Text = _agenteAtual.Email;
                txtUsername.Text = _agenteAtual.Username;
                txtPassword.Text = _agenteAtual.Password;
                txtDocument.Text = _agenteAtual.Document;
                dateTimeHealthAgent.Value = _agenteAtual.BirthDate;

                txtStreet.Text = _agenteAtual.Address.Street;
                txtNumber.Text = _agenteAtual.Address.Number;
                txtNeighborhood.Text = _agenteAtual.Address.Neighborhood;
                txtCity.Text = _agenteAtual.Address.City;
                comboBoxState.Text = _agenteAtual.Address.State;
                txtZipCode.Text = _agenteAtual.Address.ZipCode;
                txtComplement.Text = _agenteAtual.Address.Complement;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }

        private void DefinirStatus(FoxLabel label, bool valido)
        {
            if (valido)
            {
                label.ForeColor = Color.Green;
                label.Font = new Font(label.Font, FontStyle.Bold);
            }
            else
            {
                label.ForeColor = Color.Gray;
                label.Font = new Font(label.Font, FontStyle.Regular);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Atualiza o objeto
                _agenteAtual.Name = txtName.Text;
                _agenteAtual.Email = txtEmail.Text;
                _agenteAtual.Username = txtUsername.Text;
                _agenteAtual.Password = txtPassword.Text;
                _agenteAtual.Document = txtDocument.Text;
                _agenteAtual.BirthDate = dateTimeHealthAgent.Value;

                // Garante que o endereço não é nulo
                if (_agenteAtual.Address == null) _agenteAtual.Address = new Address();

                _agenteAtual.Address.Street = txtStreet.Text;
                _agenteAtual.Address.Number = txtNumber.Text;
                _agenteAtual.Address.Neighborhood = txtNeighborhood.Text;
                _agenteAtual.Address.City = txtCity.Text;
                _agenteAtual.Address.State = comboBoxState.Text;
                _agenteAtual.Address.ZipCode = txtZipCode.Text;
                _agenteAtual.Address.Complement = txtComplement.Text;

                _repository.Update(_agenteAtual);

                MessageBox.Show("Perfil atualizado com sucesso!");
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string senha = txtPassword.Text;

            if (senha.Length >= 8) DefinirStatus(lblCheckTamanho, true);
            else DefinirStatus(lblCheckTamanho, false);

            if (Regex.IsMatch(senha, "[A-Z]")) DefinirStatus(lblCheckMaiuscula, true);
            else DefinirStatus(lblCheckMaiuscula, false);

            if (Regex.IsMatch(senha, "[a-z]")) DefinirStatus(lblCheckMinuscula, true);
            else DefinirStatus(lblCheckMinuscula, false);

            if (Regex.IsMatch(senha, "[0-9]")) DefinirStatus(lblCheckNumero, true);
            else DefinirStatus(lblCheckNumero, false);

            if (Regex.IsMatch(senha, "[\\W]")) DefinirStatus(lblCheckSimbolo, true);
            else DefinirStatus(lblCheckSimbolo, false);
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

        private void txtDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDocument_TextChanged(object sender, EventArgs e)
        {
            if (!txtDocument.Text.Contains("."))
            {
                string textoLimpo = txtDocument.Text.Replace(" ", "");

                if (textoLimpo.Length > 11)
                {
                    txtDocument.Text = textoLimpo.Substring(0, 11);
                    txtDocument.SelectionStart = 11;

                    labelCPF.Text = "Limite de 11 números atingido!";
                    labelCPF.Visible = true;
                }
                else
                {
                    labelCPF.Visible = false;
                }
            }
        }
    }
}