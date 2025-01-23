namespace Rentacar
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            panel1 = new Panel();
            textBoxConPass = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            textBoxName = new TextBox();
            buttonSignUp = new Button();
            labelConPass = new Label();
            labelPassword = new Label();
            labelName = new Label();
            labelUsername = new Label();
            labelSignUp = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(textBoxConPass);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(buttonSignUp);
            panel1.Controls.Add(labelConPass);
            panel1.Controls.Add(labelPassword);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(labelUsername);
            panel1.Controls.Add(labelSignUp);
            panel1.Location = new Point(63, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 638);
            panel1.TabIndex = 0;
            // 
            // textBoxConPass
            // 
            textBoxConPass.Location = new Point(420, 464);
            textBoxConPass.Name = "textBoxConPass";
            textBoxConPass.Size = new Size(271, 39);
            textBoxConPass.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(420, 366);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(271, 39);
            textBoxPassword.TabIndex = 8;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(420, 272);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(271, 39);
            textBoxUsername.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(420, 177);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(271, 39);
            textBoxName.TabIndex = 6;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.DarkSeaGreen;
            buttonSignUp.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSignUp.ForeColor = Color.DarkGreen;
            buttonSignUp.Location = new Point(230, 531);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(267, 75);
            buttonSignUp.TabIndex = 1;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click_1;
            // 
            // labelConPass
            // 
            labelConPass.AutoSize = true;
            labelConPass.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConPass.ForeColor = Color.DarkGreen;
            labelConPass.Location = new Point(42, 453);
            labelConPass.Name = "labelConPass";
            labelConPass.Size = new Size(339, 50);
            labelConPass.TabIndex = 5;
            labelConPass.Text = "Confirm Password";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.DarkGreen;
            labelPassword.Location = new Point(42, 355);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(187, 50);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.DarkGreen;
            labelName.Location = new Point(42, 166);
            labelName.Name = "labelName";
            labelName.Size = new Size(125, 50);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.DarkGreen;
            labelUsername.Location = new Point(42, 261);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(196, 50);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username";
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.Font = new Font("Segoe UI", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSignUp.ForeColor = SystemColors.ButtonHighlight;
            labelSignUp.Location = new Point(42, 16);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(295, 92);
            labelSignUp.TabIndex = 1;
            labelSignUp.Text = "Sign Up";
            // 
            // SignUpForm
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1742, 896);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "SignUpForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelSignUp;
        private Label labelUsername;
        private Label labelName;
        private TextBox textBoxName;
        private Button buttonSignUp;
        private Label labelConPass;
        private Label labelPassword;
        private TextBox textBoxConPass;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
    }
}