using System;
namespace Healthcare
{
	public class HealthcareProvider
	{
		private int providerID;
		private string lastName;
		private string firstName;
		private string specialty;
		private Address Address;

		public int ProviderID { get; set; }
		public string LastName
		{
			get
			{
				return lastName;
			}
			set
			{
				lastName = value.ToUpper();
			}
		}

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				firstName = value.ToUpper();
			}
		}

		public string Specialty { get; set; }

		public HealthcareProvider()
		{
		}

		public HealthcareProvider(int providerID, string lastName, string firstName)
		{
			ProviderID = providerID;
			LastName = lastName;
			FirstName = firstName;
		}

		public HealthcareProvider(int providerID, string lastName, string firstName, string specialty)
		{
			ProviderID = providerID;
			LastName = lastName;
			FirstName = firstName;
			Specialty = specialty;
		}

        public HealthcareProvider(int providerID, string lastName, string firstName, string specialty,
			string streetAddress, string city, string state, string zipCode)
        {
            ProviderID = providerID;
            LastName = lastName;
            FirstName = firstName;
            Specialty = specialty;
			Address = new Address(streetAddress, city, state, zipCode);
        }

        public void displayProvider()
		{
			Console.WriteLine("PrividerID: " + ProviderID);
			Console.WriteLine("Last Name: " + LastName);
			Console.WriteLine("First Name: " + FirstName);
			Console.WriteLine("Specialty: " + Specialty);

			if (Address != null)
			{
				Console.WriteLine("Street Address: " + Address.StreetAddress);
				Console.WriteLine("City: " + Address.City);
				Console.WriteLine("State: " + Address.State);
				Console.WriteLine("Zip Code: " + Address.ZipCode);
			}
		}
	}
}

