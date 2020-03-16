using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSharp
{
	class Circle : Shape
	{
		public override double Area
		{
			get
			{
				return Width*Width*Math.PI;
			}
		}
		public Circle(double width)
		{
			Width = width;
		}
		public override void Draw()
		{
			Console.WriteLine("Drawing Circle...");
		}

		public override string ToString()
		{
			return "Circle with area: " + Area + " centimeters squared.";
		}
	}
}
