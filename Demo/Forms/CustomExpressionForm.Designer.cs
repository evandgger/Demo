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
            ExpressionInput.Location = new Point(56, 291);
            ExpressionInput.Name = "ExpressionInput";
            ExpressionInput.Size = new Size(420, 23);
            ExpressionInput.TabIndex = 0;
            // 
            // ExpressionLabel
            // 
            ExpressionLabel.AutoSize = true;
            ExpressionLabel.Location = new Point(11, 294);
            ExpressionLabel.Name = "ExpressionLabel";
            ExpressionLabel.Size = new Size(39, 15);
            ExpressionLabel.TabIndex = 1;
            ExpressionLabel.Text = "f(x) = ";
            // 
            // EvaluateExpressionButton
            // 
            EvaluateExpressionButton.Location = new Point(179, 338);
            EvaluateExpressionButton.Name = "EvaluateExpressionButton";
            EvaluateExpressionButton.Size = new Size(105, 23);
            EvaluateExpressionButton.TabIndex = 2;
            EvaluateExpressionButton.Text = "Застосувати";
            EvaluateExpressionButton.UseVisualStyleBackColor = true;
            EvaluateExpressionButton.Click += EvaluateExpressionButton_Click;
            // 
            // RulesTextArea
            // 
            RulesTextArea.Location = new Point(12, 12);
            RulesTextArea.Multiline = true;
            RulesTextArea.Name = "RulesTextArea";
            RulesTextArea.ReadOnly = true;
            RulesTextArea.Size = new Size(464, 252);
            RulesTextArea.TabIndex = 3;
            RulesTextArea.Text = resources.GetString("RulesTextArea.Text");
            // 
            // CustomExpressionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 373);
            Controls.Add(RulesTextArea);
            Controls.Add(EvaluateExpressionButton);
            Controls.Add(ExpressionLabel);
            Controls.Add(ExpressionInput);
            Name = "CustomExpressionForm";
            Text = "Custom Expression";
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