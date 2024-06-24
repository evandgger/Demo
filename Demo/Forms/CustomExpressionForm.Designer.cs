namespace Demo.Forms
{
    partial class CustomExpressionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomExpressionForm));
            ExpressionInput = new TextBox();
            ExpressionLabel = new Label();
            EvaluateExpressionButton = new Button();
            RulesTextArea = new TextBox();
            SuspendLayout();
            // 
            // ExpressionInput
            // 
            ExpressionInput.BackColor = Color.White;
            ExpressionInput.Cursor = Cursors.IBeam;
            ExpressionInput.ForeColor = Color.FromArgb(112, 97, 131);
            ExpressionInput.Location = new Point(93, 396);
            ExpressionInput.Margin = new Padding(4);
            ExpressionInput.Name = "ExpressionInput";
            ExpressionInput.Size = new Size(517, 26);
            ExpressionInput.TabIndex = 0;
            // 
            // ExpressionLabel
            // 
            ExpressionLabel.AutoSize = true;
            ExpressionLabel.Location = new Point(13, 399);
            ExpressionLabel.Margin = new Padding(4, 0, 4, 0);
            ExpressionLabel.Name = "ExpressionLabel";
            ExpressionLabel.Size = new Size(72, 19);
            ExpressionLabel.TabIndex = 1;
            ExpressionLabel.Text = "f(x) = ";
            // 
            // EvaluateExpressionButton
            // 
            EvaluateExpressionButton.BackColor = Color.White;
            EvaluateExpressionButton.Cursor = Cursors.Hand;
            EvaluateExpressionButton.ForeColor = Color.FromArgb(112, 97, 131);
            EvaluateExpressionButton.Location = new Point(228, 430);
            EvaluateExpressionButton.Margin = new Padding(4);
            EvaluateExpressionButton.Name = "EvaluateExpressionButton";
            EvaluateExpressionButton.Size = new Size(135, 29);
            EvaluateExpressionButton.TabIndex = 2;
            EvaluateExpressionButton.Text = "Застосувати";
            EvaluateExpressionButton.UseVisualStyleBackColor = false;
            EvaluateExpressionButton.Click += EvaluateExpressionButton_Click;
            // 
            // RulesTextArea
            // 
            RulesTextArea.BackColor = Color.FromArgb(112, 97, 131);
            RulesTextArea.ForeColor = SystemColors.Window;
            RulesTextArea.Location = new Point(15, 15);
            RulesTextArea.Margin = new Padding(4);
            RulesTextArea.Multiline = true;
            RulesTextArea.Name = "RulesTextArea";
            RulesTextArea.ReadOnly = true;
            RulesTextArea.Size = new Size(595, 373);
            RulesTextArea.TabIndex = 3;
            RulesTextArea.Text = resources.GetString("RulesTextArea.Text");
            // 
            // CustomExpressionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(112, 97, 131);
            ClientSize = new Size(627, 465);
            Controls.Add(RulesTextArea);
            Controls.Add(EvaluateExpressionButton);
            Controls.Add(ExpressionLabel);
            Controls.Add(ExpressionInput);
            Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "CustomExpressionForm";
            Text = "Власна формула";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ExpressionInput;
        private Label ExpressionLabel;
        private Button EvaluateExpressionButton;
        private TextBox RulesTextArea;
    }
}