namespace Client.Forms.Admin.Language
{
    partial class FrmLanguageSave
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
            Menu = new MenuStrip();
            BtnSave = new ToolStripMenuItem();
            textBox1 = new TextBox();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { BtnSave });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(609, 25);
            Menu.TabIndex = 5;
            Menu.Text = "menuStrip1";
            // 
            // BtnSave
            // 
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(50, 21);
            BtnSave.Text = "ذخیره";
            BtnSave.Click += BtnSave_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(609, 228);
            textBox1.TabIndex = 6;
            // 
            // FrmLanguageSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 253);
            Controls.Add(textBox1);
            Controls.Add(Menu);
            Name = "FrmLanguageSave";
            Text = "FrmLanguageSave";
            FormClosed += FrmLanguageSave_FormClosed;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem BtnSave;
        private TextBox textBox1;
    }
}