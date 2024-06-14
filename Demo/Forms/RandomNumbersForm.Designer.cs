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
            RandomMinimumInput.Location = new Point(156, 12);
            RandomMinimumInput.Name = "RandomMinimumInput";
            RandomMinimumInput.Size = new Size(100, 23);
            RandomMinimumInput.TabIndex = 0;
            // 
            // RandomMaximumInput
            // 
            RandomMaximumInput.Location = new Point(156, 70);
            RandomMaximumInput.Name = "RandomMaximumInput";
            RandomMaximumInput.Size = new Size(100, 23);
            RandomMaximumInput.TabIndex = 1;
            // 
            // RandomMinimumLabel
            // 
            RandomMinimumLabel.AutoSize = true;
            RandomMinimumLabel.Location = new Point(12, 15);
            RandomMinimumLabel.Name = "RandomMinimumLabel";
            RandomMinimumLabel.Size = new Size(126, 15);
            RandomMinimumLabel.TabIndex = 2;
            RandomMinimumLabel.Text = "Мінімальне значення";
            // 
            // RandomMaximumLabel
            // 
            RandomMaximumLabel.AutoSize = true;
            RandomMaximumLabel.Location = new Point(12, 73);
            RandomMaximumLabel.Name = "RandomMaximumLabel";
            RandomMaximumLabel.Size = new Size(138, 15);
            RandomMaximumLabel.TabIndex = 3;
            RandomMaximumLabel.Text = "Максимальне значення";
            // 
            // ApplyRandomButton
            // 
            ApplyRandomButton.Location = new Point(112, 150);
            ApplyRandomButton.Name = "ApplyRandomButton";
            ApplyRandomButton.Size = new Size(96, 23);
            ApplyRandomButton.TabIndex = 4;
            ApplyRandomButton.Text = "Застосувати";
            ApplyRandomButton.UseVisualStyleBackColor = true;
            ApplyRandomButton.Click += ApplyRandomButton_Click;
            // 
            // RandomNumbersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 185);
            Controls.Add(ApplyRandomButton);
            Controls.Add(RandomMaximumLabel);
            Controls.Add(RandomMinimumLabel);
            Controls.Add(RandomMaximumInput);
            Controls.Add(RandomMinimumInput);
            Name = "RandomNumbersForm";
            Text = "RandomNumbersForm";
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