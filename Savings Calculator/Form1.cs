using System;
using System.Windows.Forms;

namespace Savings_Calculator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Populate_Terms();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal total = 0;
			double initialAmount = Convert.ToDouble(nudInitial.Value);
			double interestRate = Convert.ToDouble(nudInterest.Value);
			int years = Convert.ToInt32(nudYears.Value);

			string calculatedPeriod = cboTerms.SelectedItem.ToString();
			double monthlyDeposit = Convert.ToDouble(nudMonthly.Value);

			ISavings savings = new Savings();
			switch (calculatedPeriod)
			{
				case "Monthly":
					total = Convert.ToDecimal(savings.Calculate(initialAmount, interestRate, years, 12, monthlyDeposit));
					//var final = savings.Calculate(initialAmount, interestRate, years, 12, monthlyDeposit);
					//nudTotal.Value = Convert.ToDecimal(final);
					break;
				case "Quarterly":
					total = Convert.ToDecimal(savings.Calculate(initialAmount, interestRate, years, 3, monthlyDeposit));
					//var finalQuarter = savings.Total_Quarterly(initialAmount, interestRate, years, 3, monthlyDeposit);
					//nudTotal.Value = Convert.ToDecimal(finalQuarter);
					break;
				case "HalfYear":
					total = Convert.ToDecimal(savings.Calculate(initialAmount, interestRate, years, 2, monthlyDeposit));
					//var finalHalf = savings.Total_HalfYear(initialAmount, interestRate, years, 2, monthlyDeposit);
					//nudTotal.Value = Convert.ToDecimal(finalHalf);
					break;
			}

			nudTotal.Value = Math.Round(total, 2);
		}

		private void Populate_Terms()
		{
			cboTerms.Items.Add(Period.HalfYear.ToString());
			cboTerms.Items.Add(Period.Monthly.ToString());
			cboTerms.Items.Add(Period.Quarterly.ToString());
		}
	}

	enum Period
	{
		Monthly,
		Quarterly,
		HalfYear
	}
}
