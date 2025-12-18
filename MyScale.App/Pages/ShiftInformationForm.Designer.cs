namespace MyScale.App.Pages
{
    partial class ShiftInformationForm
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
            button1 = new ReaLTaiizor.Controls.Button();
            button2 = new ReaLTaiizor.Controls.Button();
            labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            lblName = new ReaLTaiizor.Controls.LabelEdit();
            lblMunicipalRegistry = new ReaLTaiizor.Controls.LabelEdit();
            lblCNPJ = new ReaLTaiizor.Controls.LabelEdit();
            lblFoundationDate = new ReaLTaiizor.Controls.LabelEdit();
            lblEmail = new ReaLTaiizor.Controls.LabelEdit();
            lblRegisterDate = new ReaLTaiizor.Controls.LabelEdit();
            labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            lblStreet = new ReaLTaiizor.Controls.LabelEdit();
            lblNeighborhood = new ReaLTaiizor.Controls.LabelEdit();
            lblNumber = new ReaLTaiizor.Controls.LabelEdit();
            lblCity = new ReaLTaiizor.Controls.LabelEdit();
            lblState = new ReaLTaiizor.Controls.LabelEdit();
            lblZipCode = new ReaLTaiizor.Controls.LabelEdit();
            lblComplement = new ReaLTaiizor.Controls.LabelEdit();
            labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            lblHour = new ReaLTaiizor.Controls.LabelEdit();
            lblDate = new ReaLTaiizor.Controls.LabelEdit();
            lblPaymentAmount = new ReaLTaiizor.Controls.LabelEdit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonShadow;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelEdit1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(430, 37);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelEdit1
            // 
            labelEdit1.Anchor = AnchorStyles.None;
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdit1.ForeColor = Color.Black;
            labelEdit1.Location = new Point(101, 6);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(228, 24);
            labelEdit1.TabIndex = 0;
            labelEdit1.Text = "Informações do plantão";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(298, 512);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(120, 40);
            button1.TabIndex = 1;
            button1.Text = "Desistir do plantão";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += btnDesistir_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.FromArgb(32, 34, 37);
            button2.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button2.EnteredColor = Color.FromArgb(32, 34, 37);
            button2.Font = new Font("Microsoft Sans Serif", 12F);
            button2.Image = null;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.InactiveColor = Color.FromArgb(32, 34, 37);
            button2.Location = new Point(12, 512);
            button2.Name = "button2";
            button2.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button2.PressedColor = Color.FromArgb(165, 37, 37);
            button2.Size = new Size(120, 40);
            button2.TabIndex = 2;
            button2.Text = "Voltar";
            button2.TextAlignment = StringAlignment.Center;
            button2.Click += btnVoltar_Click;
            // 
            // labelEdit2
            // 
            labelEdit2.Anchor = AnchorStyles.None;
            labelEdit2.AutoSize = true;
            labelEdit2.BackColor = Color.Transparent;
            labelEdit2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdit2.ForeColor = Color.DarkTurquoise;
            labelEdit2.Location = new Point(12, 50);
            labelEdit2.Name = "labelEdit2";
            labelEdit2.Size = new Size(235, 24);
            labelEdit2.TabIndex = 3;
            labelEdit2.Text = "Informações do Hospital";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(12, 74);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Nome: ";
            // 
            // lblMunicipalRegistry
            // 
            lblMunicipalRegistry.Anchor = AnchorStyles.None;
            lblMunicipalRegistry.AutoSize = true;
            lblMunicipalRegistry.BackColor = Color.Transparent;
            lblMunicipalRegistry.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMunicipalRegistry.ForeColor = Color.Black;
            lblMunicipalRegistry.Location = new Point(12, 94);
            lblMunicipalRegistry.Name = "lblMunicipalRegistry";
            lblMunicipalRegistry.Size = new Size(162, 20);
            lblMunicipalRegistry.TabIndex = 5;
            lblMunicipalRegistry.Text = "Registro municipal:";
            // 
            // lblCNPJ
            // 
            lblCNPJ.Anchor = AnchorStyles.None;
            lblCNPJ.AutoSize = true;
            lblCNPJ.BackColor = Color.Transparent;
            lblCNPJ.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCNPJ.ForeColor = Color.Black;
            lblCNPJ.Location = new Point(12, 114);
            lblCNPJ.Name = "lblCNPJ";
            lblCNPJ.Size = new Size(58, 20);
            lblCNPJ.TabIndex = 6;
            lblCNPJ.Text = "CNPJ:";
            // 
            // lblFoundationDate
            // 
            lblFoundationDate.Anchor = AnchorStyles.None;
            lblFoundationDate.AutoSize = true;
            lblFoundationDate.BackColor = Color.Transparent;
            lblFoundationDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoundationDate.ForeColor = Color.Black;
            lblFoundationDate.Location = new Point(12, 134);
            lblFoundationDate.Name = "lblFoundationDate";
            lblFoundationDate.Size = new Size(163, 20);
            lblFoundationDate.TabIndex = 7;
            lblFoundationDate.Text = "Data de fundação: ";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(12, 154);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 20);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // lblRegisterDate
            // 
            lblRegisterDate.Anchor = AnchorStyles.None;
            lblRegisterDate.AutoSize = true;
            lblRegisterDate.BackColor = Color.Transparent;
            lblRegisterDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegisterDate.ForeColor = Color.Black;
            lblRegisterDate.Location = new Point(12, 174);
            lblRegisterDate.Name = "lblRegisterDate";
            lblRegisterDate.Size = new Size(149, 20);
            lblRegisterDate.TabIndex = 9;
            lblRegisterDate.Text = "Data de registro: ";
            // 
            // labelEdit3
            // 
            labelEdit3.Anchor = AnchorStyles.None;
            labelEdit3.AutoSize = true;
            labelEdit3.BackColor = Color.Transparent;
            labelEdit3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdit3.ForeColor = Color.DarkTurquoise;
            labelEdit3.Location = new Point(12, 199);
            labelEdit3.Name = "labelEdit3";
            labelEdit3.Size = new Size(102, 24);
            labelEdit3.TabIndex = 10;
            labelEdit3.Text = "Endereço";
            // 
            // lblStreet
            // 
            lblStreet.Anchor = AnchorStyles.None;
            lblStreet.AutoSize = true;
            lblStreet.BackColor = Color.Transparent;
            lblStreet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStreet.ForeColor = Color.Black;
            lblStreet.Location = new Point(12, 223);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(47, 20);
            lblStreet.TabIndex = 11;
            lblStreet.Text = "Rua:";
            // 
            // lblNeighborhood
            // 
            lblNeighborhood.Anchor = AnchorStyles.None;
            lblNeighborhood.AutoSize = true;
            lblNeighborhood.BackColor = Color.Transparent;
            lblNeighborhood.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNeighborhood.ForeColor = Color.Black;
            lblNeighborhood.Location = new Point(12, 263);
            lblNeighborhood.Name = "lblNeighborhood";
            lblNeighborhood.Size = new Size(62, 20);
            lblNeighborhood.TabIndex = 12;
            lblNeighborhood.Text = "Bairro:";
            // 
            // lblNumber
            // 
            lblNumber.Anchor = AnchorStyles.None;
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.Transparent;
            lblNumber.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.ForeColor = Color.Black;
            lblNumber.Location = new Point(12, 243);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(33, 20);
            lblNumber.TabIndex = 13;
            lblNumber.Text = "Nº:";
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.None;
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCity.ForeColor = Color.Black;
            lblCity.Location = new Point(12, 283);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(75, 20);
            lblCity.TabIndex = 14;
            lblCity.Text = "Cidade: ";
            // 
            // lblState
            // 
            lblState.Anchor = AnchorStyles.None;
            lblState.AutoSize = true;
            lblState.BackColor = Color.Transparent;
            lblState.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblState.ForeColor = Color.Black;
            lblState.Location = new Point(12, 303);
            lblState.Name = "lblState";
            lblState.Size = new Size(76, 20);
            lblState.TabIndex = 15;
            lblState.Text = "Estado: ";
            // 
            // lblZipCode
            // 
            lblZipCode.Anchor = AnchorStyles.None;
            lblZipCode.AutoSize = true;
            lblZipCode.BackColor = Color.Transparent;
            lblZipCode.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZipCode.ForeColor = Color.Black;
            lblZipCode.Location = new Point(12, 323);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(49, 20);
            lblZipCode.TabIndex = 16;
            lblZipCode.Text = "CEP:";
            // 
            // lblComplement
            // 
            lblComplement.Anchor = AnchorStyles.None;
            lblComplement.AutoSize = true;
            lblComplement.BackColor = Color.Transparent;
            lblComplement.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplement.ForeColor = Color.Black;
            lblComplement.Location = new Point(12, 343);
            lblComplement.Name = "lblComplement";
            lblComplement.Size = new Size(124, 20);
            lblComplement.TabIndex = 17;
            lblComplement.Text = "Complemento:";
            // 
            // labelEdit4
            // 
            labelEdit4.Anchor = AnchorStyles.None;
            labelEdit4.AutoSize = true;
            labelEdit4.BackColor = Color.Transparent;
            labelEdit4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdit4.ForeColor = Color.DarkTurquoise;
            labelEdit4.Location = new Point(12, 378);
            labelEdit4.Name = "labelEdit4";
            labelEdit4.Size = new Size(229, 24);
            labelEdit4.TabIndex = 18;
            labelEdit4.Text = "Informações do Plantão";
            // 
            // lblHour
            // 
            lblHour.Anchor = AnchorStyles.None;
            lblHour.AutoSize = true;
            lblHour.BackColor = Color.Transparent;
            lblHour.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHour.ForeColor = Color.Black;
            lblHour.Location = new Point(12, 442);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(73, 20);
            lblHour.TabIndex = 21;
            lblHour.Text = "Horário:";
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(12, 422);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(53, 20);
            lblDate.TabIndex = 20;
            lblDate.Text = "Data:";
            // 
            // lblPaymentAmount
            // 
            lblPaymentAmount.Anchor = AnchorStyles.None;
            lblPaymentAmount.AutoSize = true;
            lblPaymentAmount.BackColor = Color.Transparent;
            lblPaymentAmount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentAmount.ForeColor = Color.Black;
            lblPaymentAmount.Location = new Point(12, 402);
            lblPaymentAmount.Name = "lblPaymentAmount";
            lblPaymentAmount.Size = new Size(61, 20);
            lblPaymentAmount.TabIndex = 19;
            lblPaymentAmount.Text = "Valor: ";
            // 
            // ShiftInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 564);
            Controls.Add(lblHour);
            Controls.Add(lblDate);
            Controls.Add(lblPaymentAmount);
            Controls.Add(labelEdit4);
            Controls.Add(lblComplement);
            Controls.Add(lblZipCode);
            Controls.Add(lblState);
            Controls.Add(lblCity);
            Controls.Add(lblNumber);
            Controls.Add(lblNeighborhood);
            Controls.Add(lblStreet);
            Controls.Add(labelEdit3);
            Controls.Add(lblRegisterDate);
            Controls.Add(lblEmail);
            Controls.Add(lblFoundationDate);
            Controls.Add(lblCNPJ);
            Controls.Add(lblMunicipalRegistry);
            Controls.Add(lblName);
            Controls.Add(labelEdit2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShiftInformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShiftInformationForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.LabelEdit lblName;
        private ReaLTaiizor.Controls.LabelEdit lblMunicipalRegistry;
        private ReaLTaiizor.Controls.LabelEdit lblCNPJ;
        private ReaLTaiizor.Controls.LabelEdit lblFoundationDate;
        private ReaLTaiizor.Controls.LabelEdit lblEmail;
        private ReaLTaiizor.Controls.LabelEdit lblRegisterDate;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.LabelEdit lblStreet;
        private ReaLTaiizor.Controls.LabelEdit lblNeighborhood;
        private ReaLTaiizor.Controls.LabelEdit lblNumber;
        private ReaLTaiizor.Controls.LabelEdit lblCity;
        private ReaLTaiizor.Controls.LabelEdit lblState;
        private ReaLTaiizor.Controls.LabelEdit lblZipCode;
        private ReaLTaiizor.Controls.LabelEdit lblComplement;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private ReaLTaiizor.Controls.LabelEdit lblHour;
        private ReaLTaiizor.Controls.LabelEdit lblDate;
        private ReaLTaiizor.Controls.LabelEdit lblPaymentAmount;
    }
}