using System;

namespace Savings_Calculator
{
	public class Savings : ISavings
	{
		public double Calculate(double initial, double interest, int years, int monthly, double deposit)
		{
			return (initial + deposit) * Math.Pow((1 + (interest / 100) / monthly), (monthly * years));
		}

		//public double Total_Monthly(double initial, double interest, int years, int monthly, double deposit)
		//{
		//	return (initial + deposit) * Math.Pow((1 + (interest / 100) / monthly), (monthly * years));
		//}

		//public double Total_Quarterly(double initial, double interest, int years, int monthly, double deposit)
		//{
		//	return (initial + deposit) * Math.Pow((1 + (interest / 100) / monthly), (monthly * years));
		//}
	}
}
