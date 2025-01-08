namespace Client.Forms.Common.Identity.Roles.Role
{
    partial class FrmRoleSave
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
            TxtRoleName = new TextBox();
            BtnCreateRole = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtRoleName);
            groupBox1.Controls.Add(BtnCreateRole);
            groupBox1.Location = new Point(12, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(305, 148);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "نام نقش جدید";
            // 
            // TxtRoleName
            // 
            TxtRoleName.Font = new Font("Segoe UI", 9.75F);
            TxtRoleName.Location = new Point(16, 32);
            TxtRoleName.Margin = new Padding(2, 1, 2, 1);
            TxtRoleName.Name = "TxtRoleName";
            TxtRoleName.Size = new Size(272, 25);
            TxtRoleName.TabIndex = 10;
            // 
            // BtnCreateRole
            // 
            BtnCreateRole.Font = new Font("Segoe UI", 9.75F);
            BtnCreateRole.Location = new Point(16, 98);
            BtnCreateRole.Margin = new Padding(2, 1, 2, 1);
            BtnCreateRole.Name = "BtnCreateRole";
            BtnCreateRole.Size = new Size(272, 28);
            BtnCreateRole.TabIndex = 17;
            BtnCreateRole.Text = "ایجاد";
            BtnCreateRole.UseVisualStyleBackColor = true;
            BtnCreateRole.Click += BtnCreateRole_Click;
            // 
            // FrmRoleSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 180);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmRoleSave";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmRoleSave";
            FormClosed += FrmRoleSave_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtRoleName;
        private Button BtnCreateRole;
    }
}