namespace VargasForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            recoveraccount = new Button();
            linkLabel1 = new LinkLabel();
            label9 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            username = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Enabled = false;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(227, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // recoveraccount
            // 
            recoveraccount.Location = new Point(217, 354);
            recoveraccount.Name = "recoveraccount";
            recoveraccount.Size = new Size(132, 43);
            recoveraccount.TabIndex = 54;
            recoveraccount.Text = "Recover Account";
            recoveraccount.UseVisualStyleBackColor = true;
            recoveraccount.Click += recoveraccount_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(293, 439);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(56, 25);
            linkLabel1.TabIndex = 53;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(217, 439);
            label9.Name = "label9";
            label9.Size = new Size(75, 25);
            label9.TabIndex = 52;
            label9.Text = "Back to ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 257);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 273);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 47;
            label4.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(193, 212);
            label2.Name = "label2";
            label2.Size = new Size(202, 23);
            label2.TabIndex = 45;
            label2.Text = "Enter first your username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(114, 145);
            label5.Name = "label5";
            label5.Size = new Size(363, 51);
            label5.TabIndex = 44;
            label5.Text = "Password Recovery";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 145);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 43;
            // 
            // username
            // 
            username.Location = new Point(222, 270);
            username.Name = "username";
            username.Size = new Size(173, 27);
            username.TabIndex = 58;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(558, 535);
            Controls.Add(username);
            Controls.Add(pictureBox1);
            Controls.Add(recoveraccount);
            Controls.Add(linkLabel1);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button recoveraccount;
        private LinkLabel linkLabel1;
        private Label label9;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label1;
        private TextBox username;
    }
}