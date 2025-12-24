namespace DemoJobs;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job("Re-shingle roof", 8, 125.00);
        Job job2 = new Job("Kitchen remodel", 80, 150.00);
        Job job3 = new Job("Lawn leveling", 8, 200.00);
        Job job4 = new Job("Replace HVAC unit", 20, 150.00);

        //job1.displayJob();

        Job totalJobs = job1 + job2;
        totalJobs.displayJob();

        Job totalJobs2 = job3 + job4;
        totalJobs2.displayJob();
    }
}

