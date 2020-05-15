namespace Savings_Calculator
{
	public interface ISavings
	{
		double Calculate(double initial,double interest,int years,int monthly, double deposit);
		//double Total_Monthly(double initial, double interest, int years, int monthly, double deposit);
		//double Total_HalfYear(double initial, double interest, int years, int monthly, double deposit);
	}
}
