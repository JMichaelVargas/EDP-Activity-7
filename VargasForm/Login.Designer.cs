using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace VargasForm
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button1 = new Button();
            username = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            linkLabel2 = new LinkLabel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(232, 378);
            button1.Name = "button1";
            button1.Size = new Size(123, 43);
            button1.TabIndex = 0;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // username
            // 
            username.Location = new Point(202, 229);
            username.Name = "username";
            username.Size = new Size(211, 27);
            username.TabIndex = 1;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(202, 278);
            password.Name = "password";
            password.Size = new Size(211, 27);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            password.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 236);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Email:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 281);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 265);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(202, 326);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 479);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 9;
            label4.Text = "Don't have an account? Click";
            label4.Click += label4_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(355, 479);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(61, 20);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(149, 109);
            label5.Name = "label5";
            label5.Size = new Size(274, 68);
            label5.TabIndex = 11;
            label5.Text = "Welcome!";
            label5.Click += label5_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(230, 444);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(125, 20);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Forgot Password?";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(160, 177);
            label6.Name = "label6";
            label6.Size = new Size(240, 23);
            label6.TabIndex = 13;
            label6.Text = "Enter your credentials to login";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Enabled = false;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(232, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(570, 520);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(linkLabel2);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(button1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mcdo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox username;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label5;
        private LinkLabel linkLabel2;
        private Label label6;
        private PictureBox pictureBox1;
    }
}
