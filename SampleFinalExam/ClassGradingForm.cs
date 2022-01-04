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
    // Created class to get and calculate total Grade Values for each new entry (student)
    public partial class ClassGradingForm : Form
    {
        private List<StudentGrading> studentGrades = new List<StudentGrading>(); // List of Students grade entries

        private const double MinimumPassGrade = 60;

        public ClassGradingForm()
        {
            InitializeComponent();

            gradingDataGridView.DataSource = new BindingList<StudentGrading>(studentGrades); // DGV gets updated
        }

        private void gradingDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateGradeStats();
        }

        // Every time we change weights for different grading, update
        private void gradeWeightNumericUpDown_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateGradeStats();
        }

        // Main class function
        private void UpdateGradeStats()
        {
            // calculate list of grades
            // New var of grades is created and calculated
            var grades = studentGrades.Select(x => x.GetGrade((double)attendanceNumericUpDown.Value, (double)homeworkNumericUpDown.Value, (double)midtermNumericUpDown.Value, (double)finalNumericUpDown.Value)).ToList();

            classAverageTextBox.Text = grades.Average().ToString("N2"); // Finds and displays average of all grades for every new entry

            studentsCountTextBox.Text = grades.Count.ToString(); // With every new Student Entry, studentsCount++

            var passRate = grades.Count(x => x >= MinimumPassGrade) / (double)grades.Count; // passRate = students passed the course / total number of students
            passRateTextBox.Text = passRate.ToString("P2");
        }

        private void backToMainFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
