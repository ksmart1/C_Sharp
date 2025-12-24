using System;
using System.Diagnostics;

namespace PhotoDemo
{
	public class MattedPhoto : Photo
	{
		public string Color { get; set; }

		public MattedPhoto(int width, int height, string color) : base(width, height)
		{
			Color = color;
		}

		protected override double Price
		{
			get
			{
				double price = base.Price;
				return price + 10.00;
			}
		}

        // Override ToString() method
        public override string ToString()
        {
            return $"{GetType().Name} - Matted Photo: Color - {Color}, Price: ${Price:F2}";
        }

    }
}

