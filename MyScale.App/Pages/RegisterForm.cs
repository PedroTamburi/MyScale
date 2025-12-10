using FluentValidation;
using MyScale.Domain.Base;
using MyScale.Domain.Entities;
using MyScale.Service.Validators;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Util;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Drawing;
using System.Text.RegularExpressions;
using ReaLTaiizor.Controls;

namespace MyScale.App.Pages
{
    public partial class RegisterForm : LostForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        //dependências 
        private readonly IBaseRepository<Hospital> _hospitalRepository;
        private readonly IBaseRepository<HealthAgent> _agentRepository;

        // validadores 
        private readonly IValidator<Hospital> _hospitalValidator;
        private readonly IValidator<HealthAgent> _agentValidator;

        public RegisterForm(IBaseRepository<Hospital> hospitalRepository, IBaseRepository<HealthAgent> agentRepository)
        {
            InitializeComponent();

            _hospitalRepository = hospitalRepository;
            _agentRepository = agentRepository;

            _hospitalValidator = new HospitalValidator();
            _agentValidator = new HealthAgentValidator();

            // tela
            pnlHealthAgent.Visible = false;
            pnlHospital.Visible = false;
            pBoxEyeVisible.Visible = false;
            txtPassword.UseSystemPasswordChar = true;


            pnlHealthAgent.BringToFront();
            pnlHospital.BringToFront();
        }
        #region metodos
        private void AlternarCampos()
        {
            if (radioHospital.Checked)
            {
                pnlHospital.Visible = true;
                pnlHealthAgent.Visible = false;
                txtDocument.Text = string.Empty;
            }
            else
            {
                pnlHospital.Visible = false;
                pnlHealthAgent.Visible = true;
                txtCNPJ.Text = string.Empty;
                txtMuniciaplRegistry.Text = string.Empty;
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

        
        #endregion
        #region Eventos
        private void radioHealthAgent_CheckedChanged(object sender, EventArgs e)
        {
            AlternarCampos();
        }

        private void radioHospital_CheckedChanged(object sender, EventArgs e)
        {
            AlternarCampos();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria o Endereço
                var address = new Address
                {
                    Street = txtStreet.Text,
                    Number = txtNumber.Text,
                    Neighborhood = txtNeighborhood.Text,
                    City = txtCity.Text,
                    State = comboBoxState.Text,
                    ZipCode = txtZipCode.Text,
                    Complement = txtComplement.Text
                };

                // 2. Verifica o Tipo de Cadastro
                if (radioHospital.Checked)
                {
                    // --- HOSPITAL ---
                    var hospital = new Hospital
                    {
                        Name = txtName.Text,
                        Email = txtEmail.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,

                        // Campos do painel Hospital
                        CNPJ = txtCNPJ.Text,
                        MunicipalRegistry = txtMuniciaplRegistry.Text,
                        FoundationDate = DateOnly.FromDateTime(dateTimeHospital.Value),

                        Address = address,
                        RegisterDate = DateTime.Now,
                        IsActive = true
                    };

                    // Validação
                    var result = _hospitalValidator.Validate(hospital);
                    if (!result.IsValid)
                    {
                        MessageBox.Show(result.Errors.First().ErrorMessage, "Erro de Validação");
                        return;
                    }

                    // Salvar
                    _hospitalRepository.Insert(hospital);
                    MessageBox.Show("Hospital cadastrado com sucesso!", "Sucesso");
                }
                else
                {
                    // --- AGENTE DE SAÚDE ---
                    var agent = new HealthAgent
                    {
                        Name = txtName.Text,
                        Email = txtEmail.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,

                        Document = txtDocument.Text,
                        BirthDate = DateOnly.FromDateTime(dateTimeHealthAgent.Value),

                        Address = address,
                        RegisterDate = DateTime.Now,
                        IsActive = true
                    };

                    var result = _agentValidator.Validate(agent);
                    if (!result.IsValid)
                    {
                        MessageBox.Show(result.Errors.First().ErrorMessage, "Erro de Validação");
                        return;
                    }

                    // Salvar
                    _agentRepository.Insert(agent);
                    MessageBox.Show("Agente cadastrado com sucesso!", "Sucesso");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void txtDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
#endregion