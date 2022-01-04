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
    public partial class CyprusTaxCalculatorForm : Form
    {
        private const double SocialInsurancePercent = 8.3 / 100;
        private const double GesyPercent = 2.65 / 100;

        public object DisplaySalaryBreakdown { get; private set; }

        public CyprusTaxCalculatorForm()
        {
            InitializeComponent();
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateSalaryBreakdown();
        }

        private void monthlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSalaryBreakdown();
        }

        private void annualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSalaryBreakdown();
        }

        private void thirteenthMonthSalaryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSalaryBreakdown();
        }

        private void CalculateSalaryBreakdown()
        {
            double annualSalary, annualSocialInsurance, annualGesy, annualTax, annualNetSalary;

            int monthsCount = 12;
            if (thirteenthMonthSalaryCheckBox.Checked)
                monthsCount = 13;

            // If the input is not valid, no need to proceed further
            if (false == double.TryParse(salaryTextBox.Text, out double inputSalary))
                return;

            // If monthly is not selected, then it's annual
            if (monthlyRadioButton.Checked)
                annualSalary = inputSalary * monthsCount;
            else
                annualSalary = inputSalary;

            annualSocialInsurance = annualSalary * SocialInsurancePercent;
            annualGesy = annualSalary * GesyPercent;

            double salaryAfterDeductions = annualSalary - (annualSocialInsurance + annualGesy);

            annualTax = GetAnnualTax(salaryAfterDeductions);

            annualNetSalary = salaryAfterDeductions - annualTax;

            // Update Annual Fields
            annualGrossTextBox.Text = "€ " + annualSalary.ToString("N2");
            annualTaxTextBox.Text = "€ " + annualTax.ToString("N2");
            annualSocialInsuranceTextBox.Text = "€ " + annualSocialInsurance.ToString("N2");
            annualNHISTextBox.Text = "€ " + annualGesy.ToString("N2");
            annualNetTextBox.Text = "€ " + annualNetSalary.ToString("N2");

            // Update Monthly Fields
            monthlyGrossTextBox.Text = "€ " + (annualSalary / monthsCount).ToString("N2");
            monthlyTaxTextBox.Text = "€ " + (annualTax / monthsCount).ToString("N2");
            monthlySocialInsuranceTextBox.Text = "€ " + (annualSocialInsurance / monthsCount).ToString("N2");
            monthlyNHISTextBox.Text = "€ " + (annualGesy / monthsCount).ToString("N2");
            monthlyNetTextBox.Text = "€ " + (annualNetSalary / monthsCount).ToString("N2");
        }

        private double GetAnnualTax(double salaryAfterDeductions)
        {
            // Start - End      =>  Tax Rate
            // 0     - 19500    =>  0%
            // 19501 - 28000    => 20%
            // 28001 - 36300    => 25%
            // 36301 - 60000    => 30%
            // 60000 - ...      => 35%

            // Note: MUST BE SORTED and match the corresponding values in TaxBracketPercents
            List<double> TaxBracketUpperBounds = new List<double>()
            {
                19500, 28000, 36300, 60000, double.MaxValue
            };

            List<double> TaxBracketPercents = new List<double>()
            {
                0, .20, .25, .30, .35
            };

            double tax = 0, remainingSalary = salaryAfterDeductions;

            // Check every tier until nothing is left to be taxed
            for (int i = 0; i < TaxBracketUpperBounds.Count; ++i)
            {
                if (remainingSalary <= TaxBracketUpperBounds[i])
                {
                    if (i == 0)
                        return remainingSalary * TaxBracketPercents[i];
                    else
                    {
                        // return tax from previous brackets as well as the one from current bracket
                        return tax + (remainingSalary - TaxBracketUpperBounds[i - 1] - 1) * TaxBracketPercents[i];
                    }
                }
                else
                {
                    if (i == 0)
                        tax += TaxBracketUpperBounds[i] * TaxBracketPercents[i];
                    else
                        tax += (TaxBracketUpperBounds[i] - TaxBracketUpperBounds[i - 1] - 1) * TaxBracketPercents[i];
                }
            }

            return tax;
        }

        private void backToMainFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
