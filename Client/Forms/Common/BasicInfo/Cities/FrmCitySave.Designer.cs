namespace Client.Forms.Common.BasicInfo.Cities
{
    partial class FrmCitySave
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
            SaveCity = new ToolStripMenuItem();
            Menu = new MenuStrip();
            TxtCity = new TextBox();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // SaveCity
            // 
            SaveCity.Name = "SaveCity";
            SaveCity.Size = new Size(50, 21);
            SaveCity.Text = "ذخیره";
            SaveCity.Click += SaveCity_Click;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { SaveCity });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(499, 25);
            Menu.TabIndex = 14;
            Menu.Text = "menuStrip1";
            // 
            // TxtCity
            // 
            TxtCity.Location = new Point(21, 68);
            TxtCity.Name = "TxtCity";
            TxtCity.Size = new Size(448, 23);
            TxtCity.TabIndex = 13;
            // 
            // FrmCitySave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 124);
            Controls.Add(Menu);
            Controls.Add(TxtCity);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmCitySave";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmCitySave";
            FormClosed += FrmCitySave_FormClosed;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem SaveCity;
        private MenuStrip Menu;
        private TextBox TxtCity;
    }
}