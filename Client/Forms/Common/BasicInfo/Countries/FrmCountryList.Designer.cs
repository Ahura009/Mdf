﻿namespace Client.Forms.Common.BasicInfo.Countries
{
    partial class FrmCountryList
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
            dataGridView1 = new DataGridView();
            Menu = new MenuStrip();
            SaveCountry = new ToolStripMenuItem();
            BtnDelete = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            BtnSearch = new Button();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            Menu.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 320);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "لیست کشورها";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(794, 298);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Menu
            // 
            Menu.BackColor = SystemColors.ActiveBorder;
            Menu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.Items.AddRange(new ToolStripItem[] { SaveCountry, BtnDelete });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.RightToLeft = RightToLeft.Yes;
            Menu.Size = new Size(800, 25);
            Menu.TabIndex = 11;
            Menu.Text = "menuStrip1";
            // 
            // SaveCountry
            // 
            SaveCountry.Name = "SaveCountry";
            SaveCountry.Size = new Size(119, 21);
            SaveCountry.Text = "تعریف کشور جدید";
            SaveCountry.Click += SaveCountry_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(82, 21);
            BtnDelete.Text = "حذف کشور";
            BtnDelete.Click += BtnDelete_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(BtnSearch);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 100);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "جستجو";
            // 
            // BtnSearch
            // 
            BtnSearch.Location = new Point(544, 60);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(217, 23);
            BtnSearch.TabIndex = 1;
            BtnSearch.Text = "جستجو";
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(544, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 0;
            // 
            // FrmCountryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 538);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Menu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmCountryList";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmCountryList";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private MenuStrip Menu;
        private ToolStripMenuItem SaveCountry;
        private GroupBox groupBox2;
        private Button BtnSearch;
        private TextBox textBox1;
        private ToolStripMenuItem BtnDelete;
    }
}