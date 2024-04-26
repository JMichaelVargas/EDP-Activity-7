namespace VargasForm
{
    partial class ForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPass));
            changePasswordButton = new Button();
            linkLabel1 = new LinkLabel();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            confirmNewPasswordTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            newPasswordTextBox = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            button2 = new Button();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location = new Point(150, 408);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(123, 43);
            changePasswordButton.TabIndex = 39;
            changePasswordButton.Text = "Save";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(290, 465);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 25);
            linkLabel1.TabIndex = 38;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(214, 465);
            label9.Name = "label9";
            label9.Size = new Size(75, 25);
            label9.TabIndex = 37;
            label9.Text = "Back to ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(263, 318);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 321);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 35;
            label8.Text = "Confirm Password:";
            // 
            // confirmNewPasswordTextBox
            // 
            confirmNewPasswordTextBox.Location = new Point(214, 318);
            confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            confirmNewPasswordTextBox.Size = new Size(224, 27);
            confirmNewPasswordTextBox.TabIndex = 34;
            confirmNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(263, 258);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 274);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 32;
            label4.Text = "Password:";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(214, 271);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.Size = new Size(224, 27);
            newPasswordTextBox.TabIndex = 30;
            newPasswordTextBox.UseSystemPasswordChar = true;
            newPasswordTextBox.TextChanged += newPasswordTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(190, 213);
            label2.Name = "label2";
            label2.Size = new Size(201, 23);
            label2.TabIndex = 28;
            label2.Text = "Enter your new password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(111, 146);
            label5.Name = "label5";
            label5.Size = new Size(363, 51);
            label5.TabIndex = 27;
            label5.Text = "Password Recovery";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 146);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 26;
            // 
            // button2
            // 
            button2.Location = new Point(290, 408);
            button2.Name = "button2";
            button2.Size = new Size(123, 43);
            button2.TabIndex = 40;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(214, 367);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 41;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Enabled = false;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(224, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // ForgotPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(560, 531);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(changePasswordButton);
            Controls.Add(linkLabel1);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(confirmNewPasswordTextBox);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(newPasswordTextBox);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "ForgotPass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mcdo";
            Load += ForgotPass_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private LinkLabel linkLabel1;
        private Label label9;
        private Label label7;
        private Label label8;
        private TextBox confirmpassword;
        private Label label3;
        private Label label4;
        private TextBox newPassword;
        private Label label2;
        private Label label5;
        private Label label1;
        private Button button2;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private TextBox newPasswordTextBox;
        private TextBox confirmNewPasswordTextBox;
        private Button changePasswordButton;
    }
}