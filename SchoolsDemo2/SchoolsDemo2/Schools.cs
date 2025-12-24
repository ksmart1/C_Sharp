using System;
namespace SchoolsDemo2
{
    internal class Schools : IComparable<Schools>
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Enrollment { get; set; }

        public Schools()
        {

        }

        public Schools(string name, string city, string state, int enrollment)
        {
            this.Name = name;
            this.City = city;
            this.State = state;
            this.Enrollment = enrollment;
        }

        public int CompareTo(Schools other)
        {
            if (other == null)
            {
                return 1;
            }

            return Enrollment.CompareTo(other.Enrollment);
        }

        public void displaySchool()
        {
            Console.WriteLine("School Name: " + Name);
            Console.WriteLine("City: " + City);
            Console.WriteLine("State: " + State);
            Console.WriteLine("Enrollment: " + Enrollment);
        }
    }

}

