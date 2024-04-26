namespace VargasForm
{
    partial class Dashform
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            active = new Button();
            inactive = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(944, 249);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(420, 26);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 2;
            label1.Text = "Account Data";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(282, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_search_50;
            pictureBox1.Location = new Point(242, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(282, 406);
            button2.Name = "button2";
            button2.Size = new Size(129, 35);
            button2.TabIndex = 12;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // active
            // 
            active.Location = new Point(448, 406);
            active.Name = "active";
            active.Size = new Size(129, 35);
            active.TabIndex = 13;
            active.Text = "ACTIVE";
            active.UseVisualStyleBackColor = true;
            active.Click += active_Click;
            // 
            // inactive
            // 
            inactive.Location = new Point(603, 406);
            inactive.Name = "inactive";
            inactive.Size = new Size(129, 35);
            inactive.TabIndex = 14;
            inactive.Text = "INACTIVE";
            inactive.UseVisualStyleBackColor = true;
            inactive.Click += inactive_Click;
            // 
            // Dashform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(inactive);
            Controls.Add(active);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Dashform";
            Size = new Size(1053, 490);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button active;
        private Button inactive;
    }
}
