using System;
namespace Healthcare
{
	public class Cardiologist : HealthcareProvider
	{
		public string CardiologySubspecialty { get; set; }

		public Cardiologist()
		{
		}

		public Cardiologist(int providerID, string lastName, string firstName, string specialty, string subspecialty)
		{
			base.ProviderID = providerID;
			base.LastName = lastName;
			base.FirstName = firstName;
			base.Specialty = specialty;
			CardiologySubspecialty = subspecialty;
		}

		public void displayCardioligist()
		{
			//Console.WriteLine("PrividerID: " + ProviderID);
			//Console.WriteLine("Last Name: " + LastName);
			//Console.WriteLine("First Name: " + FirstName);
			//Console.WriteLine("Specialty: " + Specialty);
			base.displayProvider();
			Console.WriteLine("Cardiology Subspecialty: " + CardiologySubspecialty);
        }
	}
}

