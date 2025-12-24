using System;
using System.Drawing;

namespace PhotoDemo
{
	public class FramedPhoto : Photo
	{
		public string FrameMaterial { get; set; }
		public string FrameStyle { get; set; }

		public FramedPhoto(int width, int height, string frameMaterial, string frameStyle) : base(width, height)
		{
			FrameMaterial = frameMaterial;
			FrameStyle = frameStyle;
		}

        protected override double Price
		{
			get
			{
				double price = base.Price;
				return price + 25.00;
			}
		}

        public override string ToString()
        {
            return $"{GetType().Name} - Framed Photo: Material - {FrameMaterial}, Style - {FrameStyle}, Price: ${Price:F2}";
        }
    }
}

