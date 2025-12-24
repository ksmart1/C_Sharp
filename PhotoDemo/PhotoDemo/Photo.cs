using System;
namespace PhotoDemo
{
	public class Photo
	{
        public int Width { get; set; }
        public int Height { get; set; }
		protected virtual double Price
		{
			get
			{
				// If-loop to determine Price of photo
				if (Width == 8 && Height == 10)
				{
					return 3.99;
				}
				else if (Width == 10 && Height == 12)
				{
					return 5.99;
				}
				else
				{
					return 9.99;
				}
			}
		}

		// Default constructor to allow instantiating empty objects
		//public Photo()
		//{
		//}

		public Photo (int width, int height)
		{
			Width = width;
			Height = height;
		}

        // Override ToString() method
        public override string ToString()
        {
            return $"{GetType().Name} - Width: {Width} inches, Height: {Height} inches, Price: ${Price:F2}";
        }

    }
}

