namespace Client.Forms.Admin.Language
{
    partial class FrmLanguageList
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
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Menu = new MenuStrip();
            BtnSave = new ToolStripMenuItem();
            MenuApp = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ComLanguage = new ComboBox();
            TxtValue = new TextBox();
            TxtKey = new TextBox();
            BtnLoadCachce = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Menu.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 187);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1034, 550);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "نمایش کلیدها";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1028, 528);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { BtnSave });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(1034, 25);
            Menu.TabIndex = 4;
            Menu.Text = "menuStrip1";
            // 
            // BtnSave
            // 
            BtnSave.DropDownItems.AddRange(new ToolStripItem[] { MenuApp });
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(50, 21);
            BtnSave.Text = "ذخیره";
            // 
            // MenuApp
            // 
            MenuApp.Name = "MenuApp";
            MenuApp.Size = new Size(152, 22);
            MenuApp.Text = "مدیریت کارگاه";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(BtnLoadCachce);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1034, 156);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "عملیات";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ComLanguage);
            groupBox3.Controls.Add(TxtValue);
            groupBox3.Controls.Add(TxtKey);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(3, 82);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1028, 71);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "جستجوی کلید";
            // 
            // ComLanguage
            // 
            ComLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            ComLanguage.FormattingEnabled = true;
            ComLanguage.Location = new Point(9, 22);
            ComLanguage.Name = "ComLanguage";
            ComLanguage.Size = new Size(182, 23);
            ComLanguage.TabIndex = 4;
            ComLanguage.SelectedIndexChanged += ComLanguage_SelectedIndexChanged;
            // 
            // TxtValue
            // 
            TxtValue.Location = new Point(197, 22);
            TxtValue.Name = "TxtValue";
            TxtValue.PlaceholderText = "مقدار";
            TxtValue.Size = new Size(408, 23);
            TxtValue.TabIndex = 3;
            TxtValue.TextChanged += TxtValue_TextChanged;
            // 
            // TxtKey
            // 
            TxtKey.Location = new Point(611, 22);
            TxtKey.Name = "TxtKey";
            TxtKey.PlaceholderText = "کلید";
            TxtKey.Size = new Size(411, 23);
            TxtKey.TabIndex = 1;
            TxtKey.TextChanged += TxtKey_TextChanged;
            // 
            // BtnLoadCachce
            // 
            BtnLoadCachce.Dock = DockStyle.Top;
            BtnLoadCachce.Location = new Point(3, 19);
            BtnLoadCachce.Name = "BtnLoadCachce";
            BtnLoadCachce.Size = new Size(1028, 48);
            BtnLoadCachce.TabIndex = 0;
            BtnLoadCachce.Text = "به روز رسانی ترجمه ها";
            BtnLoadCachce.UseVisualStyleBackColor = true;
            BtnLoadCachce.Click += BtnLoadCachce_Click;
            // 
            // FrmLanguageList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 737);
            Controls.Add(groupBox2);
            Controls.Add(Menu);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmLanguageList";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmLanguage";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private MenuStrip Menu;
        private ToolStripMenuItem BtnSave;
        private ToolStripMenuItem MenuApp;
        private GroupBox groupBox2;
        private Button BtnLoadCachce;
        private GroupBox groupBox3;
        private TextBox TxtValue;
        private TextBox TxtKey;
        private ComboBox ComLanguage;
    }
}