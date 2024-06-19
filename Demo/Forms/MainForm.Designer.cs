namespace Demo.Forms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            DataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            RangeGroupBox = new GroupBox();
            StepLabel = new Label();
            EndRangeLabel = new Label();
            StartRangeLabel = new Label();
            StepInput = new TextBox();
            EndRangeInput = new TextBox();
            StartRangeInput = new TextBox();
            BuildButton = new Button();
            VisualizationGroupBox = new GroupBox();
            CustomCheckBox = new CheckBox();
            RandomRangeLabel = new Label();
            RandomCheckBox = new CheckBox();
            SinCheckBox = new CheckBox();
            ChartTypeComboBox = new ComboBox();
            LinearCheckBox = new CheckBox();
            SquareCheckBox = new CheckBox();
            TransformationGroupBox = new GroupBox();
            TransformButton = new Button();
            StretchYCheckBox = new CheckBox();
            StretchXCheckBox = new CheckBox();
            ShiftYCheckBox = new CheckBox();
            ShiftXCheckBox = new CheckBox();
            TransformationLabel = new Label();
            TransformationInput = new TextBox();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            CustomFormulaLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)DataChart).BeginInit();
            RangeGroupBox.SuspendLayout();
            VisualizationGroupBox.SuspendLayout();
            TransformationGroupBox.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DataChart
            // 
            DataChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataChart.BackColor = Color.Transparent;
            DataChart.BorderlineColor = Color.Transparent;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.LabelStyle.Format = "N0";
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.BackColor = Color.Transparent;
            chartArea1.BackImageTransparentColor = Color.FromArgb(224, 224, 224);
            chartArea1.BackSecondaryColor = Color.FromArgb(224, 224, 224);
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea";
            DataChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.Transparent;
            legend1.Name = "Legend1";
            DataChart.Legends.Add(legend1);
            DataChart.Location = new Point(12, 45);
            DataChart.Name = "DataChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.LabelBackColor = Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "y = x^2";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.LabelBackColor = Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "y = x";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.LabelBackColor = Color.Transparent;
            series3.Legend = "Legend1";
            series3.Name = "y = sin(x)";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.LabelBackColor = Color.Transparent;
            series4.Legend = "Legend1";
            series4.Name = "y = random";
            series5.BorderColor = Color.White;
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = Color.DarkGreen;
            series5.Legend = "Legend1";
            series5.Name = "y = custom";
            DataChart.Series.Add(series1);
            DataChart.Series.Add(series2);
            DataChart.Series.Add(series3);
            DataChart.Series.Add(series4);
            DataChart.Series.Add(series5);
            DataChart.Size = new Size(744, 618);
            DataChart.TabIndex = 0;
            DataChart.Text = "chart1";
            // 
            // RangeGroupBox
            // 
            RangeGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RangeGroupBox.Controls.Add(StepLabel);
            RangeGroupBox.Controls.Add(EndRangeLabel);
            RangeGroupBox.Controls.Add(StartRangeLabel);
            RangeGroupBox.Controls.Add(StepInput);
            RangeGroupBox.Controls.Add(EndRangeInput);
            RangeGroupBox.Controls.Add(StartRangeInput);
            RangeGroupBox.ForeColor = Color.Black;
            RangeGroupBox.Location = new Point(779, 36);
            RangeGroupBox.Name = "RangeGroupBox";
            RangeGroupBox.Size = new Size(255, 170);
            RangeGroupBox.TabIndex = 1;
            RangeGroupBox.TabStop = false;
            RangeGroupBox.Text = "Проміжок";
            // 
            // StepLabel
            // 
            StepLabel.AutoSize = true;
            StepLabel.Location = new Point(6, 138);
            StepLabel.Name = "StepLabel";
            StepLabel.Size = new Size(54, 15);
            StepLabel.TabIndex = 5;
            StepLabel.Text = "Крок (H)";
            // 
            // EndRangeLabel
            // 
            EndRangeLabel.AutoSize = true;
            EndRangeLabel.Location = new Point(6, 90);
            EndRangeLabel.Name = "EndRangeLabel";
            EndRangeLabel.Size = new Size(118, 15);
            EndRangeLabel.TabIndex = 4;
            EndRangeLabel.Text = "Кінець проміжку (B)";
            // 
            // StartRangeLabel
            // 
            StartRangeLabel.AutoSize = true;
            StartRangeLabel.Location = new Point(6, 45);
            StartRangeLabel.Name = "StartRangeLabel";
            StartRangeLabel.Size = new Size(130, 15);
            StartRangeLabel.TabIndex = 3;
            StartRangeLabel.Text = "Початок проміжку (A)";
            // 
            // StepInput
            // 
            StepInput.Location = new Point(148, 135);
            StepInput.Name = "StepInput";
            StepInput.Size = new Size(100, 23);
            StepInput.TabIndex = 2;
            StepInput.Text = "1";
            // 
            // EndRangeInput
            // 
            EndRangeInput.Location = new Point(148, 87);
            EndRangeInput.Name = "EndRangeInput";
            EndRangeInput.Size = new Size(100, 23);
            EndRangeInput.TabIndex = 1;
            EndRangeInput.Text = "10";
            // 
            // StartRangeInput
            // 
            StartRangeInput.Location = new Point(148, 42);
            StartRangeInput.Name = "StartRangeInput";
            StartRangeInput.Size = new Size(100, 23);
            StartRangeInput.TabIndex = 0;
            StartRangeInput.Text = "-10";
            // 
            // BuildButton
            // 
            BuildButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BuildButton.BackColor = SystemColors.ButtonHighlight;
            BuildButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            BuildButton.FlatAppearance.BorderSize = 5;
            BuildButton.Location = new Point(863, 640);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(91, 23);
            BuildButton.TabIndex = 2;
            BuildButton.Text = "Побудувати";
            BuildButton.UseVisualStyleBackColor = false;
            BuildButton.Click += BuildButton_Click;
            // 
            // VisualizationGroupBox
            // 
            VisualizationGroupBox.Anchor = AnchorStyles.Right;
            VisualizationGroupBox.BackColor = Color.Transparent;
            VisualizationGroupBox.Controls.Add(CustomFormulaLabel);
            VisualizationGroupBox.Controls.Add(CustomCheckBox);
            VisualizationGroupBox.Controls.Add(RandomRangeLabel);
            VisualizationGroupBox.Controls.Add(RandomCheckBox);
            VisualizationGroupBox.Controls.Add(SinCheckBox);
            VisualizationGroupBox.Controls.Add(ChartTypeComboBox);
            VisualizationGroupBox.Controls.Add(LinearCheckBox);
            VisualizationGroupBox.Controls.Add(SquareCheckBox);
            VisualizationGroupBox.Font = new Font("Segoe UI", 9F);
            VisualizationGroupBox.Location = new Point(776, 227);
            VisualizationGroupBox.Name = "VisualizationGroupBox";
            VisualizationGroupBox.Size = new Size(249, 187);
            VisualizationGroupBox.TabIndex = 3;
            VisualizationGroupBox.TabStop = false;
            VisualizationGroupBox.Text = "Візуалізація";
            // 
            // CustomCheckBox
            // 
            CustomCheckBox.AutoSize = true;
            CustomCheckBox.Location = new Point(11, 128);
            CustomCheckBox.Name = "CustomCheckBox";
            CustomCheckBox.Size = new Size(86, 19);
            CustomCheckBox.TabIndex = 6;
            CustomCheckBox.Text = "y = custom";
            CustomCheckBox.UseVisualStyleBackColor = true;
            CustomCheckBox.CheckedChanged += CustomCheckBox_CheckedChanged;
            // 
            // RandomRangeLabel
            // 
            RandomRangeLabel.AutoSize = true;
            RandomRangeLabel.Location = new Point(112, 103);
            RandomRangeLabel.Name = "RandomRangeLabel";
            RandomRangeLabel.Size = new Size(0, 15);
            RandomRangeLabel.TabIndex = 5;
            RandomRangeLabel.Visible = false;
            // 
            // RandomCheckBox
            // 
            RandomCheckBox.AutoSize = true;
            RandomCheckBox.Location = new Point(11, 103);
            RandomCheckBox.Name = "RandomCheckBox";
            RandomCheckBox.Size = new Size(88, 19);
            RandomCheckBox.TabIndex = 4;
            RandomCheckBox.Text = "y = random";
            RandomCheckBox.UseVisualStyleBackColor = true;
            RandomCheckBox.CheckedChanged += RandomCheckBox_CheckedChanged;
            // 
            // SinCheckBox
            // 
            SinCheckBox.AutoSize = true;
            SinCheckBox.Location = new Point(11, 78);
            SinCheckBox.Name = "SinCheckBox";
            SinCheckBox.Size = new Size(75, 19);
            SinCheckBox.TabIndex = 3;
            SinCheckBox.Text = "y = sin(x)";
            SinCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChartTypeComboBox
            // 
            ChartTypeComboBox.FormattingEnabled = true;
            ChartTypeComboBox.Items.AddRange(new object[] { "Точковий", "Діаграма", "Лінія" });
            ChartTypeComboBox.Location = new Point(9, 153);
            ChartTypeComboBox.Name = "ChartTypeComboBox";
            ChartTypeComboBox.Size = new Size(121, 23);
            ChartTypeComboBox.TabIndex = 2;
            ChartTypeComboBox.SelectedIndexChanged += ChartTypeComboBox_SelectedIndexChanged;
            // 
            // LinearCheckBox
            // 
            LinearCheckBox.AutoSize = true;
            LinearCheckBox.Location = new Point(11, 53);
            LinearCheckBox.Name = "LinearCheckBox";
            LinearCheckBox.Size = new Size(52, 19);
            LinearCheckBox.TabIndex = 1;
            LinearCheckBox.Text = "y = x";
            LinearCheckBox.UseVisualStyleBackColor = true;
            // 
            // SquareCheckBox
            // 
            SquareCheckBox.AutoSize = true;
            SquareCheckBox.Location = new Point(11, 28);
            SquareCheckBox.Name = "SquareCheckBox";
            SquareCheckBox.Size = new Size(72, 19);
            SquareCheckBox.TabIndex = 0;
            SquareCheckBox.Text = "y = x ^ 2";
            SquareCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransformationGroupBox
            // 
            TransformationGroupBox.Anchor = AnchorStyles.Right;
            TransformationGroupBox.Controls.Add(TransformButton);
            TransformationGroupBox.Controls.Add(StretchYCheckBox);
            TransformationGroupBox.Controls.Add(StretchXCheckBox);
            TransformationGroupBox.Controls.Add(ShiftYCheckBox);
            TransformationGroupBox.Controls.Add(ShiftXCheckBox);
            TransformationGroupBox.Controls.Add(TransformationLabel);
            TransformationGroupBox.Controls.Add(TransformationInput);
            TransformationGroupBox.Location = new Point(776, 445);
            TransformationGroupBox.Name = "TransformationGroupBox";
            TransformationGroupBox.Size = new Size(248, 189);
            TransformationGroupBox.TabIndex = 4;
            TransformationGroupBox.TabStop = false;
            TransformationGroupBox.Text = "Трансформація";
            // 
            // TransformButton
            // 
            TransformButton.Location = new Point(88, 154);
            TransformButton.Name = "TransformButton";
            TransformButton.Size = new Size(91, 23);
            TransformButton.TabIndex = 6;
            TransformButton.Text = "Застосувати";
            TransformButton.UseVisualStyleBackColor = true;
            TransformButton.Click += TransformButton_Click;
            // 
            // StretchYCheckBox
            // 
            StretchYCheckBox.AutoSize = true;
            StretchYCheckBox.Location = new Point(8, 129);
            StretchYCheckBox.Name = "StretchYCheckBox";
            StretchYCheckBox.Size = new Size(129, 19);
            StretchYCheckBox.TabIndex = 5;
            StretchYCheckBox.Text = "Стистення по осі Y";
            StretchYCheckBox.UseVisualStyleBackColor = true;
            // 
            // StretchXCheckBox
            // 
            StretchXCheckBox.AutoSize = true;
            StretchXCheckBox.Location = new Point(8, 104);
            StretchXCheckBox.Name = "StretchXCheckBox";
            StretchXCheckBox.Size = new Size(131, 19);
            StretchXCheckBox.TabIndex = 4;
            StretchXCheckBox.Text = "Стиснення по осі X";
            StretchXCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShiftYCheckBox
            // 
            ShiftYCheckBox.AutoSize = true;
            ShiftYCheckBox.Location = new Point(8, 79);
            ShiftYCheckBox.Name = "ShiftYCheckBox";
            ShiftYCheckBox.Size = new Size(120, 19);
            ShiftYCheckBox.TabIndex = 3;
            ShiftYCheckBox.Text = "Перенос по осі Y";
            ShiftYCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShiftXCheckBox
            // 
            ShiftXCheckBox.AutoSize = true;
            ShiftXCheckBox.Location = new Point(9, 54);
            ShiftXCheckBox.Name = "ShiftXCheckBox";
            ShiftXCheckBox.Size = new Size(120, 19);
            ShiftXCheckBox.TabIndex = 2;
            ShiftXCheckBox.Text = "Перенос по осі X";
            ShiftXCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransformationLabel
            // 
            TransformationLabel.AutoSize = true;
            TransformationLabel.Location = new Point(12, 28);
            TransformationLabel.Name = "TransformationLabel";
            TransformationLabel.Size = new Size(85, 15);
            TransformationLabel.TabIndex = 1;
            TransformationLabel.Text = "Коефіцієнт (K)";
            // 
            // TransformationInput
            // 
            TransformationInput.Location = new Point(103, 25);
            TransformationInput.Name = "TransformationInput";
            TransformationInput.Size = new Size(100, 23);
            TransformationInput.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ButtonFace;
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1046, 24);
            menuStrip.TabIndex = 6;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(112, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(112, 22);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // CustomFormulaLabel
            // 
            CustomFormulaLabel.AutoSize = true;
            CustomFormulaLabel.Location = new Point(99, 129);
            CustomFormulaLabel.Name = "CustomFormulaLabel";
            CustomFormulaLabel.Size = new Size(0, 15);
            CustomFormulaLabel.TabIndex = 7;
            CustomFormulaLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1046, 741);
            Controls.Add(menuStrip);
            Controls.Add(TransformationGroupBox);
            Controls.Add(VisualizationGroupBox);
            Controls.Add(BuildButton);
            Controls.Add(RangeGroupBox);
            Controls.Add(DataChart);
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)DataChart).EndInit();
            RangeGroupBox.ResumeLayout(false);
            RangeGroupBox.PerformLayout();
            VisualizationGroupBox.ResumeLayout(false);
            VisualizationGroupBox.PerformLayout();
            TransformationGroupBox.ResumeLayout(false);
            TransformationGroupBox.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart DataChart;
        private GroupBox RangeGroupBox;
        private Label StepLabel;
        private Label EndRangeLabel;
        private Label StartRangeLabel;
        private TextBox StepInput;
        private TextBox EndRangeInput;
        private TextBox StartRangeInput;
        private Button BuildButton;
        private GroupBox VisualizationGroupBox;
        private CheckBox LinearCheckBox;
        private CheckBox SquareCheckBox;
        private ComboBox ChartTypeComboBox;
        private CheckBox SinCheckBox;
        private CheckBox RandomCheckBox;
        private GroupBox TransformationGroupBox;
        private TextBox TransformationInput;
        private Button TransformButton;
        private CheckBox StretchYCheckBox;
        private CheckBox StretchXCheckBox;
        private CheckBox ShiftYCheckBox;
        private CheckBox ShiftXCheckBox;
        private Label TransformationLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label RandomRangeLabel;
        private CheckBox CustomCheckBox;
        private Label CustomFormulaLabel;
    }
}
