namespace Client.Forms.Common.Identity.Users.UserRole
{
    partial class FrmUserRoleList
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
            MenuUserRole = new ToolStripMenuItem();
            DeleteUserRole = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            ComUser = new ComboBox();
            label1 = new Label();
            Menu.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { MenuUserRole, DeleteUserRole });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(884, 25);
            Menu.TabIndex = 7;
            Menu.Text = "menuStrip1";
            // 
            // MenuUserRole
            // 
            MenuUserRole.Name = "MenuUserRole";
            MenuUserRole.Size = new Size(139, 21);
            MenuUserRole.Text = "تخصیص نقش به کاربر";
            MenuUserRole.Click += MenuUserRole_Click;
            // 
            // DeleteUserRole
            // 
            DeleteUserRole.Name = "DeleteUserRole";
            DeleteUserRole.Size = new Size(106, 21);
            DeleteUserRole.Text = "حذف نقش کاربر";
            DeleteUserRole.Click += DeleteUserRole_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 126);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(884, 428);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "ثبت کاربر جدید";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 19);
            dataGridView1.Margin = new Padding(3, 1, 3, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(876, 406);
            dataGridView1.TabIndex = 14;
            // 
            // ComUser
            // 
            ComUser.DropDownStyle = ComboBoxStyle.DropDownList;
            ComUser.FormattingEnabled = true;
            ComUser.Location = new Point(641, 82);
            ComUser.Name = "ComUser";
            ComUser.Size = new Size(239, 23);
            ComUser.TabIndex = 11;
            ComUser.SelectedIndexChanged += ComUser_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(884, 41);
            label1.TabIndex = 23;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmUserRoleList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 554);
            Controls.Add(ComUser);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmUserRoleList";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUserRoleList";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem MenuUserRole;
        private GroupBox groupBox1;
        private ToolStripMenuItem DeleteUserRole;
        private ComboBox ComUser;
        private DataGridView dataGridView1;
        private Label label1;
    }
}