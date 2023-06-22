namespace LibraryManagementSystem
{
    partial class Admin_Panel_Form
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
            btn_fetch = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            userslabel = new Label();
            bookslabel = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_fetch
            // 
            btn_fetch.ImeMode = ImeMode.NoControl;
            btn_fetch.Location = new Point(12, 76);
            btn_fetch.Name = "btn_fetch";
            btn_fetch.Size = new Size(75, 23);
            btn_fetch.TabIndex = 27;
            btn_fetch.Text = "View Users";
            btn_fetch.UseVisualStyleBackColor = true;
            btn_fetch.Click += btn_fetch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(332, 333);
            dataGridView1.TabIndex = 26;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(366, 105);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(505, 333);
            dataGridView2.TabIndex = 28;
            // 
            // userslabel
            // 
            userslabel.AutoSize = true;
            userslabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            userslabel.ForeColor = SystemColors.ButtonFace;
            userslabel.Location = new Point(12, 9);
            userslabel.Name = "userslabel";
            userslabel.Size = new Size(87, 37);
            userslabel.TabIndex = 29;
            userslabel.Text = "Users";
            userslabel.Click += label1_Click;
            // 
            // bookslabel
            // 
            bookslabel.AutoSize = true;
            bookslabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            bookslabel.ForeColor = SystemColors.ButtonFace;
            bookslabel.Location = new Point(366, 9);
            bookslabel.Name = "bookslabel";
            bookslabel.Size = new Size(124, 37);
            bookslabel.TabIndex = 30;
            bookslabel.Text = "Borrows";
            // 
            // button1
            // 
            button1.Location = new Point(269, 76);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 31;
            button1.Text = "Operations";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 76);
            button2.Name = "button2";
            button2.Size = new Size(86, 23);
            button2.TabIndex = 32;
            button2.Text = "View Books";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(350, -5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 458);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.ImeMode = ImeMode.NoControl;
            button3.Location = new Point(367, 76);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 34;
            button3.Text = "Fetch Borrows";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Admin_Panel_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(881, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bookslabel);
            Controls.Add(userslabel);
            Controls.Add(dataGridView2);
            Controls.Add(btn_fetch);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Admin_Panel_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            Load += Admin_Panel_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_fetch;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label userslabel;
        private Label bookslabel;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
    }
}