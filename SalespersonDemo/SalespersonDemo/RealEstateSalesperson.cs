using System;
namespace SalespersonDemo
{
	public class RealEstateSalesperson : Salesperson
	{

		public double TotalValueSold { get; private set; }
		public double TotalCommissionEarned { get; private set; }
        public double CommissionRate;

		public RealEstateSalesperson(string firstName, string lastName, double commissionRate) : base(firstName, lastName)
		{
			CommissionRate = commissionRate;
		}

		public override void SalesSpeech()
		{
			Console.WriteLine("Hello, I'm your realtor, {0} {1}.", FirstName, LastName);
			Console.WriteLine("This is the best time to get into a new home and this " +
				"property has everything you're looking for.");
			Console.WriteLine("Let's do this!");
		}

		public override void MakeSale(int homeValue)
		{
			TotalValueSold += homeValue;
			TotalCommissionEarned = homeValue * CommissionRate;
			Console.WriteLine("Total Commission Earned: " + TotalCommissionEarned.ToString("C"));
		}
	}
}

