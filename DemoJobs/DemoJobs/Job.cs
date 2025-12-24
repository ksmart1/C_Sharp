using System;
namespace DemoJobs
{
	public class Job
	{
		private string Description { get; set; }
		private float Hours { get; set; }
		private double HourlyRate { get; set; }

		private double TotalFee
		{
			get
			{
                return (double)Hours * HourlyRate;
            }
		}

		public Job(string Description, float Hours, double HourlyRate)
		{
			this.Description = Description;
			this.Hours = Hours;
			this.HourlyRate = HourlyRate;
		}

		public void displayJob()
		{
			Console.WriteLine("Description: " + Description);
			Console.WriteLine("Hours: " + Hours);
			Console.WriteLine("Hourly-rate: " + HourlyRate.ToString("C"));
			Console.WriteLine("Total Fee: " + TotalFee.ToString("C"));
		}

		public static Job operator +(Job job1, Job job2)
		{
			var TotalDescription = job1.Description + " and " + job2.Description;
			var TotalHours = job1.Hours + job2.Hours;
			var AvgHourlyRate = (job1.HourlyRate + job2.HourlyRate) / 2;

			return new Job(TotalDescription, TotalHours, AvgHourlyRate);
		}
	}
}

