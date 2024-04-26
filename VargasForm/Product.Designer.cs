namespace VargasForm
{
    partial class Product
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
            label1 = new Label();
            button1 = new Button();
            category = new ComboBox();
            description = new TextBox();
            label5 = new Label();
            label6 = new Label();
            price = new TextBox();
            name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(category);
            panel2.Controls.Add(description);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(price);
            panel2.Controls.Add(name);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(32, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(988, 428);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 32);
            label1.Name = "label1";
            label1.Size = new Size(239, 36);
            label1.TabIndex = 11;
            label1.Text = "ADD PRODUCT";
            // 
            // button1
            // 
            button1.Location = new Point(660, 329);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 10;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Food", "Dessert", "Drink", "Toys" });
            category.Location = new Point(602, 210);
            category.Name = "category";
            category.Size = new Size(158, 28);
            category.TabIndex = 9;
            // 
            // description
            // 
            description.Location = new Point(602, 156);
            description.Name = "description";
            description.Size = new Size(158, 27);
            description.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(469, 206);
            label5.Name = "label5";
            label5.Size = new Size(96, 28);
            label5.TabIndex = 7;
            label5.Text = "Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(469, 156);
            label6.Name = "label6";
            label6.Size = new Size(116, 28);
            label6.TabIndex = 6;
            label6.Text = "Description:";
            // 
            // price
            // 
            price.Location = new Point(218, 211);
            price.Multiline = true;
            price.Name = "price";
            price.Size = new Size(158, 27);
            price.TabIndex = 3;
            // 
            // name
            // 
            name.Location = new Point(218, 156);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(158, 27);
            name.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(104, 211);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 1;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 156);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "Product";
            Size = new Size(1053, 490);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button button1;
        private ComboBox category;
        private TextBox description;
        private Label label5;
        private Label label6;
        private TextBox price;
        private TextBox name;
        private Label label3;
        private Label label2;
    }
}
