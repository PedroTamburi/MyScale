using ReaLTaiizor.Controls;

namespace MyScale.App.Pages
{
    partial class EditShiftForm
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
            labelEdit1 = new LabelEdit();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new ReaLTaiizor.Controls.Button();
            button2 = new ReaLTaiizor.Controls.Button();
            button1 = new ReaLTaiizor.Controls.Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblDate = new LabelEdit();
            lblStartTime = new LabelEdit();
            lblEndTime = new LabelEdit();
            button4 = new ReaLTaiizor.Controls.Button();
            txtPaymentAmount = new HopeTextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // labelEdit1
            // 
            labelEdit1.Anchor = AnchorStyles.None;
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdit1.ForeColor = Color.Black;
            labelEdit1.Location = new Point(82, 4);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(188, 30);
            labelEdit1.TabIndex = 1;
            labelEdit1.Text = "Edição de plantão";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.AppWorkspace;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(labelEdit1, 0, 0);
            tableLayoutPanel1.Location = new Point(-1, -1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(352, 38);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Transparent;
            button3.BorderColor = Color.FromArgb(32, 34, 37);
            button3.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button3.EnteredColor = Color.FromArgb(32, 34, 37);
            button3.Font = new Font("Microsoft Sans Serif", 12F);
            button3.Image = null;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.InactiveColor = Color.IndianRed;
            button3.Location = new Point(9, 108);
            button3.Name = "button3";
            button3.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button3.PressedColor = Color.FromArgb(165, 37, 37);
            button3.Size = new Size(174, 40);
            button3.TabIndex = 11;
            button3.Text = "Excluir Plantão";
            button3.TextAlignment = StringAlignment.Center;
            button3.Click += btnExcluir_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.FromArgb(32, 34, 37);
            button2.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button2.EnteredColor = Color.FromArgb(32, 34, 37);
            button2.Font = new Font("Microsoft Sans Serif", 12F);
            button2.Image = null;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.InactiveColor = Color.MediumSeaGreen;
            button2.Location = new Point(9, 56);
            button2.Name = "button2";
            button2.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button2.PressedColor = Color.FromArgb(165, 37, 37);
            button2.Size = new Size(174, 40);
            button2.TabIndex = 10;
            button2.Text = "Salvar Alterações";
            button2.TextAlignment = StringAlignment.Center;
            button2.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.SlateGray;
            button1.Location = new Point(9, 5);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(174, 40);
            button1.TabIndex = 9;
            button1.Text = "Cancelar";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += btnCancelar_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Controls.Add(button3, 0, 2);
            tableLayoutPanel2.Controls.Add(button2, 0, 1);
            tableLayoutPanel2.Location = new Point(67, 265);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.Size = new Size(192, 155);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.None;
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(12, 49);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 21);
            lblDate.TabIndex = 14;
            lblDate.Text = "Dia: ";
            // 
            // lblStartTime
            // 
            lblStartTime.Anchor = AnchorStyles.None;
            lblStartTime.AutoSize = true;
            lblStartTime.BackColor = Color.Transparent;
            lblStartTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStartTime.ForeColor = Color.Black;
            lblStartTime.Location = new Point(12, 80);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(61, 21);
            lblStartTime.TabIndex = 15;
            lblStartTime.Text = "Inicio: ";
            // 
            // lblEndTime
            // 
            lblEndTime.Anchor = AnchorStyles.None;
            lblEndTime.AutoSize = true;
            lblEndTime.BackColor = Color.Transparent;
            lblEndTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndTime.ForeColor = Color.Black;
            lblEndTime.Location = new Point(12, 110);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(46, 21);
            lblEndTime.TabIndex = 16;
            lblEndTime.Text = "Fim: ";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BorderColor = Color.FromArgb(32, 34, 37);
            button4.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button4.EnteredColor = Color.FromArgb(32, 34, 37);
            button4.Font = new Font("Microsoft Sans Serif", 12F);
            button4.Image = null;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.InactiveColor = Color.Black;
            button4.Location = new Point(238, 50);
            button4.Name = "button4";
            button4.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button4.PressedColor = Color.FromArgb(165, 37, 37);
            button4.Size = new Size(100, 43);
            button4.TabIndex = 19;
            button4.Text = "Definir Data e Horarios";
            button4.TextAlignment = StringAlignment.Center;
            button4.Click += btnChangeDate_Click;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.BackColor = Color.White;
            txtPaymentAmount.BaseColor = Color.WhiteSmoke;
            txtPaymentAmount.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPaymentAmount.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPaymentAmount.Font = new Font("Segoe UI", 12F);
            txtPaymentAmount.ForeColor = Color.FromArgb(48, 49, 51);
            txtPaymentAmount.Hint = "Valor";
            txtPaymentAmount.Location = new Point(12, 146);
            txtPaymentAmount.MaxLength = 32767;
            txtPaymentAmount.Multiline = false;
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.PasswordChar = '\0';
            txtPaymentAmount.ScrollBars = ScrollBars.None;
            txtPaymentAmount.SelectedText = "";
            txtPaymentAmount.SelectionLength = 0;
            txtPaymentAmount.SelectionStart = 0;
            txtPaymentAmount.Size = new Size(204, 38);
            txtPaymentAmount.TabIndex = 20;
            txtPaymentAmount.TabStop = false;
            txtPaymentAmount.UseSystemPasswordChar = false;
            // 
            // EditShiftForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(350, 448);
            Controls.Add(txtPaymentAmount);
            Controls.Add(button4);
            Controls.Add(lblEndTime);
            Controls.Add(lblStartTime);
            Controls.Add(lblDate);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditShiftForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditShiftForm";
            Load += EditShiftForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.Button button3;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.LabelEdit lblDate;
        private ReaLTaiizor.Controls.LabelEdit lblStartTime;
        private LabelEdit lblEndTime;
        private ReaLTaiizor.Controls.LabelEdit labelEdit5;
        private ReaLTaiizor.Controls.Button button4;
        private HopeTextBox txtPaymentAmount;
    }
}