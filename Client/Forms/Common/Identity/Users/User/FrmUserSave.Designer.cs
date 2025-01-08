namespace Client.Forms.Common.Identity.Users.User
{
    partial class FrmUserSave
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
            BtnSaveUser = new Button();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            groupBox1 = new GroupBox();
            TxtPhoneNumber = new TextBox();
            TxtNationalCode = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSaveUser
            // 
            BtnSaveUser.Location = new Point(20, 202);
            BtnSaveUser.Margin = new Padding(2, 1, 2, 1);
            BtnSaveUser.Name = "BtnSaveUser";
            BtnSaveUser.Size = new Size(474, 40);
            BtnSaveUser.TabIndex = 10;
            BtnSaveUser.Text = "ثبت نام کاربر";
            BtnSaveUser.UseVisualStyleBackColor = true;
            BtnSaveUser.Click += BtnSaveUser_Click;
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(20, 29);
            TxtUsername.Margin = new Padding(2, 1, 2, 1);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.PlaceholderText = "نام کاربری و ایمیل";
            TxtUsername.Size = new Size(474, 23);
            TxtUsername.TabIndex = 4;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(20, 68);
            TxtPassword.Margin = new Padding(2, 1, 2, 1);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PlaceholderText = "رمز عبور";
            TxtPassword.Size = new Size(473, 23);
            TxtPassword.TabIndex = 3;
            TxtPassword.Text = "Admin1001Co#";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtPhoneNumber);
            groupBox1.Controls.Add(TxtNationalCode);
            groupBox1.Controls.Add(BtnSaveUser);
            groupBox1.Controls.Add(TxtUsername);
            groupBox1.Controls.Add(TxtPassword);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(507, 262);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "ثبت کاربر جدید";
            // 
            // TxtPhoneNumber
            // 
            TxtPhoneNumber.Location = new Point(20, 112);
            TxtPhoneNumber.Margin = new Padding(2, 1, 2, 1);
            TxtPhoneNumber.Name = "TxtPhoneNumber";
            TxtPhoneNumber.PlaceholderText = "تلفن";
            TxtPhoneNumber.Size = new Size(473, 23);
            TxtPhoneNumber.TabIndex = 12;
            TxtPhoneNumber.Text = "08134587412";
            // 
            // TxtNationalCode
            // 
            TxtNationalCode.Location = new Point(20, 159);
            TxtNationalCode.Margin = new Padding(2, 1, 2, 1);
            TxtNationalCode.Name = "TxtNationalCode";
            TxtNationalCode.PlaceholderText = "کد ملی";
            TxtNationalCode.Size = new Size(473, 23);
            TxtNationalCode.TabIndex = 11;
            TxtNationalCode.Text = "1234567891";
            // 
            // FrmUserSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 262);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmUserSave";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUserSave";
            FormClosed += FrmUserSave_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnSaveUser;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private GroupBox groupBox1;
        private TextBox TxtNationalCode;
        private TextBox TxtPhoneNumber;
    }
}