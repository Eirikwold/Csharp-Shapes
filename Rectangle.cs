using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSharp
{
	class Rectangle : Shape
	{
		public override double Area
		{
			get
			{
				return Height * Width;
			}
		}
		public Rectangle(double height, double width)
		{
			Height = height;
			Width = width;
		}
		public override void Draw()
		{
			Console.WriteLine("Drawing Rectangle...");
		}
		public override string ToString()
		{
			return "Rectangle with area: " + Area + " centimeters squared.";
		}
	}
}
