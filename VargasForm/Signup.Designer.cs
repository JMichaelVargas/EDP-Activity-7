namespace VargasForm
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            label1 = new Label();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            password = new TextBox();
            username = new TextBox();
            label7 = new Label();
            label8 = new Label();
            confirmpassword = new TextBox();
            linkLabel1 = new LinkLabel();
            label9 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 135);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(145, 123);
            label5.Name = "label5";
            label5.Size = new Size(228, 68);
            label5.TabIndex = 12;
            label5.Text = " Sign up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(182, 200);
            label2.Name = "label2";
            label2.Size = new Size(165, 23);
            label2.TabIndex = 13;
            label2.Text = "Create your account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(231, 286);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 302);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 17;
            label4.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 255);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 16;
            label6.Text = "Email:";
            // 
            // password
            // 
            password.Location = new Point(182, 299);
            password.Name = "password";
            password.Size = new Size(260, 27);
            password.TabIndex = 15;
            password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            username.Location = new Point(182, 252);
            username.Name = "username";
            username.Size = new Size(260, 27);
            username.TabIndex = 14;
            username.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(231, 331);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 347);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 20;
            label8.Text = "Confirm Password:";
            label8.Click += label8_Click;
            // 
            // confirmpassword
            // 
            confirmpassword.Location = new Point(182, 344);
            confirmpassword.Name = "confirmpassword";
            confirmpassword.Size = new Size(260, 27);
            confirmpassword.TabIndex = 19;
            confirmpassword.UseSystemPasswordChar = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(336, 496);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(126, 496);
            label9.Name = "label9";
            label9.Size = new Size(213, 20);
            label9.TabIndex = 23;
            label9.Text = "Already have an account? Click";
            label9.Click += label8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(182, 429);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 25;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Enabled = false;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(200, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(182, 388);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(530, 568);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(confirmpassword);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mcdo";
            Load += Signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox password;
        private TextBox username;
        private Label label7;
        private Label label8;
        private TextBox confirmpassword;
        private LinkLabel linkLabel1;
        private Label label9;
        private Button button1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
    }
}