using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFinalExam
{
    public partial class ShoppingListForm : Form
    {
        public ShoppingListForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Name Validation
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter the name for the item", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Quantity Validation
            if (false == int.TryParse(quantityTextBox.Text, out int quantity))
            {
                MessageBox.Show("Please enter valid number for quantity", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (quantity <= 0)
            {
                MessageBox.Show("Please enter positive number for quantity", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the shopping item
            var shoppingItem = new ShoppingListItem(nameTextBox.Text, quantity);
            toDoListBox.Items.Add(shoppingItem);

            shoppingListProgressBar.Maximum++;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedTodoItem = toDoListBox.SelectedItem;
            if (selectedTodoItem == null)
                return;

            toDoListBox.Items.Remove(selectedTodoItem);

            shoppingListProgressBar.Maximum--;
        }

        private void markAsCompleteButton_Click(object sender, EventArgs e)
        {
            var selectedTodoItem = toDoListBox.SelectedItem;
            if (selectedTodoItem == null)
                return;

            toDoListBox.Items.Remove(selectedTodoItem);

            completedListBox.Items.Add(selectedTodoItem);

            shoppingListProgressBar.Value++;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            while (completedListBox.Items.Count > 0)
            {
                var currentItem = completedListBox.Items[0];

                completedListBox.Items.Remove(currentItem);
                shoppingListProgressBar.Value--;
                shoppingListProgressBar.Maximum--;
            }
        }

        private void backToMainFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
