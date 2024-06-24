namespace Demo.Forms
{
    partial class RandomNumbersForm
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
            RandomMinimumInput = new TextBox();
            RandomMaximumInput = new TextBox();
            RandomMinimumLabel = new Label();
            RandomMaximumLabel = new Label();
            ApplyRandomButton = new Button();
            SuspendLayout();
            // 
            // RandomMinimumInput
            // 
            RandomMinimumInput.BackColor = Color.White;
            RandomMinimumInput.Cursor = Cursors.IBeam;
            RandomMinimumInput.ForeColor = Color.FromArgb(112, 97, 131);
            RandomMinimumInput.Location = new Point(206, 16);
            RandomMinimumInput.Margin = new Padding(4);
            RandomMinimumInput.Name = "RandomMinimumInput";
            RandomMinimumInput.Size = new Size(127, 26);
            RandomMinimumInput.TabIndex = 0;
            RandomMinimumInput.Text = "-100";
            // 
            // RandomMaximumInput
            // 
            RandomMaximumInput.BackColor = Color.White;
            RandomMaximumInput.Cursor = Cursors.IBeam;
            RandomMaximumInput.ForeColor = Color.FromArgb(112, 97, 131);
            RandomMaximumInput.Location = new Point(206, 89);
            RandomMaximumInput.Margin = new Padding(4);
            RandomMaximumInput.Name = "RandomMaximumInput";
            RandomMaximumInput.Size = new Size(127, 26);
            RandomMaximumInput.TabIndex = 1;
            RandomMaximumInput.Text = "100";
            // 
            // RandomMinimumLabel
            // 
            RandomMinimumLabel.AutoSize = true;
            RandomMinimumLabel.Location = new Point(15, 19);
            RandomMinimumLabel.Margin = new Padding(4, 0, 4, 0);
            RandomMinimumLabel.Name = "RandomMinimumLabel";
            RandomMinimumLabel.Size = new Size(180, 19);
            RandomMinimumLabel.TabIndex = 2;
            RandomMinimumLabel.Text = "Мінімальне значення";
            // 
            // RandomMaximumLabel
            // 
            RandomMaximumLabel.AutoSize = true;
            RandomMaximumLabel.Location = new Point(15, 92);
            RandomMaximumLabel.Margin = new Padding(4, 0, 4, 0);
            RandomMaximumLabel.Name = "RandomMaximumLabel";
            RandomMaximumLabel.Size = new Size(189, 19);
            RandomMaximumLabel.TabIndex = 3;
            RandomMaximumLabel.Text = "Максимальне значення";
            // 
            // ApplyRandomButton
            // 
            ApplyRandomButton.BackColor = Color.White;
            ApplyRandomButton.Cursor = Cursors.Hand;
            ApplyRandomButton.ForeColor = Color.FromArgb(112, 97, 131);
            ApplyRandomButton.Location = new Point(118, 154);
            ApplyRandomButton.Margin = new Padding(4);
            ApplyRandomButton.Name = "ApplyRandomButton";
            ApplyRandomButton.Size = new Size(123, 29);
            ApplyRandomButton.TabIndex = 4;
            ApplyRandomButton.Text = "Застосувати";
            ApplyRandomButton.UseVisualStyleBackColor = false;
            ApplyRandomButton.Click += ApplyRandomButton_Click;
            // 
            // RandomNumbersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(112, 97, 131);
            ClientSize = new Size(346, 196);
            Controls.Add(ApplyRandomButton);
            Controls.Add(RandomMaximumLabel);
            Controls.Add(RandomMinimumLabel);
            Controls.Add(RandomMaximumInput);
            Controls.Add(RandomMinimumInput);
            Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "RandomNumbersForm";
            Text = "Границі випадкових чисел";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RandomMinimumInput;
        private TextBox RandomMaximumInput;
        private Label RandomMinimumLabel;
        private Label RandomMaximumLabel;
        private Button ApplyRandomButton;
    }
}