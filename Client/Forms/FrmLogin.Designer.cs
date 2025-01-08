namespace Client.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            TxtPassword = new TextBox();
            TxtUsername = new TextBox();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(387, 58);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 17);
            label3.TabIndex = 8;
            label3.Text = "رمز عبور";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(385, 14);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 9;
            label2.Text = "نام کاربری";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(195, 52);
            TxtPassword.Margin = new Padding(4, 3, 4, 3);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '•';
            TxtPassword.Size = new Size(181, 23);
            TxtPassword.TabIndex = 7;
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(193, 12);
            TxtUsername.Margin = new Padding(4, 3, 4, 3);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(181, 23);
            TxtUsername.TabIndex = 6;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F);
            button2.Location = new Point(324, 107);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(121, 36);
            button2.TabIndex = 13;
            button2.Text = "لغو";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.Location = new Point(193, 107);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(121, 36);
            button1.TabIndex = 11;
            button1.Text = "ورود";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(464, 14);
            button3.Name = "button3";
            button3.Size = new Size(83, 23);
            button3.TabIndex = 14;
            button3.Text = "1001";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(464, 43);
            button4.Name = "button4";
            button4.Size = new Size(83, 23);
            button4.TabIndex = 15;
            button4.Text = "محمدی";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(464, 72);
            button5.Name = "button5";
            button5.Size = new Size(83, 23);
            button5.TabIndex = 16;
            button5.Text = "صحرایی";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(553, 72);
            button6.Name = "button6";
            button6.Size = new Size(30, 23);
            button6.TabIndex = 17;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(553, 43);
            button7.Name = "button7";
            button7.Size = new Size(30, 23);
            button7.TabIndex = 18;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(589, 72);
            button8.Name = "button8";
            button8.Size = new Size(30, 23);
            button8.TabIndex = 19;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(625, 72);
            button9.Name = "button9";
            button9.Size = new Size(30, 23);
            button9.TabIndex = 20;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 156);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "فرم ورود کاربران";
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private TextBox TxtPassword;
        public TextBox TxtUsername;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}