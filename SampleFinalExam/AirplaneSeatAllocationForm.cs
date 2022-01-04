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
    public partial class AirplaneSeatAllocationForm : Form
    {
        private const int CheckBoxWidth = 50;
        private const int CheckBoxHeight = 45;
        private const int ExtraSpacingSize = 5;
        private const int SegmentSpacingSize = CheckBoxWidth;

        private int remainingSeatCount = 0;

        public AirplaneSeatAllocationForm()
        {
            InitializeComponent();
        }

        private void settingsNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            seatAllocationPanel.Controls.Clear();

            remainingSeatCount = 0;
            for (int r = 0; r < rowsNumericUpDown.Value; r++)
                for (int c = 0; c < columnsNumericUpDown.Value; c++)
                {
                    char rowLetter = (char)('A' + r);
                    int columnNumber = c + 1;

                    // Additional spacing for X so checkboxes won't stick to the border
                    int locationX = ExtraSpacingSize + c * (CheckBoxWidth + ExtraSpacingSize);
                    int locationY = r * (CheckBoxHeight + ExtraSpacingSize);

                    if (segmentSizeNumericUpDown.Value != 0)
                        locationX += (int)(c / segmentSizeNumericUpDown.Value) * SegmentSpacingSize;

                    var checkBox = new CheckBox();
                    checkBox.Text = rowLetter + columnNumber.ToString();
                    checkBox.Location = new Point(locationX, locationY);
                    checkBox.Size = new Size(CheckBoxWidth, CheckBoxHeight);
                    checkBox.CheckedChanged += SeatCheckBox_CheckedChanged;
                    seatAllocationPanel.Controls.Add(checkBox);

                    remainingSeatCount++;
                }

            totalSeatsTextBox.Text = remainingSeatCount.ToString();
            remainingSeatsTextBox.Text = remainingSeatCount.ToString();
        }

        private void SeatCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox seatCheckBox = sender as CheckBox;

            if (seatCheckBox.Checked)
                remainingSeatCount--;
            else
                remainingSeatCount++;

            remainingSeatsTextBox.Text = remainingSeatCount.ToString();
        }

        private void backToMainFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
