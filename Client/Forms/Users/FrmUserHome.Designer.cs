namespace Client.Forms.Users
{
    partial class FrmUserHome
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
            label1 = new Label();
            BtnUser = new Button();
            BtnRole = new Button();
            BtnUserRole = new Button();
            BtnRolePermission = new Button();
            groupBox1 = new GroupBox();
            BtnUserSetting = new Button();
            BtnCity = new Button();
            BtnProvince = new Button();
            BtnCountry = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(638, 72);
            label1.TabIndex = 0;
            label1.Text = "کارگاه محمدی";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnUser
            // 
            BtnUser.Location = new Point(428, 24);
            BtnUser.Name = "BtnUser";
            BtnUser.Size = new Size(202, 50);
            BtnUser.TabIndex = 1;
            BtnUser.Text = "مدیریت کاربران";
            BtnUser.UseVisualStyleBackColor = true;
            BtnUser.Click += BtnUser_Click;
            // 
            // BtnRole
            // 
            BtnRole.Location = new Point(220, 24);
            BtnRole.Name = "BtnRole";
            BtnRole.Size = new Size(202, 50);
            BtnRole.TabIndex = 2;
            BtnRole.Text = "مدیریت نقش ها";
            BtnRole.UseVisualStyleBackColor = true;
            BtnRole.Click += BtnRole_Click;
            // 
            // BtnUserRole
            // 
            BtnUserRole.Location = new Point(12, 24);
            BtnUserRole.Name = "BtnUserRole";
            BtnUserRole.Size = new Size(202, 50);
            BtnUserRole.TabIndex = 3;
            BtnUserRole.Text = "مدیریت تخصیص کاربر به نقش";
            BtnUserRole.UseVisualStyleBackColor = true;
            BtnUserRole.Click += BtnUserRole_Click;
            // 
            // BtnRolePermission
            // 
            BtnRolePermission.Location = new Point(220, 80);
            BtnRolePermission.Name = "BtnRolePermission";
            BtnRolePermission.Size = new Size(202, 50);
            BtnRolePermission.TabIndex = 4;
            BtnRolePermission.Text = "مدیریت مجوزهای نقش";
            BtnRolePermission.UseVisualStyleBackColor = true;
            BtnRolePermission.Click += BtnRolePermission_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BtnUserSetting);
            groupBox1.Controls.Add(BtnCity);
            groupBox1.Controls.Add(BtnProvince);
            groupBox1.Controls.Add(BtnCountry);
            groupBox1.Controls.Add(BtnRole);
            groupBox1.Controls.Add(BtnRolePermission);
            groupBox1.Controls.Add(BtnUserRole);
            groupBox1.Controls.Add(BtnUser);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(638, 378);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "مدیریت نرم افزار";
            // 
            // BtnUserSetting
            // 
            BtnUserSetting.Location = new Point(430, 319);
            BtnUserSetting.Name = "BtnUserSetting";
            BtnUserSetting.Size = new Size(202, 50);
            BtnUserSetting.TabIndex = 8;
            BtnUserSetting.Text = "تنظیمات شخصی";
            BtnUserSetting.UseVisualStyleBackColor = true;
            BtnUserSetting.Click += BtnUserSetting_Click;
            // 
            // BtnCity
            // 
            BtnCity.Location = new Point(222, 319);
            BtnCity.Name = "BtnCity";
            BtnCity.Size = new Size(202, 50);
            BtnCity.TabIndex = 7;
            BtnCity.Text = "مدیریت شهرها";
            BtnCity.UseVisualStyleBackColor = true;
            BtnCity.Click += BtnCity_Click;
            // 
            // BtnProvince
            // 
            BtnProvince.Location = new Point(220, 263);
            BtnProvince.Name = "BtnProvince";
            BtnProvince.Size = new Size(204, 50);
            BtnProvince.TabIndex = 6;
            BtnProvince.Text = "مدیریت استانها";
            BtnProvince.UseVisualStyleBackColor = true;
            BtnProvince.Click += BtnProvince_Click;
            // 
            // BtnCountry
            // 
            BtnCountry.Location = new Point(430, 263);
            BtnCountry.Name = "BtnCountry";
            BtnCountry.Size = new Size(202, 50);
            BtnCountry.TabIndex = 5;
            BtnCountry.Text = "مدیریت کشورها";
            BtnCountry.UseVisualStyleBackColor = true;
            BtnCountry.Click += BtnCountry_Click;
            // 
            // FrmUserHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 450);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmUserHome";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUserHome";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnUser;
        private Button BtnRole;
        private Button BtnUserRole;
        private Button BtnRolePermission;
        private GroupBox groupBox1;
        private Button BtnCity;
        private Button BtnProvince;
        private Button BtnCountry;
        private Button BtnUserSetting;
    }
}