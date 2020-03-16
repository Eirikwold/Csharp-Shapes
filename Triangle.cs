using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSharp
{
	class Triangle : Shape
	{
		public override double Area
		{
			get
			{
				return Height * Width * 0.5;
			}
		}
		public Triangle(double height, double width)
		{
			Height = height;
			Width = width;
		}
		public override void Draw()
		{
			Console.WriteLine("Drawing Triangle...");
		}

		public override string ToString()
		{
			return "Triangle with area: " + Area + " centimeters squared.";
		}
	}
}
