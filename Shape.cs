using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeSharp
{
	class Shape
	{

		public double Height { get; set; }
		public double Width { get; set; }

		public virtual double Area { get; }

		public Shape()
		{

		}

		public Shape(double height, double width)
		{
			Height = height;
			Width = width;
		}

		//Draws a shape (Overriden and overloaded in subclasses)
		public virtual void Draw()
		{
			Console.WriteLine("Drawing shape");
		}
	}
}
