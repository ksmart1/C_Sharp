using System;
namespace SalespersonDemo
{
	public abstract class Salesperson
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Salesperson(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

		public abstract void SalesSpeech();

		public abstract void MakeSale(int value);

		public void displaySalesperson()
		{
			Console.WriteLine("Salesperson Name: " + FirstName +
				" " + LastName);
		}
	}
}

