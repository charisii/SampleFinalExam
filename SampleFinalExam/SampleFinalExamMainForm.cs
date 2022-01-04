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
    public partial class SampleFinalExamMainForm : Form
    {
        public SampleFinalExamMainForm()
        {
            InitializeComponent();
        }

        private void shoppingListButton_Click(object sender, EventArgs e)
        {
            Hide();
            //var form = new IE1_ShoppingList.ShoppingListForm();
            var form = new ShoppingListForm();
            form.ShowDialog();
            Show();
        }

        private void airplaneSeatAllocationButton_Click(object sender, EventArgs e)
        {
            Hide();
            //var form = new IE2_AirplaneSeatAllocation.AirplaneSeatAllocationForm();
            var form = new AirplaneSeatAllocationForm();
            form.ShowDialog();
            Show();
        }

        private void classGradingButton_Click(object sender, EventArgs e)
        {
            Hide();
            //var form = new IE3_ClassGrading.ClassGradingForm();
            var form = new ClassGradingForm();
            form.ShowDialog();
            Show();
        }

        private void cyprusTaxCalculatorButton_Click(object sender, EventArgs e)
        {
            Hide();
            //var form = new IE4_CyprusTaxCalculator.CyprusTaxCalculatorForm();
            var form = new CyprusTaxCalculatorForm();
            form.ShowDialog();
            Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
