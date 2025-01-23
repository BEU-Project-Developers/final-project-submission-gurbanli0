namespace Rentacar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            loginPanel = new Panel();
            panel1 = new Panel();
            buttonSignUp1 = new Button();
            buttonLogin1 = new Button();
            textBoxPass = new TextBox();
            textBoxUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonSignUp = new Button();
            buttonLogin = new Button();
            
            labelCrAcc = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            labelLogin = new Label();
            loginPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.DarkSeaGreen;
            loginPanel.BackgroundImageLayout = ImageLayout.Stretch;
            loginPanel.BorderStyle = BorderStyle.Fixed3D;
            loginPanel.Controls.Add(panel1);
            loginPanel.Controls.Add(buttonSignUp);
            loginPanel.Controls.Add(buttonLogin);
            
            loginPanel.Controls.Add(labelCrAcc);
            loginPanel.Controls.Add(labelUsername);
            loginPanel.Controls.Add(labelPassword);
            loginPanel.Controls.Add(labelLogin);
            loginPanel.ForeColor = Color.DarkGreen;
            loginPanel.Location = new Point(70, 95);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(591, 720);
            loginPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(buttonSignUp1);
            panel1.Controls.Add(buttonLogin1);
            panel1.Controls.Add(textBoxPass);
            panel1.Controls.Add(textBoxUser);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.DarkGreen;
            panel1.Location = new Point(-2, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 720);
            panel1.TabIndex = 8;
            // 
            // buttonSignUp1
            // 
            buttonSignUp1.BackColor = Color.DarkSeaGreen;
            buttonSignUp1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignUp1.Location = new Point(155, 586);
            buttonSignUp1.Name = "buttonSignUp1";
            buttonSignUp1.Size = new Size(271, 86);
            buttonSignUp1.TabIndex = 7;
            buttonSignUp1.Text = "Sign Up";
            buttonSignUp1.UseVisualStyleBackColor = false;
            buttonSignUp1.Click += buttonSignUp1_Click;
            // 
            // buttonLogin1
            // 
            buttonLogin1.BackColor = Color.DarkSeaGreen;
            buttonLogin1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin1.Location = new Point(155, 389);
            buttonLogin1.Name = "buttonLogin1";
            buttonLogin1.Size = new Size(271, 86);
            buttonLogin1.TabIndex = 6;
            buttonLogin1.Text = "Login";
            buttonLogin1.UseVisualStyleBackColor = false;
            buttonLogin1.Click += buttonLogin1_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(293, 299);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(243, 39);
            textBoxPass.TabIndex = 5;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(293, 219);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(243, 39);
            textBoxUser.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(141, 522);
            label1.Name = "label1";
            label1.Size = new Size(285, 45);
            label1.TabIndex = 3;
            label1.Text = "Create an account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(67, 208);
            label2.Name = "label2";
            label2.Size = new Size(196, 50);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(67, 288);
            label3.Name = "label3";
            label3.Size = new Size(187, 50);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(67, 67);
            label4.Name = "label4";
            label4.Size = new Size(221, 92);
            label4.TabIndex = 0;
            label4.Text = "Login";
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.DarkSeaGreen;
            buttonSignUp.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignUp.Location = new Point(155, 586);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(271, 86);
            buttonSignUp.TabIndex = 7;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DarkSeaGreen;
            buttonLogin.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(155, 389);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(271, 86);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            
            // 
            // textBoxUsername
            // 
            
            // 
            // labelCrAcc
            // 
            labelCrAcc.AutoSize = true;
            labelCrAcc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCrAcc.ForeColor = SystemColors.InactiveCaptionText;
            labelCrAcc.Location = new Point(141, 522);
            labelCrAcc.Name = "labelCrAcc";
            labelCrAcc.Size = new Size(285, 45);
            labelCrAcc.TabIndex = 3;
            labelCrAcc.Text = "Create an account";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.DarkGreen;
            labelUsername.Location = new Point(67, 208);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(196, 50);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.DarkGreen;
            labelPassword.Location = new Point(67, 288);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(187, 50);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogin.ForeColor = SystemColors.ControlLightLight;
            labelLogin.Location = new Point(67, 67);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(221, 92);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2019, 917);
            Controls.Add(loginPanel);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Label labelUsername;
        private Label labelPassword;
        private Label labelLogin;
        private Label labelCrAcc;
        private Button buttonSignUp;
        private Button buttonLogin;
        private Panel panel1;
        private Button buttonSignUp1;
        private Button buttonLogin1;
        private TextBox textBoxPass;
        private TextBox textBoxUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
