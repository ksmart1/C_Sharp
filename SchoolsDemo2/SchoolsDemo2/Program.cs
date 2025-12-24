namespace SchoolsDemo2;

class Program
{
    static void Main(string[] args)
    {
        Schools school1 = new Schools();
        Schools school2 = new Schools();
        Schools school3 = new Schools();
        Schools school4 = new Schools();
        Schools school5 = new Schools();

        Schools[] school = { school1, school2, school3, school4, school5 };

        for (int i = 0; i < school.Length; i++)
        {
            Console.Write("Enter the school name: ");
            school[i].Name = Console.ReadLine();
            Console.Write("Enter the city: ");
            school[i].City = Console.ReadLine();
            Console.Write("Enter the state [IN]: ");
            school[i].State = Console.ReadLine();
            Console.Write("Enter the number of students enrolled: ");
            school[i].Enrollment = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(school);
        Console.WriteLine("Here are the schools you entered in descneding order" +
            "based on enrollment size:");

        foreach (var obj in school)
        {
            Console.WriteLine();
            obj.displaySchool();
        }

        Console.WriteLine();
        Console.Write("Please enter the minimum enrollment value: ");
        int minEroll = Convert.ToInt32(Console.ReadLine());

        foreach (var obj in school)
        {
            if (obj.Enrollment >= minEroll)
            {
                Console.WriteLine();
                obj.displaySchool();
            }
            
            
        }


    }

}    
   
