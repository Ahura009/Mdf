namespace Client.Forms.Common.Identity.Users.UserRole
{
    partial class FrmUserRoleSave
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
            BtnCreateUserRole = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
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
            dataGridView1.Margin = new Padding(3, 1, 3, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(840, 355);
            dataGridView1.TabIndex = 13;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { BtnCreateUserRole });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(846, 25);
            Menu.TabIndex = 20;
            Menu.Text = "menuStrip1";
            // 
            // BtnCreateUserRole
            // 
            BtnCreateUserRole.Name = "BtnCreateUserRole";
            BtnCreateUserRole.Size = new Size(50, 21);
            BtnCreateUserRole.Text = "ذخیره";
            BtnCreateUserRole.Click += BtnCreateUserRole_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 180);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(846, 375);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "نام نقش جدید";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(846, 78);
            label1.TabIndex = 21;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmUserRoleSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 555);
            Controls.Add(label1);
            Controls.Add(Menu);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmUserRoleSave";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmUserRoleSave";
            FormClosed += FrmUserRoleSave_FormClosed;
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
        private ToolStripMenuItem BtnCreateUserRole;
        private GroupBox groupBox1;
        private Label label1;
    }
}