namespace MyScale.App.Pages
{
    partial class MainForm
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
            materialShowTabControl1 = new ReaLTaiizor.Controls.MaterialShowTabControl();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            materialShowTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // materialShowTabControl1
            // 
            materialShowTabControl1.Controls.Add(tabPage2);
            materialShowTabControl1.Controls.Add(tabPage3);
            materialShowTabControl1.Depth = 0;
            materialShowTabControl1.Location = new Point(6, 67);
            materialShowTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialShowTabControl1.Multiline = true;
            materialShowTabControl1.Name = "materialShowTabControl1";
            materialShowTabControl1.SelectedIndex = 0;
            materialShowTabControl1.Size = new Size(1190, 512);
            materialShowTabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1182, 484);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(192, 72);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 757);
            Controls.Add(materialShowTabControl1);
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyScale";
            WindowState = FormWindowState.Maximized;
            materialShowTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialShowTabControl materialShowTabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}