using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlannerTWO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //default value to be selcted
            cmbInvestmentPlan.Text = "Retirement 2040";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double yearlyInvestment, rateOfInvestment;
            int numberOfYears;
            double currentInvestmentValue = 0;
            int years;

            //Repeats value in textbox and storing it in the variable yearlyInvestment
            double.TryParse(txtYearlyInvestment.Text, out yearlyInvestment);

            //Checking validation of textboxes
            if (yearlyInvestment == 0)
            {
                MessageBox.Show("Please enter a valid yearly investment value");
                txtYearlyInvestment.Clear();
                txtYearlyInvestment.Focus();
                return;
            }

            int.TryParse(txtNumYears.Text, out numberOfYears);

            if(numberOfYears == 0)
            {
                MessageBox.Show("Please enter a valid value for number of years");
                txtNumYears.Clear();
                txtNumYears.Focus();
                return;
            }

            if (cmbInvestmentPlan.SelectedItem == "Retirement 2040")
            {
                rateOfInvestment = 7;
            }
            else if (cmbInvestmentPlan.SelectedItem == "Retirement 2050")
            {
                rateOfInvestment = 8;
            }
            else
            {
                rateOfInvestment = 9;
            }

            //string format adds the two columns named in quotes, the numbers in curly
            //braces represent how many characters are reserved in the space; ex. year allows 10 characters
            lstInvestment.Items.Add(string.Format("{0, 10}{0, 20}", "Year", "Investment Value"));
            lstInvestment.Items.Add("");

            for (years = 1; years <= numberOfYears; years = years +1 )
            {
               //calculates current investment value at the end of each year
                currentInvestmentValue = (currentInvestmentValue + yearlyInvestment) * (1+ rateOfInvestment/100);
                lstInvestment.Items.Add(string.Format("{0, 10}{1, 20}", years, currentInvestmentValue.ToString("C")));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           //Do the same thing, CLEAR
            txtYearlyInvestment.Text= string.Empty;
            txtNumYears.Clear();
            lstInvestment.Items.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this -> current application that is being closed
            this.Close();
        }
    }
} 
