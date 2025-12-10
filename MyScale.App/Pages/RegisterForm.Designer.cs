using ReaLTaiizor.Controls;
using System.Text;

namespace MyScale.App.Pages
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            foxLabel1 = new FoxLabel();
            radioHealthAgent = new FoxRadioButton();
            radioHospital = new FoxRadioButton();
            txtName = new HopeTextBox();
            txtEmail = new HopeTextBox();
            txtUsername = new HopeTextBox();
            txtPassword = new HopeTextBox();
            pnlHospital = new ReaLTaiizor.Controls.Panel();
            labelMunicipalRegistry = new FoxLabel();
            labelCNPJ = new FoxLabel();
            txtCNPJ = new HopeTextBox();
            txtMuniciaplRegistry = new HopeTextBox();
            dateTimeHospital = new PoisonDateTime();
            pnlHealthAgent = new ReaLTaiizor.Controls.Panel();
            labelCPF = new FoxLabel();
            dateTimeHealthAgent = new PoisonDateTime();
            txtDocument = new HopeTextBox();
            txtZipCode = new HopeTextBox();
            txtStreet = new HopeTextBox();
            txtNumber = new HopeTextBox();
            txtCity = new HopeTextBox();
            comboBoxState = new HopeComboBox();
            txtComplement = new HopeTextBox();
            btnRegister = new ForeverButton();
            txtNeighborhood = new HopeTextBox();
            pBoxEyeHidden = new PictureBox();
            pBoxEyeVisible = new PictureBox();
            lblCheckTamanho = new FoxLabel();
            lblCheckMaiuscula = new FoxLabel();
            lblCheckMinuscula = new FoxLabel();
            lblCheckNumero = new FoxLabel();
            lblCheckSimbolo = new FoxLabel();
            pnlHospital.SuspendLayout();
            pnlHealthAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxEyeHidden).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxEyeVisible).BeginInit();
            SuspendLayout();
            // 
            // foxLabel1
            // 
            foxLabel1.BackColor = Color.Transparent;
            foxLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            foxLabel1.ForeColor = Color.FromArgb(76, 88, 100);
            foxLabel1.Location = new Point(6, 48);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(196, 19);
            foxLabel1.TabIndex = 0;
            foxLabel1.Text = "Você está se registrando como";
            // 
            // radioHealthAgent
            // 
            radioHealthAgent.BackColor = Color.Transparent;
            radioHealthAgent.BorderColor = Color.FromArgb(200, 200, 200);
            radioHealthAgent.Checked = false;
            radioHealthAgent.CheckedColor = Color.FromArgb(44, 156, 218);
            radioHealthAgent.DisabledBorderColor = Color.FromArgb(230, 230, 230);
            radioHealthAgent.DisabledCheckedColor = Color.FromArgb(182, 180, 180);
            radioHealthAgent.DisabledTextColor = Color.FromArgb(166, 178, 190);
            radioHealthAgent.EnabledCalc = true;
            radioHealthAgent.Font = new Font("Segoe UI", 10F);
            radioHealthAgent.ForeColor = Color.FromArgb(66, 78, 90);
            radioHealthAgent.HoverBorderColor = Color.FromArgb(44, 156, 218);
            radioHealthAgent.Location = new Point(6, 73);
            radioHealthAgent.Name = "radioHealthAgent";
            radioHealthAgent.Size = new Size(138, 21);
            radioHealthAgent.TabIndex = 3;
            radioHealthAgent.Text = "Agente de saúde";
            radioHealthAgent.CheckedChanged += radioHealthAgent_CheckedChanged;
            // 
            // radioHospital
            // 
            radioHospital.BackColor = Color.Transparent;
            radioHospital.BorderColor = Color.FromArgb(200, 200, 200);
            radioHospital.Checked = false;
            radioHospital.CheckedColor = Color.FromArgb(44, 156, 218);
            radioHospital.DisabledBorderColor = Color.FromArgb(230, 230, 230);
            radioHospital.DisabledCheckedColor = Color.FromArgb(182, 180, 180);
            radioHospital.DisabledTextColor = Color.FromArgb(166, 178, 190);
            radioHospital.EnabledCalc = true;
            radioHospital.Font = new Font("Segoe UI", 10F);
            radioHospital.ForeColor = Color.FromArgb(66, 78, 90);
            radioHospital.HoverBorderColor = Color.FromArgb(44, 156, 218);
            radioHospital.Location = new Point(6, 100);
            radioHospital.Name = "radioHospital";
            radioHospital.Size = new Size(138, 21);
            radioHospital.TabIndex = 4;
            radioHospital.Text = "Hospital";
            radioHospital.CheckedChanged += radioHospital_CheckedChanged;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BaseColor = Color.White;
            txtName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = Color.Black;
            txtName.Hint = "Nome";
            txtName.Location = new Point(6, 128);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(305, 38);
            txtName.TabIndex = 1;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BaseColor = Color.White;
            txtEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            txtEmail.BorderColorB = Color.FromArgb(220, 223, 230);
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.ForeColor = Color.FromArgb(48, 49, 51);
            txtEmail.Hint = "Email";
            txtEmail.Location = new Point(6, 172);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.ScrollBars = ScrollBars.None;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.Size = new Size(538, 38);
            txtEmail.TabIndex = 3;
            txtEmail.TabStop = false;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BaseColor = Color.White;
            txtUsername.BorderColorA = Color.FromArgb(64, 158, 255);
            txtUsername.BorderColorB = Color.FromArgb(220, 223, 230);
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.ForeColor = Color.FromArgb(48, 49, 51);
            txtUsername.Hint = "Login (nome de usuário)";
            txtUsername.Location = new Point(317, 128);
            txtUsername.MaxLength = 32767;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.ScrollBars = ScrollBars.None;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.Size = new Size(227, 38);
            txtUsername.TabIndex = 2;
            txtUsername.TabStop = false;
            txtUsername.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BaseColor = Color.White;
            txtPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPassword.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.FromArgb(48, 49, 51);
            txtPassword.Hint = "Senha";
            txtPassword.Location = new Point(6, 216);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(538, 38);
            txtPassword.TabIndex = 4;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // pnlHospital
            // 
            pnlHospital.BackColor = Color.White;
            pnlHospital.Controls.Add(labelMunicipalRegistry);
            pnlHospital.Controls.Add(labelCNPJ);
            pnlHospital.Controls.Add(txtCNPJ);
            pnlHospital.Controls.Add(txtMuniciaplRegistry);
            pnlHospital.Controls.Add(dateTimeHospital);
            pnlHospital.EdgeColor = Color.FromArgb(224, 224, 224);
            pnlHospital.Location = new Point(6, 403);
            pnlHospital.Name = "pnlHospital";
            pnlHospital.Padding = new Padding(5);
            pnlHospital.Size = new Size(541, 115);
            pnlHospital.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnlHospital.TabIndex = 9;
            pnlHospital.Text = "panel1";
            // 
            // labelMunicipalRegistry
            // 
            labelMunicipalRegistry.BackColor = Color.Transparent;
            labelMunicipalRegistry.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelMunicipalRegistry.ForeColor = Color.Red;
            labelMunicipalRegistry.Location = new Point(0, 52);
            labelMunicipalRegistry.Name = "labelMunicipalRegistry";
            labelMunicipalRegistry.Size = new Size(140, 19);
            labelMunicipalRegistry.TabIndex = 22;
            labelMunicipalRegistry.Text = "Máximo de 14 dígitos";
            labelMunicipalRegistry.Visible = false;
            // 
            // labelCNPJ
            // 
            labelCNPJ.BackColor = Color.Transparent;
            labelCNPJ.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCNPJ.ForeColor = Color.Red;
            labelCNPJ.Location = new Point(395, 51);
            labelCNPJ.Name = "labelCNPJ";
            labelCNPJ.Size = new Size(140, 19);
            labelCNPJ.TabIndex = 21;
            labelCNPJ.Text = "Máximo de 14 dígitos";
            labelCNPJ.Visible = false;
            // 
            // txtCNPJ
            // 
            txtCNPJ.BackColor = Color.White;
            txtCNPJ.BaseColor = Color.White;
            txtCNPJ.BorderColorA = Color.FromArgb(64, 158, 255);
            txtCNPJ.BorderColorB = Color.FromArgb(220, 223, 230);
            txtCNPJ.Font = new Font("Segoe UI", 12F);
            txtCNPJ.ForeColor = Color.Black;
            txtCNPJ.Hint = "CNPJ";
            txtCNPJ.Location = new Point(195, 8);
            txtCNPJ.MaxLength = 32767;
            txtCNPJ.Multiline = false;
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PasswordChar = '\0';
            txtCNPJ.ScrollBars = ScrollBars.None;
            txtCNPJ.SelectedText = "";
            txtCNPJ.SelectionLength = 0;
            txtCNPJ.SelectionStart = 0;
            txtCNPJ.Size = new Size(343, 38);
            txtCNPJ.TabIndex = 13;
            txtCNPJ.TabStop = false;
            txtCNPJ.UseSystemPasswordChar = false;
            txtCNPJ.KeyPress += txtCNPJ_KeyPress;
            txtCNPJ.TextChanged += txtCNPJ_TextChanged;
            // 
            // txtMuniciaplRegistry
            // 
            txtMuniciaplRegistry.BackColor = Color.White;
            txtMuniciaplRegistry.BaseColor = Color.White;
            txtMuniciaplRegistry.BorderColorA = Color.FromArgb(64, 158, 255);
            txtMuniciaplRegistry.BorderColorB = Color.FromArgb(220, 223, 230);
            txtMuniciaplRegistry.Font = new Font("Segoe UI", 12F);
            txtMuniciaplRegistry.ForeColor = Color.Black;
            txtMuniciaplRegistry.Hint = "Registro Municipal";
            txtMuniciaplRegistry.Location = new Point(0, 8);
            txtMuniciaplRegistry.MaxLength = 32767;
            txtMuniciaplRegistry.Multiline = false;
            txtMuniciaplRegistry.Name = "txtMuniciaplRegistry";
            txtMuniciaplRegistry.PasswordChar = '\0';
            txtMuniciaplRegistry.ScrollBars = ScrollBars.None;
            txtMuniciaplRegistry.SelectedText = "";
            txtMuniciaplRegistry.SelectionLength = 0;
            txtMuniciaplRegistry.SelectionStart = 0;
            txtMuniciaplRegistry.Size = new Size(188, 38);
            txtMuniciaplRegistry.TabIndex = 12;
            txtMuniciaplRegistry.TabStop = false;
            txtMuniciaplRegistry.UseSystemPasswordChar = false;
            txtMuniciaplRegistry.KeyPress += txtMuniciaplRegistry_KeyPress;
            txtMuniciaplRegistry.TextChanged += txtMunicipalRegistry_TextChanged;
            // 
            // dateTimeHospital
            // 
            dateTimeHospital.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dateTimeHospital.Location = new Point(0, 73);
            dateTimeHospital.MinimumSize = new Size(0, 29);
            dateTimeHospital.Name = "dateTimeHospital";
            dateTimeHospital.Size = new Size(285, 29);
            dateTimeHospital.TabIndex = 20;
            // 
            // pnlHealthAgent
            // 
            pnlHealthAgent.BackColor = Color.White;
            pnlHealthAgent.Controls.Add(labelCPF);
            pnlHealthAgent.Controls.Add(dateTimeHealthAgent);
            pnlHealthAgent.Controls.Add(txtDocument);
            pnlHealthAgent.EdgeColor = Color.FromArgb(224, 224, 224);
            pnlHealthAgent.Location = new Point(3, 402);
            pnlHealthAgent.Name = "pnlHealthAgent";
            pnlHealthAgent.Padding = new Padding(5);
            pnlHealthAgent.Size = new Size(541, 67);
            pnlHealthAgent.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnlHealthAgent.TabIndex = 21;
            pnlHealthAgent.Text = "panel1";
            // 
            // labelCPF
            // 
            labelCPF.BackColor = Color.Transparent;
            labelCPF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCPF.ForeColor = Color.Red;
            labelCPF.Location = new Point(3, 47);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(196, 19);
            labelCPF.TabIndex = 24;
            labelCPF.Text = "Máximo de 11 dígitos";
            labelCPF.Visible = false;
            // 
            // dateTimeHealthAgent
            // 
            dateTimeHealthAgent.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dateTimeHealthAgent.Location = new Point(253, 8);
            dateTimeHealthAgent.MinimumSize = new Size(0, 29);
            dateTimeHealthAgent.Name = "dateTimeHealthAgent";
            dateTimeHealthAgent.Size = new Size(285, 29);
            dateTimeHealthAgent.TabIndex = 20;
            // 
            // txtDocument
            // 
            txtDocument.BackColor = Color.White;
            txtDocument.BaseColor = Color.White;
            txtDocument.BorderColorA = Color.FromArgb(64, 158, 255);
            txtDocument.BorderColorB = Color.FromArgb(220, 223, 230);
            txtDocument.Font = new Font("Segoe UI", 12F);
            txtDocument.ForeColor = Color.Black;
            txtDocument.Hint = "Documento (CPF)";
            txtDocument.Location = new Point(0, 8);
            txtDocument.MaxLength = 32767;
            txtDocument.Multiline = false;
            txtDocument.Name = "txtDocument";
            txtDocument.PasswordChar = '\0';
            txtDocument.ScrollBars = ScrollBars.None;
            txtDocument.SelectedText = "";
            txtDocument.SelectionLength = 0;
            txtDocument.SelectionStart = 0;
            txtDocument.Size = new Size(240, 38);
            txtDocument.TabIndex = 12;
            txtDocument.TabStop = false;
            txtDocument.UseSystemPasswordChar = false;
            txtDocument.KeyPress += txtDocument_KeyPress;
            txtDocument.TextChanged += txtDocument_TextChanged;
            // 
            // txtZipCode
            // 
            txtZipCode.BackColor = Color.White;
            txtZipCode.BaseColor = Color.White;
            txtZipCode.BorderColorA = Color.FromArgb(64, 158, 255);
            txtZipCode.BorderColorB = Color.FromArgb(220, 223, 230);
            txtZipCode.Font = new Font("Segoe UI", 12F);
            txtZipCode.ForeColor = Color.FromArgb(48, 49, 51);
            txtZipCode.Hint = "CEP";
            txtZipCode.Location = new Point(6, 274);
            txtZipCode.MaxLength = 32767;
            txtZipCode.Multiline = false;
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PasswordChar = '\0';
            txtZipCode.ScrollBars = ScrollBars.None;
            txtZipCode.SelectedText = "";
            txtZipCode.SelectionLength = 0;
            txtZipCode.SelectionStart = 0;
            txtZipCode.Size = new Size(117, 38);
            txtZipCode.TabIndex = 5;
            txtZipCode.TabStop = false;
            txtZipCode.UseSystemPasswordChar = false;
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.White;
            txtStreet.BaseColor = Color.White;
            txtStreet.BorderColorA = Color.FromArgb(64, 158, 255);
            txtStreet.BorderColorB = Color.FromArgb(220, 223, 230);
            txtStreet.Font = new Font("Segoe UI", 12F);
            txtStreet.ForeColor = Color.FromArgb(48, 49, 51);
            txtStreet.Hint = "Rua";
            txtStreet.Location = new Point(129, 274);
            txtStreet.MaxLength = 32767;
            txtStreet.Multiline = false;
            txtStreet.Name = "txtStreet";
            txtStreet.PasswordChar = '\0';
            txtStreet.ScrollBars = ScrollBars.None;
            txtStreet.SelectedText = "";
            txtStreet.SelectionLength = 0;
            txtStreet.SelectionStart = 0;
            txtStreet.Size = new Size(320, 38);
            txtStreet.TabIndex = 6;
            txtStreet.TabStop = false;
            txtStreet.UseSystemPasswordChar = false;
            // 
            // txtNumber
            // 
            txtNumber.BackColor = Color.White;
            txtNumber.BaseColor = Color.White;
            txtNumber.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNumber.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNumber.Font = new Font("Segoe UI", 12F);
            txtNumber.ForeColor = Color.FromArgb(48, 49, 51);
            txtNumber.Hint = "Nº";
            txtNumber.Location = new Point(455, 274);
            txtNumber.MaxLength = 32767;
            txtNumber.Multiline = false;
            txtNumber.Name = "txtNumber";
            txtNumber.PasswordChar = '\0';
            txtNumber.ScrollBars = ScrollBars.None;
            txtNumber.SelectedText = "";
            txtNumber.SelectionLength = 0;
            txtNumber.SelectionStart = 0;
            txtNumber.Size = new Size(89, 38);
            txtNumber.TabIndex = 7;
            txtNumber.TabStop = false;
            txtNumber.UseSystemPasswordChar = false;
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.White;
            txtCity.BaseColor = Color.White;
            txtCity.BorderColorA = Color.FromArgb(64, 158, 255);
            txtCity.BorderColorB = Color.FromArgb(220, 223, 230);
            txtCity.Font = new Font("Segoe UI", 12F);
            txtCity.ForeColor = Color.FromArgb(48, 49, 51);
            txtCity.Hint = "Cidade";
            txtCity.Location = new Point(300, 320);
            txtCity.MaxLength = 32767;
            txtCity.Multiline = false;
            txtCity.Name = "txtCity";
            txtCity.PasswordChar = '\0';
            txtCity.ScrollBars = ScrollBars.None;
            txtCity.SelectedText = "";
            txtCity.SelectionLength = 0;
            txtCity.SelectionStart = 0;
            txtCity.Size = new Size(117, 38);
            txtCity.TabIndex = 9;
            txtCity.TabStop = false;
            txtCity.UseSystemPasswordChar = false;
            // 
            // comboBoxState
            // 
            comboBoxState.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxState.FlatStyle = FlatStyle.Flat;
            comboBoxState.Font = new Font("Segoe UI", 12F);
            comboBoxState.FormattingEnabled = true;
            comboBoxState.ItemHeight = 26;
            comboBoxState.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxState.Location = new Point(423, 323);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(121, 32);
            comboBoxState.TabIndex = 10;
            comboBoxState.Text = "UF";
            // 
            // txtComplement
            // 
            txtComplement.BackColor = Color.White;
            txtComplement.BaseColor = Color.White;
            txtComplement.BorderColorA = Color.FromArgb(64, 158, 255);
            txtComplement.BorderColorB = Color.FromArgb(220, 223, 230);
            txtComplement.Font = new Font("Segoe UI", 12F);
            txtComplement.ForeColor = Color.FromArgb(48, 49, 51);
            txtComplement.Hint = "Complemento";
            txtComplement.Location = new Point(6, 362);
            txtComplement.MaxLength = 32767;
            txtComplement.Multiline = false;
            txtComplement.Name = "txtComplement";
            txtComplement.PasswordChar = '\0';
            txtComplement.ScrollBars = ScrollBars.None;
            txtComplement.SelectedText = "";
            txtComplement.SelectionLength = 0;
            txtComplement.SelectionStart = 0;
            txtComplement.Size = new Size(538, 38);
            txtComplement.TabIndex = 11;
            txtComplement.TabStop = false;
            txtComplement.UseSystemPasswordChar = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BaseColor = Color.SeaGreen;
            btnRegister.Font = new Font("Segoe UI", 12F);
            btnRegister.Location = new Point(385, 533);
            btnRegister.Name = "btnRegister";
            btnRegister.Rounded = false;
            btnRegister.Size = new Size(159, 41);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Registrar";
            btnRegister.TextColor = Color.FromArgb(243, 243, 243);
            btnRegister.Click += btnRegister_Click;
            // 
            // txtNeighborhood
            // 
            txtNeighborhood.BackColor = Color.White;
            txtNeighborhood.BaseColor = Color.White;
            txtNeighborhood.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNeighborhood.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNeighborhood.Font = new Font("Segoe UI", 12F);
            txtNeighborhood.ForeColor = Color.FromArgb(48, 49, 51);
            txtNeighborhood.Hint = "Bairro";
            txtNeighborhood.Location = new Point(6, 318);
            txtNeighborhood.MaxLength = 32767;
            txtNeighborhood.Multiline = false;
            txtNeighborhood.Name = "txtNeighborhood";
            txtNeighborhood.PasswordChar = '\0';
            txtNeighborhood.ScrollBars = ScrollBars.None;
            txtNeighborhood.SelectedText = "";
            txtNeighborhood.SelectionLength = 0;
            txtNeighborhood.SelectionStart = 0;
            txtNeighborhood.Size = new Size(288, 38);
            txtNeighborhood.TabIndex = 8;
            txtNeighborhood.TabStop = false;
            txtNeighborhood.UseSystemPasswordChar = false;
            // 
            // pBoxEyeHidden
            // 
            pBoxEyeHidden.BackgroundImage = Properties.Resources.eye_hidden;
            pBoxEyeHidden.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxEyeHidden.Cursor = Cursors.Hand;
            pBoxEyeHidden.Location = new Point(508, 220);
            pBoxEyeHidden.Name = "pBoxEyeHidden";
            pBoxEyeHidden.Size = new Size(30, 30);
            pBoxEyeHidden.TabIndex = 25;
            pBoxEyeHidden.TabStop = false;
            pBoxEyeHidden.Click += pBoxEyeHidden_Click;
            // 
            // pBoxEyeVisible
            // 
            pBoxEyeVisible.BackgroundImage = Properties.Resources.eye_visible;
            pBoxEyeVisible.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxEyeVisible.Cursor = Cursors.Hand;
            pBoxEyeVisible.Location = new Point(508, 220);
            pBoxEyeVisible.Name = "pBoxEyeVisible";
            pBoxEyeVisible.Size = new Size(30, 30);
            pBoxEyeVisible.TabIndex = 26;
            pBoxEyeVisible.TabStop = false;
            pBoxEyeVisible.Click += pBoxEyeVisible_Click;
            // 
            // lblCheckTamanho
            // 
            lblCheckTamanho.BackColor = Color.Transparent;
            lblCheckTamanho.Font = new Font("Segoe UI", 8.25F);
            lblCheckTamanho.ForeColor = Color.Gray;
            lblCheckTamanho.Location = new Point(6, 258);
            lblCheckTamanho.Name = "lblCheckTamanho";
            lblCheckTamanho.Size = new Size(117, 15);
            lblCheckTamanho.TabIndex = 23;
            lblCheckTamanho.Text = "• Mínimo 8 caracteres";
            // 
            // lblCheckMaiuscula
            // 
            lblCheckMaiuscula.BackColor = Color.Transparent;
            lblCheckMaiuscula.Font = new Font("Segoe UI", 8.25F);
            lblCheckMaiuscula.ForeColor = Color.Gray;
            lblCheckMaiuscula.Location = new Point(129, 258);
            lblCheckMaiuscula.Name = "lblCheckMaiuscula";
            lblCheckMaiuscula.Size = new Size(100, 15);
            lblCheckMaiuscula.TabIndex = 27;
            lblCheckMaiuscula.Text = "• Letra Maiúscula";
            // 
            // lblCheckMinuscula
            // 
            lblCheckMinuscula.BackColor = Color.Transparent;
            lblCheckMinuscula.Font = new Font("Segoe UI", 8.25F);
            lblCheckMinuscula.ForeColor = Color.Gray;
            lblCheckMinuscula.Location = new Point(235, 258);
            lblCheckMinuscula.Name = "lblCheckMinuscula";
            lblCheckMinuscula.Size = new Size(100, 15);
            lblCheckMinuscula.TabIndex = 28;
            lblCheckMinuscula.Text = "• Letra Minúscula";
            // 
            // lblCheckNumero
            // 
            lblCheckNumero.BackColor = Color.Transparent;
            lblCheckNumero.Font = new Font("Segoe UI", 8.25F);
            lblCheckNumero.ForeColor = Color.Gray;
            lblCheckNumero.Location = new Point(341, 258);
            lblCheckNumero.Name = "lblCheckNumero";
            lblCheckNumero.Size = new Size(61, 15);
            lblCheckNumero.TabIndex = 29;
            lblCheckNumero.Text = "• Número";
            // 
            // lblCheckSimbolo
            // 
            lblCheckSimbolo.BackColor = Color.Transparent;
            lblCheckSimbolo.Font = new Font("Segoe UI", 8.25F);
            lblCheckSimbolo.ForeColor = Color.Gray;
            lblCheckSimbolo.Location = new Point(400, 258);
            lblCheckSimbolo.Name = "lblCheckSimbolo";
            lblCheckSimbolo.Size = new Size(61, 15);
            lblCheckSimbolo.TabIndex = 30;
            lblCheckSimbolo.Text = "• Simbolo";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 583);
            Controls.Add(lblCheckSimbolo);
            Controls.Add(lblCheckNumero);
            Controls.Add(lblCheckMinuscula);
            Controls.Add(lblCheckMaiuscula);
            Controls.Add(lblCheckTamanho);
            Controls.Add(pBoxEyeVisible);
            Controls.Add(pBoxEyeHidden);
            Controls.Add(pnlHospital);
            Controls.Add(pnlHealthAgent);
            Controls.Add(txtNeighborhood);
            Controls.Add(btnRegister);
            Controls.Add(txtComplement);
            Controls.Add(comboBoxState);
            Controls.Add(txtCity);
            Controls.Add(txtNumber);
            Controls.Add(txtStreet);
            Controls.Add(txtZipCode);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(radioHospital);
            Controls.Add(radioHealthAgent);
            Controls.Add(foxLabel1);
            ForeColor = SystemColors.ControlLightLight;
            HeaderColor = Color.SeaGreen;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyScale - Registrar";
            Load += RegisterForm_Load;
            pnlHospital.ResumeLayout(false);
            pnlHealthAgent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxEyeHidden).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxEyeVisible).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private FoxRadioButton radioHealthAgent;
        private ReaLTaiizor.Controls.FoxRadioButton foxRadioButton1;
        private ReaLTaiizor.Controls.FoxRadioButton radioHospital;
        private ReaLTaiizor.Controls.HopeTextBox txtName;
        private HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.HopeTextBox txtUsername;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private ReaLTaiizor.Controls.Panel pnlHospital;
        private PoisonDateTime dateTimeHospital;
        private HopeTextBox txtCNPJ;
        private HopeTextBox txtMuniciaplRegistry;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox5;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox6;
        private ReaLTaiizor.Controls.HopeTextBox txtNumber;
        private HopeTextBox txtCity;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox8;
        private ReaLTaiizor.Controls.HopeComboBox comboBoxState;
        private HopeTextBox txtComplement;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox9;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox11;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox10;
        private ReaLTaiizor.Controls.Panel pnlHealthAgent;
        private PoisonDateTime dateTimeHealthAgent;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime2;
        private ReaLTaiizor.Controls.HopeTextBox txtDocument;
        private HopeTextBox txtZipCode;
        private HopeTextBox txtStreet;
        private ForeverButton btnRegister;
        private HopeTextBox txtNeighborhood;
        private FoxLabel labelCNPJ;
        private FoxLabel labelCPF;
        private FoxLabel labelMunicipalRegistry;
        private PictureBox pBoxEyeHidden;
        private PictureBox pBoxEyeVisible;
        private FoxLabel lblCheckTamanho;
        private FoxLabel lblCheckMaiuscula;
        private FoxLabel lblCheckMinuscula;
        private FoxLabel lblCheckNumero;
        private FoxLabel lblCheckSimbolo;
    }
}