namespace Client.Forms.Common.Identity.Users.UserSetting
{
    partial class FrmUserSetting
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
            BtnCreateUserRole = new ToolStripMenuItem();
            RdFarsi = new RadioButton();
            RdEnglish = new RadioButton();
            groupBox1 = new GroupBox();
            Menu.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { BtnCreateUserRole });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(301, 25);
            Menu.TabIndex = 21;
            Menu.Text = "menuStrip1";
            // 
            // BtnCreateUserRole
            // 
            BtnCreateUserRole.Name = "BtnCreateUserRole";
            BtnCreateUserRole.Size = new Size(50, 21);
            BtnCreateUserRole.Text = "ذخیره";
            BtnCreateUserRole.Click += BtnCreateUserRole_Click;
            // 
            // RdFarsi
            // 
            RdFarsi.AutoSize = true;
            RdFarsi.Checked = true;
            RdFarsi.Location = new Point(225, 32);
            RdFarsi.Name = "RdFarsi";
            RdFarsi.Size = new Size(55, 19);
            RdFarsi.TabIndex = 22;
            RdFarsi.TabStop = true;
            RdFarsi.Text = "فارسی";
            RdFarsi.UseVisualStyleBackColor = true;
            // 
            // RdEnglish
            // 
            RdEnglish.AutoSize = true;
            RdEnglish.Location = new Point(6, 32);
            RdEnglish.Name = "RdEnglish";
            RdEnglish.Size = new Size(63, 19);
            RdEnglish.TabIndex = 23;
            RdEnglish.Text = "English";
            RdEnglish.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RdEnglish);
            groupBox1.Controls.Add(RdFarsi);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 179);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 124);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "تنظیمات زیان";
            // 
            // FrmUserSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 303);
            Controls.Add(groupBox1);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmUserSetting";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUserSetting";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem BtnCreateUserRole;
        private RadioButton RdFarsi;
        private RadioButton RdEnglish;
        private GroupBox groupBox1;
    }
}