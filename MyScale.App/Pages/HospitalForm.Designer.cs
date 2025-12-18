namespace MyScale.App.Pages
{
    partial class HospitalForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabPageUser = new TabPage();
            linkLblLogout = new ReaLTaiizor.Controls.LinkLabelEdit();
            lblMunicipalRegistry = new ReaLTaiizor.Controls.LabelEdit();
            lblComplement = new ReaLTaiizor.Controls.LabelEdit();
            lblZipCode = new ReaLTaiizor.Controls.LabelEdit();
            lblState = new ReaLTaiizor.Controls.LabelEdit();
            lblCity = new ReaLTaiizor.Controls.LabelEdit();
            lblNeighborhood = new ReaLTaiizor.Controls.LabelEdit();
            lblNumber = new ReaLTaiizor.Controls.LabelEdit();
            lblStreet = new ReaLTaiizor.Controls.LabelEdit();
            lblName = new ReaLTaiizor.Controls.LabelEdit();
            lblFoundationDate = new ReaLTaiizor.Controls.LabelEdit();
            lblCNPJ = new ReaLTaiizor.Controls.LabelEdit();
            lblEmail = new ReaLTaiizor.Controls.LabelEdit();
            lblExcluirConta = new ReaLTaiizor.Controls.LabelEdit();
            lblEditar = new ReaLTaiizor.Controls.LabelEdit();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            lblUsername = new ReaLTaiizor.Controls.LabelEdit();
            tabPageShifts = new TabPage();
            poisonTabControl1 = new ReaLTaiizor.Controls.PoisonTabControl();
            tabPage1 = new TabPage();
            poisonPanel1 = new ReaLTaiizor.Controls.PoisonPanel();
            lbllDuracao = new ReaLTaiizor.Controls.LabelEdit();
            btnCriaPlantao = new ReaLTaiizor.Controls.Button();
            lblPaymentAmount = new ReaLTaiizor.Controls.LabelEdit();
            lblFim = new ReaLTaiizor.Controls.LabelEdit();
            lblInicio = new ReaLTaiizor.Controls.LabelEdit();
            lblDia = new ReaLTaiizor.Controls.LabelEdit();
            labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            btnCalendario = new ReaLTaiizor.Controls.Button();
            txtPaymentAmount = new ReaLTaiizor.Controls.HopeTextBox();
            tabPage2 = new TabPage();
            gridShifts = new ReaLTaiizor.Controls.PoisonDataGridView();
            tabPageHospital = new ReaLTaiizor.Controls.TabPage();
            imageList1 = new ImageList(components);
            tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            tabPageShifts.SuspendLayout();
            poisonTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            poisonPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridShifts).BeginInit();
            tabPageHospital.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageUser
            // 
            tabPageUser.BackColor = Color.FromArgb(41, 50, 63);
            tabPageUser.Controls.Add(linkLblLogout);
            tabPageUser.Controls.Add(lblMunicipalRegistry);
            tabPageUser.Controls.Add(lblComplement);
            tabPageUser.Controls.Add(lblZipCode);
            tabPageUser.Controls.Add(lblState);
            tabPageUser.Controls.Add(lblCity);
            tabPageUser.Controls.Add(lblNeighborhood);
            tabPageUser.Controls.Add(lblNumber);
            tabPageUser.Controls.Add(lblStreet);
            tabPageUser.Controls.Add(lblName);
            tabPageUser.Controls.Add(lblFoundationDate);
            tabPageUser.Controls.Add(lblCNPJ);
            tabPageUser.Controls.Add(lblEmail);
            tabPageUser.Controls.Add(lblExcluirConta);
            tabPageUser.Controls.Add(lblEditar);
            tabPageUser.Controls.Add(hopePictureBox1);
            tabPageUser.Controls.Add(lblUsername);
            tabPageUser.Location = new Point(154, 4);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(1278, 854);
            tabPageUser.TabIndex = 2;
            tabPageUser.Text = "Usuário";
            // 
            // linkLblLogout
            // 
            linkLblLogout.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            linkLblLogout.AutoSize = true;
            linkLblLogout.BackColor = Color.Transparent;
            linkLblLogout.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLblLogout.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblLogout.LinkColor = Color.FromArgb(32, 34, 37);
            linkLblLogout.Location = new Point(19, 324);
            linkLblLogout.Name = "linkLblLogout";
            linkLblLogout.Size = new Size(124, 24);
            linkLblLogout.TabIndex = 16;
            linkLblLogout.TabStop = true;
            linkLblLogout.Text = "Sair (logout)";
            linkLblLogout.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            linkLblLogout.LinkClicked += linkLblLogout_LinkClicked;
            // 
            // lblMunicipalRegistry
            // 
            lblMunicipalRegistry.AutoSize = true;
            lblMunicipalRegistry.BackColor = Color.Transparent;
            lblMunicipalRegistry.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMunicipalRegistry.ForeColor = Color.Black;
            lblMunicipalRegistry.Location = new Point(284, 158);
            lblMunicipalRegistry.Name = "lblMunicipalRegistry";
            lblMunicipalRegistry.Size = new Size(173, 25);
            lblMunicipalRegistry.TabIndex = 15;
            lblMunicipalRegistry.Text = "Registro Municipal:";
            // 
            // lblComplement
            // 
            lblComplement.AutoSize = true;
            lblComplement.BackColor = Color.Transparent;
            lblComplement.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComplement.ForeColor = Color.Black;
            lblComplement.Location = new Point(284, 372);
            lblComplement.Name = "lblComplement";
            lblComplement.Size = new Size(131, 25);
            lblComplement.TabIndex = 14;
            lblComplement.Text = "Complemento";
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.BackColor = Color.Transparent;
            lblZipCode.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblZipCode.ForeColor = Color.Black;
            lblZipCode.Location = new Point(284, 347);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(49, 25);
            lblZipCode.TabIndex = 13;
            lblZipCode.Text = "CEP:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.BackColor = Color.Transparent;
            lblState.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblState.ForeColor = Color.Black;
            lblState.Location = new Point(284, 322);
            lblState.Name = "lblState";
            lblState.Size = new Size(77, 25);
            lblState.TabIndex = 12;
            lblState.Text = "Estado: ";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCity.ForeColor = Color.Black;
            lblCity.Location = new Point(284, 297);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(75, 25);
            lblCity.TabIndex = 11;
            lblCity.Text = "Cidade:";
            // 
            // lblNeighborhood
            // 
            lblNeighborhood.AutoSize = true;
            lblNeighborhood.BackColor = Color.Transparent;
            lblNeighborhood.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNeighborhood.ForeColor = Color.Black;
            lblNeighborhood.Location = new Point(284, 272);
            lblNeighborhood.Name = "lblNeighborhood";
            lblNeighborhood.Size = new Size(67, 25);
            lblNeighborhood.TabIndex = 10;
            lblNeighborhood.Text = "Bairro:";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.Transparent;
            lblNumber.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumber.ForeColor = Color.Black;
            lblNumber.Location = new Point(284, 247);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(85, 25);
            lblNumber.TabIndex = 9;
            lblNumber.Text = "Número:";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.BackColor = Color.Transparent;
            lblStreet.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStreet.ForeColor = Color.Black;
            lblStreet.Location = new Point(284, 222);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(53, 25);
            lblStreet.TabIndex = 8;
            lblStreet.Text = "Rua: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(284, 108);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 25);
            lblName.TabIndex = 7;
            lblName.Text = "Nome:";
            // 
            // lblFoundationDate
            // 
            lblFoundationDate.AutoSize = true;
            lblFoundationDate.BackColor = Color.Transparent;
            lblFoundationDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFoundationDate.ForeColor = Color.Black;
            lblFoundationDate.Location = new Point(284, 183);
            lblFoundationDate.Name = "lblFoundationDate";
            lblFoundationDate.Size = new Size(165, 25);
            lblFoundationDate.TabIndex = 6;
            lblFoundationDate.Text = "Data de fundação:";
            // 
            // lblCNPJ
            // 
            lblCNPJ.AutoSize = true;
            lblCNPJ.BackColor = Color.Transparent;
            lblCNPJ.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCNPJ.ForeColor = Color.Black;
            lblCNPJ.Location = new Point(284, 133);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(59, 25);
            lblCNPJ.TabIndex = 5;
            lblCNPJ.Text = "CNPJ:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(286, 49);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(159, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email do Usuário:";
            // 
            // lblExcluirConta
            // 
            lblExcluirConta.AutoSize = true;
            lblExcluirConta.BackColor = Color.Transparent;
            lblExcluirConta.Cursor = Cursors.Hand;
            lblExcluirConta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblExcluirConta.ForeColor = Color.Black;
            lblExcluirConta.Location = new Point(19, 290);
            lblExcluirConta.Name = "lblExcluirConta";
            lblExcluirConta.Size = new Size(152, 24);
            lblExcluirConta.TabIndex = 3;
            lblExcluirConta.Text = "Excluir Usuário";
            lblExcluirConta.Click += lblExcluirConta_Click;
            // 
            // lblEditar
            // 
            lblEditar.AutoSize = true;
            lblEditar.BackColor = Color.Transparent;
            lblEditar.Cursor = Cursors.Hand;
            lblEditar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblEditar.ForeColor = Color.Black;
            lblEditar.Location = new Point(19, 256);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(184, 24);
            lblEditar.TabIndex = 2;
            lblEditar.Text = "Editar informações";
            lblEditar.Click += labelEdit4_Click;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.BackgroundImage = Properties.Resources.user;
            hopePictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            hopePictureBox1.Location = new Point(19, 17);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(225, 225);
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 1;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(284, 17);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(229, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nome do Usuário: ";
            // 
            // tabPageShifts
            // 
            tabPageShifts.BackColor = Color.FromArgb(41, 50, 63);
            tabPageShifts.Controls.Add(poisonTabControl1);
            tabPageShifts.Location = new Point(154, 4);
            tabPageShifts.Name = "tabPageShifts";
            tabPageShifts.Padding = new Padding(3);
            tabPageShifts.Size = new Size(1278, 854);
            tabPageShifts.TabIndex = 1;
            tabPageShifts.Text = "Plantões";
            // 
            // poisonTabControl1
            // 
            poisonTabControl1.Controls.Add(tabPage1);
            poisonTabControl1.Controls.Add(tabPage2);
            poisonTabControl1.Dock = DockStyle.Fill;
            poisonTabControl1.Location = new Point(3, 3);
            poisonTabControl1.Name = "poisonTabControl1";
            poisonTabControl1.Padding = new Point(6, 8);
            poisonTabControl1.SelectedIndex = 0;
            poisonTabControl1.Size = new Size(1272, 848);
            poisonTabControl1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            poisonTabControl1.TabIndex = 0;
            poisonTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(poisonPanel1);
            tabPage1.Controls.Add(labelEdit2);
            tabPage1.Controls.Add(labelEdit1);
            tabPage1.Controls.Add(btnCalendario);
            tabPage1.Controls.Add(txtPaymentAmount);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1264, 806);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastrar plantão";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // poisonPanel1
            // 
            poisonPanel1.Controls.Add(lbllDuracao);
            poisonPanel1.Controls.Add(btnCriaPlantao);
            poisonPanel1.Controls.Add(lblPaymentAmount);
            poisonPanel1.Controls.Add(lblFim);
            poisonPanel1.Controls.Add(lblInicio);
            poisonPanel1.Controls.Add(lblDia);
            poisonPanel1.HorizontalScrollbarBarColor = true;
            poisonPanel1.HorizontalScrollbarHighlightOnWheel = false;
            poisonPanel1.HorizontalScrollbarSize = 10;
            poisonPanel1.Location = new Point(453, 37);
            poisonPanel1.Name = "poisonPanel1";
            poisonPanel1.Size = new Size(359, 125);
            poisonPanel1.TabIndex = 6;
            poisonPanel1.VerticalScrollbarBarColor = true;
            poisonPanel1.VerticalScrollbarHighlightOnWheel = false;
            poisonPanel1.VerticalScrollbarSize = 10;
            // 
            // lbllDuracao
            // 
            lbllDuracao.AutoSize = true;
            lbllDuracao.BackColor = Color.Transparent;
            lbllDuracao.Font = new Font("Microsoft Sans Serif", 9F);
            lbllDuracao.ForeColor = Color.Black;
            lbllDuracao.Location = new Point(3, 92);
            lbllDuracao.Name = "lbllDuracao";
            lbllDuracao.Size = new Size(101, 15);
            lbllDuracao.TabIndex = 8;
            lbllDuracao.Text = "Duração: _ horas";
            // 
            // btnCriaPlantao
            // 
            btnCriaPlantao.BackColor = Color.Transparent;
            btnCriaPlantao.BorderColor = Color.SeaGreen;
            btnCriaPlantao.EnteredBorderColor = Color.MediumSeaGreen;
            btnCriaPlantao.EnteredColor = Color.MediumSeaGreen;
            btnCriaPlantao.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCriaPlantao.Image = null;
            btnCriaPlantao.ImageAlign = ContentAlignment.MiddleLeft;
            btnCriaPlantao.InactiveColor = Color.SeaGreen;
            btnCriaPlantao.Location = new Point(228, 82);
            btnCriaPlantao.Name = "btnCriaPlantao";
            btnCriaPlantao.PressedBorderColor = Color.SpringGreen;
            btnCriaPlantao.PressedColor = Color.SpringGreen;
            btnCriaPlantao.Size = new Size(126, 38);
            btnCriaPlantao.TabIndex = 7;
            btnCriaPlantao.Text = "Criar plantão";
            btnCriaPlantao.TextAlignment = StringAlignment.Center;
            btnCriaPlantao.Click += btnCriarPlantao_Click;
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.AutoSize = true;
            lblPaymentAmount.BackColor = Color.Transparent;
            lblPaymentAmount.Font = new Font("Microsoft Sans Serif", 9F);
            lblPaymentAmount.ForeColor = Color.Black;
            lblPaymentAmount.Location = new Point(3, 70);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(181, 15);
            lblPaymentAmount.TabIndex = 5;
            lblPaymentAmount.Text = "Valor do pagamento: R$ ___,__";
            // 
            // lblFim
            // 
            lblFim.AutoSize = true;
            lblFim.BackColor = Color.Transparent;
            lblFim.Font = new Font("Microsoft Sans Serif", 9F);
            lblFim.ForeColor = Color.Black;
            lblFim.Location = new Point(3, 50);
            lblFim.Name = "lblFim";
            lblFim.Size = new Size(126, 15);
            lblFim.TabIndex = 4;
            lblFim.Text = "Fim do plantão: __:__";
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.BackColor = Color.Transparent;
            lblInicio.Font = new Font("Microsoft Sans Serif", 9F);
            lblInicio.ForeColor = Color.Black;
            lblInicio.Location = new Point(3, 30);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(134, 15);
            lblInicio.TabIndex = 3;
            lblInicio.Text = "Início do plantão: __:__";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.BackColor = Color.Transparent;
            lblDia.Font = new Font("Microsoft Sans Serif", 9F);
            lblDia.ForeColor = Color.Black;
            lblDia.Location = new Point(3, 10);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(94, 15);
            lblDia.TabIndex = 2;
            lblDia.Text = "Dia: __/__/____";
            // 
            // labelEdit2
            // 
            labelEdit2.AutoSize = true;
            labelEdit2.BackColor = Color.Transparent;
            labelEdit2.Font = new Font("Microsoft Sans Serif", 9F);
            labelEdit2.ForeColor = Color.Black;
            labelEdit2.Location = new Point(20, 106);
            labelEdit2.Name = "labelEdit2";
            labelEdit2.Size = new Size(283, 15);
            labelEdit2.TabIndex = 5;
            labelEdit2.Text = "Escolha o dia e horários de Início e Fim do plantão";
            // 
            // labelEdit1
            // 
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Font = new Font("Microsoft Sans Serif", 9F);
            labelEdit1.ForeColor = Color.Black;
            labelEdit1.Location = new Point(20, 37);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(359, 15);
            labelEdit1.TabIndex = 4;
            labelEdit1.Text = "Digite o valor a ser pago para o Agente de saúde (ex: R$ 250,00)";
            // 
            // btnCalendario
            // 
            btnCalendario.BackColor = Color.Transparent;
            btnCalendario.BorderColor = Color.SeaGreen;
            btnCalendario.EnteredBorderColor = Color.MediumSeaGreen;
            btnCalendario.EnteredColor = Color.MediumSeaGreen;
            btnCalendario.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalendario.Image = null;
            btnCalendario.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalendario.InactiveColor = Color.SeaGreen;
            btnCalendario.Location = new Point(20, 124);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.PressedBorderColor = Color.SpringGreen;
            btnCalendario.PressedColor = Color.SpringGreen;
            btnCalendario.Size = new Size(359, 38);
            btnCalendario.TabIndex = 3;
            btnCalendario.Text = "Definir dia e horário";
            btnCalendario.TextAlignment = StringAlignment.Center;
            btnCalendario.Click += btnCalendario_Click;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.BackColor = Color.White;
            txtPaymentAmount.BaseColor = Color.White;
            txtPaymentAmount.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPaymentAmount.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPaymentAmount.Font = new Font("Segoe UI", 12F);
            txtPaymentAmount.ForeColor = Color.Black;
            txtPaymentAmount.Hint = "Valor";
            txtPaymentAmount.Location = new Point(20, 55);
            txtPaymentAmount.MaxLength = 32767;
            txtPaymentAmount.Multiline = false;
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.PasswordChar = '\0';
            txtPaymentAmount.ScrollBars = ScrollBars.None;
            txtPaymentAmount.SelectedText = "";
            txtPaymentAmount.SelectionLength = 0;
            txtPaymentAmount.SelectionStart = 0;
            txtPaymentAmount.Size = new Size(359, 38);
            txtPaymentAmount.TabIndex = 2;
            txtPaymentAmount.TabStop = false;
            txtPaymentAmount.UseSystemPasswordChar = false;
            txtPaymentAmount.Leave += txtPaymentAmount_Leave;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(gridShifts);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1264, 806);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consultar plantões";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridShifts
            // 
            gridShifts.AllowUserToAddRows = false;
            gridShifts.AllowUserToDeleteRows = false;
            gridShifts.AllowUserToOrderColumns = true;
            gridShifts.AllowUserToResizeRows = false;
            gridShifts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridShifts.BackgroundColor = Color.FromArgb(255, 255, 255);
            gridShifts.BorderStyle = BorderStyle.None;
            gridShifts.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            gridShifts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridShifts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridShifts.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridShifts.DefaultCellStyle = dataGridViewCellStyle2;
            gridShifts.Dock = DockStyle.Fill;
            gridShifts.EnableHeadersVisualStyles = false;
            gridShifts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            gridShifts.GridColor = Color.FromArgb(255, 255, 255);
            gridShifts.Location = new Point(3, 3);
            gridShifts.MultiSelect = false;
            gridShifts.Name = "gridShifts";
            gridShifts.ReadOnly = true;
            gridShifts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridShifts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridShifts.RowHeadersVisible = false;
            gridShifts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridShifts.Size = new Size(1258, 800);
            gridShifts.TabIndex = 0;
            gridShifts.CellDoubleClick += gridShifts_CellDoubleClick;
            gridShifts.CellFormatting += gridShifts_CellFormatting;
            // 
            // tabPageHospital
            // 
            tabPageHospital.ActiveForeColor = Color.Black;
            tabPageHospital.ActiveLineTabColor = Color.MediumSeaGreen;
            tabPageHospital.ActiveTabColor = Color.SpringGreen;
            tabPageHospital.Alignment = TabAlignment.Left;
            tabPageHospital.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            tabPageHospital.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            tabPageHospital.ControlBackColor = Color.MediumSeaGreen;
            tabPageHospital.Controls.Add(tabPageShifts);
            tabPageHospital.Controls.Add(tabPageUser);
            tabPageHospital.Dock = DockStyle.Fill;
            tabPageHospital.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabPageHospital.FrameColor = Color.MediumSeaGreen;
            tabPageHospital.ImageList = imageList1;
            tabPageHospital.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            tabPageHospital.ItemSize = new Size(60, 150);
            tabPageHospital.LineColor = Color.MediumSeaGreen;
            tabPageHospital.LineTabColor = Color.SeaGreen;
            tabPageHospital.Location = new Point(2, 36);
            tabPageHospital.Multiline = true;
            tabPageHospital.Name = "tabPageHospital";
            tabPageHospital.NormalForeColor = Color.White;
            tabPageHospital.PageColor = Color.White;
            tabPageHospital.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            tabPageHospital.SelectedIndex = 0;
            tabPageHospital.Size = new Size(1436, 862);
            tabPageHospital.SizeMode = TabSizeMode.Fixed;
            tabPageHospital.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tabPageHospital.StringType = StringAlignment.Near;
            tabPageHospital.TabColor = Color.SeaGreen;
            tabPageHospital.TabIndex = 0;
            tabPageHospital.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(32, 32);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // HospitalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderColor = Color.Transparent;
            ClientSize = new Size(1440, 900);
            Controls.Add(tabPageHospital);
            HeaderColor = Color.SeaGreen;
            Name = "HospitalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyScale";
            WindowState = FormWindowState.Maximized;
            tabPageUser.ResumeLayout(false);
            tabPageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            tabPageShifts.ResumeLayout(false);
            poisonTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            poisonPanel1.ResumeLayout(false);
            poisonPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridShifts).EndInit();
            tabPageHospital.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageUser;
        private TabPage tabPageShifts;
        private ReaLTaiizor.Controls.TabPage tabPageHospital;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.PoisonTabControl poisonTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.Button btnCalendario;
        private ReaLTaiizor.Controls.HopeTextBox txtPaymentAmount;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.PoisonPanel poisonPanel1;
        private ReaLTaiizor.Controls.Button btnCriaPlantao;
        private ReaLTaiizor.Controls.LabelEdit lblPaymentAmount;
        private ReaLTaiizor.Controls.LabelEdit lblFim;
        private ReaLTaiizor.Controls.LabelEdit lblInicio;
        private ReaLTaiizor.Controls.LabelEdit lblDia;
        private ReaLTaiizor.Controls.LabelEdit lbllDuracao;
        private ReaLTaiizor.Controls.PoisonDataGridView gridShifts;
        private ReaLTaiizor.Controls.LabelEdit lblUsername;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.LabelEdit lblEmail;
        private ReaLTaiizor.Controls.LabelEdit lblExcluirConta;
        private ReaLTaiizor.Controls.LabelEdit labelEdit5;
        private ReaLTaiizor.Controls.LabelEdit lblEditar;
        private ReaLTaiizor.Controls.LabelEdit lblZipCode;
        private ReaLTaiizor.Controls.LabelEdit lblState;
        private ReaLTaiizor.Controls.LabelEdit lblCity;
        private ReaLTaiizor.Controls.LabelEdit lblNeighborhood;
        private ReaLTaiizor.Controls.LabelEdit lblNumber;
        private ReaLTaiizor.Controls.LabelEdit lblStreet;
        private ReaLTaiizor.Controls.LabelEdit lblName;
        private ReaLTaiizor.Controls.LabelEdit lblFoundationDate;
        private ReaLTaiizor.Controls.LabelEdit lblCNPJ;
        private ReaLTaiizor.Controls.LabelEdit lblComplement;
        private ReaLTaiizor.Controls.LabelEdit lblMunicipalRegistry;
        private ReaLTaiizor.Controls.LinkLabelEdit linkLblLogout;
    }
}