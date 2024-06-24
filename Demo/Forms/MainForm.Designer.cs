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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            CustomFormulaLabel = new Label();
            CustomCheckBox = new CheckBox();
            RandomRangeLabel = new Label();
            RandomCheckBox = new CheckBox();
            SinCheckBox = new CheckBox();
            ChartTypeComboBox = new ComboBox();
            LinearCheckBox = new CheckBox();
            SquareCheckBox = new CheckBox();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            TransformationInput = new TextBox();
            TransformationLabel = new Label();
            ShiftXCheckBox = new CheckBox();
            ShiftYCheckBox = new CheckBox();
            StretchXCheckBox = new CheckBox();
            StretchYCheckBox = new CheckBox();
            TransformButton = new Button();
            TransformationGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)DataChart).BeginInit();
            RangeGroupBox.SuspendLayout();
            VisualizationGroupBox.SuspendLayout();
            menuStrip.SuspendLayout();
            TransformationGroupBox.SuspendLayout();
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisX.LabelStyle.Format = "N0";
            chartArea1.AxisX.LineColor = Color.WhiteSmoke;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = Color.White;
            chartArea1.AxisX.MinorGrid.LineColor = Color.White;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.LineColor = Color.White;
            chartArea1.AxisX.Title = "X";
            chartArea1.AxisX.TitleFont = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.AxisX.TitleForeColor = Color.White;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisY.LabelStyle.Format = "N0";
            chartArea1.AxisY.LineColor = Color.White;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineColor = Color.White;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = Color.White;
            chartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisY.Title = "Y";
            chartArea1.AxisY.TitleFont = new Font("Consolas", 12F, FontStyle.Bold);
            chartArea1.AxisY.TitleForeColor = Color.White;
            chartArea1.BackColor = Color.Transparent;
            chartArea1.BackImageTransparentColor = Color.FromArgb(224, 224, 224);
            chartArea1.BackSecondaryColor = Color.FromArgb(224, 224, 224);
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea";
            DataChart.ChartAreas.Add(chartArea1);
            DataChart.Cursor = Cursors.Hand;
            legend1.BackColor = Color.Transparent;
            legend1.Font = new Font("Consolas", 12F);
            legend1.ForeColor = Color.White;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend";
            DataChart.Legends.Add(legend1);
            DataChart.Location = new Point(15, 39);
            DataChart.Margin = new Padding(4);
            DataChart.Name = "DataChart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = Color.Fuchsia;
            series1.LabelBackColor = Color.Transparent;
            series1.Legend = "Legend";
            series1.Name = "y = x^2";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = Color.Yellow;
            series2.LabelBackColor = Color.Transparent;
            series2.Legend = "Legend";
            series2.Name = "y = x";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = Color.DodgerBlue;
            series3.LabelBackColor = Color.Transparent;
            series3.Legend = "Legend";
            series3.Name = "y = sin(x)";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = Color.LawnGreen;
            series4.LabelBackColor = Color.Transparent;
            series4.Legend = "Legend";
            series4.Name = "y = random";
            series5.BorderColor = Color.White;
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = Color.Crimson;
            series5.Legend = "Legend";
            series5.Name = "y = custom";
            DataChart.Series.Add(series1);
            DataChart.Series.Add(series2);
            DataChart.Series.Add(series3);
            DataChart.Series.Add(series4);
            DataChart.Series.Add(series5);
            DataChart.Size = new Size(857, 739);
            DataChart.TabIndex = 0;
            DataChart.Text = "chart1";
            // 
            // RangeGroupBox
            // 
            RangeGroupBox.Anchor = AnchorStyles.Top;
            RangeGroupBox.BackColor = Color.FromArgb(112, 97, 131);
            RangeGroupBox.Controls.Add(StepLabel);
            RangeGroupBox.Controls.Add(EndRangeLabel);
            RangeGroupBox.Controls.Add(StartRangeLabel);
            RangeGroupBox.Controls.Add(StepInput);
            RangeGroupBox.Controls.Add(EndRangeInput);
            RangeGroupBox.Controls.Add(StartRangeInput);
            RangeGroupBox.ForeColor = SystemColors.Control;
            RangeGroupBox.Location = new Point(880, 39);
            RangeGroupBox.Margin = new Padding(4);
            RangeGroupBox.Name = "RangeGroupBox";
            RangeGroupBox.Padding = new Padding(4);
            RangeGroupBox.Size = new Size(336, 215);
            RangeGroupBox.TabIndex = 1;
            RangeGroupBox.TabStop = false;
            RangeGroupBox.Text = "Проміжок";
            // 
            // StepLabel
            // 
            StepLabel.AutoSize = true;
            StepLabel.ForeColor = SystemColors.Control;
            StepLabel.Location = new Point(8, 175);
            StepLabel.Margin = new Padding(4, 0, 4, 0);
            StepLabel.Name = "StepLabel";
            StepLabel.Size = new Size(81, 19);
            StepLabel.TabIndex = 5;
            StepLabel.Text = "Крок (H)";
            // 
            // EndRangeLabel
            // 
            EndRangeLabel.AutoSize = true;
            EndRangeLabel.ForeColor = SystemColors.Control;
            EndRangeLabel.Location = new Point(8, 114);
            EndRangeLabel.Margin = new Padding(4, 0, 4, 0);
            EndRangeLabel.Name = "EndRangeLabel";
            EndRangeLabel.Size = new Size(180, 19);
            EndRangeLabel.TabIndex = 4;
            EndRangeLabel.Text = "Кінець проміжку (B)";
            // 
            // StartRangeLabel
            // 
            StartRangeLabel.AutoSize = true;
            StartRangeLabel.ForeColor = SystemColors.Control;
            StartRangeLabel.Location = new Point(8, 57);
            StartRangeLabel.Margin = new Padding(4, 0, 4, 0);
            StartRangeLabel.Name = "StartRangeLabel";
            StartRangeLabel.Size = new Size(189, 19);
            StartRangeLabel.TabIndex = 3;
            StartRangeLabel.Text = "Початок проміжку (A)";
            // 
            // StepInput
            // 
            StepInput.BackColor = Color.White;
            StepInput.Cursor = Cursors.IBeam;
            StepInput.ForeColor = Color.FromArgb(112, 97, 131);
            StepInput.Location = new Point(201, 172);
            StepInput.Margin = new Padding(4);
            StepInput.Name = "StepInput";
            StepInput.Size = new Size(127, 26);
            StepInput.TabIndex = 2;
            StepInput.Text = "1";
            // 
            // EndRangeInput
            // 
            EndRangeInput.BackColor = Color.White;
            EndRangeInput.Cursor = Cursors.IBeam;
            EndRangeInput.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EndRangeInput.ForeColor = Color.FromArgb(112, 97, 131);
            EndRangeInput.Location = new Point(201, 114);
            EndRangeInput.Margin = new Padding(4);
            EndRangeInput.Name = "EndRangeInput";
            EndRangeInput.Size = new Size(127, 26);
            EndRangeInput.TabIndex = 1;
            EndRangeInput.Text = "10";
            // 
            // StartRangeInput
            // 
            StartRangeInput.BackColor = Color.White;
            StartRangeInput.Cursor = Cursors.IBeam;
            StartRangeInput.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartRangeInput.ForeColor = Color.FromArgb(112, 97, 131);
            StartRangeInput.Location = new Point(201, 54);
            StartRangeInput.Margin = new Padding(4);
            StartRangeInput.Name = "StartRangeInput";
            StartRangeInput.Size = new Size(127, 26);
            StartRangeInput.TabIndex = 0;
            StartRangeInput.Text = "-10";
            // 
            // BuildButton
            // 
            BuildButton.Anchor = AnchorStyles.Top;
            BuildButton.BackColor = Color.White;
            BuildButton.Cursor = Cursors.Hand;
            BuildButton.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            BuildButton.FlatAppearance.BorderSize = 5;
            BuildButton.ForeColor = Color.FromArgb(112, 97, 131);
            BuildButton.Location = new Point(1001, 752);
            BuildButton.Margin = new Padding(4);
            BuildButton.Name = "BuildButton";
            BuildButton.Size = new Size(117, 29);
            BuildButton.TabIndex = 2;
            BuildButton.Text = "Побудувати";
            BuildButton.UseVisualStyleBackColor = false;
            BuildButton.Click += BuildButton_Click;
            // 
            // VisualizationGroupBox
            // 
            VisualizationGroupBox.Anchor = AnchorStyles.Top;
            VisualizationGroupBox.BackColor = Color.FromArgb(112, 97, 131);
            VisualizationGroupBox.Controls.Add(CustomFormulaLabel);
            VisualizationGroupBox.Controls.Add(CustomCheckBox);
            VisualizationGroupBox.Controls.Add(RandomRangeLabel);
            VisualizationGroupBox.Controls.Add(RandomCheckBox);
            VisualizationGroupBox.Controls.Add(SinCheckBox);
            VisualizationGroupBox.Controls.Add(ChartTypeComboBox);
            VisualizationGroupBox.Controls.Add(LinearCheckBox);
            VisualizationGroupBox.Controls.Add(SquareCheckBox);
            VisualizationGroupBox.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VisualizationGroupBox.ForeColor = SystemColors.Control;
            VisualizationGroupBox.Location = new Point(880, 260);
            VisualizationGroupBox.Margin = new Padding(4);
            VisualizationGroupBox.Name = "VisualizationGroupBox";
            VisualizationGroupBox.Padding = new Padding(4);
            VisualizationGroupBox.Size = new Size(336, 237);
            VisualizationGroupBox.TabIndex = 3;
            VisualizationGroupBox.TabStop = false;
            VisualizationGroupBox.Text = "Візуалізація";
            // 
            // CustomFormulaLabel
            // 
            CustomFormulaLabel.AutoSize = true;
            CustomFormulaLabel.Location = new Point(127, 163);
            CustomFormulaLabel.Margin = new Padding(4, 0, 4, 0);
            CustomFormulaLabel.Name = "CustomFormulaLabel";
            CustomFormulaLabel.Size = new Size(0, 19);
            CustomFormulaLabel.TabIndex = 7;
            CustomFormulaLabel.Visible = false;
            // 
            // CustomCheckBox
            // 
            CustomCheckBox.AutoSize = true;
            CustomCheckBox.Cursor = Cursors.Hand;
            CustomCheckBox.Location = new Point(14, 162);
            CustomCheckBox.Margin = new Padding(4);
            CustomCheckBox.Name = "CustomCheckBox";
            CustomCheckBox.Size = new Size(118, 23);
            CustomCheckBox.TabIndex = 6;
            CustomCheckBox.Text = "y = custom";
            CustomCheckBox.UseVisualStyleBackColor = true;
            CustomCheckBox.CheckedChanged += CustomCheckBox_CheckedChanged;
            // 
            // RandomRangeLabel
            // 
            RandomRangeLabel.AutoSize = true;
            RandomRangeLabel.Location = new Point(144, 130);
            RandomRangeLabel.Margin = new Padding(4, 0, 4, 0);
            RandomRangeLabel.Name = "RandomRangeLabel";
            RandomRangeLabel.Size = new Size(0, 19);
            RandomRangeLabel.TabIndex = 5;
            RandomRangeLabel.Visible = false;
            // 
            // RandomCheckBox
            // 
            RandomCheckBox.AutoSize = true;
            RandomCheckBox.Cursor = Cursors.Hand;
            RandomCheckBox.Location = new Point(14, 130);
            RandomCheckBox.Margin = new Padding(4);
            RandomCheckBox.Name = "RandomCheckBox";
            RandomCheckBox.Size = new Size(118, 23);
            RandomCheckBox.TabIndex = 4;
            RandomCheckBox.Text = "y = random";
            RandomCheckBox.UseVisualStyleBackColor = true;
            RandomCheckBox.CheckedChanged += RandomCheckBox_CheckedChanged;
            // 
            // SinCheckBox
            // 
            SinCheckBox.AutoSize = true;
            SinCheckBox.Cursor = Cursors.Hand;
            SinCheckBox.Location = new Point(14, 99);
            SinCheckBox.Margin = new Padding(4);
            SinCheckBox.Name = "SinCheckBox";
            SinCheckBox.Size = new Size(118, 23);
            SinCheckBox.TabIndex = 3;
            SinCheckBox.Text = "y = sin(x)";
            SinCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChartTypeComboBox
            // 
            ChartTypeComboBox.BackColor = Color.White;
            ChartTypeComboBox.Cursor = Cursors.Hand;
            ChartTypeComboBox.ForeColor = Color.FromArgb(112, 97, 131);
            ChartTypeComboBox.FormattingEnabled = true;
            ChartTypeComboBox.Items.AddRange(new object[] { "Точковий", "Діаграма", "Лінія" });
            ChartTypeComboBox.Location = new Point(12, 194);
            ChartTypeComboBox.Margin = new Padding(4);
            ChartTypeComboBox.Name = "ChartTypeComboBox";
            ChartTypeComboBox.Size = new Size(154, 27);
            ChartTypeComboBox.TabIndex = 2;
            ChartTypeComboBox.SelectedIndexChanged += ChartTypeComboBox_SelectedIndexChanged;
            // 
            // LinearCheckBox
            // 
            LinearCheckBox.AutoSize = true;
            LinearCheckBox.Cursor = Cursors.Hand;
            LinearCheckBox.Location = new Point(14, 67);
            LinearCheckBox.Margin = new Padding(4);
            LinearCheckBox.Name = "LinearCheckBox";
            LinearCheckBox.Size = new Size(73, 23);
            LinearCheckBox.TabIndex = 1;
            LinearCheckBox.Text = "y = x";
            LinearCheckBox.UseVisualStyleBackColor = true;
            // 
            // SquareCheckBox
            // 
            SquareCheckBox.AutoSize = true;
            SquareCheckBox.Cursor = Cursors.Hand;
            SquareCheckBox.Location = new Point(14, 35);
            SquareCheckBox.Margin = new Padding(4);
            SquareCheckBox.Name = "SquareCheckBox";
            SquareCheckBox.Size = new Size(109, 23);
            SquareCheckBox.TabIndex = 0;
            SquareCheckBox.Text = "y = x ^ 2";
            SquareCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.FromArgb(112, 97, 131);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(1229, 29);
            menuStrip.TabIndex = 6;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.ForeColor = SystemColors.Control;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(57, 23);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.BackColor = Color.FromArgb(185, 174, 196);
            openToolStripMenuItem.ForeColor = SystemColors.Control;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 24);
            openToolStripMenuItem.Text = "Відкрити";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.BackColor = Color.FromArgb(185, 174, 196);
            saveAsToolStripMenuItem.ForeColor = SystemColors.Control;
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 24);
            saveAsToolStripMenuItem.Text = "Зберегти";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // TransformationInput
            // 
            TransformationInput.BackColor = Color.White;
            TransformationInput.Cursor = Cursors.IBeam;
            TransformationInput.ForeColor = Color.FromArgb(112, 97, 131);
            TransformationInput.Location = new Point(155, 32);
            TransformationInput.Margin = new Padding(4);
            TransformationInput.Name = "TransformationInput";
            TransformationInput.Size = new Size(127, 26);
            TransformationInput.TabIndex = 0;
            // 
            // TransformationLabel
            // 
            TransformationLabel.AutoSize = true;
            TransformationLabel.Location = new Point(12, 35);
            TransformationLabel.Margin = new Padding(4, 0, 4, 0);
            TransformationLabel.Name = "TransformationLabel";
            TransformationLabel.Size = new Size(135, 19);
            TransformationLabel.TabIndex = 1;
            TransformationLabel.Text = "Коефіцієнт (K)";
            // 
            // ShiftXCheckBox
            // 
            ShiftXCheckBox.AutoSize = true;
            ShiftXCheckBox.Cursor = Cursors.Hand;
            ShiftXCheckBox.Location = new Point(12, 68);
            ShiftXCheckBox.Margin = new Padding(4);
            ShiftXCheckBox.Name = "ShiftXCheckBox";
            ShiftXCheckBox.Size = new Size(172, 23);
            ShiftXCheckBox.TabIndex = 2;
            ShiftXCheckBox.Text = "Перенос по осі X";
            ShiftXCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShiftYCheckBox
            // 
            ShiftYCheckBox.AutoSize = true;
            ShiftYCheckBox.Cursor = Cursors.Hand;
            ShiftYCheckBox.Location = new Point(12, 101);
            ShiftYCheckBox.Margin = new Padding(4);
            ShiftYCheckBox.Name = "ShiftYCheckBox";
            ShiftYCheckBox.Size = new Size(172, 23);
            ShiftYCheckBox.TabIndex = 3;
            ShiftYCheckBox.Text = "Перенос по осі Y";
            ShiftYCheckBox.UseVisualStyleBackColor = true;
            // 
            // StretchXCheckBox
            // 
            StretchXCheckBox.AutoSize = true;
            StretchXCheckBox.Cursor = Cursors.Hand;
            StretchXCheckBox.Location = new Point(12, 132);
            StretchXCheckBox.Margin = new Padding(4);
            StretchXCheckBox.Name = "StretchXCheckBox";
            StretchXCheckBox.Size = new Size(190, 23);
            StretchXCheckBox.TabIndex = 4;
            StretchXCheckBox.Text = "Стиснення по осі X";
            StretchXCheckBox.UseVisualStyleBackColor = true;
            // 
            // StretchYCheckBox
            // 
            StretchYCheckBox.AutoSize = true;
            StretchYCheckBox.Cursor = Cursors.Hand;
            StretchYCheckBox.Location = new Point(12, 163);
            StretchYCheckBox.Margin = new Padding(4);
            StretchYCheckBox.Name = "StretchYCheckBox";
            StretchYCheckBox.Size = new Size(190, 23);
            StretchYCheckBox.TabIndex = 5;
            StretchYCheckBox.Text = "Стистення по осі Y";
            StretchYCheckBox.UseVisualStyleBackColor = true;
            // 
            // TransformButton
            // 
            TransformButton.BackColor = Color.White;
            TransformButton.Cursor = Cursors.Hand;
            TransformButton.ForeColor = Color.FromArgb(112, 97, 131);
            TransformButton.Location = new Point(121, 202);
            TransformButton.Margin = new Padding(4);
            TransformButton.Name = "TransformButton";
            TransformButton.Size = new Size(117, 29);
            TransformButton.TabIndex = 6;
            TransformButton.Text = "Застосувати";
            TransformButton.UseVisualStyleBackColor = false;
            TransformButton.Click += TransformButton_Click;
            // 
            // TransformationGroupBox
            // 
            TransformationGroupBox.Anchor = AnchorStyles.Top;
            TransformationGroupBox.BackColor = Color.FromArgb(112, 97, 131);
            TransformationGroupBox.Controls.Add(TransformButton);
            TransformationGroupBox.Controls.Add(StretchYCheckBox);
            TransformationGroupBox.Controls.Add(StretchXCheckBox);
            TransformationGroupBox.Controls.Add(ShiftYCheckBox);
            TransformationGroupBox.Controls.Add(ShiftXCheckBox);
            TransformationGroupBox.Controls.Add(TransformationLabel);
            TransformationGroupBox.Controls.Add(TransformationInput);
            TransformationGroupBox.ForeColor = SystemColors.Control;
            TransformationGroupBox.Location = new Point(880, 505);
            TransformationGroupBox.Margin = new Padding(4);
            TransformationGroupBox.Name = "TransformationGroupBox";
            TransformationGroupBox.Padding = new Padding(4);
            TransformationGroupBox.Size = new Size(336, 239);
            TransformationGroupBox.TabIndex = 4;
            TransformationGroupBox.TabStop = false;
            TransformationGroupBox.Text = "Трансформація";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 39, 50);
            ClientSize = new Size(1229, 791);
            Controls.Add(menuStrip);
            Controls.Add(TransformationGroupBox);
            Controls.Add(VisualizationGroupBox);
            Controls.Add(BuildButton);
            Controls.Add(RangeGroupBox);
            Controls.Add(DataChart);
            Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonFace;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            Margin = new Padding(4);
            MaximumSize = new Size(1396, 924);
            Name = "MainForm";
            Text = "Навчальна практика";
            ((System.ComponentModel.ISupportInitialize)DataChart).EndInit();
            RangeGroupBox.ResumeLayout(false);
            RangeGroupBox.PerformLayout();
            VisualizationGroupBox.ResumeLayout(false);
            VisualizationGroupBox.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            TransformationGroupBox.ResumeLayout(false);
            TransformationGroupBox.PerformLayout();
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
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private Label RandomRangeLabel;
        private CheckBox CustomCheckBox;
        private Label CustomFormulaLabel;
        private TextBox TransformationInput;
        private Label TransformationLabel;
        private CheckBox ShiftXCheckBox;
        private CheckBox ShiftYCheckBox;
        private CheckBox StretchXCheckBox;
        private CheckBox StretchYCheckBox;
        private Button TransformButton;
        private GroupBox TransformationGroupBox;
    }
}
