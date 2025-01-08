namespace Client.Forms.Common.Identity.Roles.RolePermission
{
    partial class FrmRolePermissionList
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
            dataGridView1 = new DataGridView();
            Menu = new MenuStrip();
            BtnCreateRolePermission = new ToolStripMenuItem();
            BtnDeleteRolePermission = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            ComRole = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Menu.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 18);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(837, 425);
            dataGridView1.TabIndex = 10;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { BtnCreateRolePermission, BtnDeleteRolePermission });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(843, 25);
            Menu.TabIndex = 17;
            Menu.Text = "menuStrip1";
            // 
            // BtnCreateRolePermission
            // 
            BtnCreateRolePermission.Name = "BtnCreateRolePermission";
            BtnCreateRolePermission.Size = new Size(139, 21);
            BtnCreateRolePermission.Text = "ایجاد دسترسی به نقش";
            BtnCreateRolePermission.Click += BtnCreateRolePermission_Click;
            // 
            // BtnDeleteRolePermission
            // 
            BtnDeleteRolePermission.Name = "BtnDeleteRolePermission";
            BtnDeleteRolePermission.Size = new Size(139, 21);
            BtnDeleteRolePermission.Text = "حذف دسترسی از نقش";
            BtnDeleteRolePermission.Click += BtnDeleteRolePermission_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 168);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(843, 445);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "لیست مجوزها";
            // 
            // ComRole
            // 
            ComRole.DropDownStyle = ComboBoxStyle.DropDownList;
            ComRole.FormattingEnabled = true;
            ComRole.Location = new Point(644, 123);
            ComRole.Margin = new Padding(2, 1, 2, 1);
            ComRole.Name = "ComRole";
            ComRole.Size = new Size(188, 23);
            ComRole.TabIndex = 15;
            ComRole.SelectedIndexChanged += ComRole_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(843, 78);
            label1.TabIndex = 23;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmRolePermissionList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 613);
            Controls.Add(label1);
            Controls.Add(Menu);
            Controls.Add(groupBox1);
            Controls.Add(ComRole);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmRolePermissionList";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmRolePermissionList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip Menu;
        private ToolStripMenuItem BtnCreateRolePermission;
        private GroupBox groupBox1;
        private ComboBox ComRole;
        private ToolStripMenuItem BtnDeleteRolePermission;
        private Label label1;
    }
}