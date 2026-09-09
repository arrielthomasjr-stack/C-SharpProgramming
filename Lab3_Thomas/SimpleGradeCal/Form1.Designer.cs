namespace SimpleGradeCal
{
    partial class Form1
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
            lblPrompt = new Label();
            txtScore = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblPrompt
            // 
            lblPrompt.AutoSize = true;
            lblPrompt.Location = new Point(29, 18);
            lblPrompt.Name = "lblPrompt";
            lblPrompt.Size = new Size(220, 32);
            lblPrompt.TabIndex = 0;
            lblPrompt.Text = "Enter score (0-100):";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(261, 22);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(200, 39);
            txtScore.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(285, 67);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(150, 46);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(307, 140);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 32);
            lblResult.TabIndex = 3;
            lblResult.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 191);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtScore);
            Controls.Add(lblPrompt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrompt;
        private TextBox txtScore;
        private Button btnCalculate;
        private Label lblResult;
    }
}
