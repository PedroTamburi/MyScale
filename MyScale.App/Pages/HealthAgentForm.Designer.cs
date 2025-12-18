namespace MyScale.App.Pages
{
    partial class HealthAgentForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabPageHospital = new ReaLTaiizor.Controls.TabPage();
            tabPageShifts = new TabPage();
            tabControlAgenteShifts = new ReaLTaiizor.Controls.PoisonTabControl();
            tabPage2 = new TabPage();
            gridShifts = new ReaLTaiizor.Controls.PoisonDataGridView();
            tabPage1 = new TabPage();
            gridMyShifts = new ReaLTaiizor.Controls.PoisonDataGridView();
            tabPageUser = new TabPage();
            linkLblEditInformations = new ReaLTaiizor.Controls.LinkLabelEdit();
            linkLblDeleteAccount = new ReaLTaiizor.Controls.LinkLabelEdit();
            linkLblLogout = new ReaLTaiizor.Controls.LinkLabelEdit();
            lblDocument = new ReaLTaiizor.Controls.LabelEdit();
            lblComplement = new ReaLTaiizor.Controls.LabelEdit();
            lblZipCode = new ReaLTaiizor.Controls.LabelEdit();
            lblState = new ReaLTaiizor.Controls.LabelEdit();
            lblCity = new ReaLTaiizor.Controls.LabelEdit();
            lblNeighborhood = new ReaLTaiizor.Controls.LabelEdit();
            lblNumber = new ReaLTaiizor.Controls.LabelEdit();
            lblStreet = new ReaLTaiizor.Controls.LabelEdit();
            lblName = new ReaLTaiizor.Controls.LabelEdit();
            lblBirthDate = new ReaLTaiizor.Controls.LabelEdit();
            lblEmail = new ReaLTaiizor.Controls.LabelEdit();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            lblUsername = new ReaLTaiizor.Controls.LabelEdit();
            tabPageHospital.SuspendLayout();
            tabPageShifts.SuspendLayout();
            tabControlAgenteShifts.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridShifts).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridMyShifts).BeginInit();
            tabPageUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
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
            tabPageHospital.Size = new Size(1461, 825);
            tabPageHospital.SizeMode = TabSizeMode.Fixed;
            tabPageHospital.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tabPageHospital.StringType = StringAlignment.Near;
            tabPageHospital.TabColor = Color.SeaGreen;
            tabPageHospital.TabIndex = 1;
            tabPageHospital.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tabPageShifts
            // 
            tabPageShifts.BackColor = Color.White;
            tabPageShifts.Controls.Add(tabControlAgenteShifts);
            tabPageShifts.Location = new Point(154, 4);
            tabPageShifts.Name = "tabPageShifts";
            tabPageShifts.Padding = new Padding(3);
            tabPageShifts.Size = new Size(1303, 817);
            tabPageShifts.TabIndex = 1;
            tabPageShifts.Text = "Plantões";
            // 
            // tabControlAgenteShifts
            // 
            tabControlAgenteShifts.Controls.Add(tabPage2);
            tabControlAgenteShifts.Controls.Add(tabPage1);
            tabControlAgenteShifts.Dock = DockStyle.Fill;
            tabControlAgenteShifts.Location = new Point(3, 3);
            tabControlAgenteShifts.Name = "tabControlAgenteShifts";
            tabControlAgenteShifts.Padding = new Point(6, 8);
            tabControlAgenteShifts.SelectedIndex = 0;
            tabControlAgenteShifts.Size = new Size(1297, 811);
            tabControlAgenteShifts.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            tabControlAgenteShifts.TabIndex = 2;
            tabControlAgenteShifts.UseSelectable = true;
            tabControlAgenteShifts.SelectedIndexChanged += tabControlAgenteShifts_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(gridShifts);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1289, 769);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Plantões Disponíveis";
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
            gridShifts.Size = new Size(1283, 763);
            gridShifts.TabIndex = 0;
            gridShifts.CellDoubleClick += gridShifts_CellDoubleClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(gridMyShifts);
            tabPage1.Location = new Point(4, 35);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1289, 772);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Meus Plantões";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridMyShifts
            // 
            gridMyShifts.AllowUserToAddRows = false;
            gridMyShifts.AllowUserToDeleteRows = false;
            gridMyShifts.AllowUserToOrderColumns = true;
            gridMyShifts.AllowUserToResizeRows = false;
            gridMyShifts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridMyShifts.BackgroundColor = Color.FromArgb(255, 255, 255);
            gridMyShifts.BorderStyle = BorderStyle.None;
            gridMyShifts.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            gridMyShifts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridMyShifts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridMyShifts.ColumnHeadersHeight = 35;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.PaleGreen;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            gridMyShifts.DefaultCellStyle = dataGridViewCellStyle5;
            gridMyShifts.Dock = DockStyle.Fill;
            gridMyShifts.EnableHeadersVisualStyles = false;
            gridMyShifts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            gridMyShifts.GridColor = Color.FromArgb(255, 255, 255);
            gridMyShifts.Location = new Point(3, 3);
            gridMyShifts.MultiSelect = false;
            gridMyShifts.Name = "gridMyShifts";
            gridMyShifts.ReadOnly = true;
            gridMyShifts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridMyShifts.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            gridMyShifts.RowHeadersVisible = false;
            gridMyShifts.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridMyShifts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridMyShifts.Size = new Size(1283, 766);
            gridMyShifts.TabIndex = 1;
            gridMyShifts.CellDoubleClick += gridMyShifts_CellDoubleClick;
            // 
            // tabPageUser
            // 
            tabPageUser.BackColor = Color.White;
            tabPageUser.Controls.Add(linkLblEditInformations);
            tabPageUser.Controls.Add(linkLblDeleteAccount);
            tabPageUser.Controls.Add(linkLblLogout);
            tabPageUser.Controls.Add(lblDocument);
            tabPageUser.Controls.Add(lblComplement);
            tabPageUser.Controls.Add(lblZipCode);
            tabPageUser.Controls.Add(lblState);
            tabPageUser.Controls.Add(lblCity);
            tabPageUser.Controls.Add(lblNeighborhood);
            tabPageUser.Controls.Add(lblNumber);
            tabPageUser.Controls.Add(lblStreet);
            tabPageUser.Controls.Add(lblName);
            tabPageUser.Controls.Add(lblBirthDate);
            tabPageUser.Controls.Add(lblEmail);
            tabPageUser.Controls.Add(hopePictureBox1);
            tabPageUser.Controls.Add(lblUsername);
            tabPageUser.Location = new Point(154, 4);
            tabPageUser.Name = "tabPageUser";
            tabPageUser.Padding = new Padding(3);
            tabPageUser.Size = new Size(1303, 817);
            tabPageUser.TabIndex = 2;
            tabPageUser.Text = "Usuário";
            // 
            // linkLblEditInformations
            // 
            linkLblEditInformations.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            linkLblEditInformations.AutoSize = true;
            linkLblEditInformations.BackColor = Color.Transparent;
            linkLblEditInformations.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLblEditInformations.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblEditInformations.LinkColor = Color.FromArgb(32, 34, 37);
            linkLblEditInformations.Location = new Point(22, 262);
            linkLblEditInformations.Name = "linkLblEditInformations";
            linkLblEditInformations.Size = new Size(184, 24);
            linkLblEditInformations.TabIndex = 19;
            linkLblEditInformations.TabStop = true;
            linkLblEditInformations.Text = "Editar Informações";
            linkLblEditInformations.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            linkLblEditInformations.LinkClicked += linkLblEditInformations_LinkClicked;
            // 
            // linkLblDeleteAccount
            // 
            linkLblDeleteAccount.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            linkLblDeleteAccount.AutoSize = true;
            linkLblDeleteAccount.BackColor = Color.Transparent;
            linkLblDeleteAccount.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLblDeleteAccount.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblDeleteAccount.LinkColor = Color.FromArgb(32, 34, 37);
            linkLblDeleteAccount.Location = new Point(22, 300);
            linkLblDeleteAccount.Name = "linkLblDeleteAccount";
            linkLblDeleteAccount.Size = new Size(133, 24);
            linkLblDeleteAccount.TabIndex = 18;
            linkLblDeleteAccount.TabStop = true;
            linkLblDeleteAccount.Text = "Deletar conta";
            linkLblDeleteAccount.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            linkLblDeleteAccount.LinkClicked += linkLblDeleteAccount_LinkClicked;
            // 
            // linkLblLogout
            // 
            linkLblLogout.ActiveLinkColor = Color.FromArgb(153, 34, 34);
            linkLblLogout.AutoSize = true;
            linkLblLogout.BackColor = Color.Transparent;
            linkLblLogout.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLblLogout.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLblLogout.LinkColor = Color.FromArgb(32, 34, 37);
            linkLblLogout.Location = new Point(22, 339);
            linkLblLogout.Name = "linkLblLogout";
            linkLblLogout.Size = new Size(124, 24);
            linkLblLogout.TabIndex = 17;
            linkLblLogout.TabStop = true;
            linkLblLogout.Text = "Sair (logout)";
            linkLblLogout.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            linkLblLogout.LinkClicked += linkLblLogout_LinkClicked;
            // 
            // lblDocument
            // 
            lblDocument.AutoSize = true;
            lblDocument.BackColor = Color.Transparent;
            lblDocument.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDocument.ForeColor = Color.Black;
            lblDocument.Location = new Point(287, 136);
            lblDocument.Name = "lblDocument";
            lblDocument.Size = new Size(163, 25);
            lblDocument.TabIndex = 15;
            lblDocument.Text = "Documento (CPF):";
            // 
            // lblComplement
            // 
            lblComplement.AutoSize = true;
            lblComplement.BackColor = Color.Transparent;
            lblComplement.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComplement.ForeColor = Color.Black;
            lblComplement.Location = new Point(287, 367);
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
            lblZipCode.Location = new Point(287, 342);
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
            lblState.Location = new Point(287, 317);
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
            lblCity.Location = new Point(287, 292);
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
            lblNeighborhood.Location = new Point(287, 267);
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
            lblNumber.Location = new Point(287, 242);
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
            lblStreet.Location = new Point(287, 217);
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
            lblName.Location = new Point(287, 111);
            lblName.Name = "lblName";
            lblName.Size = new Size(67, 25);
            lblName.TabIndex = 7;
            lblName.Text = "Nome:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.BackColor = Color.Transparent;
            lblBirthDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBirthDate.ForeColor = Color.Black;
            lblBirthDate.Location = new Point(289, 161);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(188, 25);
            lblBirthDate.TabIndex = 6;
            lblBirthDate.Text = "Data de nascimento: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(289, 52);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(159, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email do Usuário:";
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
            lblUsername.Location = new Point(287, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(229, 32);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Nome do Usuário: ";
            // 
            // HealthAgentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderColor = Color.Transparent;
            ClientSize = new Size(1465, 863);
            Controls.Add(tabPageHospital);
            HeaderColor = Color.SeaGreen;
            Name = "HealthAgentForm";
            Text = "HealthAgentForm";
            WindowState = FormWindowState.Maximized;
            Load += HealthAgentForm_Load;
            tabPageHospital.ResumeLayout(false);
            tabPageShifts.ResumeLayout(false);
            tabControlAgenteShifts.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridShifts).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridMyShifts).EndInit();
            tabPageUser.ResumeLayout(false);
            tabPageUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.TabPage tabPageHospital;
        private TabPage tabPageShifts;
        private ReaLTaiizor.Controls.PoisonTabControl tabControlAgenteShifts;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.PoisonDataGridView gridShifts;
        private TabPage tabPageUser;
        private ReaLTaiizor.Controls.LabelEdit lblMunicipalRegistry;
        private ReaLTaiizor.Controls.LabelEdit lblComplement;
        private ReaLTaiizor.Controls.LabelEdit lblZipCode;
        private ReaLTaiizor.Controls.LabelEdit lblState;
        private ReaLTaiizor.Controls.LabelEdit lblCity;
        private ReaLTaiizor.Controls.LabelEdit lblNeighborhood;
        private ReaLTaiizor.Controls.LabelEdit lblNumber;
        private ReaLTaiizor.Controls.LabelEdit lblStreet;
        private ReaLTaiizor.Controls.LabelEdit lblName;
        private ReaLTaiizor.Controls.LabelEdit lblBirthDate;
        private ReaLTaiizor.Controls.LabelEdit lblCNPJ;
        private ReaLTaiizor.Controls.LabelEdit lblEmail;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.LabelEdit lblUsername;
        private TabPage tabPage1;
        private ReaLTaiizor.Controls.PoisonDataGridView gridMyShifts;
        private ReaLTaiizor.Controls.LinkLabelEdit linkLblEditInformations;
        private ReaLTaiizor.Controls.LinkLabelEdit linkLblDeleteAccount;
        private ReaLTaiizor.Controls.LinkLabelEdit linkLblLogout;
        private ReaLTaiizor.Controls.LabelEdit lblDocument;
    }
}