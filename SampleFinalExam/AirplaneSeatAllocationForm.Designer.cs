
namespace SampleFinalExam
{
    partial class AirplaneSeatAllocationForm
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
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.segmentSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.columnsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.segmentSizeLabel = new System.Windows.Forms.Label();
            this.columnsLabel = new System.Windows.Forms.Label();
            this.rowsLabel = new System.Windows.Forms.Label();
            this.seatAllocationPanel = new System.Windows.Forms.Panel();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.totalSeatsTextBox = new System.Windows.Forms.TextBox();
            this.remainingSeatsTextBox = new System.Windows.Forms.TextBox();
            this.totalSeatsLabel = new System.Windows.Forms.Label();
            this.remainingSeatsLabel = new System.Windows.Forms.Label();
            this.backToMainFormButton = new System.Windows.Forms.Button();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segmentSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumericUpDown)).BeginInit();
            this.statsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.segmentSizeNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.columnsNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.rowsNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.segmentSizeLabel);
            this.settingsGroupBox.Controls.Add(this.columnsLabel);
            this.settingsGroupBox.Controls.Add(this.rowsLabel);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(781, 65);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // segmentSizeNumericUpDown
            // 
            this.segmentSizeNumericUpDown.Location = new System.Drawing.Point(624, 28);
            this.segmentSizeNumericUpDown.Name = "segmentSizeNumericUpDown";
            this.segmentSizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.segmentSizeNumericUpDown.TabIndex = 5;
            // 
            // columnsNumericUpDown
            // 
            this.columnsNumericUpDown.Location = new System.Drawing.Point(337, 28);
            this.columnsNumericUpDown.Name = "columnsNumericUpDown";
            this.columnsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.columnsNumericUpDown.TabIndex = 4;
            // 
            // rowsNumericUpDown
            // 
            this.rowsNumericUpDown.Location = new System.Drawing.Point(67, 28);
            this.rowsNumericUpDown.Name = "rowsNumericUpDown";
            this.rowsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.rowsNumericUpDown.TabIndex = 3;
            // 
            // segmentSizeLabel
            // 
            this.segmentSizeLabel.AutoSize = true;
            this.segmentSizeLabel.Location = new System.Drawing.Point(518, 30);
            this.segmentSizeLabel.Name = "segmentSizeLabel";
            this.segmentSizeLabel.Size = new System.Drawing.Size(72, 13);
            this.segmentSizeLabel.TabIndex = 2;
            this.segmentSizeLabel.Text = "Segment Size";
            // 
            // columnsLabel
            // 
            this.columnsLabel.AutoSize = true;
            this.columnsLabel.Location = new System.Drawing.Point(258, 30);
            this.columnsLabel.Name = "columnsLabel";
            this.columnsLabel.Size = new System.Drawing.Size(47, 13);
            this.columnsLabel.TabIndex = 1;
            this.columnsLabel.Text = "Columns";
            // 
            // rowsLabel
            // 
            this.rowsLabel.AutoSize = true;
            this.rowsLabel.Location = new System.Drawing.Point(6, 30);
            this.rowsLabel.Name = "rowsLabel";
            this.rowsLabel.Size = new System.Drawing.Size(34, 13);
            this.rowsLabel.TabIndex = 0;
            this.rowsLabel.Text = "Rows";
            // 
            // seatAllocationPanel
            // 
            this.seatAllocationPanel.Location = new System.Drawing.Point(12, 83);
            this.seatAllocationPanel.Name = "seatAllocationPanel";
            this.seatAllocationPanel.Size = new System.Drawing.Size(781, 318);
            this.seatAllocationPanel.TabIndex = 1;
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.totalSeatsTextBox);
            this.statsGroupBox.Controls.Add(this.remainingSeatsTextBox);
            this.statsGroupBox.Controls.Add(this.totalSeatsLabel);
            this.statsGroupBox.Controls.Add(this.remainingSeatsLabel);
            this.statsGroupBox.Location = new System.Drawing.Point(12, 416);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(781, 71);
            this.statsGroupBox.TabIndex = 2;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Stats";
            // 
            // totalSeatsTextBox
            // 
            this.totalSeatsTextBox.Location = new System.Drawing.Point(548, 26);
            this.totalSeatsTextBox.Name = "totalSeatsTextBox";
            this.totalSeatsTextBox.Size = new System.Drawing.Size(213, 20);
            this.totalSeatsTextBox.TabIndex = 3;
            // 
            // remainingSeatsTextBox
            // 
            this.remainingSeatsTextBox.Location = new System.Drawing.Point(99, 26);
            this.remainingSeatsTextBox.Name = "remainingSeatsTextBox";
            this.remainingSeatsTextBox.Size = new System.Drawing.Size(236, 20);
            this.remainingSeatsTextBox.TabIndex = 2;
            // 
            // totalSeatsLabel
            // 
            this.totalSeatsLabel.AutoSize = true;
            this.totalSeatsLabel.Location = new System.Drawing.Point(481, 29);
            this.totalSeatsLabel.Name = "totalSeatsLabel";
            this.totalSeatsLabel.Size = new System.Drawing.Size(61, 13);
            this.totalSeatsLabel.TabIndex = 1;
            this.totalSeatsLabel.Text = "Total Seats";
            // 
            // remainingSeatsLabel
            // 
            this.remainingSeatsLabel.AutoSize = true;
            this.remainingSeatsLabel.Location = new System.Drawing.Point(6, 29);
            this.remainingSeatsLabel.Name = "remainingSeatsLabel";
            this.remainingSeatsLabel.Size = new System.Drawing.Size(87, 13);
            this.remainingSeatsLabel.TabIndex = 0;
            this.remainingSeatsLabel.Text = "Remaining Seats";
            // 
            // backToMainFormButton
            // 
            this.backToMainFormButton.Location = new System.Drawing.Point(707, 505);
            this.backToMainFormButton.Name = "backToMainFormButton";
            this.backToMainFormButton.Size = new System.Drawing.Size(75, 23);
            this.backToMainFormButton.TabIndex = 4;
            this.backToMainFormButton.Text = "&Back";
            this.backToMainFormButton.UseVisualStyleBackColor = true;
            this.backToMainFormButton.Click += new System.EventHandler(this.backToMainFormButton_Click);
            // 
            // AirplaneSeatAllocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 542);
            this.Controls.Add(this.backToMainFormButton);
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.seatAllocationPanel);
            this.Controls.Add(this.settingsGroupBox);
            this.Name = "AirplaneSeatAllocationForm";
            this.Text = "Airplane Seat Allocation Form";
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segmentSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumericUpDown)).EndInit();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.NumericUpDown segmentSizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown columnsNumericUpDown;
        private System.Windows.Forms.NumericUpDown rowsNumericUpDown;
        private System.Windows.Forms.Label segmentSizeLabel;
        private System.Windows.Forms.Label columnsLabel;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.Panel seatAllocationPanel;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.TextBox totalSeatsTextBox;
        private System.Windows.Forms.TextBox remainingSeatsTextBox;
        private System.Windows.Forms.Label totalSeatsLabel;
        private System.Windows.Forms.Label remainingSeatsLabel;
        private System.Windows.Forms.Button backToMainFormButton;
    }
}