namespace Client.Forms.Common.Identity.Roles.RolePermission
{
    partial class FrmRolePermissionSave
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            TxtPermission = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Menu.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 18);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(823, 311);
            dataGridView1.TabIndex = 10;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { BtnCreateRolePermission });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(829, 25);
            Menu.TabIndex = 20;
            Menu.Text = "menuStrip1";
            // 
            // BtnCreateRolePermission
            // 
            BtnCreateRolePermission.Name = "BtnCreateRolePermission";
            BtnCreateRolePermission.Size = new Size(50, 21);
            BtnCreateRolePermission.Text = "ذخیره";
            BtnCreateRolePermission.Click += BtnCreateRolePermission_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 201);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(829, 331);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "لیست مجوزها";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(829, 78);
            label1.TabIndex = 24;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtPermission);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(829, 63);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "جستجو";
            // 
            // TxtPermission
            // 
            TxtPermission.Dock = DockStyle.Fill;
            TxtPermission.Location = new Point(3, 19);
            TxtPermission.Name = "TxtPermission";
            TxtPermission.Size = new Size(823, 23);
            TxtPermission.TabIndex = 0;
            TxtPermission.TextChanged += TxtPermission_TextChanged;
            // 
            // FrmRolePermissionSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 532);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(Menu);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmRolePermissionSave";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmRolePermissionSave";
            FormClosed += FrmRolePermissionSave_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip Menu;
        private ToolStripMenuItem BtnCreateRolePermission;
        private GroupBox groupBox1;
 
        private Label label1;
        private GroupBox groupBox2;
        private TextBox TxtPermission;
    }
}