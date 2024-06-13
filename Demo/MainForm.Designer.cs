﻿namespace Demo
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
            SinCheckBox = new CheckBox();
            ChartTypeComboBox = new ComboBox();
            LinearCheckBox = new CheckBox();
            SquareCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)DataChart).BeginInit();
            RangeGroupBox.SuspendLayout();
            VisualizationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DataChart
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.LabelStyle.Format = "N0";
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.BackColor = Color.White;
            chartArea1.Name = "ChartArea";
            DataChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            DataChart.Legends.Add(legend1);
            DataChart.Location = new Point(12, 12);
            DataChart.Name = "DataChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "y = x^2";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "y = x";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "y = sin(x)";
            DataChart.Series.Add(series1);
            DataChart.Series.Add(series2);
            DataChart.Series.Add(series3);
            DataChart.Size = new Size(516, 426);
            DataChart.TabIndex = 0;
            DataChart.Text = "chart1";
            // 
            // RangeGroupBox
            // 
            RangeGroupBox.Controls.Add(StepLabel);
            RangeGroupBox.Controls.Add(EndRangeLabel);
            RangeGroupBox.Controls.Add(StartRangeLabel);
            RangeGroupBox.Controls.Add(StepInput);
            RangeGroupBox.Controls.Add(EndRangeInput);
            RangeGroupBox.Controls.Add(StartRangeInput);
            RangeGroupBox.Location = new Point(534, 12);
            RangeGroupBox.Name = "RangeGroupBox";
            RangeGroupBox.Size = new Size(254, 168);
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
            BuildButton.Location = new Point(631, 415);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(91, 23);
            BuildButton.TabIndex = 2;
            BuildButton.Text = "Побудувати";
            BuildButton.UseVisualStyleBackColor = true;
            BuildButton.Click += BuildButton_Click;
            // 
            // VisualizationGroupBox
            // 
            VisualizationGroupBox.Controls.Add(SinCheckBox);
            VisualizationGroupBox.Controls.Add(ChartTypeComboBox);
            VisualizationGroupBox.Controls.Add(LinearCheckBox);
            VisualizationGroupBox.Controls.Add(SquareCheckBox);
            VisualizationGroupBox.Location = new Point(539, 195);
            VisualizationGroupBox.Name = "VisualizationGroupBox";
            VisualizationGroupBox.Size = new Size(249, 146);
            VisualizationGroupBox.TabIndex = 3;
            VisualizationGroupBox.TabStop = false;
            VisualizationGroupBox.Text = "Візуалізація";
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
            SinCheckBox.CheckedChanged += SinCheckBox_CheckedChanged;
            // 
            // ChartTypeComboBox
            // 
            ChartTypeComboBox.FormattingEnabled = true;
            ChartTypeComboBox.Items.AddRange(new object[] { "Точковий", "Діаграма", "Лінія" });
            ChartTypeComboBox.Location = new Point(11, 108);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 464);
            Controls.Add(VisualizationGroupBox);
            Controls.Add(BuildButton);
            Controls.Add(RangeGroupBox);
            Controls.Add(DataChart);
            Name = "MainForm";
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)DataChart).EndInit();
            RangeGroupBox.ResumeLayout(false);
            RangeGroupBox.PerformLayout();
            VisualizationGroupBox.ResumeLayout(false);
            VisualizationGroupBox.PerformLayout();
            ResumeLayout(false);
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
    }
}