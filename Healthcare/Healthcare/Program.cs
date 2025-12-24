namespace Healthcare;

class Program
{
    static void Main(string[] args)
    {
        HealthcareProvider pro1 = new HealthcareProvider(867, "Smith", "Bill", "Pediatrics");
        HealthcareProvider pro2 = new HealthcareProvider(345, "Saginaw", "Tracy", "Obstetrics");
        HealthcareProvider[] proArray = new HealthcareProvider[2];
        Cardiologist card1 = new Cardiologist(232, "wayne", "bruce", "cardiology", "surgery");
        HealthcareProvider pro3 = new HealthcareProvider(999, "Goldberg", "Steve", "Neurology",
            "123 Nerve Ct", "Austin", "TX", "56784");
       
        pro1.displayProvider();
        Console.WriteLine();
        pro2.displayProvider();
        Console.WriteLine();
        card1.displayCardioligist();
        Console.WriteLine();
        pro3.displayProvider();


        for (int i = 0; i < 2; i++)
        {
            Console.Write("Enter the provider ID: ");
            int provID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the last name: ");
            string last = Console.ReadLine();
            Console.Write("Enter the first name: ");
            string first = Console.ReadLine();
            Console.Write("Enter the provider specialty: ");
            string specialty = Console.ReadLine();
            proArray[i] = new HealthcareProvider(provID, last, first, specialty);
        }


        for (int i = 0; i < proArray.Length; i++)
        {
            Console.WriteLine("Provider ID: " + proArray[i].ProviderID);
            Console.WriteLine("Last Name: " + proArray[i].LastName);
            Console.WriteLine("First Name: " + proArray[i].FirstName);
            Console.WriteLine("Specialty: " + proArray[i].Specialty);
        }


    }
}


