
namespace SampleFinalExam
{
    partial class ClassGradingForm
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
            this.gradeWeightsGroupBox = new System.Windows.Forms.GroupBox();
            this.attendanceLabel = new System.Windows.Forms.Label();
            this.homeworkLabel = new System.Windows.Forms.Label();
            this.midtermLabel = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.attendanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.homeworkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.midtermNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.finalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.studentsCountTextBox = new System.Windows.Forms.TextBox();
            this.classAverageTextBox = new System.Windows.Forms.TextBox();
            this.studentsCountLabel = new System.Windows.Forms.Label();
            this.classAverageLabel = new System.Windows.Forms.Label();
            this.passRateTextBox = new System.Windows.Forms.TextBox();
            this.passRateLabel = new System.Windows.Forms.Label();
            this.gradingDataGridView = new System.Windows.Forms.DataGridView();
            this.backToMainFormButton = new System.Windows.Forms.Button();
            this.gradeWeightsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midtermNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalNumericUpDown)).BeginInit();
            this.statsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeWeightsGroupBox
            // 
            this.gradeWeightsGroupBox.Controls.Add(this.finalNumericUpDown);
            this.gradeWeightsGroupBox.Controls.Add(this.midtermNumericUpDown);
            this.gradeWeightsGroupBox.Controls.Add(this.homeworkNumericUpDown);
            this.gradeWeightsGroupBox.Controls.Add(this.attendanceNumericUpDown);
            this.gradeWeightsGroupBox.Controls.Add(this.finalLabel);
            this.gradeWeightsGroupBox.Controls.Add(this.midtermLabel);
            this.gradeWeightsGroupBox.Controls.Add(this.homeworkLabel);
            this.gradeWeightsGroupBox.Controls.Add(this.attendanceLabel);
            this.gradeWeightsGroupBox.Location = new System.Drawing.Point(12, 23);
            this.gradeWeightsGroupBox.Name = "gradeWeightsGroupBox";
            this.gradeWeightsGroupBox.Size = new System.Drawing.Size(630, 68);
            this.gradeWeightsGroupBox.TabIndex = 0;
            this.gradeWeightsGroupBox.TabStop = false;
            this.gradeWeightsGroupBox.Text = "Grade Weights";
            // 
            // attendanceLabel
            // 
            this.attendanceLabel.AutoSize = true;
            this.attendanceLabel.Location = new System.Drawing.Point(27, 32);
            this.attendanceLabel.Name = "attendanceLabel";
            this.attendanceLabel.Size = new System.Drawing.Size(62, 13);
            this.attendanceLabel.TabIndex = 0;
            this.attendanceLabel.Text = "Attendance";
            // 
            // homeworkLabel
            // 
            this.homeworkLabel.AutoSize = true;
            this.homeworkLabel.Location = new System.Drawing.Point(182, 32);
            this.homeworkLabel.Name = "homeworkLabel";
            this.homeworkLabel.Size = new System.Drawing.Size(58, 13);
            this.homeworkLabel.TabIndex = 1;
            this.homeworkLabel.Text = "Homework";
            // 
            // midtermLabel
            // 
            this.midtermLabel.AutoSize = true;
            this.midtermLabel.Location = new System.Drawing.Point(343, 32);
            this.midtermLabel.Name = "midtermLabel";
            this.midtermLabel.Size = new System.Drawing.Size(44, 13);
            this.midtermLabel.TabIndex = 2;
            this.midtermLabel.Text = "Midterm";
            // 
            // finalLabel
            // 
            this.finalLabel.AutoSize = true;
            this.finalLabel.Location = new System.Drawing.Point(491, 32);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(29, 13);
            this.finalLabel.TabIndex = 3;
            this.finalLabel.Text = "Final";
            // 
            // attendanceNumericUpDown
            // 
            this.attendanceNumericUpDown.Location = new System.Drawing.Point(95, 30);
            this.attendanceNumericUpDown.Name = "attendanceNumericUpDown";
            this.attendanceNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.attendanceNumericUpDown.TabIndex = 1;
            // 
            // homeworkNumericUpDown
            // 
            this.homeworkNumericUpDown.Location = new System.Drawing.Point(246, 30);
            this.homeworkNumericUpDown.Name = "homeworkNumericUpDown";
            this.homeworkNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.homeworkNumericUpDown.TabIndex = 4;
            // 
            // midtermNumericUpDown
            // 
            this.midtermNumericUpDown.Location = new System.Drawing.Point(393, 30);
            this.midtermNumericUpDown.Name = "midtermNumericUpDown";
            this.midtermNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.midtermNumericUpDown.TabIndex = 5;
            // 
            // finalNumericUpDown
            // 
            this.finalNumericUpDown.Location = new System.Drawing.Point(526, 30);
            this.finalNumericUpDown.Name = "finalNumericUpDown";
            this.finalNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.finalNumericUpDown.TabIndex = 6;
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.passRateTextBox);
            this.statsGroupBox.Controls.Add(this.passRateLabel);
            this.statsGroupBox.Controls.Add(this.studentsCountTextBox);
            this.statsGroupBox.Controls.Add(this.classAverageTextBox);
            this.statsGroupBox.Controls.Add(this.studentsCountLabel);
            this.statsGroupBox.Controls.Add(this.classAverageLabel);
            this.statsGroupBox.Location = new System.Drawing.Point(12, 278);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(630, 55);
            this.statsGroupBox.TabIndex = 3;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Stats";
            // 
            // studentsCountTextBox
            // 
            this.studentsCountTextBox.Location = new System.Drawing.Point(308, 24);
            this.studentsCountTextBox.Name = "studentsCountTextBox";
            this.studentsCountTextBox.Size = new System.Drawing.Size(65, 20);
            this.studentsCountTextBox.TabIndex = 3;
            // 
            // classAverageTextBox
            // 
            this.classAverageTextBox.Location = new System.Drawing.Point(87, 24);
            this.classAverageTextBox.Name = "classAverageTextBox";
            this.classAverageTextBox.Size = new System.Drawing.Size(72, 20);
            this.classAverageTextBox.TabIndex = 2;
            // 
            // studentsCountLabel
            // 
            this.studentsCountLabel.AutoSize = true;
            this.studentsCountLabel.Location = new System.Drawing.Point(222, 27);
            this.studentsCountLabel.Name = "studentsCountLabel";
            this.studentsCountLabel.Size = new System.Drawing.Size(80, 13);
            this.studentsCountLabel.TabIndex = 1;
            this.studentsCountLabel.Text = "Students Count";
            // 
            // classAverageLabel
            // 
            this.classAverageLabel.AutoSize = true;
            this.classAverageLabel.Location = new System.Drawing.Point(6, 27);
            this.classAverageLabel.Name = "classAverageLabel";
            this.classAverageLabel.Size = new System.Drawing.Size(75, 13);
            this.classAverageLabel.TabIndex = 0;
            this.classAverageLabel.Text = "Class Average";
            // 
            // passRateTextBox
            // 
            this.passRateTextBox.Location = new System.Drawing.Point(535, 24);
            this.passRateTextBox.Name = "passRateTextBox";
            this.passRateTextBox.Size = new System.Drawing.Size(65, 20);
            this.passRateTextBox.TabIndex = 5;
            // 
            // passRateLabel
            // 
            this.passRateLabel.AutoSize = true;
            this.passRateLabel.Location = new System.Drawing.Point(473, 27);
            this.passRateLabel.Name = "passRateLabel";
            this.passRateLabel.Size = new System.Drawing.Size(56, 13);
            this.passRateLabel.TabIndex = 4;
            this.passRateLabel.Text = "Pass Rate";
            // 
            // gradingDataGridView
            // 
            this.gradingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradingDataGridView.Location = new System.Drawing.Point(12, 97);
            this.gradingDataGridView.Name = "gradingDataGridView";
            this.gradingDataGridView.Size = new System.Drawing.Size(630, 175);
            this.gradingDataGridView.TabIndex = 4;
            // 
            // backToMainFormButton
            // 
            this.backToMainFormButton.Location = new System.Drawing.Point(557, 349);
            this.backToMainFormButton.Name = "backToMainFormButton";
            this.backToMainFormButton.Size = new System.Drawing.Size(75, 23);
            this.backToMainFormButton.TabIndex = 5;
            this.backToMainFormButton.Text = "&Back";
            this.backToMainFormButton.UseVisualStyleBackColor = true;
            this.backToMainFormButton.Click += new System.EventHandler(this.backToMainFormButton_Click);
            // 
            // ClassGradingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 384);
            this.Controls.Add(this.backToMainFormButton);
            this.Controls.Add(this.gradingDataGridView);
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.gradeWeightsGroupBox);
            this.Name = "ClassGradingForm";
            this.Text = "Class Grading Form";
            this.gradeWeightsGroupBox.ResumeLayout(false);
            this.gradeWeightsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeworkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midtermNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalNumericUpDown)).EndInit();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradingDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gradeWeightsGroupBox;
        private System.Windows.Forms.NumericUpDown finalNumericUpDown;
        private System.Windows.Forms.NumericUpDown midtermNumericUpDown;
        private System.Windows.Forms.NumericUpDown homeworkNumericUpDown;
        private System.Windows.Forms.NumericUpDown attendanceNumericUpDown;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.Label midtermLabel;
        private System.Windows.Forms.Label homeworkLabel;
        private System.Windows.Forms.Label attendanceLabel;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.TextBox passRateTextBox;
        private System.Windows.Forms.Label passRateLabel;
        private System.Windows.Forms.TextBox studentsCountTextBox;
        private System.Windows.Forms.TextBox classAverageTextBox;
        private System.Windows.Forms.Label studentsCountLabel;
        private System.Windows.Forms.Label classAverageLabel;
        private System.Windows.Forms.DataGridView gradingDataGridView;
        private System.Windows.Forms.Button backToMainFormButton;
    }
}