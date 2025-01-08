namespace Client.Forms.Common.BasicInfo.Countries
{
    partial class FrmCountrySave
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
            TxtCountry = new TextBox();
            Menu = new MenuStrip();
            SaveCountry = new ToolStripMenuItem();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // TxtCountry
            // 
            TxtCountry.Location = new Point(12, 70);
            TxtCountry.Name = "TxtCountry";
            TxtCountry.Size = new Size(448, 23);
            TxtCountry.TabIndex = 1;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { SaveCountry });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(472, 25);
            Menu.TabIndex = 12;
            Menu.Text = "menuStrip1";
            // 
            // SaveCountry
            // 
            SaveCountry.Name = "SaveCountry";
            SaveCountry.Size = new Size(50, 21);
            SaveCountry.Text = "ذخیره";
            SaveCountry.Click += SaveCountry_Click;
            // 
            // FrmCountrySave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 148);
            Controls.Add(Menu);
            Controls.Add(TxtCountry);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmCountrySave";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmCountrySave";
            FormClosed += FrmCountrySave_FormClosed;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtCountry;
        private MenuStrip Menu;
        private ToolStripMenuItem SaveCountry;
    }
}