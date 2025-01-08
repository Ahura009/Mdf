namespace Client.Forms.Common.Identity.Roles.Role
{
    partial class FrmRoleList
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
            MenuRole = new ToolStripMenuItem();
            DeleteRole = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Menu.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 19);
            dataGridView1.Margin = new Padding(3, 1, 3, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.Size = new Size(798, 393);
            dataGridView1.TabIndex = 3;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { MenuRole, DeleteRole });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(806, 25);
            Menu.TabIndex = 5;
            Menu.Text = "menuStrip1";
            // 
            // MenuRole
            // 
            MenuRole.Name = "MenuRole";
            MenuRole.Size = new Size(79, 21);
            MenuRole.Text = "تعریف رول";
            MenuRole.Click += MenuRole_Click;
            // 
            // DeleteRole
            // 
            DeleteRole.Name = "DeleteRole";
            DeleteRole.Size = new Size(78, 21);
            DeleteRole.Text = "حذف نقش";
            DeleteRole.Click += DeleteRole_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 133);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(806, 415);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "لیست نفش ها";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(806, 78);
            label1.TabIndex = 22;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmRoleList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 548);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmRoleList";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmRoleList";
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
        private ToolStripMenuItem MenuRole;
        private GroupBox groupBox1;
        private ToolStripMenuItem DeleteRole;
        private Label label1;
    }
}