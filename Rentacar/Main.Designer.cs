namespace Rentacar
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tabControlAvCar = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            button2 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage3 = new TabPage();
            button3 = new Button();
            label6 = new Label();
            labelRentaCar = new Label();
            tabControlAvCar.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAvCar
            // 
            tabControlAvCar.Appearance = TabAppearance.FlatButtons;
            tabControlAvCar.Controls.Add(tabPage1);
            tabControlAvCar.Controls.Add(tabPage2);
            tabControlAvCar.Controls.Add(tabPage3);
            tabControlAvCar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlAvCar.Location = new Point(109, 184);
            tabControlAvCar.Multiline = true;
            tabControlAvCar.Name = "tabControlAvCar";
            tabControlAvCar.SelectedIndex = 0;
            tabControlAvCar.Size = new Size(995, 652);
            tabControlAvCar.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 77);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(987, 571);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Available Cars";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(303, 232);
            button1.Name = "button1";
            button1.Size = new Size(366, 97);
            button1.TabIndex = 3;
            button1.Text = "See";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(115, 125);
            label1.Name = "label1";
            label1.Size = new Size(780, 65);
            label1.TabIndex = 2;
            label1.Text = "Which cars are available for now?";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(numericUpDown1);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(checkBox1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 77);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(987, 571);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search Cars";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(414, 228);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(378, 71);
            numericUpDown1.TabIndex = 10;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(414, 305);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(378, 71);
            dateTimePicker1.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(807, 325);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(28, 27);
            checkBox1.TabIndex = 8;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.ForeColor = Color.DarkGreen;
            button2.Location = new Point(492, 421);
            button2.Name = "button2";
            button2.Size = new Size(300, 83);
            button2.TabIndex = 7;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(414, 147);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(378, 73);
            comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(414, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(378, 73);
            comboBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 305);
            label5.Name = "label5";
            label5.Size = new Size(134, 65);
            label5.TabIndex = 3;
            label5.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 226);
            label4.Name = "label4";
            label4.Size = new Size(124, 65);
            label4.TabIndex = 2;
            label4.Text = "Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 147);
            label3.Name = "label3";
            label3.Size = new Size(152, 65);
            label3.TabIndex = 1;
            label3.Text = "Make";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 68);
            label2.Name = "label2";
            label2.Size = new Size(173, 65);
            label2.TabIndex = 0;
            label2.Text = "Model";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 77);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(987, 571);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "My Rented Cars";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSeaGreen;
            button3.ForeColor = Color.DarkGreen;
            button3.Location = new Point(328, 245);
            button3.Name = "button3";
            button3.Size = new Size(270, 86);
            button3.TabIndex = 1;
            button3.Text = "Show";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(217, 143);
            label6.Name = "label6";
            label6.Size = new Size(498, 65);
            label6.TabIndex = 0;
            label6.Text = "Show my rented cars";
            // 
            // labelRentaCar
            // 
            labelRentaCar.AutoSize = true;
            labelRentaCar.BackColor = Color.DarkSeaGreen;
            labelRentaCar.Font = new Font("Segoe UI", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRentaCar.Location = new Point(109, 52);
            labelRentaCar.Name = "labelRentaCar";
            labelRentaCar.Size = new Size(469, 92);
            labelRentaCar.TabIndex = 1;
            labelRentaCar.Text = "B-Rent-A-Car";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1983, 1045);
            Controls.Add(labelRentaCar);
            Controls.Add(tabControlAvCar);
            DoubleBuffered = true;
            Name = "Main";
            Text = "Main";
            tabControlAvCar.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlAvCar;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label labelRentaCar;
        private TabPage tabPage3;
        private Button button1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private Label label6;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
    }
}