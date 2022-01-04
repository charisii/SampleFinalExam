
namespace SampleFinalExam
{
    partial class ShoppingListForm
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
            this.newItemGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.toDoGroupBox = new System.Windows.Forms.GroupBox();
            this.markAsCompleteButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.toDoListBox = new System.Windows.Forms.ListBox();
            this.completedGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.shoppingListProgressBar = new System.Windows.Forms.ProgressBar();
            this.completedListBox = new System.Windows.Forms.ListBox();
            this.backToMainFormButton = new System.Windows.Forms.Button();
            this.newItemGroupBox.SuspendLayout();
            this.toDoGroupBox.SuspendLayout();
            this.completedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newItemGroupBox
            // 
            this.newItemGroupBox.Controls.Add(this.addButton);
            this.newItemGroupBox.Controls.Add(this.quantityTextBox);
            this.newItemGroupBox.Controls.Add(this.nameTextBox);
            this.newItemGroupBox.Controls.Add(this.quantityLabel);
            this.newItemGroupBox.Controls.Add(this.nameLabel);
            this.newItemGroupBox.Location = new System.Drawing.Point(12, 12);
            this.newItemGroupBox.Name = "newItemGroupBox";
            this.newItemGroupBox.Size = new System.Drawing.Size(276, 302);
            this.newItemGroupBox.TabIndex = 0;
            this.newItemGroupBox.TabStop = false;
            this.newItemGroupBox.Text = "New Item";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(76, 254);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 30);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(66, 146);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(187, 20);
            this.quantityTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(66, 77);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(187, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(6, 149);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 1;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 80);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // toDoGroupBox
            // 
            this.toDoGroupBox.Controls.Add(this.markAsCompleteButton);
            this.toDoGroupBox.Controls.Add(this.deleteButton);
            this.toDoGroupBox.Controls.Add(this.toDoListBox);
            this.toDoGroupBox.Location = new System.Drawing.Point(294, 12);
            this.toDoGroupBox.Name = "toDoGroupBox";
            this.toDoGroupBox.Size = new System.Drawing.Size(293, 302);
            this.toDoGroupBox.TabIndex = 1;
            this.toDoGroupBox.TabStop = false;
            this.toDoGroupBox.Text = "Todo";
            // 
            // markAsCompleteButton
            // 
            this.markAsCompleteButton.Location = new System.Drawing.Point(148, 254);
            this.markAsCompleteButton.Name = "markAsCompleteButton";
            this.markAsCompleteButton.Size = new System.Drawing.Size(139, 30);
            this.markAsCompleteButton.TabIndex = 6;
            this.markAsCompleteButton.Text = "&Mark as Complete";
            this.markAsCompleteButton.UseVisualStyleBackColor = true;
            this.markAsCompleteButton.Click += new System.EventHandler(this.markAsCompleteButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 254);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(136, 30);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // toDoListBox
            // 
            this.toDoListBox.FormattingEnabled = true;
            this.toDoListBox.Location = new System.Drawing.Point(6, 19);
            this.toDoListBox.Name = "toDoListBox";
            this.toDoListBox.Size = new System.Drawing.Size(281, 225);
            this.toDoListBox.TabIndex = 0;
            // 
            // completedGroupBox
            // 
            this.completedGroupBox.Controls.Add(this.clearButton);
            this.completedGroupBox.Controls.Add(this.shoppingListProgressBar);
            this.completedGroupBox.Controls.Add(this.completedListBox);
            this.completedGroupBox.Location = new System.Drawing.Point(593, 12);
            this.completedGroupBox.Name = "completedGroupBox";
            this.completedGroupBox.Size = new System.Drawing.Size(319, 302);
            this.completedGroupBox.TabIndex = 2;
            this.completedGroupBox.TabStop = false;
            this.completedGroupBox.Text = "Completed";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(173, 254);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 30);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // shoppingListProgressBar
            // 
            this.shoppingListProgressBar.Location = new System.Drawing.Point(6, 254);
            this.shoppingListProgressBar.Name = "shoppingListProgressBar";
            this.shoppingListProgressBar.Size = new System.Drawing.Size(161, 30);
            this.shoppingListProgressBar.TabIndex = 1;
            // 
            // completedListBox
            // 
            this.completedListBox.FormattingEnabled = true;
            this.completedListBox.Location = new System.Drawing.Point(6, 19);
            this.completedListBox.Name = "completedListBox";
            this.completedListBox.Size = new System.Drawing.Size(307, 225);
            this.completedListBox.TabIndex = 0;
            // 
            // backToMainFormButton
            // 
            this.backToMainFormButton.Location = new System.Drawing.Point(831, 324);
            this.backToMainFormButton.Name = "backToMainFormButton";
            this.backToMainFormButton.Size = new System.Drawing.Size(75, 23);
            this.backToMainFormButton.TabIndex = 3;
            this.backToMainFormButton.Text = "&Back";
            this.backToMainFormButton.UseVisualStyleBackColor = true;
            this.backToMainFormButton.Click += new System.EventHandler(this.backToMainFormButton_Click);
            // 
            // ShoppingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 359);
            this.Controls.Add(this.backToMainFormButton);
            this.Controls.Add(this.completedGroupBox);
            this.Controls.Add(this.toDoGroupBox);
            this.Controls.Add(this.newItemGroupBox);
            this.Name = "ShoppingListForm";
            this.Text = "Shopping List Form";
            this.newItemGroupBox.ResumeLayout(false);
            this.newItemGroupBox.PerformLayout();
            this.toDoGroupBox.ResumeLayout(false);
            this.completedGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newItemGroupBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox toDoGroupBox;
        private System.Windows.Forms.Button markAsCompleteButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox toDoListBox;
        private System.Windows.Forms.GroupBox completedGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ProgressBar shoppingListProgressBar;
        private System.Windows.Forms.ListBox completedListBox;
        private System.Windows.Forms.Button backToMainFormButton;
    }
}