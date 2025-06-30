namespace BigButtonDemo
{
    partial class MainForm
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
            GetWeather = new Button();
            label1 = new Label();
            TempatureTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            Time = new DataGridViewTextBoxColumn();
            Tempature = new DataGridViewTextBoxColumn();
            Condition = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GetWeather
            // 
            GetWeather.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GetWeather.Location = new Point(694, 409);
            GetWeather.Name = "GetWeather";
            GetWeather.Size = new Size(94, 29);
            GetWeather.TabIndex = 0;
            GetWeather.Text = "Click Me";
            GetWeather.UseVisualStyleBackColor = true;
            GetWeather.Click += GetWeatherButton;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 2;
            label1.Text = "Current Tempature:";
            // 
            // TempatureTextBox
            // 
            TempatureTextBox.Enabled = false;
            TempatureTextBox.Location = new Point(168, 23);
            TempatureTextBox.Name = "TempatureTextBox";
            TempatureTextBox.ReadOnly = true;
            TempatureTextBox.Size = new Size(125, 27);
            TempatureTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Time, Tempature, Condition });
            dataGridView1.Location = new Point(24, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(764, 336);
            dataGridView1.TabIndex = 4;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.ReadOnly = true;
            Time.Width = 250;
            // 
            // Tempature
            // 
            Tempature.HeaderText = "Tempature";
            Tempature.MinimumWidth = 6;
            Tempature.Name = "Tempature";
            Tempature.ReadOnly = true;
            Tempature.Width = 125;
            // 
            // Condition
            // 
            Condition.HeaderText = "Condition";
            Condition.MinimumWidth = 6;
            Condition.Name = "Condition";
            Condition.ReadOnly = true;
            Condition.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(TempatureTextBox);
            Controls.Add(label1);
            Controls.Add(GetWeather);
            Name = "MainForm";
            Text = "Weather Demo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetWeather;
        private Label label1;
        private TextBox TempatureTextBox;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Tempature;
        private DataGridViewTextBoxColumn Condition;
    }
}
