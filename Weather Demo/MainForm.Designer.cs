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
            WeatherDataGrid = new DataGridView();
            Time = new DataGridViewTextBoxColumn();
            Tempature = new DataGridViewTextBoxColumn();
            Condition = new DataGridViewTextBoxColumn();
            TidesDataGrid = new DataGridView();
            TideTime = new DataGridViewTextBoxColumn();
            TideHeight = new DataGridViewTextBoxColumn();
            TideType = new DataGridViewTextBoxColumn();
            StationTextBox = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)WeatherDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TidesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // GetWeather
            // 
            GetWeather.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GetWeather.Location = new Point(693, 799);
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
            WeatherDataGrid.AllowUserToAddRows = false;
            WeatherDataGrid.AllowUserToDeleteRows = false;
            WeatherDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WeatherDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WeatherDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            WeatherDataGrid.Columns.AddRange(new DataGridViewColumn[] { Time, Tempature, Condition });
            WeatherDataGrid.Location = new Point(24, 67);
            WeatherDataGrid.Name = "dataGridView1";
            WeatherDataGrid.RowHeadersWidth = 51;
            WeatherDataGrid.Size = new Size(763, 251);
            WeatherDataGrid.TabIndex = 4;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // Tempature
            // 
            Tempature.HeaderText = "Tempature";
            Tempature.MinimumWidth = 6;
            Tempature.Name = "Tempature";
            Tempature.ReadOnly = true;
            // 
            // Condition
            // 
            Condition.HeaderText = "Condition";
            Condition.MinimumWidth = 6;
            Condition.Name = "Condition";
            Condition.ReadOnly = true;
            // 
            // TidesDataGrid
            // 
            TidesDataGrid.AllowUserToAddRows = false;
            TidesDataGrid.AllowUserToDeleteRows = false;
            TidesDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TidesDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TidesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TidesDataGrid.Columns.AddRange(new DataGridViewColumn[] { TideTime, TideHeight, TideType });
            TidesDataGrid.Location = new Point(22, 370);
            TidesDataGrid.Name = "TidesDataGrid";
            TidesDataGrid.ReadOnly = true;
            TidesDataGrid.RowHeadersWidth = 51;
            TidesDataGrid.Size = new Size(765, 423);
            TidesDataGrid.TabIndex = 5;
            // 
            // TideTime
            // 
            TideTime.HeaderText = "Time";
            TideTime.MinimumWidth = 6;
            TideTime.Name = "TideTime";
            TideTime.ReadOnly = true;
            // 
            // TideHeight
            // 
            TideHeight.HeaderText = "Height";
            TideHeight.MinimumWidth = 6;
            TideHeight.Name = "TideHeight";
            TideHeight.ReadOnly = true;
            // 
            // TideType
            // 
            TideType.HeaderText = "Type";
            TideType.MinimumWidth = 6;
            TideType.Name = "TideType";
            TideType.ReadOnly = true;
            // 
            // StationTextBox
            // 
            StationTextBox.Enabled = false;
            StationTextBox.Location = new Point(90, 334);
            StationTextBox.Name = "StationTextBox";
            StationTextBox.ReadOnly = true;
            StationTextBox.Size = new Size(220, 27);
            StationTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 337);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 7;
            label2.Text = "Station:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 840);
            Controls.Add(label2);
            Controls.Add(StationTextBox);
            Controls.Add(TidesDataGrid);
            Controls.Add(WeatherDataGrid);
            Controls.Add(TempatureTextBox);
            Controls.Add(label1);
            Controls.Add(GetWeather);
            Name = "MainForm";
            Text = "Weather Demo";
            ((System.ComponentModel.ISupportInitialize)WeatherDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)TidesDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetWeather;
        private Label label1;
        private TextBox TempatureTextBox;
        private DataGridView WeatherDataGrid;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Tempature;
        private DataGridViewTextBoxColumn Condition;
        private DataGridView TidesDataGrid;
        private DataGridViewTextBoxColumn TideTime;
        private DataGridViewTextBoxColumn TideHeight;
        private DataGridViewTextBoxColumn TideType;
        private TextBox StationTextBox;
        private Label label2;
    }
}
