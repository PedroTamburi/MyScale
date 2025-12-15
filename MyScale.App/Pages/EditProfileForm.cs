using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Text.RegularExpressions;

namespace MyScale.App.Pages
{
    public partial class EditProfileForm : Form
    {
        private readonly IBaseRepository<Hospital> _repository;
        private readonly int _hospitalId;
        private Hospital _hospitalAtual;
        public EditProfileForm(int hospitalId, IBaseRepository<Hospital> repository)
        {
            InitializeComponent();
            _hospitalId = hospitalId;
            _repository = repository;
            CarregarDados();
            pBoxEyeVisible.Visible = false;
            txtPassword.UseSystemPasswordChar = true;
        }
        private void CarregarDados()
        {
            try
            {
                _hospitalAtual = _repository.Select(_hospitalId, new List<string> { "Address" });

                if (_hospitalAtual == null)
                {
                    MessageBox.Show("Erro ao carregar perfil.");
                    this.Close();
                    return;
                }

                txtName.Text = _hospitalAtual.Name;
                txtEmail.Text = _hospitalAtual.Email;
                txtCNPJ.Text = _hospitalAtual.CNPJ;
                txtMuniciaplRegistry.Text = _hospitalAtual.MunicipalRegistry;
                txtUsername.Text = _hospitalAtual.Username;
                txtPassword.Text = _hospitalAtual.Password;

                // Endereço
                if (_hospitalAtual.Address != null)
                {
                    txtStreet.Text = _hospitalAtual.Address.Street;
                    txtNumber.Text = _hospitalAtual.Address.Number;
                    txtNeighborhood.Text = _hospitalAtual.Address.Neighborhood;
                    txtCity.Text = _hospitalAtual.Address.City;
                    comboBoxState.Text = _hospitalAtual.Address.State;
                    txtZipCode.Text = _hospitalAtual.Address.ZipCode;
                    txtComplement.Text = _hospitalAtual.Address.Complement;
                }
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
                // Atualiza o objeto com o que foi digitado
                _hospitalAtual.Name = txtName.Text;
                _hospitalAtual.Email = txtEmail.Text;
                _hospitalAtual.CNPJ = txtCNPJ.Text;
                _hospitalAtual.MunicipalRegistry = txtMuniciaplRegistry.Text;
                _hospitalAtual.Username = txtUsername.Text;
                _hospitalAtual.Password = txtPassword.Text;

                _hospitalAtual.Address.Street = txtStreet.Text;
                _hospitalAtual.Address.Number = txtNumber.Text;
                _hospitalAtual.Address.Neighborhood = txtNeighborhood.Text;
                _hospitalAtual.Address.City = txtCity.Text;
                _hospitalAtual.Address.State = comboBoxState.Text;
                _hospitalAtual.Address.ZipCode = txtZipCode.Text;
                _hospitalAtual.Address.Complement = txtComplement.Text;

                _repository.Update(_hospitalAtual);

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

            if (senha.Length >= 8)
                DefinirStatus(lblCheckTamanho, true);
            else
                DefinirStatus(lblCheckTamanho, false);

            if (Regex.IsMatch(senha, "[A-Z]"))
                DefinirStatus(lblCheckMaiuscula, true);
            else
                DefinirStatus(lblCheckMaiuscula, false);

            if (Regex.IsMatch(senha, "[a-z]"))
                DefinirStatus(lblCheckMinuscula, true);
            else
                DefinirStatus(lblCheckMinuscula, false);

            if (Regex.IsMatch(senha, "[0-9]"))
                DefinirStatus(lblCheckNumero, true);
            else
                DefinirStatus(lblCheckNumero, false);

            if (Regex.IsMatch(senha, "[\\W]"))
                DefinirStatus(lblCheckSimbolo, true);
            else
                DefinirStatus(lblCheckSimbolo, false);

        }
        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (!txtCNPJ.Text.Contains("."))
            {
                string textoLimpo = txtCNPJ.Text.Replace(" ", "");

                if (textoLimpo.Length > 14)
                {
                    txtCNPJ.Text = textoLimpo.Substring(0, 14);

                    txtCNPJ.SelectionStart = 14;

                    labelCNPJ.Text = "Limite de 14 números atingido!";
                    labelCNPJ.Visible = true;
                }
                else
                {
                    labelCNPJ.Visible = false;
                }
            }
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMuniciaplRegistry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMunicipalRegistry_TextChanged(object sender, EventArgs e)
        {
            if (!txtMuniciaplRegistry.Text.Contains("."))
            {
                string textoLimpo = txtMuniciaplRegistry.Text.Replace(" ", "");

                if (textoLimpo.Length > 14)
                {
                    txtMuniciaplRegistry.Text = textoLimpo.Substring(0, 14);

                    txtMuniciaplRegistry.SelectionStart = 14;

                    labelMunicipalRegistry.Text = "Limite de 14 números atingido!";
                    labelMunicipalRegistry.Visible = true;
                }
                else
                {
                    labelMunicipalRegistry.Visible = false;
                }
            }
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
