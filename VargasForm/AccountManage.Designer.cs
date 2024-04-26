namespace VargasForm
{
    partial class AccountManage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            email = new TextBox();
            label4 = new Label();
            label1 = new Label();
            button1 = new Button();
            sex = new ComboBox();
            phonenumber = new TextBox();
            label5 = new Label();
            label6 = new Label();
            name = new TextBox();
            accountID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(email);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(sex);
            panel2.Controls.Add(phonenumber);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(name);
            panel2.Controls.Add(accountID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(35, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 428);
            panel2.TabIndex = 1;
            // 
            // email
            // 
            email.Location = new Point(218, 108);
            email.Multiline = true;
            email.Name = "email";
            email.Size = new Size(158, 27);
            email.TabIndex = 13;
            email.TextChanged += email_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(104, 109);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 12;
            label4.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 32);
            label1.Name = "label1";
            label1.Size = new Size(288, 36);
            label1.TabIndex = 11;
            label1.Text = "CREATE ACCOUNT";
            // 
            // button1
            // 
            button1.Location = new Point(660, 329);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 10;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sex
            // 
            sex.FormattingEnabled = true;
            sex.Items.AddRange(new object[] { "Male", "Female" });
            sex.Location = new Point(596, 152);
            sex.Name = "sex";
            sex.Size = new Size(158, 28);
            sex.TabIndex = 9;
            // 
            // phonenumber
            // 
            phonenumber.Location = new Point(596, 108);
            phonenumber.Name = "phonenumber";
            phonenumber.Size = new Size(158, 27);
            phonenumber.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(537, 155);
            label5.Name = "label5";
            label5.Size = new Size(42, 28);
            label5.TabIndex = 7;
            label5.Text = "Sex";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(435, 108);
            label6.Name = "label6";
            label6.Size = new Size(144, 28);
            label6.TabIndex = 6;
            label6.Text = "Phone Number";
            // 
            // name
            // 
            name.Location = new Point(218, 211);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(158, 27);
            name.TabIndex = 3;
            // 
            // accountID
            // 
            accountID.Location = new Point(218, 156);
            accountID.Multiline = true;
            accountID.Name = "accountID";
            accountID.Size = new Size(158, 27);
            accountID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 211);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 1;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 156);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 0;
            label2.Text = "Account ID:";
            // 
            // AccountManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "AccountManage";
            Size = new Size(1053, 490);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox accountID;
        private TextBox phonenumber;
        private Label label5;
        private Label label6;
        private ComboBox sex;
        private Button button1;
        private Label label1;
        private Label label4;
        private TextBox email;
    }
}
