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
    public partial class ClassGradingForm : Form
    {
        private List<StudentGrading> studentGrades = new List<StudentGrading>();

        private const double MinimumPassGrade = 60;

        public ClassGradingForm()
        {
            InitializeComponent();

            gradingDataGridView.DataSource = new BindingList<StudentGrading>(studentGrades);
        }

        private void gradingDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateGradeStats();
        }

        private void gradeWeightNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateGradeStats();
        }

        private void UpdateGradeStats()
        {
            // calculate list of grades
            var grades = studentGrades.Select(x => x.GetGrade((double)attendanceNumericUpDown.Value, (double)homeworkNumericUpDown.Value, (double)midtermNumericUpDown.Value, (double)finalNumericUpDown.Value)).ToList();

            classAverageTextBox.Text = grades.Average().ToString("N2");

            studentsCountTextBox.Text = grades.Count.ToString();

            var passRate = grades.Count(x => x >= MinimumPassGrade) / (double)grades.Count;
            passRateTextBox.Text = passRate.ToString("P2");
        }

        private void backToMainFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
