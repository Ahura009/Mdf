namespace Client.Forms.Admin
{
    partial class FrmHome
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
            MenuManager = new ToolStripMenuItem();
            MenuApp = new ToolStripMenuItem();
            label1 = new Label();
            BtnCity = new Button();
            BtnProvince = new Button();
            BtnCountry = new Button();
            BtnUserSetting = new Button();
            BtnLanguage = new Button();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { MenuManager });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(724, 25);
            Menu.TabIndex = 3;
            Menu.Text = "menuStrip1";
            // 
            // MenuManager
            // 
            MenuManager.DropDownItems.AddRange(new ToolStripItem[] { MenuApp });
            MenuManager.Name = "MenuManager";
            MenuManager.Size = new Size(61, 21);
            MenuManager.Text = "مدیریت";
            // 
            // MenuApp
            // 
            MenuApp.Name = "MenuApp";
            MenuApp.Size = new Size(152, 22);
            MenuApp.Text = "مدیریت کارگاه";
            MenuApp.Click += MenuApp_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.Size = new Size(724, 72);
            label1.TabIndex = 4;
            label1.Text = "ادمین 1001";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnCity
            // 
            BtnCity.Location = new Point(53, 142);
            BtnCity.Name = "BtnCity";
            BtnCity.Size = new Size(202, 50);
            BtnCity.TabIndex = 10;
            BtnCity.Text = "مدیریت شهرها";
            BtnCity.UseVisualStyleBackColor = true;
            BtnCity.Click += BtnCity_Click;
            // 
            // BtnProvince
            // 
            BtnProvince.Location = new Point(261, 142);
            BtnProvince.Name = "BtnProvince";
            BtnProvince.Size = new Size(202, 50);
            BtnProvince.TabIndex = 9;
            BtnProvince.Text = "مدیریت استانها";
            BtnProvince.UseVisualStyleBackColor = true;
            BtnProvince.Click += BtnProvince_Click;
            // 
            // BtnCountry
            // 
            BtnCountry.Location = new Point(469, 142);
            BtnCountry.Name = "BtnCountry";
            BtnCountry.Size = new Size(202, 50);
            BtnCountry.TabIndex = 8;
            BtnCountry.Text = "مدیریت کشورها";
            BtnCountry.UseVisualStyleBackColor = true;
            BtnCountry.Click += BtnCountry_Click;
            // 
            // BtnUserSetting
            // 
            BtnUserSetting.Location = new Point(469, 198);
            BtnUserSetting.Name = "BtnUserSetting";
            BtnUserSetting.Size = new Size(202, 50);
            BtnUserSetting.TabIndex = 11;
            BtnUserSetting.Text = "تنظیمات شخصی";
            BtnUserSetting.UseVisualStyleBackColor = true;
            BtnUserSetting.Click += BtnUserSetting_Click;
            // 
            // BtnLanguage
            // 
            BtnLanguage.Location = new Point(261, 198);
            BtnLanguage.Name = "BtnLanguage";
            BtnLanguage.Size = new Size(202, 50);
            BtnLanguage.TabIndex = 12;
            BtnLanguage.Text = "تنظیمات چند زبانی";
            BtnLanguage.UseVisualStyleBackColor = true;
            BtnLanguage.Click += BtnLanguage_Click;
            // 
            // FrmHome
            // 
            ClientSize = new Size(724, 334);
            Controls.Add(BtnLanguage);
            Controls.Add(BtnUserSetting);
            Controls.Add(BtnCity);
            Controls.Add(BtnProvince);
            Controls.Add(BtnCountry);
            Controls.Add(label1);
            Controls.Add(Menu);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = Menu;
            Margin = new Padding(6);
            Name = "FrmHome";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Home";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip Menu;
        private ToolStripMenuItem MenuManager;
        private ToolStripMenuItem MenuApp;
        private Label label1;
        private Button BtnCity;
        private Button BtnProvince;
        private Button BtnCountry;
        private Button BtnUserSetting;
        private Button BtnLanguage;
    }
}