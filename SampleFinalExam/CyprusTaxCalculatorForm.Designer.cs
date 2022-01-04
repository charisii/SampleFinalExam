
namespace SampleFinalExam
{
    partial class CyprusTaxCalculatorForm
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
            this.salaryDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.annuallyGroupBox = new System.Windows.Forms.GroupBox();
            this.monthlyGroupBox = new System.Windows.Forms.GroupBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.monthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.annualRadioButton = new System.Windows.Forms.RadioButton();
            this.thirteenthMonthSalaryCheckBox = new System.Windows.Forms.CheckBox();
            this.annualGrossLabel = new System.Windows.Forms.Label();
            this.annualTaxLabel = new System.Windows.Forms.Label();
            this.annualSocialInsuranceLabel = new System.Windows.Forms.Label();
            this.annualNHISLabel = new System.Windows.Forms.Label();
            this.annualNetLabel = new System.Windows.Forms.Label();
            this.monthlyNetLabel = new System.Windows.Forms.Label();
            this.monthlyNHISLabel = new System.Windows.Forms.Label();
            this.monthlySocialInsuranceLabel = new System.Windows.Forms.Label();
            this.monthlyTaxLabel = new System.Windows.Forms.Label();
            this.monthlyGrossLabel = new System.Windows.Forms.Label();
            this.backToMainFormButton = new System.Windows.Forms.Button();
            this.annualGrossTextBox = new System.Windows.Forms.TextBox();
            this.annualTaxTextBox = new System.Windows.Forms.TextBox();
            this.annualSocialInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.annualNHISTextBox = new System.Windows.Forms.TextBox();
            this.annualNetTextBox = new System.Windows.Forms.TextBox();
            this.monthlyNetTextBox = new System.Windows.Forms.TextBox();
            this.monthlyNHISTextBox = new System.Windows.Forms.TextBox();
            this.monthlySocialInsuranceTextBox = new System.Windows.Forms.TextBox();
            this.monthlyTaxTextBox = new System.Windows.Forms.TextBox();
            this.monthlyGrossTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.salaryDetailsGroupBox.SuspendLayout();
            this.annuallyGroupBox.SuspendLayout();
            this.monthlyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // salaryDetailsGroupBox
            // 
            this.salaryDetailsGroupBox.Controls.Add(this.salaryTextBox);
            this.salaryDetailsGroupBox.Controls.Add(this.thirteenthMonthSalaryCheckBox);
            this.salaryDetailsGroupBox.Controls.Add(this.annualRadioButton);
            this.salaryDetailsGroupBox.Controls.Add(this.monthlyRadioButton);
            this.salaryDetailsGroupBox.Controls.Add(this.salaryLabel);
            this.salaryDetailsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.salaryDetailsGroupBox.Name = "salaryDetailsGroupBox";
            this.salaryDetailsGroupBox.Size = new System.Drawing.Size(231, 121);
            this.salaryDetailsGroupBox.TabIndex = 0;
            this.salaryDetailsGroupBox.TabStop = false;
            this.salaryDetailsGroupBox.Text = "Salary Details";
            // 
            // annuallyGroupBox
            // 
            this.annuallyGroupBox.Controls.Add(this.annualNetTextBox);
            this.annuallyGroupBox.Controls.Add(this.annualNHISTextBox);
            this.annuallyGroupBox.Controls.Add(this.annualSocialInsuranceTextBox);
            this.annuallyGroupBox.Controls.Add(this.annualTaxTextBox);
            this.annuallyGroupBox.Controls.Add(this.annualGrossTextBox);
            this.annuallyGroupBox.Controls.Add(this.annualNetLabel);
            this.annuallyGroupBox.Controls.Add(this.annualNHISLabel);
            this.annuallyGroupBox.Controls.Add(this.annualSocialInsuranceLabel);
            this.annuallyGroupBox.Controls.Add(this.annualTaxLabel);
            this.annuallyGroupBox.Controls.Add(this.annualGrossLabel);
            this.annuallyGroupBox.Location = new System.Drawing.Point(12, 139);
            this.annuallyGroupBox.Name = "annuallyGroupBox";
            this.annuallyGroupBox.Size = new System.Drawing.Size(231, 207);
            this.annuallyGroupBox.TabIndex = 1;
            this.annuallyGroupBox.TabStop = false;
            this.annuallyGroupBox.Text = "Annually";
            // 
            // monthlyGroupBox
            // 
            this.monthlyGroupBox.Controls.Add(this.monthlyNetTextBox);
            this.monthlyGroupBox.Controls.Add(this.monthlyNHISTextBox);
            this.monthlyGroupBox.Controls.Add(this.monthlySocialInsuranceTextBox);
            this.monthlyGroupBox.Controls.Add(this.monthlyTaxTextBox);
            this.monthlyGroupBox.Controls.Add(this.monthlyGrossTextBox);
            this.monthlyGroupBox.Controls.Add(this.monthlyNetLabel);
            this.monthlyGroupBox.Controls.Add(this.monthlyNHISLabel);
            this.monthlyGroupBox.Controls.Add(this.monthlySocialInsuranceLabel);
            this.monthlyGroupBox.Controls.Add(this.monthlyTaxLabel);
            this.monthlyGroupBox.Controls.Add(this.monthlyGrossLabel);
            this.monthlyGroupBox.Location = new System.Drawing.Point(249, 139);
            this.monthlyGroupBox.Name = "monthlyGroupBox";
            this.monthlyGroupBox.Size = new System.Drawing.Size(231, 207);
            this.monthlyGroupBox.TabIndex = 2;
            this.monthlyGroupBox.TabStop = false;
            this.monthlyGroupBox.Text = "Monthly";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(313, 42);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(144, 58);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Cyprus Tax\r\nCalculator";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(18, 30);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(36, 13);
            this.salaryLabel.TabIndex = 0;
            this.salaryLabel.Text = "Salary";
            // 
            // monthlyRadioButton
            // 
            this.monthlyRadioButton.AutoSize = true;
            this.monthlyRadioButton.Location = new System.Drawing.Point(21, 57);
            this.monthlyRadioButton.Name = "monthlyRadioButton";
            this.monthlyRadioButton.Size = new System.Drawing.Size(62, 17);
            this.monthlyRadioButton.TabIndex = 1;
            this.monthlyRadioButton.TabStop = true;
            this.monthlyRadioButton.Text = "Monthly";
            this.monthlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // annualRadioButton
            // 
            this.annualRadioButton.AutoSize = true;
            this.annualRadioButton.Location = new System.Drawing.Point(102, 57);
            this.annualRadioButton.Name = "annualRadioButton";
            this.annualRadioButton.Size = new System.Drawing.Size(58, 17);
            this.annualRadioButton.TabIndex = 4;
            this.annualRadioButton.TabStop = true;
            this.annualRadioButton.Text = "Annual";
            this.annualRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirteenthMonthSalaryCheckBox
            // 
            this.thirteenthMonthSalaryCheckBox.AutoSize = true;
            this.thirteenthMonthSalaryCheckBox.Location = new System.Drawing.Point(21, 89);
            this.thirteenthMonthSalaryCheckBox.Name = "thirteenthMonthSalaryCheckBox";
            this.thirteenthMonthSalaryCheckBox.Size = new System.Drawing.Size(112, 17);
            this.thirteenthMonthSalaryCheckBox.TabIndex = 5;
            this.thirteenthMonthSalaryCheckBox.Text = "13th Month Salary";
            this.thirteenthMonthSalaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // annualGrossLabel
            // 
            this.annualGrossLabel.AutoSize = true;
            this.annualGrossLabel.Location = new System.Drawing.Point(18, 35);
            this.annualGrossLabel.Name = "annualGrossLabel";
            this.annualGrossLabel.Size = new System.Drawing.Size(34, 13);
            this.annualGrossLabel.TabIndex = 1;
            this.annualGrossLabel.Text = "Gross";
            // 
            // annualTaxLabel
            // 
            this.annualTaxLabel.AutoSize = true;
            this.annualTaxLabel.Location = new System.Drawing.Point(18, 70);
            this.annualTaxLabel.Name = "annualTaxLabel";
            this.annualTaxLabel.Size = new System.Drawing.Size(25, 13);
            this.annualTaxLabel.TabIndex = 2;
            this.annualTaxLabel.Text = "Tax";
            // 
            // annualSocialInsuranceLabel
            // 
            this.annualSocialInsuranceLabel.AutoSize = true;
            this.annualSocialInsuranceLabel.Location = new System.Drawing.Point(18, 104);
            this.annualSocialInsuranceLabel.Name = "annualSocialInsuranceLabel";
            this.annualSocialInsuranceLabel.Size = new System.Drawing.Size(86, 13);
            this.annualSocialInsuranceLabel.TabIndex = 3;
            this.annualSocialInsuranceLabel.Text = "Social Insurance";
            // 
            // annualNHISLabel
            // 
            this.annualNHISLabel.AutoSize = true;
            this.annualNHISLabel.Location = new System.Drawing.Point(18, 138);
            this.annualNHISLabel.Name = "annualNHISLabel";
            this.annualNHISLabel.Size = new System.Drawing.Size(71, 13);
            this.annualNHISLabel.TabIndex = 4;
            this.annualNHISLabel.Text = "NHIS (GESY)";
            // 
            // annualNetLabel
            // 
            this.annualNetLabel.AutoSize = true;
            this.annualNetLabel.Location = new System.Drawing.Point(18, 175);
            this.annualNetLabel.Name = "annualNetLabel";
            this.annualNetLabel.Size = new System.Drawing.Size(24, 13);
            this.annualNetLabel.TabIndex = 5;
            this.annualNetLabel.Text = "Net";
            // 
            // monthlyNetLabel
            // 
            this.monthlyNetLabel.AutoSize = true;
            this.monthlyNetLabel.Location = new System.Drawing.Point(20, 175);
            this.monthlyNetLabel.Name = "monthlyNetLabel";
            this.monthlyNetLabel.Size = new System.Drawing.Size(24, 13);
            this.monthlyNetLabel.TabIndex = 10;
            this.monthlyNetLabel.Text = "Net";
            // 
            // monthlyNHISLabel
            // 
            this.monthlyNHISLabel.AutoSize = true;
            this.monthlyNHISLabel.Location = new System.Drawing.Point(20, 138);
            this.monthlyNHISLabel.Name = "monthlyNHISLabel";
            this.monthlyNHISLabel.Size = new System.Drawing.Size(71, 13);
            this.monthlyNHISLabel.TabIndex = 9;
            this.monthlyNHISLabel.Text = "NHIS (GESY)";
            // 
            // monthlySocialInsuranceLabel
            // 
            this.monthlySocialInsuranceLabel.AutoSize = true;
            this.monthlySocialInsuranceLabel.Location = new System.Drawing.Point(20, 104);
            this.monthlySocialInsuranceLabel.Name = "monthlySocialInsuranceLabel";
            this.monthlySocialInsuranceLabel.Size = new System.Drawing.Size(86, 13);
            this.monthlySocialInsuranceLabel.TabIndex = 8;
            this.monthlySocialInsuranceLabel.Text = "Social Insurance";
            // 
            // monthlyTaxLabel
            // 
            this.monthlyTaxLabel.AutoSize = true;
            this.monthlyTaxLabel.Location = new System.Drawing.Point(20, 70);
            this.monthlyTaxLabel.Name = "monthlyTaxLabel";
            this.monthlyTaxLabel.Size = new System.Drawing.Size(25, 13);
            this.monthlyTaxLabel.TabIndex = 7;
            this.monthlyTaxLabel.Text = "Tax";
            // 
            // monthlyGrossLabel
            // 
            this.monthlyGrossLabel.AutoSize = true;
            this.monthlyGrossLabel.Location = new System.Drawing.Point(20, 35);
            this.monthlyGrossLabel.Name = "monthlyGrossLabel";
            this.monthlyGrossLabel.Size = new System.Drawing.Size(34, 13);
            this.monthlyGrossLabel.TabIndex = 6;
            this.monthlyGrossLabel.Text = "Gross";
            // 
            // backToMainFormButton
            // 
            this.backToMainFormButton.Location = new System.Drawing.Point(392, 360);
            this.backToMainFormButton.Name = "backToMainFormButton";
            this.backToMainFormButton.Size = new System.Drawing.Size(75, 23);
            this.backToMainFormButton.TabIndex = 6;
            this.backToMainFormButton.Text = "&Back";
            this.backToMainFormButton.UseVisualStyleBackColor = true;
            this.backToMainFormButton.Click += new System.EventHandler(this.backToMainFormButton_Click);
            // 
            // annualGrossTextBox
            // 
            this.annualGrossTextBox.Location = new System.Drawing.Point(112, 32);
            this.annualGrossTextBox.Name = "annualGrossTextBox";
            this.annualGrossTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualGrossTextBox.TabIndex = 6;
            // 
            // annualTaxTextBox
            // 
            this.annualTaxTextBox.Location = new System.Drawing.Point(112, 67);
            this.annualTaxTextBox.Name = "annualTaxTextBox";
            this.annualTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualTaxTextBox.TabIndex = 7;
            // 
            // annualSocialInsuranceTextBox
            // 
            this.annualSocialInsuranceTextBox.Location = new System.Drawing.Point(112, 101);
            this.annualSocialInsuranceTextBox.Name = "annualSocialInsuranceTextBox";
            this.annualSocialInsuranceTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualSocialInsuranceTextBox.TabIndex = 8;
            // 
            // annualNHISTextBox
            // 
            this.annualNHISTextBox.Location = new System.Drawing.Point(112, 135);
            this.annualNHISTextBox.Name = "annualNHISTextBox";
            this.annualNHISTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualNHISTextBox.TabIndex = 9;
            // 
            // annualNetTextBox
            // 
            this.annualNetTextBox.Location = new System.Drawing.Point(112, 172);
            this.annualNetTextBox.Name = "annualNetTextBox";
            this.annualNetTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualNetTextBox.TabIndex = 10;
            // 
            // monthlyNetTextBox
            // 
            this.monthlyNetTextBox.Location = new System.Drawing.Point(118, 172);
            this.monthlyNetTextBox.Name = "monthlyNetTextBox";
            this.monthlyNetTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthlyNetTextBox.TabIndex = 15;
            // 
            // monthlyNHISTextBox
            // 
            this.monthlyNHISTextBox.Location = new System.Drawing.Point(118, 135);
            this.monthlyNHISTextBox.Name = "monthlyNHISTextBox";
            this.monthlyNHISTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthlyNHISTextBox.TabIndex = 14;
            // 
            // monthlySocialInsuranceTextBox
            // 
            this.monthlySocialInsuranceTextBox.Location = new System.Drawing.Point(118, 101);
            this.monthlySocialInsuranceTextBox.Name = "monthlySocialInsuranceTextBox";
            this.monthlySocialInsuranceTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthlySocialInsuranceTextBox.TabIndex = 13;
            // 
            // monthlyTaxTextBox
            // 
            this.monthlyTaxTextBox.Location = new System.Drawing.Point(118, 67);
            this.monthlyTaxTextBox.Name = "monthlyTaxTextBox";
            this.monthlyTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthlyTaxTextBox.TabIndex = 12;
            // 
            // monthlyGrossTextBox
            // 
            this.monthlyGrossTextBox.Location = new System.Drawing.Point(118, 32);
            this.monthlyGrossTextBox.Name = "monthlyGrossTextBox";
            this.monthlyGrossTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthlyGrossTextBox.TabIndex = 11;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(70, 27);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(127, 20);
            this.salaryTextBox.TabIndex = 7;
            // 
            // CyprusTaxCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 395);
            this.Controls.Add(this.backToMainFormButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.monthlyGroupBox);
            this.Controls.Add(this.annuallyGroupBox);
            this.Controls.Add(this.salaryDetailsGroupBox);
            this.Name = "CyprusTaxCalculatorForm";
            this.Text = "Cyprus Tax Calculator Form";
            this.salaryDetailsGroupBox.ResumeLayout(false);
            this.salaryDetailsGroupBox.PerformLayout();
            this.annuallyGroupBox.ResumeLayout(false);
            this.annuallyGroupBox.PerformLayout();
            this.monthlyGroupBox.ResumeLayout(false);
            this.monthlyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox salaryDetailsGroupBox;
        private System.Windows.Forms.CheckBox thirteenthMonthSalaryCheckBox;
        private System.Windows.Forms.RadioButton annualRadioButton;
        private System.Windows.Forms.RadioButton monthlyRadioButton;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.GroupBox annuallyGroupBox;
        private System.Windows.Forms.Label annualNetLabel;
        private System.Windows.Forms.Label annualNHISLabel;
        private System.Windows.Forms.Label annualSocialInsuranceLabel;
        private System.Windows.Forms.Label annualTaxLabel;
        private System.Windows.Forms.Label annualGrossLabel;
        private System.Windows.Forms.GroupBox monthlyGroupBox;
        private System.Windows.Forms.Label monthlyNetLabel;
        private System.Windows.Forms.Label monthlyNHISLabel;
        private System.Windows.Forms.Label monthlySocialInsuranceLabel;
        private System.Windows.Forms.Label monthlyTaxLabel;
        private System.Windows.Forms.Label monthlyGrossLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox annualNetTextBox;
        private System.Windows.Forms.TextBox annualNHISTextBox;
        private System.Windows.Forms.TextBox annualSocialInsuranceTextBox;
        private System.Windows.Forms.TextBox annualTaxTextBox;
        private System.Windows.Forms.TextBox annualGrossTextBox;
        private System.Windows.Forms.TextBox monthlyNetTextBox;
        private System.Windows.Forms.TextBox monthlyNHISTextBox;
        private System.Windows.Forms.TextBox monthlySocialInsuranceTextBox;
        private System.Windows.Forms.TextBox monthlyTaxTextBox;
        private System.Windows.Forms.TextBox monthlyGrossTextBox;
        private System.Windows.Forms.Button backToMainFormButton;
        private System.Windows.Forms.TextBox salaryTextBox;
    }
}