namespace LibraryManagementSystem
{
    partial class SettingForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            button5 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            button6 = new Button();
            button7 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 80);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Max Borrow";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(215, 77);
            button1.Name = "button1";
            button1.Size = new Size(46, 23);
            button1.TabIndex = 2;
            button1.Text = "Set";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(215, 132);
            button2.Name = "button2";
            button2.Size = new Size(46, 23);
            button2.TabIndex = 5;
            button2.Text = "Set";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(97, 132);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 135);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Max Due";
            // 
            // button3
            // 
            button3.Location = new Point(215, 187);
            button3.Name = "button3";
            button3.Size = new Size(46, 23);
            button3.TabIndex = 8;
            button3.Text = "Set";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(97, 188);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 6;
            label3.Text = "Make Teacher";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(97, 9);
            label4.Name = "label4";
            label4.Size = new Size(87, 30);
            label4.TabIndex = 9;
            label4.Text = "Settings";
            // 
            // button4
            // 
            button4.Location = new Point(20, 16);
            button4.Name = "button4";
            button4.Size = new Size(46, 23);
            button4.TabIndex = 10;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(215, 242);
            button5.Name = "button5";
            button5.Size = new Size(46, 23);
            button5.TabIndex = 13;
            button5.Text = "Set";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 243);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 246);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 11;
            label5.Text = "Make Student";
            // 
            // button6
            // 
            button6.Location = new Point(301, 17);
            button6.Name = "button6";
            button6.Size = new Size(95, 23);
            button6.TabIndex = 14;
            button6.Text = "View Teachers";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(402, 17);
            button7.Name = "button7";
            button7.Size = new Size(95, 23);
            button7.TabIndex = 15;
            button7.Text = "View Students";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(301, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(330, 218);
            dataGridView1.TabIndex = 16;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 291);
            Controls.Add(dataGridView1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SettingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += SettingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button3;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Button button4;
        private Button button5;
        private TextBox textBox4;
        private Label label5;
        private Button button6;
        private Button button7;
        private DataGridView dataGridView1;
    }
}