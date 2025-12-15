using ReaLTaiizor.Controls;

namespace MyScale.App.Pages
{
    partial class calendarForm
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
            btnProximo = new ReaLTaiizor.Controls.Button();
            btnAnterior = new ReaLTaiizor.Controls.Button();
            gridCalendario = new PoisonDataGridView();
            Domingo = new DataGridViewTextBoxColumn();
            Segunda = new DataGridViewTextBoxColumn();
            Terça = new DataGridViewTextBoxColumn();
            Quarta = new DataGridViewTextBoxColumn();
            Quinta = new DataGridViewTextBoxColumn();
            Sexta = new DataGridViewTextBoxColumn();
            Sábado = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblMesAno = new LabelEdit();
            comboInicio = new HopeComboBox();
            comboFim = new HopeComboBox();
            btnConfirma = new ReaLTaiizor.Controls.Button();
            spaceClose1 = new SpaceClose();
            ((System.ComponentModel.ISupportInitialize)gridCalendario).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProximo
            // 
            btnProximo.Anchor = AnchorStyles.None;
            btnProximo.BackColor = Color.Transparent;
            btnProximo.BorderColor = Color.FromArgb(32, 34, 37);
            btnProximo.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnProximo.EnteredColor = Color.FromArgb(32, 34, 37);
            btnProximo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProximo.Image = null;
            btnProximo.ImageAlign = ContentAlignment.MiddleLeft;
            btnProximo.InactiveColor = Color.Teal;
            btnProximo.Location = new Point(716, 3);
            btnProximo.Name = "btnProximo";
            btnProximo.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnProximo.PressedColor = Color.FromArgb(165, 37, 37);
            btnProximo.Size = new Size(48, 23);
            btnProximo.TabIndex = 2;
            btnProximo.Text = "→";
            btnProximo.TextAlignment = StringAlignment.Center;
            btnProximo.Click += btnProximo_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Anchor = AnchorStyles.None;
            btnAnterior.BackColor = Color.Transparent;
            btnAnterior.BorderColor = Color.FromArgb(32, 34, 37);
            btnAnterior.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnAnterior.EnteredColor = Color.FromArgb(32, 34, 37);
            btnAnterior.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnterior.Image = null;
            btnAnterior.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnterior.InactiveColor = Color.Teal;
            btnAnterior.Location = new Point(6, 3);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnAnterior.PressedColor = Color.FromArgb(165, 37, 37);
            btnAnterior.Size = new Size(48, 23);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "←";
            btnAnterior.TextAlignment = StringAlignment.Center;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // gridCalendario
            // 
            gridCalendario.AllowUserToAddRows = false;
            gridCalendario.AllowUserToResizeColumns = false;
            gridCalendario.AllowUserToResizeRows = false;
            gridCalendario.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gridCalendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridCalendario.BackgroundColor = Color.WhiteSmoke;
            gridCalendario.BorderStyle = BorderStyle.None;
            gridCalendario.CellBorderStyle = DataGridViewCellBorderStyle.None;
            gridCalendario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkCyan;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridCalendario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridCalendario.ColumnHeadersHeight = 30;
            gridCalendario.Columns.AddRange(new DataGridViewColumn[] { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridCalendario.DefaultCellStyle = dataGridViewCellStyle2;
            gridCalendario.EnableHeadersVisualStyles = false;
            gridCalendario.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            gridCalendario.GridColor = Color.White;
            gridCalendario.Location = new Point(13, 74);
            gridCalendario.MultiSelect = false;
            gridCalendario.Name = "gridCalendario";
            gridCalendario.ReadOnly = true;
            gridCalendario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridCalendario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridCalendario.RowHeadersVisible = false;
            gridCalendario.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridCalendario.ScrollBars = ScrollBars.None;
            gridCalendario.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridCalendario.Size = new Size(775, 277);
            gridCalendario.TabIndex = 4;
            gridCalendario.CellClick += gridCalendario_CellClick;
            // 
            // Domingo
            // 
            Domingo.HeaderText = "Domingo";
            Domingo.Name = "Domingo";
            Domingo.ReadOnly = true;
            // 
            // Segunda
            // 
            Segunda.HeaderText = "Segunda";
            Segunda.Name = "Segunda";
            Segunda.ReadOnly = true;
            // 
            // Terça
            // 
            Terça.HeaderText = "Terça";
            Terça.Name = "Terça";
            Terça.ReadOnly = true;
            // 
            // Quarta
            // 
            Quarta.HeaderText = "Quarta";
            Quarta.Name = "Quarta";
            Quarta.ReadOnly = true;
            // 
            // Quinta
            // 
            Quinta.HeaderText = "Quinta";
            Quinta.Name = "Quinta";
            Quinta.ReadOnly = true;
            // 
            // Sexta
            // 
            Sexta.HeaderText = "Sexta";
            Sexta.Name = "Sexta";
            Sexta.ReadOnly = true;
            // 
            // Sábado
            // 
            Sábado.HeaderText = "Sábado";
            Sábado.Name = "Sábado";
            Sábado.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 646F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 69F));
            tableLayoutPanel1.Controls.Add(lblMesAno, 1, 0);
            tableLayoutPanel1.Controls.Add(btnAnterior, 0, 0);
            tableLayoutPanel1.Controls.Add(btnProximo, 2, 0);
            tableLayoutPanel1.Location = new Point(13, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(775, 29);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // lblMesAno
            // 
            lblMesAno.Anchor = AnchorStyles.None;
            lblMesAno.AutoSize = true;
            lblMesAno.BackColor = Color.Transparent;
            lblMesAno.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMesAno.ForeColor = Color.Black;
            lblMesAno.Location = new Point(336, 2);
            lblMesAno.Name = "lblMesAno";
            lblMesAno.Size = new Size(93, 24);
            lblMesAno.TabIndex = 0;
            lblMesAno.Text = "Mes Ano";
            // 
            // comboInicio
            // 
            comboInicio.DrawMode = DrawMode.OwnerDrawFixed;
            comboInicio.FlatStyle = FlatStyle.Flat;
            comboInicio.Font = new Font("Segoe UI", 12F);
            comboInicio.FormattingEnabled = true;
            comboInicio.ItemHeight = 26;
            comboInicio.Items.AddRange(new object[] { "" });
            comboInicio.Location = new Point(19, 377);
            comboInicio.Name = "comboInicio";
            comboInicio.Size = new Size(175, 32);
            comboInicio.TabIndex = 11;
            comboInicio.Text = "Inicio plantão";
            // 
            // comboFim
            // 
            comboFim.DrawMode = DrawMode.OwnerDrawFixed;
            comboFim.FlatStyle = FlatStyle.Flat;
            comboFim.Font = new Font("Segoe UI", 12F);
            comboFim.FormattingEnabled = true;
            comboFim.ItemHeight = 26;
            comboFim.Location = new Point(200, 377);
            comboFim.Name = "comboFim";
            comboFim.Size = new Size(175, 32);
            comboFim.TabIndex = 12;
            comboFim.Text = "Final plantão";
            // 
            // btnConfirma
            // 
            btnConfirma.BackColor = Color.Transparent;
            btnConfirma.BorderColor = Color.FromArgb(32, 34, 37);
            btnConfirma.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnConfirma.EnteredColor = Color.FromArgb(32, 34, 37);
            btnConfirma.Font = new Font("Microsoft Sans Serif", 12F);
            btnConfirma.Image = null;
            btnConfirma.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirma.InactiveColor = Color.Teal;
            btnConfirma.Location = new Point(668, 369);
            btnConfirma.Name = "btnConfirma";
            btnConfirma.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnConfirma.PressedColor = Color.FromArgb(165, 37, 37);
            btnConfirma.Size = new Size(120, 40);
            btnConfirma.TabIndex = 13;
            btnConfirma.Text = "Confirma?";
            btnConfirma.TextAlignment = StringAlignment.Center;
            btnConfirma.Click += btnConfirmar_Click;
            // 
            // spaceClose1
            // 
            spaceClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            spaceClose1.Customization = "DQ/S/xhh8/8yMjL/Kioq/x5/9/8ND9L//v7+/yMjI/8qKir/";
            spaceClose1.DefaultAnchor = true;
            spaceClose1.DefaultLocation = true;
            spaceClose1.Font = new Font("Verdana", 8F);
            spaceClose1.Image = null;
            spaceClose1.Location = new Point(790, 3);
            spaceClose1.Name = "spaceClose1";
            spaceClose1.NoRounding = false;
            spaceClose1.Size = new Size(23, 21);
            spaceClose1.TabIndex = 14;
            spaceClose1.Text = "x";
            spaceClose1.Transparent = false;
            // 
            // calendarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(spaceClose1);
            Controls.Add(btnConfirma);
            Controls.Add(comboFim);
            Controls.Add(comboInicio);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(gridCalendario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "calendarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "calendario";
            ((System.ComponentModel.ISupportInitialize)gridCalendario).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Button btnProximo;
        private ReaLTaiizor.Controls.Button btnAnterior;
        private ReaLTaiizor.Controls.PoisonDataGridView gridCalendario;
        private DataGridViewTextBoxColumn Domingo;
        private DataGridViewTextBoxColumn Segunda;
        private DataGridViewTextBoxColumn Terça;
        private DataGridViewTextBoxColumn Quarta;
        private DataGridViewTextBoxColumn Quinta;
        private DataGridViewTextBoxColumn Sexta;
        private DataGridViewTextBoxColumn Sábado;
        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.LabelEdit lblMesAno;
        private HopeComboBox comboInicio;
        private ReaLTaiizor.Controls.HopeComboBox comboBoxState;
        private ReaLTaiizor.Controls.HopeComboBox comboFim;
        private ReaLTaiizor.Controls.Button btnConfirma;
        private ReaLTaiizor.Controls.SpaceClose spaceClose1;
    }
}