namespace Client.Forms.Admin.Core.App
{
    partial class FrmAppSave
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
            BtnCreateUser = new Button();
            TxtName = new TextBox();
            ComCountry = new ComboBox();
            TxtTelephone = new TextBox();
            TxtMobile = new TextBox();
            TxtOwnerName = new TextBox();
            groupBox1 = new GroupBox();
            ComCity = new ComboBox();
            ComProvince = new ComboBox();
            ComExpired = new ComboBox();
            TxtAddress = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCreateUser
            // 
            BtnCreateUser.Location = new Point(11, 238);
            BtnCreateUser.Margin = new Padding(2, 1, 2, 1);
            BtnCreateUser.Name = "BtnCreateUser";
            BtnCreateUser.Size = new Size(485, 40);
            BtnCreateUser.TabIndex = 10;
            BtnCreateUser.Text = "ذخیره";
            BtnCreateUser.UseVisualStyleBackColor = true;
            BtnCreateUser.Click += BtnCreateUser_Click;
            // 
            // TxtName
            // 
            TxtName.Location = new Point(263, 19);
            TxtName.Margin = new Padding(2, 1, 2, 1);
            TxtName.Name = "TxtName";
            TxtName.PlaceholderText = "نام کارگاه";
            TxtName.Size = new Size(235, 23);
            TxtName.TabIndex = 4;
            // 
            // ComCountry
            // 
            ComCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            ComCountry.FormattingEnabled = true;
            ComCountry.Location = new Point(11, 20);
            ComCountry.Margin = new Padding(2, 1, 2, 1);
            ComCountry.Name = "ComCountry";
            ComCountry.Size = new Size(235, 23);
            ComCountry.TabIndex = 8;
            ComCountry.SelectedIndexChanged += ComCountry_SelectedIndexChanged;
            // 
            // TxtTelephone
            // 
            TxtTelephone.Location = new Point(263, 149);
            TxtTelephone.Margin = new Padding(2, 1, 2, 1);
            TxtTelephone.Name = "TxtTelephone";
            TxtTelephone.PlaceholderText = "تلفن";
            TxtTelephone.Size = new Size(235, 23);
            TxtTelephone.TabIndex = 3;
            TxtTelephone.Text = "08134258596";
            // 
            // TxtMobile
            // 
            TxtMobile.Location = new Point(263, 105);
            TxtMobile.Margin = new Padding(2, 1, 2, 1);
            TxtMobile.Name = "TxtMobile";
            TxtMobile.PlaceholderText = "موبایل";
            TxtMobile.Size = new Size(235, 23);
            TxtMobile.TabIndex = 7;
            TxtMobile.Text = "09188114294";
            // 
            // TxtOwnerName
            // 
            TxtOwnerName.Location = new Point(263, 63);
            TxtOwnerName.Margin = new Padding(2, 1, 2, 1);
            TxtOwnerName.Name = "TxtOwnerName";
            TxtOwnerName.PlaceholderText = "نام مالک";
            TxtOwnerName.Size = new Size(235, 23);
            TxtOwnerName.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComCity);
            groupBox1.Controls.Add(ComProvince);
            groupBox1.Controls.Add(ComExpired);
            groupBox1.Controls.Add(TxtAddress);
            groupBox1.Controls.Add(BtnCreateUser);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(ComCountry);
            groupBox1.Controls.Add(TxtTelephone);
            groupBox1.Controls.Add(TxtMobile);
            groupBox1.Controls.Add(TxtOwnerName);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(507, 293);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "ثبت کاربر جدید";
            // 
            // ComCity
            // 
            ComCity.DropDownStyle = ComboBoxStyle.DropDownList;
            ComCity.FormattingEnabled = true;
            ComCity.Location = new Point(11, 105);
            ComCity.Margin = new Padding(2, 1, 2, 1);
            ComCity.Name = "ComCity";
            ComCity.Size = new Size(235, 23);
            ComCity.TabIndex = 14;
            // 
            // ComProvince
            // 
            ComProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            ComProvince.FormattingEnabled = true;
            ComProvince.Location = new Point(11, 63);
            ComProvince.Margin = new Padding(2, 1, 2, 1);
            ComProvince.Name = "ComProvince";
            ComProvince.Size = new Size(235, 23);
            ComProvince.TabIndex = 13;
            ComProvince.SelectedIndexChanged += ComProvince_SelectedIndexChanged;
            // 
            // ComExpired
            // 
            ComExpired.DropDownStyle = ComboBoxStyle.DropDownList;
            ComExpired.FormattingEnabled = true;
            ComExpired.Location = new Point(11, 149);
            ComExpired.Margin = new Padding(2, 1, 2, 1);
            ComExpired.Name = "ComExpired";
            ComExpired.Size = new Size(235, 23);
            ComExpired.TabIndex = 12;
            // 
            // TxtAddress
            // 
            TxtAddress.Location = new Point(11, 192);
            TxtAddress.Margin = new Padding(2, 1, 2, 1);
            TxtAddress.Name = "TxtAddress";
            TxtAddress.PlaceholderText = "آدرس";
            TxtAddress.Size = new Size(487, 23);
            TxtAddress.TabIndex = 11;
            // 
            // FrmAppSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 293);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmAppSave";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAppSave";
            FormClosed += FrmAppSave_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCreateUser;
        private TextBox TxtName;
        private ComboBox ComCountry;
        private TextBox TxtTelephone;
        private TextBox TxtMobile;
        private TextBox TxtOwnerName;
        private GroupBox groupBox1;
        private TextBox TxtAddress;
        private ComboBox ComExpired;
        private ComboBox ComCity;
        private ComboBox ComProvince;
    }
}