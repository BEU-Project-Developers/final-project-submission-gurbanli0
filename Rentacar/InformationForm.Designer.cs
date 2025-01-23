namespace Rentacar
{
    partial class InformationForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            carMapperBindingSource = new BindingSource(components);
            bookingMapperBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carMapperBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingMapperBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.DarkSeaGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1261, 605);
            dataGridView1.TabIndex = 0;
            // 
            // carMapperBindingSource
            // 
            carMapperBindingSource.DataSource = typeof(mapper.CarMapper);
            // 
            // bookingMapperBindingSource
            // 
            bookingMapperBindingSource.DataSource = typeof(mapper.BookingMapper);
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 629);
            Controls.Add(dataGridView1);
            Name = "InformationForm";
            Text = "InformationForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carMapperBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingMapperBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource bookingMapperBindingSource;
        private BindingSource carMapperBindingSource;
    }
}