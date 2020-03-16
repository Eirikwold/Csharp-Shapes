using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSharp
{
	class Square : Shape
	{
		public override double Area
		{
			get
			{
				return Height * Width;
			}
		}
		public Square(double height, double width)
		{
			Height = height;
			Width = width;
		}
		public override void Draw()
		{
			Console.WriteLine("Drawing Square...");
		}

		public override string ToString()
		{
			return "Square with area: " + Area + " centimeters squared.";
		}

	}
}
