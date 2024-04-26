namespace VargasForm
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            exit = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            comboBox2 = new ComboBox();
            label1 = new Label();
            panel5 = new Panel();
            product_form1 = new product_form();
            product1 = new Product();
            dashform1 = new Dashform();
            accountManage1 = new AccountManage();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGoldenrod;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox6);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 544);
            panel1.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleGoldenrod;
            button6.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.PaleGoldenrod;
            button6.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
            button6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Image = Properties.Resources.icons8_dashboard_50;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(23, 238);
            button6.Name = "button6";
            button6.Size = new Size(158, 54);
            button6.TabIndex = 18;
            button6.Text = "Accounts";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleGoldenrod;
            button5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(23, 375);
            button5.Name = "button5";
            button5.Size = new Size(158, 54);
            button5.TabIndex = 17;
            button5.Text = "About";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleGoldenrod;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(23, 298);
            button4.Name = "button4";
            button4.Size = new Size(158, 54);
            button4.TabIndex = 16;
            button4.Text = "Create Acc";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleGoldenrod;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(23, 173);
            button3.Name = "button3";
            button3.Size = new Size(158, 54);
            button3.TabIndex = 15;
            button3.Text = "Product";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGoldenrod;
            button2.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.PaleGoldenrod;
            button2.FlatAppearance.MouseOverBackColor = Color.PaleGoldenrod;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.icons8_dashboard_50;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(23, 103);
            button2.Name = "button2";
            button2.Size = new Size(158, 54);
            button2.TabIndex = 14;
            button2.Text = "Dashboard";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(70, 466);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(91, 30);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 48);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(exit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(238, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1053, 54);
            panel2.TabIndex = 3;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.White;
            exit.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.Location = new Point(1021, 22);
            exit.Name = "exit";
            exit.Size = new Size(20, 22);
            exit.TabIndex = 2;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "January";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            comboBox1.Text = "Month";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 13);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 8;
            label3.Text = "Sales";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(280, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(0, 0);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(771, 70);
            panel4.Name = "panel4";
            panel4.Size = new Size(0, 0);
            panel4.TabIndex = 11;
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "January";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(166, 53);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            comboBox2.Text = "Month";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 13);
            label1.Name = "label1";
            label1.Size = new Size(89, 32);
            label1.TabIndex = 8;
            label1.Text = "Profit";
            // 
            // panel5
            // 
            panel5.Controls.Add(product_form1);
            panel5.Controls.Add(product1);
            panel5.Controls.Add(dashform1);
            panel5.Controls.Add(accountManage1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(238, 54);
            panel5.Name = "panel5";
            panel5.Size = new Size(1053, 490);
            panel5.TabIndex = 12;
            // 
            // product_form1
            // 
            product_form1.Location = new Point(0, 0);
            product_form1.Name = "product_form1";
            product_form1.Size = new Size(1316, 612);
            product_form1.TabIndex = 3;
            product_form1.Load += product_form1_Load;
            // 
            // product1
            // 
            product1.Location = new Point(0, 0);
            product1.Name = "product1";
            product1.Size = new Size(1316, 612);
            product1.TabIndex = 2;
            // 
            // dashform1
            // 
            dashform1.Location = new Point(0, 0);
            dashform1.Name = "dashform1";
            dashform1.Size = new Size(1316, 612);
            dashform1.TabIndex = 1;
            // 
            // accountManage1
            // 
            accountManage1.Location = new Point(0, 0);
            accountManage1.Name = "accountManage1";
            accountManage1.Size = new Size(1316, 612);
            accountManage1.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 544);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Dashboardcs_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox6;
        private Button button1;
        private Panel panel2;
        private ComboBox comboBox1;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private ComboBox comboBox2;
        private Label label1;
        private Label exit;
        private Panel panel5;
        private AccountManage accountManage1;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Dashform dashform1;
        private Button button6;
        private Product product1;
        private product_form product_form1;
    }
}