namespace MyScale.App.Pages
{
    partial class EditProfileForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            labelMunicipalRegistry = new ReaLTaiizor.Controls.FoxLabel();
            labelCNPJ = new ReaLTaiizor.Controls.FoxLabel();
            txtCNPJ = new ReaLTaiizor.Controls.HopeTextBox();
            txtMuniciaplRegistry = new ReaLTaiizor.Controls.HopeTextBox();
            dateTimeHospital = new ReaLTaiizor.Controls.PoisonDateTime();
            lblCheckSimbolo = new ReaLTaiizor.Controls.FoxLabel();
            lblCheckNumero = new ReaLTaiizor.Controls.FoxLabel();
            lblCheckMinuscula = new ReaLTaiizor.Controls.FoxLabel();
            lblCheckMaiuscula = new ReaLTaiizor.Controls.FoxLabel();
            lblCheckTamanho = new ReaLTaiizor.Controls.FoxLabel();
            txtNeighborhood = new ReaLTaiizor.Controls.HopeTextBox();
            txtComplement = new ReaLTaiizor.Controls.HopeTextBox();
            comboBoxState = new ReaLTaiizor.Controls.HopeComboBox();
            txtCity = new ReaLTaiizor.Controls.HopeTextBox();
            txtNumber = new ReaLTaiizor.Controls.HopeTextBox();
            txtStreet = new ReaLTaiizor.Controls.HopeTextBox();
            txtZipCode = new ReaLTaiizor.Controls.HopeTextBox();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            txtUsername = new ReaLTaiizor.Controls.HopeTextBox();
            txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            txtName = new ReaLTaiizor.Controls.HopeTextBox();
            btnSalvar = new ReaLTaiizor.Controls.Button();
            btnCancelar = new ReaLTaiizor.Controls.Button();
            pBoxEyeVisible = new PictureBox();
            pBoxEyeHidden = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxEyeVisible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxEyeHidden).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.AppWorkspace;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelEdit1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(565, 38);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // labelEdit1
            // 
            labelEdit1.Anchor = AnchorStyles.None;
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdit1.ForeColor = Color.Black;
            labelEdit1.Location = new Point(139, 4);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(287, 30);
            labelEdit1.TabIndex = 1;
            labelEdit1.Text = "Edição de Dados do Usuário";
            // 
            // labelMunicipalRegistry
            // 
            labelMunicipalRegistry.BackColor = Color.Transparent;
            labelMunicipalRegistry.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelMunicipalRegistry.ForeColor = Color.Red;
            labelMunicipalRegistry.Location = new Point(15, 366);
            labelMunicipalRegistry.Name = "labelMunicipalRegistry";
            labelMunicipalRegistry.Size = new Size(140, 19);
            labelMunicipalRegistry.TabIndex = 46;
            labelMunicipalRegistry.Text = "Máximo de 14 dígitos";
            labelMunicipalRegistry.Visible = false;
            // 
            // labelCNPJ
            // 
            labelCNPJ.BackColor = Color.Transparent;
            labelCNPJ.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCNPJ.ForeColor = Color.Red;
            labelCNPJ.Location = new Point(410, 365);
            labelCNPJ.Name = "labelCNPJ";
            labelCNPJ.Size = new Size(140, 19);
            labelCNPJ.TabIndex = 45;
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
            txtCNPJ.Location = new Point(210, 322);
            txtCNPJ.MaxLength = 32767;
            txtCNPJ.Multiline = false;
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.PasswordChar = '\0';
            txtCNPJ.ScrollBars = ScrollBars.None;
            txtCNPJ.SelectedText = "";
            txtCNPJ.SelectionLength = 0;
            txtCNPJ.SelectionStart = 0;
            txtCNPJ.Size = new Size(343, 38);
            txtCNPJ.TabIndex = 43;
            txtCNPJ.TabStop = false;
            txtCNPJ.UseSystemPasswordChar = false;
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
            txtMuniciaplRegistry.Location = new Point(15, 322);
            txtMuniciaplRegistry.MaxLength = 32767;
            txtMuniciaplRegistry.Multiline = false;
            txtMuniciaplRegistry.Name = "txtMuniciaplRegistry";
            txtMuniciaplRegistry.PasswordChar = '\0';
            txtMuniciaplRegistry.ScrollBars = ScrollBars.None;
            txtMuniciaplRegistry.SelectedText = "";
            txtMuniciaplRegistry.SelectionLength = 0;
            txtMuniciaplRegistry.SelectionStart = 0;
            txtMuniciaplRegistry.Size = new Size(188, 38);
            txtMuniciaplRegistry.TabIndex = 42;
            txtMuniciaplRegistry.TabStop = false;
            txtMuniciaplRegistry.UseSystemPasswordChar = false;
            txtMuniciaplRegistry.TextChanged += txtMunicipalRegistry_TextChanged;
            // 
            // dateTimeHospital
            // 
            dateTimeHospital.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dateTimeHospital.Location = new Point(15, 391);
            dateTimeHospital.MinimumSize = new Size(0, 29);
            dateTimeHospital.Name = "dateTimeHospital";
            dateTimeHospital.Size = new Size(285, 29);
            dateTimeHospital.TabIndex = 44;
            // 
            // lblCheckSimbolo
            // 
            lblCheckSimbolo.BackColor = Color.Transparent;
            lblCheckSimbolo.Font = new Font("Segoe UI", 8.25F);
            lblCheckSimbolo.ForeColor = Color.Gray;
            lblCheckSimbolo.Location = new Point(409, 174);
            lblCheckSimbolo.Name = "lblCheckSimbolo";
            lblCheckSimbolo.Size = new Size(61, 15);
            lblCheckSimbolo.TabIndex = 51;
            lblCheckSimbolo.Text = "• Simbolo";
            // 
            // lblCheckNumero
            // 
            lblCheckNumero.BackColor = Color.Transparent;
            lblCheckNumero.Font = new Font("Segoe UI", 8.25F);
            lblCheckNumero.ForeColor = Color.Gray;
            lblCheckNumero.Location = new Point(350, 174);
            lblCheckNumero.Name = "lblCheckNumero";
            lblCheckNumero.Size = new Size(61, 15);
            lblCheckNumero.TabIndex = 50;
            lblCheckNumero.Text = "• Número";
            // 
            // lblCheckMinuscula
            // 
            lblCheckMinuscula.BackColor = Color.Transparent;
            lblCheckMinuscula.Font = new Font("Segoe UI", 8.25F);
            lblCheckMinuscula.ForeColor = Color.Gray;
            lblCheckMinuscula.Location = new Point(244, 174);
            lblCheckMinuscula.Name = "lblCheckMinuscula";
            lblCheckMinuscula.Size = new Size(100, 15);
            lblCheckMinuscula.TabIndex = 49;
            lblCheckMinuscula.Text = "• Letra Minúscula";
            // 
            // lblCheckMaiuscula
            // 
            lblCheckMaiuscula.BackColor = Color.Transparent;
            lblCheckMaiuscula.Font = new Font("Segoe UI", 8.25F);
            lblCheckMaiuscula.ForeColor = Color.Gray;
            lblCheckMaiuscula.Location = new Point(138, 174);
            lblCheckMaiuscula.Name = "lblCheckMaiuscula";
            lblCheckMaiuscula.Size = new Size(100, 15);
            lblCheckMaiuscula.TabIndex = 48;
            lblCheckMaiuscula.Text = "• Letra Maiúscula";
            // 
            // lblCheckTamanho
            // 
            lblCheckTamanho.BackColor = Color.Transparent;
            lblCheckTamanho.Font = new Font("Segoe UI", 8.25F);
            lblCheckTamanho.ForeColor = Color.Gray;
            lblCheckTamanho.Location = new Point(15, 174);
            lblCheckTamanho.Name = "lblCheckTamanho";
            lblCheckTamanho.Size = new Size(117, 15);
            lblCheckTamanho.TabIndex = 47;
            lblCheckTamanho.Text = "• Mínimo 8 caracteres";
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
            txtNeighborhood.Location = new Point(15, 234);
            txtNeighborhood.MaxLength = 32767;
            txtNeighborhood.Multiline = false;
            txtNeighborhood.Name = "txtNeighborhood";
            txtNeighborhood.PasswordChar = '\0';
            txtNeighborhood.ScrollBars = ScrollBars.None;
            txtNeighborhood.SelectedText = "";
            txtNeighborhood.SelectionLength = 0;
            txtNeighborhood.SelectionStart = 0;
            txtNeighborhood.Size = new Size(288, 38);
            txtNeighborhood.TabIndex = 38;
            txtNeighborhood.TabStop = false;
            txtNeighborhood.UseSystemPasswordChar = false;
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
            txtComplement.Location = new Point(15, 278);
            txtComplement.MaxLength = 32767;
            txtComplement.Multiline = false;
            txtComplement.Name = "txtComplement";
            txtComplement.PasswordChar = '\0';
            txtComplement.ScrollBars = ScrollBars.None;
            txtComplement.SelectedText = "";
            txtComplement.SelectionLength = 0;
            txtComplement.SelectionStart = 0;
            txtComplement.Size = new Size(538, 38);
            txtComplement.TabIndex = 41;
            txtComplement.TabStop = false;
            txtComplement.UseSystemPasswordChar = false;
            // 
            // comboBoxState
            // 
            comboBoxState.DrawMode = DrawMode.OwnerDrawFixed;
            comboBoxState.FlatStyle = FlatStyle.Flat;
            comboBoxState.Font = new Font("Segoe UI", 12F);
            comboBoxState.FormattingEnabled = true;
            comboBoxState.ItemHeight = 26;
            comboBoxState.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            comboBoxState.Location = new Point(432, 239);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(121, 32);
            comboBoxState.TabIndex = 40;
            comboBoxState.Text = "UF";
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
            txtCity.Location = new Point(309, 236);
            txtCity.MaxLength = 32767;
            txtCity.Multiline = false;
            txtCity.Name = "txtCity";
            txtCity.PasswordChar = '\0';
            txtCity.ScrollBars = ScrollBars.None;
            txtCity.SelectedText = "";
            txtCity.SelectionLength = 0;
            txtCity.SelectionStart = 0;
            txtCity.Size = new Size(117, 38);
            txtCity.TabIndex = 39;
            txtCity.TabStop = false;
            txtCity.UseSystemPasswordChar = false;
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
            txtNumber.Location = new Point(464, 190);
            txtNumber.MaxLength = 32767;
            txtNumber.Multiline = false;
            txtNumber.Name = "txtNumber";
            txtNumber.PasswordChar = '\0';
            txtNumber.ScrollBars = ScrollBars.None;
            txtNumber.SelectedText = "";
            txtNumber.SelectionLength = 0;
            txtNumber.SelectionStart = 0;
            txtNumber.Size = new Size(89, 38);
            txtNumber.TabIndex = 37;
            txtNumber.TabStop = false;
            txtNumber.UseSystemPasswordChar = false;
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
            txtStreet.Location = new Point(138, 190);
            txtStreet.MaxLength = 32767;
            txtStreet.Multiline = false;
            txtStreet.Name = "txtStreet";
            txtStreet.PasswordChar = '\0';
            txtStreet.ScrollBars = ScrollBars.None;
            txtStreet.SelectedText = "";
            txtStreet.SelectionLength = 0;
            txtStreet.SelectionStart = 0;
            txtStreet.Size = new Size(320, 38);
            txtStreet.TabIndex = 36;
            txtStreet.TabStop = false;
            txtStreet.UseSystemPasswordChar = false;
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
            txtZipCode.Location = new Point(15, 190);
            txtZipCode.MaxLength = 32767;
            txtZipCode.Multiline = false;
            txtZipCode.Name = "txtZipCode";
            txtZipCode.PasswordChar = '\0';
            txtZipCode.ScrollBars = ScrollBars.None;
            txtZipCode.SelectedText = "";
            txtZipCode.SelectionLength = 0;
            txtZipCode.SelectionStart = 0;
            txtZipCode.Size = new Size(117, 38);
            txtZipCode.TabIndex = 35;
            txtZipCode.TabStop = false;
            txtZipCode.UseSystemPasswordChar = false;
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
            txtPassword.Location = new Point(15, 132);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(538, 38);
            txtPassword.TabIndex = 34;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
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
            txtUsername.Location = new Point(326, 44);
            txtUsername.MaxLength = 32767;
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.ScrollBars = ScrollBars.None;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.Size = new Size(227, 38);
            txtUsername.TabIndex = 32;
            txtUsername.TabStop = false;
            txtUsername.UseSystemPasswordChar = false;
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
            txtEmail.Location = new Point(15, 88);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.ScrollBars = ScrollBars.None;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.Size = new Size(538, 38);
            txtEmail.TabIndex = 33;
            txtEmail.TabStop = false;
            txtEmail.UseSystemPasswordChar = false;
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
            txtName.Location = new Point(15, 44);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(305, 38);
            txtName.TabIndex = 31;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Transparent;
            btnSalvar.BorderColor = Color.FromArgb(32, 34, 37);
            btnSalvar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSalvar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSalvar.Font = new Font("Microsoft Sans Serif", 12F);
            btnSalvar.Image = null;
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSalvar.Location = new Point(430, 486);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSalvar.PressedColor = Color.FromArgb(165, 37, 37);
            btnSalvar.Size = new Size(120, 40);
            btnSalvar.TabIndex = 52;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlignment = StringAlignment.Center;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.BorderColor = Color.FromArgb(32, 34, 37);
            btnCancelar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnCancelar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCancelar.Font = new Font("Microsoft Sans Serif", 12F);
            btnCancelar.Image = null;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnCancelar.Location = new Point(15, 486);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCancelar.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pBoxEyeVisible
            // 
            pBoxEyeVisible.BackgroundImage = Properties.Resources.eye_visible;
            pBoxEyeVisible.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxEyeVisible.Cursor = Cursors.Hand;
            pBoxEyeVisible.Location = new Point(511, 137);
            pBoxEyeVisible.Name = "pBoxEyeVisible";
            pBoxEyeVisible.Size = new Size(30, 30);
            pBoxEyeVisible.TabIndex = 55;
            pBoxEyeVisible.TabStop = false;
            pBoxEyeVisible.Click += pBoxEyeVisible_Click;
            // 
            // pBoxEyeHidden
            // 
            pBoxEyeHidden.BackgroundImage = Properties.Resources.eye_hidden;
            pBoxEyeHidden.BackgroundImageLayout = ImageLayout.Stretch;
            pBoxEyeHidden.Cursor = Cursors.Hand;
            pBoxEyeHidden.Location = new Point(511, 137);
            pBoxEyeHidden.Name = "pBoxEyeHidden";
            pBoxEyeHidden.Size = new Size(30, 30);
            pBoxEyeHidden.TabIndex = 54;
            pBoxEyeHidden.TabStop = false;
            pBoxEyeHidden.Click += pBoxEyeHidden_Click;
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 533);
            Controls.Add(pBoxEyeVisible);
            Controls.Add(pBoxEyeHidden);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(labelMunicipalRegistry);
            Controls.Add(labelCNPJ);
            Controls.Add(txtCNPJ);
            Controls.Add(txtMuniciaplRegistry);
            Controls.Add(dateTimeHospital);
            Controls.Add(lblCheckSimbolo);
            Controls.Add(lblCheckNumero);
            Controls.Add(lblCheckMinuscula);
            Controls.Add(lblCheckMaiuscula);
            Controls.Add(lblCheckTamanho);
            Controls.Add(txtNeighborhood);
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
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditProfileForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxEyeVisible).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxEyeHidden).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.FoxLabel labelMunicipalRegistry;
        private ReaLTaiizor.Controls.FoxLabel labelCNPJ;
        private ReaLTaiizor.Controls.HopeTextBox txtCNPJ;
        private ReaLTaiizor.Controls.HopeTextBox txtMuniciaplRegistry;
        private ReaLTaiizor.Controls.PoisonDateTime dateTimeHospital;
        private ReaLTaiizor.Controls.FoxLabel lblCheckSimbolo;
        private ReaLTaiizor.Controls.FoxLabel lblCheckNumero;
        private ReaLTaiizor.Controls.FoxLabel lblCheckMinuscula;
        private ReaLTaiizor.Controls.FoxLabel lblCheckMaiuscula;
        private ReaLTaiizor.Controls.FoxLabel lblCheckTamanho;
        private ReaLTaiizor.Controls.HopeTextBox txtNeighborhood;
        private ReaLTaiizor.Controls.HopeTextBox txtComplement;
        private ReaLTaiizor.Controls.HopeComboBox comboBoxState;
        private ReaLTaiizor.Controls.HopeTextBox txtCity;
        private ReaLTaiizor.Controls.HopeTextBox txtNumber;
        private ReaLTaiizor.Controls.HopeTextBox txtStreet;
        private ReaLTaiizor.Controls.HopeTextBox txtZipCode;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private ReaLTaiizor.Controls.HopeTextBox txtUsername;
        private ReaLTaiizor.Controls.HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.HopeTextBox txtName;
        private ReaLTaiizor.Controls.Button btnSalvar;
        private ReaLTaiizor.Controls.Button btnCancelar;
        private PictureBox pBoxEyeVisible;
        private PictureBox pBoxEyeHidden;
    }
}