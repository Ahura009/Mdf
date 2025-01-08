namespace Client.Forms.Common.BasicInfo.Provinces
{
    partial class FrmProvinceSave
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
            SaveProvince = new ToolStripMenuItem();
            Menu = new MenuStrip();
            TxtProvince = new TextBox();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // SaveProvince
            // 
            SaveProvince.Name = "SaveProvince";
            SaveProvince.Size = new Size(50, 21);
            SaveProvince.Text = "ذخیره";
            SaveProvince.Click += SaveProvince_Click;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { SaveProvince });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(478, 25);
            Menu.TabIndex = 14;
            Menu.Text = "menuStrip1";
            // 
            // TxtProvince
            // 
            TxtProvince.Location = new Point(12, 74);
            TxtProvince.Name = "TxtProvince";
            TxtProvince.Size = new Size(448, 23);
            TxtProvince.TabIndex = 13;
            // 
            // FrmProvinceSave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 154);
            Controls.Add(Menu);
            Controls.Add(TxtProvince);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmProvinceSave";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmProvinceSave";
            FormClosed += FrmProvinceSave_FormClosed;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem SaveProvince;
        private MenuStrip Menu;
        private TextBox TxtProvince;
    }
}