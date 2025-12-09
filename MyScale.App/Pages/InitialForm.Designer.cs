namespace MyScale.App.Pages
{
    partial class InitialForm
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
            tabPage1 = new ReaLTaiizor.Controls.TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.ActiveForeColor = Color.FromArgb(254, 255, 255);
            tabPage1.ActiveLineTabColor = Color.FromArgb(89, 169, 222);
            tabPage1.ActiveTabColor = Color.FromArgb(35, 36, 38);
            tabPage1.Alignment = TabAlignment.Left;
            tabPage1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            tabPage1.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            tabPage1.ControlBackColor = Color.FromArgb(54, 57, 64);
            tabPage1.Controls.Add(tabPage2);
            tabPage1.Controls.Add(tabPage3);
            tabPage1.Controls.Add(tabPage4);
            tabPage1.Dock = DockStyle.Fill;
            tabPage1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabPage1.FrameColor = Color.FromArgb(41, 50, 63);
            tabPage1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            tabPage1.ItemSize = new Size(44, 135);
            tabPage1.LineColor = Color.FromArgb(25, 26, 28);
            tabPage1.LineTabColor = Color.FromArgb(54, 57, 64);
            tabPage1.Location = new Point(2, 36);
            tabPage1.Multiline = true;
            tabPage1.Name = "tabPage1";
            tabPage1.NormalForeColor = Color.FromArgb(159, 162, 167);
            tabPage1.PageColor = Color.FromArgb(50, 63, 74);
            tabPage1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            tabPage1.SelectedIndex = 0;
            tabPage1.Size = new Size(1436, 862);
            tabPage1.SizeMode = TabSizeMode.Fixed;
            tabPage1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tabPage1.StringType = StringAlignment.Near;
            tabPage1.TabColor = Color.FromArgb(54, 57, 64);
            tabPage1.TabIndex = 0;
            tabPage1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(50, 63, 74);
            tabPage2.Location = new Point(139, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1293, 854);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(50, 63, 74);
            tabPage3.Location = new Point(139, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1293, 854);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "tabPage3";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(50, 63, 74);
            tabPage4.Location = new Point(139, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1293, 854);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "tabPage4";
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderColor = Color.Transparent;
            ClientSize = new Size(1440, 900);
            Controls.Add(tabPage1);
            HeaderColor = Color.SeaGreen;
            Name = "InitialForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyScale - Plantões";
            WindowState = FormWindowState.Maximized;
            Load += InitialForm_Load;
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}