namespace LibraryManagementSystem
{
    partial class Login_Register_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Register_Form));
            btn_ViewLogimPage = new Button();
            btn_ViewRegisterPage = new Button();
            panelRegister = new Panel();
            label5 = new Label();
            textBoxln = new TextBox();
            label6 = new Label();
            textBoxfn = new TextBox();
            btn_register = new Button();
            label3 = new Label();
            textBoxpw = new TextBox();
            label1 = new Label();
            textBoxun = new TextBox();
            panelLogin = new Panel();
            button1 = new Button();
            label10 = new Label();
            password = new TextBox();
            label12 = new Label();
            loginTextBoxun = new TextBox();
            panelRegister.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ViewLogimPage
            // 
            resources.ApplyResources(btn_ViewLogimPage, "btn_ViewLogimPage");
            btn_ViewLogimPage.BackColor = Color.FromArgb(46, 46, 46);
            btn_ViewLogimPage.FlatAppearance.BorderColor = Color.Black;
            btn_ViewLogimPage.Name = "btn_ViewLogimPage";
            btn_ViewLogimPage.UseVisualStyleBackColor = false;
            btn_ViewLogimPage.Click += btn_ViewLoginPage_Click;
            // 
            // btn_ViewRegisterPage
            // 
            resources.ApplyResources(btn_ViewRegisterPage, "btn_ViewRegisterPage");
            btn_ViewRegisterPage.FlatAppearance.BorderColor = Color.Black;
            btn_ViewRegisterPage.Name = "btn_ViewRegisterPage";
            btn_ViewRegisterPage.UseVisualStyleBackColor = true;
            btn_ViewRegisterPage.Click += btn_ViewRegisterPage_Click;
            // 
            // panelRegister
            // 
            panelRegister.Controls.Add(label5);
            panelRegister.Controls.Add(textBoxln);
            panelRegister.Controls.Add(label6);
            panelRegister.Controls.Add(textBoxfn);
            panelRegister.Controls.Add(btn_register);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(textBoxpw);
            panelRegister.Controls.Add(label1);
            panelRegister.Controls.Add(textBoxun);
            resources.ApplyResources(panelRegister, "panelRegister");
            panelRegister.Name = "panelRegister";
            panelRegister.Paint += panelRegister_Paint;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.FlatStyle = FlatStyle.Flat;
            label5.Name = "label5";
            // 
            // textBoxln
            // 
            textBoxln.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBoxln, "textBoxln");
            textBoxln.Name = "textBoxln";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.FlatStyle = FlatStyle.Flat;
            label6.Name = "label6";
            // 
            // textBoxfn
            // 
            textBoxfn.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBoxfn, "textBoxfn");
            textBoxfn.Name = "textBoxfn";
            // 
            // btn_register
            // 
            resources.ApplyResources(btn_register, "btn_register");
            btn_register.BackColor = Color.FromArgb(38, 135, 205);
            btn_register.ForeColor = Color.White;
            btn_register.Name = "btn_register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.FlatStyle = FlatStyle.Flat;
            label3.Name = "label3";
            // 
            // textBoxpw
            // 
            textBoxpw.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBoxpw, "textBoxpw");
            textBoxpw.Name = "textBoxpw";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.FlatStyle = FlatStyle.Flat;
            label1.Name = "label1";
            // 
            // textBoxun
            // 
            textBoxun.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBoxun, "textBoxun");
            textBoxun.Name = "textBoxun";
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(46, 46, 46);
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(label10);
            panelLogin.Controls.Add(password);
            panelLogin.Controls.Add(label12);
            panelLogin.Controls.Add(loginTextBoxun);
            resources.ApplyResources(panelLogin, "panelLogin");
            panelLogin.Name = "panelLogin";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.FromArgb(252, 147, 1);
            button1.ForeColor = Color.White;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(password, "password");
            password.Name = "password";
            password.UseSystemPasswordChar = true;
            password.TextChanged += loginTextBoxpw_TextChanged;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // loginTextBoxun
            // 
            loginTextBoxun.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(loginTextBoxun, "loginTextBoxun");
            loginTextBoxun.Name = "loginTextBoxun";
            loginTextBoxun.TextChanged += loginTextBoxun_TextChanged;
            // 
            // Login_Register_Form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(panelLogin);
            Controls.Add(btn_ViewRegisterPage);
            Controls.Add(btn_ViewLogimPage);
            Controls.Add(panelRegister);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Login_Register_Form";
            Load += Form1_Load;
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_ViewLogimPage;
        private Button btn_ViewRegisterPage;
        private Panel panelRegister;
        private Label label3;
        private TextBox textBoxpw;
        private Label label1;
        private TextBox textBoxun;
        private Button btn_register;
        private Label label5;
        private TextBox textBoxln;
        private Label label6;
        private TextBox textBoxfn;
        private Panel panelLogin;
        private Button button1;
        private Label label10;
        private TextBox password;
        private Label label12;
        private TextBox loginTextBoxun;
    }
}