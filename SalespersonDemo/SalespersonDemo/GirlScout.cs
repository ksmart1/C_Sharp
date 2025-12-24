using System;
namespace SalespersonDemo
{
	public class GirlScout : Salesperson
	{
		private int boxesSold = 0;
		public int BoxesSold { get; set; }

		public GirlScout(string firstName, string lastName) : base(firstName, lastName)
		{
			
		}

		public override void SalesSpeech()
		{
			Console.WriteLine($"Hello, I'm " + FirstName + " " + LastName + " from Troop 555");
			Console.WriteLine("It's that time of year again! Come one, come all "
				+ "for this year's round of self-destructive tendencies in a box!");
		}

		public override void MakeSale(int boxes)
		{
			BoxesSold += boxes;
			Console.WriteLine("Total Boxes Sold: " + BoxesSold);
		}
	}
}

