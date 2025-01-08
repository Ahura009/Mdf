namespace Client.Forms.Admin.Core.AppPermission
{
    partial class FrmAppPermissionSave
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
            MenuAppPermissionSave = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            BtnSearch = new Button();
            TxtMessage = new TextBox();
            ComMessageType = new ComboBox();
            Menu.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { MenuAppPermissionSave });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(907, 25);
            Menu.TabIndex = 10;
            Menu.Text = "menuStrip1";
            // 
            // MenuAppPermissionSave
            // 
            MenuAppPermissionSave.Name = "MenuAppPermissionSave";
            MenuAppPermissionSave.Size = new Size(50, 21);
            MenuAppPermissionSave.Text = "ذخیره";
            MenuAppPermissionSave.Click += MenuAppPermissionSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Segoe UI", 9.75F);
            groupBox2.Location = new Point(0, 288);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(907, 425);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "لیست مجوزهای آپ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 21);
            dataGridView1.Margin = new Padding(3, 1, 3, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(899, 401);
            dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(907, 64);
            label1.TabIndex = 24;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(BtnSearch);
            groupBox1.Controls.Add(TxtMessage);
            groupBox1.Controls.Add(ComMessageType);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 161);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(907, 127);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجوی مجوز";
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(27, 65);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(858, 48);
            BtnSearch.TabIndex = 3;
            BtnSearch.Text = "جستجو";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // TxtMessage
            // 
            TxtMessage.Location = new Point(463, 22);
            TxtMessage.Name = "TxtMessage";
            TxtMessage.Size = new Size(422, 23);
            TxtMessage.TabIndex = 2;
            // 
            // ComMessageType
            // 
            ComMessageType.DropDownStyle = ComboBoxStyle.DropDownList;
            ComMessageType.FormattingEnabled = true;
            ComMessageType.Location = new Point(27, 22);
            ComMessageType.Name = "ComMessageType";
            ComMessageType.Size = new Size(422, 23);
            ComMessageType.TabIndex = 0;
            // 
            // FrmAppPermissionSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 713);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(Menu);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmAppPermissionSave";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAppPermissionSave";
            FormClosed += FrmAppPermissionSave_FormClosed;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip Menu;
        private ToolStripMenuItem MenuAppPermissionSave;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox ComMessageType;
        private TextBox TxtMessage;
        private Button BtnSearch;
    }
}