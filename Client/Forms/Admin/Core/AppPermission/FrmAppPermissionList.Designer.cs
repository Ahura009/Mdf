namespace Client.Forms.Admin.Core.AppPermission
{
    partial class FrmAppPermissionList
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
            MenuAppPermissionDelete = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Menu.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { MenuAppPermissionSave, MenuAppPermissionDelete });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(868, 25);
            Menu.TabIndex = 8;
            Menu.Text = "menuStrip1";
            // 
            // MenuAppPermissionSave
            // 
            MenuAppPermissionSave.Name = "MenuAppPermissionSave";
            MenuAppPermissionSave.Size = new Size(87, 21);
            MenuAppPermissionSave.Text = "تعریف مجوز";
            MenuAppPermissionSave.Click += MenuAppPermissionSave_Click;
            // 
            // MenuAppPermissionDelete
            // 
            MenuAppPermissionDelete.Name = "MenuAppPermissionDelete";
            MenuAppPermissionDelete.Size = new Size(80, 21);
            MenuAppPermissionDelete.Text = "حذف مجوز";
            MenuAppPermissionDelete.Click += MenuAppPermissionDelete_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Segoe UI", 9.75F);
            groupBox2.Location = new Point(0, 149);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(868, 441);
            groupBox2.TabIndex = 9;
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
            dataGridView1.Size = new Size(860, 417);
            dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(868, 78);
            label1.TabIndex = 23;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmAppPermissionList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 590);
            Controls.Add(label1);
            Controls.Add(Menu);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmAppPermissionList";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmAppPermissionList";
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip Menu;
        private ToolStripMenuItem MenuAppPermissionSave;
        private ToolStripMenuItem MenuAppPermissionDelete;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}