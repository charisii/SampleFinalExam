
namespace SampleFinalExam
{
    partial class SampleFinalExamMainForm
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
            this.shoppingListButton = new System.Windows.Forms.Button();
            this.airplaneSeatAllocationButton = new System.Windows.Forms.Button();
            this.classGradingButton = new System.Windows.Forms.Button();
            this.cyprusTaxCalculatorButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shoppingListButton
            // 
            this.shoppingListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListButton.Location = new System.Drawing.Point(31, 29);
            this.shoppingListButton.Name = "shoppingListButton";
            this.shoppingListButton.Size = new System.Drawing.Size(138, 42);
            this.shoppingListButton.TabIndex = 0;
            this.shoppingListButton.Text = "&Shopping List";
            this.shoppingListButton.UseVisualStyleBackColor = true;
            this.shoppingListButton.Click += new System.EventHandler(this.shoppingListButton_Click);
            // 
            // airplaneSeatAllocationButton
            // 
            this.airplaneSeatAllocationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airplaneSeatAllocationButton.Location = new System.Drawing.Point(31, 77);
            this.airplaneSeatAllocationButton.Name = "airplaneSeatAllocationButton";
            this.airplaneSeatAllocationButton.Size = new System.Drawing.Size(138, 42);
            this.airplaneSeatAllocationButton.TabIndex = 1;
            this.airplaneSeatAllocationButton.Text = "&Airplane Seat Allocation";
            this.airplaneSeatAllocationButton.UseVisualStyleBackColor = true;
            this.airplaneSeatAllocationButton.Click += new System.EventHandler(this.airplaneSeatAllocationButton_Click);
            // 
            // classGradingButton
            // 
            this.classGradingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classGradingButton.Location = new System.Drawing.Point(31, 125);
            this.classGradingButton.Name = "classGradingButton";
            this.classGradingButton.Size = new System.Drawing.Size(138, 42);
            this.classGradingButton.TabIndex = 2;
            this.classGradingButton.Text = "Class &Grading";
            this.classGradingButton.UseVisualStyleBackColor = true;
            this.classGradingButton.Click += new System.EventHandler(this.classGradingButton_Click);
            // 
            // cyprusTaxCalculatorButton
            // 
            this.cyprusTaxCalculatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyprusTaxCalculatorButton.Location = new System.Drawing.Point(31, 173);
            this.cyprusTaxCalculatorButton.Name = "cyprusTaxCalculatorButton";
            this.cyprusTaxCalculatorButton.Size = new System.Drawing.Size(138, 42);
            this.cyprusTaxCalculatorButton.TabIndex = 3;
            this.cyprusTaxCalculatorButton.Text = "Cyprus Tax &Calculator";
            this.cyprusTaxCalculatorButton.UseVisualStyleBackColor = true;
            this.cyprusTaxCalculatorButton.Click += new System.EventHandler(this.cyprusTaxCalculatorButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(122, 241);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SampleFinalExamMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 287);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cyprusTaxCalculatorButton);
            this.Controls.Add(this.classGradingButton);
            this.Controls.Add(this.airplaneSeatAllocationButton);
            this.Controls.Add(this.shoppingListButton);
            this.Name = "SampleFinalExamMainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button shoppingListButton;
        private System.Windows.Forms.Button airplaneSeatAllocationButton;
        private System.Windows.Forms.Button classGradingButton;
        private System.Windows.Forms.Button cyprusTaxCalculatorButton;
        private System.Windows.Forms.Button exitButton;
    }
}

